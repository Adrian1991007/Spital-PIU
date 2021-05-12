
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblCetatean = new System.Windows.Forms.Label();
            this.lblDNastere = new System.Windows.Forms.Label();
            this.lblMInternare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMInternare);
            this.groupBox1.Controls.Add(this.lblDNastere);
            this.groupBox1.Controls.Add(this.lblCetatean);
            this.groupBox1.Controls.Add(this.lblVarsta);
            this.groupBox1.Controls.Add(this.lblGen);
            this.groupBox1.Controls.Add(this.lblPrenume);
            this.groupBox1.Controls.Add(this.lblNume);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupCitire";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(22, 33);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(41, 15);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(22, 62);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(58, 15);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            this.lblPrenume.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(22, 89);
            this.lblGen.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(43, 15);
            this.lblGen.TabIndex = 3;
            this.lblGen.Text = "Genul:";
            this.lblGen.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarsta.Location = new System.Drawing.Point(22, 117);
            this.lblVarsta.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(44, 15);
            this.lblVarsta.TabIndex = 4;
            this.lblVarsta.Text = "Varsta:";
            // 
            // lblCetatean
            // 
            this.lblCetatean.AutoSize = true;
            this.lblCetatean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCetatean.Location = new System.Drawing.Point(22, 144);
            this.lblCetatean.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblCetatean.Name = "lblCetatean";
            this.lblCetatean.Size = new System.Drawing.Size(62, 15);
            this.lblCetatean.TabIndex = 5;
            this.lblCetatean.Text = "Cetatenie:";
            // 
            // lblDNastere
            // 
            this.lblDNastere.AutoSize = true;
            this.lblDNastere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNastere.Location = new System.Drawing.Point(20, 171);
            this.lblDNastere.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblDNastere.Name = "lblDNastere";
            this.lblDNastere.Size = new System.Drawing.Size(81, 15);
            this.lblDNastere.TabIndex = 6;
            this.lblDNastere.Text = "Data Nasterii:";
            // 
            // lblMInternare
            // 
            this.lblMInternare.AutoSize = true;
            this.lblMInternare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMInternare.Location = new System.Drawing.Point(22, 201);
            this.lblMInternare.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lblMInternare.Name = "lblMInternare";
            this.lblMInternare.Size = new System.Drawing.Size(91, 15);
            this.lblMInternare.TabIndex = 7;
            this.lblMInternare.Text = "Motiv Internare:";
            this.lblMInternare.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Motiv Internare:";
            // 
            // Spital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.groupBox1);
            this.Name = "Spital";
            this.Text = "Spital";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblCetatean;
        private System.Windows.Forms.Label lblDNastere;
        private System.Windows.Forms.Label lblMInternare;
        private System.Windows.Forms.Label label1;
    }
}

