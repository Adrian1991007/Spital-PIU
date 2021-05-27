using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata_Utilizator_WindowsForms
{
    public partial class ShowContents : Form
    {
        public string infoform { get; set; }
        public ShowContents()
        {
            InitializeComponent();
        }

        public ShowContents(string info)
        {
            InitializeComponent();
            infoform = info;
        }
        

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Spital fr1 = new Spital();
            fr1.Show();
            txtAfisare.Text = string.Empty;
            this.Close();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            txtAfisare.Text = string.Empty;
            txtAfisare.Text = infoform;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAfisare.Text = string.Empty;
        }
    }
}
