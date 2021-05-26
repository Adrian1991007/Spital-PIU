using PatientClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelAccesDate
{
    public class AdministrarePacienti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrarePacienti_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();
        }

        public void New_Patient(Patient s)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    b.Serialize(sBinFile, s);
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

                BinaryFormatter b = new BinaryFormatter();

                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    foreach (var patient in ListOfPatients)
                        b.Serialize(sBinFile, patient);
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

        public List<Patient> GetPatient()
        {
            List<Patient> pacienti = new List<Patient>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        pacienti.Add((Patient)b.Deserialize(sBinFile));
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

            return pacienti;
        }

        public ArrayList GetPatients()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public Patient GetPatient(int idPatient, List<Patient> lst)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public Patient GetPatient(string nume)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public bool UpdatePacient(Patient PacientActualizat)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
