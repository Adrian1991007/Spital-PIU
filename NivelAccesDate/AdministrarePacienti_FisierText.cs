using PatientClass;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

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
                    swFisierText.WriteLine(patient.ConvertToStringForFile());
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

        public List<Patient> GetPatientsFromFile()
        {
            List<Patient> ListOfPatients = new List<Patient>();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Patient patient = new Patient(line);
                        ListOfPatients.Add(patient);
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
    }
}
