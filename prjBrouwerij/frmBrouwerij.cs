using prjBrouwerij.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBrouwerij
{
    public partial class frmBrouwerij : Form
    {
        public frmBrouwerij()
        {
            InitializeComponent();
            VulLijstBrouwerijen();
        }

        public void VulLijstBrouwerijen()
        {
            //voor ieder tekstitem in de list voegen we toe aan de txt
            foreach(string s in BierDA.BrouwerijenOphalen())
            {
                lsbBrouwerijen.Items.Add(s);
            }
        }

        private void lsbBrouwerijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBrouwerij.Text = lsbBrouwerijen.SelectedItem.ToString();
        }
    }
}
