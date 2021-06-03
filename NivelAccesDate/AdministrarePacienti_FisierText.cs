using PatientClass;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NivelAccesDate
{
    public class AdministrarePacienti_FisierText : IStocareData
    {
        string NumeFisier { get; set; }

        public AdministrarePacienti_FisierText(string numeFisier)
        {
            NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public void New_Patient(Patient patient)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.Write(patient.ConvertToStringForFile());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void NewListOfPatients(List<Patient> ListOfPatients)
        {
            try
            {
                File.Delete(NumeFisier);
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    foreach (var patient in ListOfPatients)
                    {
                        swFisierText.WriteLine(patient.ConvertToStringForFile());

                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public ArrayList GetPatients()
        {
            ArrayList patients = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Patient patient = new Patient(line);
                        patients.Add(patient);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {

                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return patients;
        }

        public List<Patient> GetPatient()
        {
            List<Patient> ListOfPatients = new List<Patient>();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line.Length != 0)
                        {
                            Patient patient = new Patient(line);
                            ListOfPatients.Add(patient);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return ListOfPatients;
        }

        public Patient GetPatient(int idPatient, List<Patient> lst)
        {
           foreach(Patient pat in lst)
            {
                if (pat.Id == idPatient)
                    return pat;
            }
            return null;
        }

        public Patient GetPatient(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string linieDinFisier;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((linieDinFisier = sr.ReadLine()) != null)
                    {
                        if(linieDinFisier.Length != 0 )
                        {
                            Patient patient = new Patient(linieDinFisier);
                            if (patient.Nume.ToUpper().Equals(nume.ToUpper()))
                                return patient;
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdatePacient(Patient PacientActualizat)
        {
            List<Patient> pacienti = GetPatient();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Patient pacient in pacienti)
                    {
                        Patient PacientPentruScrisInFisier = pacient;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (pacient.Id == PacientActualizat.Id)
                        {
                            PacientPentruScrisInFisier = PacientActualizat;
                        }
                        swFisierText.Write(PacientPentruScrisInFisier.ConvertToStringForFile());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }
    }
}
