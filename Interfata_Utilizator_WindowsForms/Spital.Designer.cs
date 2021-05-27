
namespace Interfata_Utilizator_WindowsForms
{
    partial class Spital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCitire = new System.Windows.Forms.GroupBox();
            this.txtMotivInternare = new System.Windows.Forms.TextBox();
            this.dtpData_Internare = new System.Windows.Forms.DateTimePicker();
            this.dtpData_Nastere = new System.Windows.Forms.DateTimePicker();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblMotiv_Internare = new System.Windows.Forms.Label();
            this.lblData_Internare = new System.Windows.Forms.Label();
            this.lblDNastere = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblCetatean = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.LstPatients = new System.Windows.Forms.ListBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.rdbDa = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.grpCetatenii = new System.Windows.Forms.GroupBox();
            this.rdbFranceza = new System.Windows.Forms.RadioButton();
            this.rdbEngleza = new System.Windows.Forms.RadioButton();
            this.rdbGermana = new System.Windows.Forms.RadioButton();
            this.rdbRomana = new System.Windows.Forms.RadioButton();
            this.grpSimptome = new System.Windows.Forms.GroupBox();
            this.ckbPneumonie = new System.Windows.Forms.CheckBox();
            this.ckbOreion = new System.Windows.Forms.CheckBox();
            this.ckbKeratita = new System.Windows.Forms.CheckBox();
            this.ckbRubeola = new System.Windows.Forms.CheckBox();
            this.ckbArtroza = new System.Windows.Forms.CheckBox();
            this.ckbOtita = new System.Windows.Forms.CheckBox();
            this.ckbGuta = new System.Windows.Forms.CheckBox();
            this.ckbGlaucom = new System.Windows.Forms.CheckBox();
            this.ckbEpilepsie = new System.Windows.Forms.CheckBox();
            this.ckbCancer = new System.Windows.Forms.CheckBox();
            this.ckbDiabet = new System.Windows.Forms.CheckBox();
            this.ckbStrabism = new System.Windows.Forms.CheckBox();
            this.lblBoliCurente = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.rdbMASCULIN = new System.Windows.Forms.RadioButton();
            this.rdbFEMININ = new System.Windows.Forms.RadioButton();
            this.grpGen = new System.Windows.Forms.GroupBox();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.dtgAfisare = new System.Windows.Forms.DataGridView();
            this.BtnReseteaza = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SpitalFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCitire.SuspendLayout();
            this.grpCetatenii.SuspendLayout();
            this.grpSimptome.SuspendLayout();
            this.grpGen.SuspendLayout();
            this.grpCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfisare)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCitire
            // 
            this.grpCitire.Controls.Add(this.txtMotivInternare);
            this.grpCitire.Controls.Add(this.dtpData_Internare);
            this.grpCitire.Controls.Add(this.dtpData_Nastere);
            this.grpCitire.Controls.Add(this.txtVarsta);
            this.grpCitire.Controls.Add(this.txtPrenume);
            this.grpCitire.Controls.Add(this.txtNume);
            this.grpCitire.Controls.Add(this.lblMotiv_Internare);
            this.grpCitire.Controls.Add(this.lblData_Internare);
            this.grpCitire.Controls.Add(this.lblDNastere);
            this.grpCitire.Controls.Add(this.lblVarsta);
            this.grpCitire.Controls.Add(this.lblPrenume);
            this.grpCitire.Controls.Add(this.lblNume);
            this.grpCitire.Location = new System.Drawing.Point(2, 29);
            this.grpCitire.Name = "grpCitire";
            this.grpCitire.Size = new System.Drawing.Size(361, 275);
            this.grpCitire.TabIndex = 0;
            this.grpCitire.TabStop = false;
            // 
            // txtMotivInternare
            // 
            this.txtMotivInternare.Location = new System.Drawing.Point(129, 223);
            this.txtMotivInternare.Name = "txtMotivInternare";
            this.txtMotivInternare.Size = new System.Drawing.Size(182, 20);
            this.txtMotivInternare.TabIndex = 17;
            // 
            // dtpData_Internare
            // 
            this.dtpData_Internare.Location = new System.Drawing.Point(129, 186);
            this.dtpData_Internare.Name = "dtpData_Internare";
            this.dtpData_Internare.Size = new System.Drawing.Size(185, 20);
            this.dtpData_Internare.TabIndex = 16;
            // 
            // dtpData_Nastere
            // 
            this.dtpData_Nastere.Location = new System.Drawing.Point(132, 145);
            this.dtpData_Nastere.Name = "dtpData_Nastere";
            this.dtpData_Nastere.Size = new System.Drawing.Size(182, 20);
            this.dtpData_Nastere.TabIndex = 15;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(132, 105);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(182, 20);
            this.txtVarsta.TabIndex = 11;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(132, 71);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(182, 20);
            this.txtPrenume.TabIndex = 10;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(132, 36);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(182, 20);
            this.txtNume.TabIndex = 9;
            // 
            // lblMotiv_Internare
            // 
            this.lblMotiv_Internare.AutoSize = true;
            this.lblMotiv_Internare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotiv_Internare.Location = new System.Drawing.Point(22, 225);
            this.lblMotiv_Internare.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblMotiv_Internare.Name = "lblMotiv_Internare";
            this.lblMotiv_Internare.Size = new System.Drawing.Size(109, 18);
            this.lblMotiv_Internare.TabIndex = 8;
            this.lblMotiv_Internare.Text = "Motiv Internare:";
            // 
            // lblData_Internare
            // 
            this.lblData_Internare.AutoSize = true;
            this.lblData_Internare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Internare.Location = new System.Drawing.Point(22, 185);
            this.lblData_Internare.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblData_Internare.Name = "lblData_Internare";
            this.lblData_Internare.Size = new System.Drawing.Size(100, 18);
            this.lblData_Internare.TabIndex = 7;
            this.lblData_Internare.Text = "Data Internare";
            // 
            // lblDNastere
            // 
            this.lblDNastere.AutoSize = true;
            this.lblDNastere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNastere.Location = new System.Drawing.Point(22, 145);
            this.lblDNastere.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblDNastere.Name = "lblDNastere";
            this.lblDNastere.Size = new System.Drawing.Size(97, 18);
            this.lblDNastere.TabIndex = 6;
            this.lblDNastere.Text = "Data Nasterii:";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarsta.Location = new System.Drawing.Point(22, 107);
            this.lblVarsta.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(54, 18);
            this.lblVarsta.TabIndex = 4;
            this.lblVarsta.Text = "Varsta:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(22, 73);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(68, 18);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(22, 33);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(48, 18);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(364, 62);
            this.lblGen.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(51, 18);
            this.lblGen.TabIndex = 3;
            this.lblGen.Text = "Genul:";
            // 
            // lblCetatean
            // 
            this.lblCetatean.AutoSize = true;
            this.lblCetatean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCetatean.Location = new System.Drawing.Point(368, 182);
            this.lblCetatean.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblCetatean.Name = "lblCetatean";
            this.lblCetatean.Size = new System.Drawing.Size(74, 18);
            this.lblCetatean.TabIndex = 5;
            this.lblCetatean.Text = "Cetatenie:";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(27, 594);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(140, 42);
            this.btnAdaugare.TabIndex = 6;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.BtnAdaugareClick);
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(253, 594);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(140, 42);
            this.btnCautare.TabIndex = 7;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.BtnCautare_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(481, 594);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(140, 42);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(684, 594);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(140, 42);
            this.btnAfiseaza.TabIndex = 9;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // LstPatients
            // 
            this.LstPatients.FormattingEnabled = true;
            this.LstPatients.Location = new System.Drawing.Point(506, 16);
            this.LstPatients.Name = "LstPatients";
            this.LstPatients.Size = new System.Drawing.Size(948, 264);
            this.LstPatients.TabIndex = 10;
            this.LstPatients.SelectedIndexChanged += new System.EventHandler(this.ListPacienti_SelectedIndexChanged);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(368, 399);
            this.lblCard.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(40, 18);
            this.lblCard.TabIndex = 17;
            this.lblCard.Text = "Card";
            // 
            // rdbDa
            // 
            this.rdbDa.AutoSize = true;
            this.rdbDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDa.Location = new System.Drawing.Point(6, 45);
            this.rdbDa.Name = "rdbDa";
            this.rdbDa.Size = new System.Drawing.Size(45, 22);
            this.rdbDa.TabIndex = 18;
            this.rdbDa.TabStop = true;
            this.rdbDa.Text = "Da";
            this.rdbDa.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(57, 45);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 22);
            this.rdbNu.TabIndex = 19;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nu";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // grpCetatenii
            // 
            this.grpCetatenii.Controls.Add(this.rdbFranceza);
            this.grpCetatenii.Controls.Add(this.rdbEngleza);
            this.grpCetatenii.Controls.Add(this.rdbGermana);
            this.grpCetatenii.Controls.Add(this.rdbRomana);
            this.grpCetatenii.Location = new System.Drawing.Point(369, 203);
            this.grpCetatenii.Name = "grpCetatenii";
            this.grpCetatenii.Size = new System.Drawing.Size(131, 181);
            this.grpCetatenii.TabIndex = 20;
            this.grpCetatenii.TabStop = false;
            // 
            // rdbFranceza
            // 
            this.rdbFranceza.AutoSize = true;
            this.rdbFranceza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFranceza.Location = new System.Drawing.Point(6, 145);
            this.rdbFranceza.Name = "rdbFranceza";
            this.rdbFranceza.Size = new System.Drawing.Size(88, 22);
            this.rdbFranceza.TabIndex = 15;
            this.rdbFranceza.TabStop = true;
            this.rdbFranceza.Text = "Franceza";
            this.rdbFranceza.UseVisualStyleBackColor = true;
            // 
            // rdbEngleza
            // 
            this.rdbEngleza.AutoSize = true;
            this.rdbEngleza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEngleza.Location = new System.Drawing.Point(6, 104);
            this.rdbEngleza.Name = "rdbEngleza";
            this.rdbEngleza.Size = new System.Drawing.Size(79, 22);
            this.rdbEngleza.TabIndex = 14;
            this.rdbEngleza.TabStop = true;
            this.rdbEngleza.Text = "Engleza";
            this.rdbEngleza.UseVisualStyleBackColor = true;
            // 
            // rdbGermana
            // 
            this.rdbGermana.AutoSize = true;
            this.rdbGermana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGermana.Location = new System.Drawing.Point(6, 63);
            this.rdbGermana.Name = "rdbGermana";
            this.rdbGermana.Size = new System.Drawing.Size(88, 22);
            this.rdbGermana.TabIndex = 13;
            this.rdbGermana.TabStop = true;
            this.rdbGermana.Text = "Germana";
            this.rdbGermana.UseVisualStyleBackColor = true;
            // 
            // rdbRomana
            // 
            this.rdbRomana.AutoSize = true;
            this.rdbRomana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRomana.Location = new System.Drawing.Point(6, 22);
            this.rdbRomana.Name = "rdbRomana";
            this.rdbRomana.Size = new System.Drawing.Size(83, 22);
            this.rdbRomana.TabIndex = 12;
            this.rdbRomana.TabStop = true;
            this.rdbRomana.Text = "Romana";
            this.rdbRomana.UseVisualStyleBackColor = true;
            // 
            // grpSimptome
            // 
            this.grpSimptome.Controls.Add(this.ckbPneumonie);
            this.grpSimptome.Controls.Add(this.ckbOreion);
            this.grpSimptome.Controls.Add(this.ckbKeratita);
            this.grpSimptome.Controls.Add(this.ckbRubeola);
            this.grpSimptome.Controls.Add(this.ckbArtroza);
            this.grpSimptome.Controls.Add(this.ckbOtita);
            this.grpSimptome.Controls.Add(this.ckbGuta);
            this.grpSimptome.Controls.Add(this.ckbGlaucom);
            this.grpSimptome.Controls.Add(this.ckbEpilepsie);
            this.grpSimptome.Controls.Add(this.ckbCancer);
            this.grpSimptome.Controls.Add(this.ckbDiabet);
            this.grpSimptome.Controls.Add(this.ckbStrabism);
            this.grpSimptome.Location = new System.Drawing.Point(2, 325);
            this.grpSimptome.Name = "grpSimptome";
            this.grpSimptome.Size = new System.Drawing.Size(361, 241);
            this.grpSimptome.TabIndex = 21;
            this.grpSimptome.TabStop = false;
            this.grpSimptome.Text = " ";
            // 
            // ckbPneumonie
            // 
            this.ckbPneumonie.AutoSize = true;
            this.ckbPneumonie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPneumonie.Location = new System.Drawing.Point(12, 209);
            this.ckbPneumonie.Name = "ckbPneumonie";
            this.ckbPneumonie.Size = new System.Drawing.Size(102, 22);
            this.ckbPneumonie.TabIndex = 17;
            this.ckbPneumonie.Text = "Pneumonie";
            this.ckbPneumonie.UseVisualStyleBackColor = true;
            this.ckbPneumonie.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbOreion
            // 
            this.ckbOreion.AutoSize = true;
            this.ckbOreion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOreion.Location = new System.Drawing.Point(197, 209);
            this.ckbOreion.Name = "ckbOreion";
            this.ckbOreion.Size = new System.Drawing.Size(72, 22);
            this.ckbOreion.TabIndex = 16;
            this.ckbOreion.Text = "Oreion";
            this.ckbOreion.UseVisualStyleBackColor = true;
            this.ckbOreion.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbKeratita
            // 
            this.ckbKeratita.AutoSize = true;
            this.ckbKeratita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKeratita.Location = new System.Drawing.Point(197, 172);
            this.ckbKeratita.Name = "ckbKeratita";
            this.ckbKeratita.Size = new System.Drawing.Size(77, 22);
            this.ckbKeratita.TabIndex = 15;
            this.ckbKeratita.Text = "Keratita";
            this.ckbKeratita.UseVisualStyleBackColor = true;
            this.ckbKeratita.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbRubeola
            // 
            this.ckbRubeola.AutoSize = true;
            this.ckbRubeola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRubeola.Location = new System.Drawing.Point(12, 134);
            this.ckbRubeola.Name = "ckbRubeola";
            this.ckbRubeola.Size = new System.Drawing.Size(82, 22);
            this.ckbRubeola.TabIndex = 14;
            this.ckbRubeola.Text = "Rubeola";
            this.ckbRubeola.UseVisualStyleBackColor = true;
            this.ckbRubeola.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbArtroza
            // 
            this.ckbArtroza.AutoSize = true;
            this.ckbArtroza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbArtroza.Location = new System.Drawing.Point(12, 94);
            this.ckbArtroza.Name = "ckbArtroza";
            this.ckbArtroza.Size = new System.Drawing.Size(75, 22);
            this.ckbArtroza.TabIndex = 13;
            this.ckbArtroza.Text = "Artroza";
            this.ckbArtroza.UseVisualStyleBackColor = true;
            this.ckbArtroza.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbOtita
            // 
            this.ckbOtita.AutoSize = true;
            this.ckbOtita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOtita.Location = new System.Drawing.Point(12, 172);
            this.ckbOtita.Name = "ckbOtita";
            this.ckbOtita.Size = new System.Drawing.Size(58, 22);
            this.ckbOtita.TabIndex = 12;
            this.ckbOtita.Text = "Otita";
            this.ckbOtita.UseVisualStyleBackColor = true;
            this.ckbOtita.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbGuta
            // 
            this.ckbGuta.AutoSize = true;
            this.ckbGuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGuta.Location = new System.Drawing.Point(197, 134);
            this.ckbGuta.Name = "ckbGuta";
            this.ckbGuta.Size = new System.Drawing.Size(59, 22);
            this.ckbGuta.TabIndex = 11;
            this.ckbGuta.Text = "Guta";
            this.ckbGuta.UseVisualStyleBackColor = true;
            this.ckbGuta.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbGlaucom
            // 
            this.ckbGlaucom.AutoSize = true;
            this.ckbGlaucom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGlaucom.Location = new System.Drawing.Point(197, 95);
            this.ckbGlaucom.Name = "ckbGlaucom";
            this.ckbGlaucom.Size = new System.Drawing.Size(88, 22);
            this.ckbGlaucom.TabIndex = 10;
            this.ckbGlaucom.Text = "Glaucom";
            this.ckbGlaucom.UseVisualStyleBackColor = true;
            this.ckbGlaucom.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbEpilepsie
            // 
            this.ckbEpilepsie.AutoSize = true;
            this.ckbEpilepsie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEpilepsie.Location = new System.Drawing.Point(197, 58);
            this.ckbEpilepsie.Name = "ckbEpilepsie";
            this.ckbEpilepsie.Size = new System.Drawing.Size(86, 22);
            this.ckbEpilepsie.TabIndex = 9;
            this.ckbEpilepsie.Text = "Epilepsie";
            this.ckbEpilepsie.UseVisualStyleBackColor = true;
            this.ckbEpilepsie.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbCancer
            // 
            this.ckbCancer.AutoSize = true;
            this.ckbCancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCancer.Location = new System.Drawing.Point(12, 58);
            this.ckbCancer.Name = "ckbCancer";
            this.ckbCancer.Size = new System.Drawing.Size(75, 22);
            this.ckbCancer.TabIndex = 8;
            this.ckbCancer.Text = "Cancer";
            this.ckbCancer.UseVisualStyleBackColor = true;
            this.ckbCancer.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbDiabet
            // 
            this.ckbDiabet.AutoSize = true;
            this.ckbDiabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDiabet.Location = new System.Drawing.Point(197, 20);
            this.ckbDiabet.Name = "ckbDiabet";
            this.ckbDiabet.Size = new System.Drawing.Size(69, 22);
            this.ckbDiabet.TabIndex = 7;
            this.ckbDiabet.Text = "Diabet";
            this.ckbDiabet.UseVisualStyleBackColor = true;
            this.ckbDiabet.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // ckbStrabism
            // 
            this.ckbStrabism.AutoSize = true;
            this.ckbStrabism.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStrabism.Location = new System.Drawing.Point(12, 19);
            this.ckbStrabism.Name = "ckbStrabism";
            this.ckbStrabism.Size = new System.Drawing.Size(86, 22);
            this.ckbStrabism.TabIndex = 0;
            this.ckbStrabism.Text = "Strabism";
            this.ckbStrabism.UseVisualStyleBackColor = true;
            this.ckbStrabism.CheckedChanged += new System.EventHandler(this.BoliCurente_CheckedChanged);
            // 
            // lblBoliCurente
            // 
            this.lblBoliCurente.AutoSize = true;
            this.lblBoliCurente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoliCurente.Location = new System.Drawing.Point(4, 307);
            this.lblBoliCurente.Name = "lblBoliCurente";
            this.lblBoliCurente.Size = new System.Drawing.Size(86, 18);
            this.lblBoliCurente.TabIndex = 0;
            this.lblBoliCurente.Text = "Boli curente";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(9, 551);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 22;
            // 
            // rdbMASCULIN
            // 
            this.rdbMASCULIN.AutoSize = true;
            this.rdbMASCULIN.Location = new System.Drawing.Point(16, 19);
            this.rdbMASCULIN.Name = "rdbMASCULIN";
            this.rdbMASCULIN.Size = new System.Drawing.Size(80, 17);
            this.rdbMASCULIN.TabIndex = 23;
            this.rdbMASCULIN.TabStop = true;
            this.rdbMASCULIN.Text = "MASCULIN";
            this.rdbMASCULIN.UseVisualStyleBackColor = true;
            // 
            // rdbFEMININ
            // 
            this.rdbFEMININ.AutoSize = true;
            this.rdbFEMININ.Location = new System.Drawing.Point(16, 55);
            this.rdbFEMININ.Name = "rdbFEMININ";
            this.rdbFEMININ.Size = new System.Drawing.Size(69, 17);
            this.rdbFEMININ.TabIndex = 24;
            this.rdbFEMININ.TabStop = true;
            this.rdbFEMININ.Text = "FEMININ";
            this.rdbFEMININ.UseVisualStyleBackColor = true;
            // 
            // grpGen
            // 
            this.grpGen.Controls.Add(this.rdbMASCULIN);
            this.grpGen.Controls.Add(this.rdbFEMININ);
            this.grpGen.Location = new System.Drawing.Point(367, 94);
            this.grpGen.Name = "grpGen";
            this.grpGen.Size = new System.Drawing.Size(133, 85);
            this.grpGen.TabIndex = 25;
            this.grpGen.TabStop = false;
            // 
            // grpCard
            // 
            this.grpCard.Controls.Add(this.rdbDa);
            this.grpCard.Controls.Add(this.rdbNu);
            this.grpCard.Location = new System.Drawing.Point(369, 420);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(131, 103);
            this.grpCard.TabIndex = 26;
            this.grpCard.TabStop = false;
            // 
            // dtgAfisare
            // 
            this.dtgAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAfisare.Location = new System.Drawing.Point(506, 282);
            this.dtgAfisare.Name = "dtgAfisare";
            this.dtgAfisare.Size = new System.Drawing.Size(948, 284);
            this.dtgAfisare.TabIndex = 27;
            // 
            // BtnReseteaza
            // 
            this.BtnReseteaza.Location = new System.Drawing.Point(901, 594);
            this.BtnReseteaza.Name = "BtnReseteaza";
            this.BtnReseteaza.Size = new System.Drawing.Size(140, 42);
            this.BtnReseteaza.TabIndex = 28;
            this.BtnReseteaza.Text = "Reset";
            this.BtnReseteaza.UseVisualStyleBackColor = true;
            this.BtnReseteaza.Click += new System.EventHandler(this.BtnReseteaza_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1402, 247);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(52, 35);
            this.BtnClear.TabIndex = 29;
            this.BtnClear.Text = "Reset";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // SpitalFileDialog
            // 
            this.SpitalFileDialog.FileName = "SpitalFileDialog";
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(1314, 594);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(140, 42);
            this.BtnIesire.TabIndex = 30;
            this.BtnIesire.Text = "Close";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTool});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1477, 27);
            this.Menu.TabIndex = 32;
            this.Menu.Text = "menuStrip1";
            // 
            // FileTool
            // 
            this.FileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpen,
            this.MenuItemNewForm});
            this.FileTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FileTool.Name = "FileTool";
            this.FileTool.Size = new System.Drawing.Size(41, 23);
            this.FileTool.Text = "File";
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(185, 24);
            this.MenuItemOpen.Text = "Deschide un fisier";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click_1);
            // 
            // MenuItemNewForm
            // 
            this.MenuItemNewForm.Name = "MenuItemNewForm";
            this.MenuItemNewForm.Size = new System.Drawing.Size(185, 24);
            this.MenuItemNewForm.Text = "Afisare Continut";
            this.MenuItemNewForm.Click += new System.EventHandler(this.newFormToolStripMenuItem_Click_1);
            // 
            // Spital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 661);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnReseteaza);
            this.Controls.Add(this.dtgAfisare);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.grpGen);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblBoliCurente);
            this.Controls.Add(this.grpSimptome);
            this.Controls.Add(this.grpCetatenii);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.LstPatients);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.grpCitire);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblCetatean);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Spital";
            this.Text = "Spital";
            this.grpCitire.ResumeLayout(false);
            this.grpCitire.PerformLayout();
            this.grpCetatenii.ResumeLayout(false);
            this.grpCetatenii.PerformLayout();
            this.grpSimptome.ResumeLayout(false);
            this.grpSimptome.PerformLayout();
            this.grpGen.ResumeLayout(false);
            this.grpGen.PerformLayout();
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfisare)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCitire;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblCetatean;
        private System.Windows.Forms.Label lblDNastere;
        private System.Windows.Forms.Label lblData_Internare;
        private System.Windows.Forms.Label lblMotiv_Internare;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ListBox LstPatients;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.RadioButton rdbDa;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.GroupBox grpCetatenii;
        private System.Windows.Forms.RadioButton rdbFranceza;
        private System.Windows.Forms.RadioButton rdbEngleza;
        private System.Windows.Forms.RadioButton rdbGermana;
        private System.Windows.Forms.RadioButton rdbRomana;
        private System.Windows.Forms.GroupBox grpSimptome;
        private System.Windows.Forms.Label lblBoliCurente;
        private System.Windows.Forms.CheckBox ckbPneumonie;
        private System.Windows.Forms.CheckBox ckbOreion;
        private System.Windows.Forms.CheckBox ckbKeratita;
        private System.Windows.Forms.CheckBox ckbRubeola;
        private System.Windows.Forms.CheckBox ckbArtroza;
        private System.Windows.Forms.CheckBox ckbOtita;
        private System.Windows.Forms.CheckBox ckbGuta;
        private System.Windows.Forms.CheckBox ckbGlaucom;
        private System.Windows.Forms.CheckBox ckbEpilepsie;
        private System.Windows.Forms.CheckBox ckbCancer;
        private System.Windows.Forms.CheckBox ckbDiabet;
        private System.Windows.Forms.CheckBox ckbStrabism;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.DateTimePicker dtpData_Internare;
        private System.Windows.Forms.DateTimePicker dtpData_Nastere;
        private System.Windows.Forms.TextBox txtMotivInternare;
        private System.Windows.Forms.RadioButton rdbMASCULIN;
        private System.Windows.Forms.RadioButton rdbFEMININ;
        private System.Windows.Forms.GroupBox grpGen;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.DataGridView dtgAfisare;
        private System.Windows.Forms.Button BtnReseteaza;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.OpenFileDialog SpitalFileDialog;
        private System.Windows.Forms.Button BtnIesire;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileTool;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewForm;
    }
}

