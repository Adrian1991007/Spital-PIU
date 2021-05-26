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
        readonly IStocareData Manager;
        readonly List<string> BoliCurenteSelectate = new List<string>();
        readonly List<Patient> pacienti;

        public Spital()
        {
            InitializeComponent();
            Manager = StocareFactory.GetAdministratorStocare();
            pacienti = Manager.GetPatient();
        }

        private void ListPacienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Patient s = Manager.GetPatient(LstPatients.SelectedIndex, pacienti);

            txtNume.Text = s.Nume;
            txtPrenume.Text = s.Prenume;
            txtVarsta.Text = s.Varsta.ToString();
            txtMotivInternare.Text = s.MotivInternare;

            foreach(Control c in grpGen.Controls)
            {
                if(c.GetType() == typeof(RadioButton))
                {
                    if (s.Sex.ToString() == c.Text)
                        ((RadioButton)c).Checked = true;
                }
            }

            foreach (Control c in grpCetatenii.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (s.Cetatean.ToString().ToUpper() == c.Text.ToUpper())
                        ((RadioButton)c).Checked = true;
                }
            }

            foreach (Control c in grpCard.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (s.Card.ToString().ToUpper() == c.Text.ToUpper())
                        ((RadioButton)c).Checked = true;
                }
            }

            foreach (Control c in grpSimptome.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    foreach(string boala in s.Boli)
                        if (boala.ToUpper() == c.Text.ToUpper())
                            ((CheckBox)c).Checked = true;
                }
            }

        }

        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            LstPatients.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-25}{2,-15}{3,-20}{4,-20}{5,-20}{6,-20}{7,-20}{8,-20}{9,-20}\n", "Id", "Nume Prenume", "Varsta", "Data Nasterii" , "Data Internare", "Genul", "Cetatenie", "Card", "Data Actualizare", "Boli Curente");
            LstPatients.Items.Add(antetTabel);

            foreach (Patient s in pacienti)
            {
                s.DataActualizare = DateTime.UtcNow;

                string input = string.Empty;
                foreach (var boala in s.Boli)
                {
                    input += boala + " ";
                }
                var linieTabel = String.Format("{0,-5}{1,-5}{2,-22}{3,-17}{4,-17}{5,-18}{6,-20}{7,-20}{8,-20}{9,-20}{10,-2}\n", s.ID, s.Nume, s.Prenume, s.Varsta, s.DataNastere.ToString("dd.MM.yyyy"), s.DataInternare.ToString("dd.MM.yyyy"), s.Sex.ToString(), s.Cetatean.ToString(), s.Card.ToString(), s.DataActualizare.ToString("dd.MM.yyyy"), input.ToString());
                LstPatients.Items.Add(linieTabel);
            }
            dtgAfisare.DataSource = null;
            dtgAfisare.DataSource = pacienti;
        }

        public void AfisarePacienti()
        {
            LstPatients.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-25}{2,-15}{3,-20}{4,-20}{5,-20}{6,-20}{7,-20}{8,-20}{9,-20}\n", "Id", "Nume Prenume", "Varsta", "Data Nasterii", "Data Internare", "Genul", "Cetatenie", "Card", "Data Actualizare", "Boli Curente");
            LstPatients.Items.Add(antetTabel);

            foreach (Patient s in pacienti)
            {
                s.DataActualizare = DateTime.UtcNow;

                string input = string.Empty;
                foreach (var boala in s.Boli)
                {
                    input += boala + " ";
                }
                var linieTabel = String.Format("{0,-5}{1,-5}{2,-22}{3,-17}{4,-17}{5,-18}{6,-20}{7,-20}{8,-20}{9,-20}{10,-2}\n", s.ID, s.Nume, s.Prenume, s.Varsta, s.DataNastere.ToString("dd.MM.yyyy"), s.DataInternare.ToString("dd.MM.yyyy"), s.Sex.ToString(), s.Cetatean.ToString(), s.Card.ToString(), s.DataActualizare.ToString("dd.MM.yyyy"), input.ToString());
                LstPatients.Items.Add(linieTabel);
            }
            dtgAfisare.DataSource = null;
            dtgAfisare.DataSource = pacienti;
        }

        private void BtnAdaugareClick(object sender, EventArgs e)
        {
            #region Testare Validari
            if (!NumeValid())
                lblNume.ForeColor = Color.Red;

            if (!PrenumeValid())
                lblPrenume.ForeColor = Color.Red;

            if (!VarstaValida())
                lblVarsta.ForeColor = Color.Red;

            if (!MotivInternareValid())
                lblMotiv_Internare.ForeColor = Color.Red;

            if (!BoliValide())
                lblBoliCurente.ForeColor = Color.Red;

            if (!GenValid())
                lblGen.ForeColor = Color.Red;

            if (!CetatenieValida())
                lblCetatean.ForeColor = Color.Red;

            if (!CardValid())
            {
                lblCard.ForeColor = Color.Red;
                return;
            }
            #endregion

            Patient patient = new Patient
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text
            };
            if (txtVarsta.Text.Length != 0)
                patient.Varsta = Convert.ToInt32(txtVarsta.Text);
            else
                patient.Varsta = 0;
            patient.DataNastere = dtpData_Nastere.Value;
            patient.DataInternare = dtpData_Internare.Value;
            patient.MotivInternare = txtMotivInternare.Text;

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
                patient.Cetatean = CetateanSelectat.Value;
            }

            patient.DataActualizare = DateTime.Now;

            patient.Boli = new List<string>();
            patient.Boli.AddRange(BoliCurenteSelectate);

            Manager.New_Patient(patient);
            lblMesaj.Text = "Pacientul a fost adaugat";

            ResetareControale();
        }

        #region Validari
        private bool NumeValid()
        {
            if (txtNume.Text.Length < 3)
            {
                return false;
            }

            return true;
        }

        private bool PrenumeValid()
        {
            if (txtPrenume.Text.Length < 3)
            {
                return false;
            }

            return true;
        }

        private bool VarstaValida()
        {
            if (txtVarsta.Text.Length == 0)
            {
                return false;
            }
            if (Convert.ToInt32(txtVarsta.Text) < 1 && Convert.ToInt32(txtVarsta.Text) > 105)
            {
                return false;
            }

            return true;
        }

        private bool MotivInternareValid()
        {
            if (txtMotivInternare.Text.Length < 3)
            {
                return false;
            }

            return true;
        }

        private bool BoliValide()
        {
            if (BoliCurenteSelectate.Count < 1)
            {
                return false;
            }

            return true;
        }

        private bool GenValid()
        {
            if (rdbMASCULIN.Checked == false && rdbFEMININ.Checked == false)
            {
                return false;
            }

            return true;
        }

        private bool CetatenieValida()
        {
            if (rdbEngleza.Checked is false && rdbGermana.Checked is false && rdbFranceza.Checked is false && rdbRomana.Checked is false)
            {
                return false;
            }

            return true;
        }

        private bool CardValid()
        {
            if (rdbNu.Checked is false && rdbDa.Checked is false)
            {
                return false;
            }

            return true;
        }
        #endregion

        private Genul? GetGenulSelectat()
        {
            if (rdbMASCULIN.Checked)
                return Genul.MASCULIN;
            if (rdbFEMININ.Checked)
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

        private void BoliCurente_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 

            string BoalaCurenta = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                BoliCurenteSelectate.Add(BoalaCurenta);
            else
                BoliCurenteSelectate.Remove(BoalaCurenta);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtVarsta.Text = txtMotivInternare.Text = string.Empty;
            rdbFEMININ.Checked = false;
            rdbMASCULIN.Checked = false;
            rdbRomana.Checked = false;
            rdbGermana.Checked = false;
            rdbEngleza.Checked = false;
            rdbFranceza.Checked = false;
            rdbDa.Checked = false;
            rdbNu.Checked = false;
            ckbStrabism.Checked = false;
            ckbCancer.Checked = false;
            ckbArtroza.Checked = false;
            ckbRubeola.Checked = false;
            ckbOtita.Checked = false;
            ckbPneumonie.Checked = false;
            ckbDiabet.Checked = false;
            ckbEpilepsie.Checked = false;
            ckbGlaucom.Checked = false;
            ckbGuta.Checked = false;
            ckbKeratita.Checked = false;
            ckbOreion.Checked = false;
            BoliCurenteSelectate.Clear();
            lblMesaj.Text = string.Empty;
        }

        private void BtnCautare_Click(object sender, EventArgs e)
        {
            LstPatients.Items.Clear();
            Patient patient = Manager.GetPatient(txtNume.Text);

            LstPatients.Items.Add("Pacientul cautat este:");

            if (patient != null)
                LstPatients.Items.Add(patient.ConvertToString());
            else
                LstPatients.Items.Add("Pacientul nu este inregistrat");
        }

        private void BtnReseteaza_Click(object sender, EventArgs e)
        {
            ResetareControale();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            Patient patient = Manager.GetPatient(LstPatients.SelectedIndex, pacienti);

            patient.Nume = txtNume.Text;
            patient.Prenume = txtPrenume.Text;
            patient.Varsta = Convert.ToInt32(txtVarsta.Text);
            patient.DataNastere = dtpData_Nastere.Value;
            patient.DataInternare = dtpData_Internare.Value;
            patient.MotivInternare = txtMotivInternare.Text;

            Genul? GenulSelectat = GetGenulSelectat();
            if (GenulSelectat.HasValue)
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
                patient.Cetatean = CetateanSelectat.Value;
            }

            patient.Boli = new List<string>();
            patient.Boli.AddRange(BoliCurenteSelectate);


            patient.DataActualizare = DateTime.Now;

            Manager.UpdatePacient(patient);

            AfisarePacienti();
            ResetareControale();
            Manager.NewListOfPatients(pacienti);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstPatients.Items.Clear();
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
