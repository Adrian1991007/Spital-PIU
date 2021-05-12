using System;

namespace PatientClass
{
    public class Patient
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ',';


        public int ID { get; set; }
        public static int IDCurent { get; set; } = 1;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Genul Sex { get; set; }
        public int Varsta { get; set; }
        public TipCetatenie Cetatean { get; set; }
        public DateTime DataNastere { get; set; }
        public string MotivInternare { get; set; }
        public DetineCard Card { get; set; }
        public DateTime DataInternare { get; set; }

        public Patient() { }

        public Patient(string info)
        {
            string[] InfoAfterSplit = info.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID = ++IDCurent;
            Nume = InfoAfterSplit[(int)(ContinutPacient.NUME)];
            Prenume = InfoAfterSplit[(int)(ContinutPacient.PRENUME)];
            Sex = (Genul)Convert.ToInt32(InfoAfterSplit[(int)(ContinutPacient.SEX)]);
            Varsta = Convert.ToInt32(InfoAfterSplit[(int)(ContinutPacient.VARSTA)]);
            Cetatean = (TipCetatenie)Convert.ToInt32(InfoAfterSplit[(int)(ContinutPacient.CETATEAN)]);
            DataNastere = DateTime.Parse(InfoAfterSplit[(int)(ContinutPacient.DATANASTERE)]);
            MotivInternare = InfoAfterSplit[(int)(ContinutPacient.MOTIVINTERNARE)];
            Card = (DetineCard)Convert.ToInt32(InfoAfterSplit[(int)(ContinutPacient.CARD)]);
            DataInternare = DateTime.Parse(InfoAfterSplit[(int)(ContinutPacient.DATAINTERNARE)]);
        }

        public string ConvertToString()
        {
            return "ID: " + (ID.ToString() ?? "NECUNOSCUT") + "\n" +
                   "Nume: " + (Nume ?? "NECUNOSCUT") + "\n" +
                   "Prenume: " + (Prenume ?? "NECUNOSCUT") + "\n" +
                   "Genul: " + (Sex.ToString() ?? "NECUNOSCUT") + "\n" +
                   "Varsta: " + (Varsta.ToString() ?? "NECUNOSCUT") + "\n" +
                   "Cetatean: " + (Cetatean.ToString() ?? "NECUNOSCUT") + "\n" +
                   "Data Nasterii: " + (DataNastere.ToString("dd-mm-yyyy") ?? "01-01-2018") + "\n" +
                   "Motiv Internare: " + (MotivInternare ?? "NECUNOSCUT") + "\n" +
                   "Detine card de sanatate: " + (Card.ToString() ?? "NECUNOSCUT") + "\n" +
                   "Data Internarii: " + (DataInternare.ToString("dd-mm-yyyy") ?? "01-01.2018");
        }

        public string ConvertToStringForFile()
        {
            string info = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                SEPARATOR_PRINCIPAL_FISIER, Nume, Prenume, Convert.ToInt32(Sex), Varsta, Convert.ToInt32(Cetatean), DataNastere.ToString("dd.mm.yyyy"),
                MotivInternare, Convert.ToInt32(Card), DataInternare.ToString("dd.mm.yyyy"));

            return info;
        }

    }
}
