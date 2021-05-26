using System;
using System.Collections;
using PatientClass;
using NivelAccesDate;
using System.Collections.Generic;

namespace Interfata_Utilizator
{
    class Program
    {
        static void Main()
        {
            IStocareData Manager = StocareFactory.GetAdministratorStocare();
            ArrayList patients = Manager.GetPatients();
            Patient.IDCurent = patients.Count;
            //List<Patient> PatientsList;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("A. Adauga un pacient\n" +
                    "B. Afisare pacienti\n" +
                    "C. Modificare pacient\n" +
                    "X. Exit\n" +
                    "Alege o optiune:");
                var choise = Console.ReadKey(true).Key;

                switch (choise)
                {
                    case ConsoleKey.A:
                        Patient NewPatient = KeyboardReading();
                        patients.Add(NewPatient);
                        Manager.New_Patient(NewPatient);
                        break;

                    case ConsoleKey.B:
                        DisplayPatients(patients);
                        break;

                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Optiune gresita\n");
                        break;

                }
                Console.WriteLine("Apasa o tasta\n");
                Console.ReadKey();
            }
        }

        public static void DisplayPatients(ArrayList arrayList)
        {
            if (arrayList.Equals(null))
                return;
            if (arrayList.Count.Equals(0))
            {
                Console.WriteLine("Nu exista pacienti inregistrati\n");
                return;
            }

            foreach (Patient element in arrayList)
                Console.WriteLine(element.ConvertToString());
        }

        public static Patient KeyboardReading()
        {
            Patient patient = new Patient();
            patient.ID++;

            Console.WriteLine("Informatii despre pacient:");

            Console.Write("Nume:");
            string info = Console.ReadLine().Trim().ToUpper();
            patient.Nume = info;

            Console.Write("Prenume:");
            string info2 = Console.ReadLine().Trim().ToUpper();
            patient.Prenume = info2;

            Console.Write("ALEGEREA GENULUI\n");
            patient.Sex = ReadSex();

            Console.Write("Varsta este: ");
            int.TryParse(Console.ReadLine(), out int Intinfo);
            patient.Varsta = Intinfo;

            Console.WriteLine("TIP CETATENIE ");
            patient.Cetatean = TypeOfC();

            Console.Write("Data de nastere: (dd.mm.yyyy)\nRaspuns:");

            string date = Console.ReadLine();
            patient.DataNastere = DateTime.Parse(date);

            Console.Write("Motiv internare: ");
            string info3 = Console.ReadLine().Trim().ToUpper();
            patient.MotivInternare = info3;

            Console.Write("CARD DE SANATATE: \n");
            patient.Card = HaveOrNotCard();

            Console.Write("Data internarii: (dd.mm.yyyy)\nRaspuns:");
            string date1 = Console.ReadLine();
            patient.DataInternare = DateTime.Parse(date1);

            Console.WriteLine("Introduceti bolile pe care le aveti:  (durere de cap, ameteala, etc.)");
            string Infoboli = Console.ReadLine().ToUpper();
            List<string> bolic = new List<string>();


            string[] SimptomeFormatate = Infoboli.Split(',');

            for (int i = 0; i < SimptomeFormatate.Length; i++)
            {
                SimptomeFormatate[i] = SimptomeFormatate[i].Trim();
                bolic.Add(SimptomeFormatate[i]);
            }

            patient.Boli = bolic;

            return patient;
        }

        public static Genul ReadSex()
        {
            var gen = Enum.GetNames(typeof(Genul));
            int contor = 0;
            foreach (var element in gen)
                Console.WriteLine(++contor + "." + element + "  ");

            Console.Write("Genul este: ");
            int.TryParse(Console.ReadLine(), out int IntGen);

            return (Genul)Convert.ToInt32(IntGen);
        }

        public static TipCetatenie TypeOfC()
        {
            var type = Enum.GetNames(typeof(TipCetatenie));
            int contor = 0;
            foreach (var element in type)
                Console.WriteLine(++contor + "." + element + "  ");

            Console.Write("Raspuns: ");
            int.TryParse(Console.ReadLine(), out int IntGen);

            return (TipCetatenie)Convert.ToInt32(IntGen);
        }

        public static DetineCard HaveOrNotCard()
        {
            var type = Enum.GetNames(typeof(DetineCard));
            int contor = 0;
            foreach (var element in type)
                Console.WriteLine(++contor + "." + element + "  ");

            Console.Write("Detine card: ");
            int.TryParse(Console.ReadLine(), out int IntGen);

            return (DetineCard)Convert.ToInt32(IntGen);
        }
    }
}
