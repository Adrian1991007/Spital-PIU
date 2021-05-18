using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;
using PatientClass;
using System.Windows.Forms;
using System.Collections;

namespace Interfata_Utilizator_WindowsForms
{
    public partial class Spital : Form
    {
        IStocareData Manager;
        List<Patient> patients;
        List<string> CetateniiSelectate = new List<string>();

        public Spital()
        {
            InitializeComponent();
            Manager = StocareFactory.GetAdministratorStocare();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void rdbFeminin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listPacienti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ID++;

            patient.Nume = txtNume.Text;
            patient.Prenume = txtPrenume.Text;
            patient.Varsta = Convert.ToInt32(txtVarsta.Text);
            patient.DataNastere = DateTime.Parse(txtData_Nastere.Text);
            patient.DataInternare = DateTime.Parse(txtData_Internare.Text);
            patient.MotivInternare = txtMotiv_Internare.Text;


            //verificare radioButton selectat

            Genul? GenulSelectat = GetGenulSelectat();
            if(GenulSelectat.HasValue)
            {
                patient.Sex = GenulSelectat.Value;
            }

            DetineCard? CardSelectat = GetCardSelectat();
            if (CardSelectat.HasValue)
            {
                patient.Card = CardSelectat.Value;
            }

            TipCetatenie? CetateanSelectat = GetCetateanSelectat();
            if (CetateanSelectat.HasValue)
            {
                patient.Cetatean= CetateanSelectat.Value;
            }

            //continua
        }

        //private bool ValidareDate()
        //{
        //    if()
        //}

        private Genul? GetGenulSelectat()
        {
            if (rdbMasculin.Checked)
                return Genul.MASCULIN;
            if (rdbFeminin.Checked)
                return Genul.FEMININ;

            return null;
        }

        private TipCetatenie? GetCetateanSelectat()
        {
            if (rdbRomana.Checked)
                return TipCetatenie.ROMANA;
            if (rdbGermana.Checked)
                return TipCetatenie.GERMANA;
            if (rdbEngleza.Checked)
                return TipCetatenie.ENGLEZA;
            if (rdbFranceza.Checked)
                return TipCetatenie.FRANCEZA;

            return null;
        }

        private DetineCard? GetCardSelectat()
        {
            if (rdbDa.Checked)
                return DetineCard.DA;
            if (rdbNu.Checked)
                return DetineCard.NU;

            return null;
        }

        private void grpCetatenii_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string CetatenieSelectata = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                CetateniiSelectate.Add(CetatenieSelectata);
            else
                CetateniiSelectate.Remove(CetatenieSelectata);
        }
    }
}
