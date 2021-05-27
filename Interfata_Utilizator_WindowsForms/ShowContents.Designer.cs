
namespace Interfata_Utilizator_WindowsForms
{
    partial class ShowContents
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
            this.txtAfisare = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAfisare
            // 
            this.txtAfisare.Location = new System.Drawing.Point(104, 71);
            this.txtAfisare.Multiline = true;
            this.txtAfisare.Name = "txtAfisare";
            this.txtAfisare.Size = new System.Drawing.Size(586, 195);
            this.txtAfisare.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.AutoSize = true;
            this.BtnLoad.Location = new System.Drawing.Point(104, 307);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(89, 38);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(601, 307);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(89, 38);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.Location = new System.Drawing.Point(310, 307);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(89, 38);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ShowContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.txtAfisare);
            this.Name = "ShowContents";
            this.Text = "ShowContents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAfisare;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnReset;
    }
}