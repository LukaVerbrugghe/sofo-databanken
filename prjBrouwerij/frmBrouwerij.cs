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

using prjBrouwerij.Model;

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
            lsvBier.Items.Clear();
            txtBrouwerij.Text = lsbBrouwerijen.SelectedItem.ToString();
            foreach (Bier b in BierDA.OphalenBieren(lsbBrouwerijen.SelectedItem.ToString()))
            {
                //voor elk biertje dat we in de lijst vinden voegen het het toe aan de listview, hiervoor hebben we een listviewitem nodig
                ListViewItem item = new ListViewItem(new String[] {b.Biernaam, b.Alcohol.ToString(), b.Kleur});
                item.Tag = b;
                lsvBier.Items.Add(item);
            }
        }

        private void lsvBier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bier BO = new Bier();
            //om er voor te zorgen dat je meerdere keren kunt klikken op verschillende bieren
            if (lsvBier.SelectedItems.Count == 0)
                return;
            //listviewitem aanmaken om de gegevens apaprt te kunnen ophalen vanuit je listview
            ListViewItem item = lsvBier.SelectedItems[0];
            //ieder item uit je item in je object steken
            BO.Biernaam = item.Text;
            BO.Alcohol = Convert.ToDecimal(item.SubItems[1].Text);
            BO.Kleur = item.SubItems[2].Text;
            //alles dat in je object zit in je tekstvak steken
            txtBiernaam.Text = BO.Biernaam.ToString();
            txtAlcohol.Text = BO.Alcohol.ToString();
            txtKleur.Text = BO.Kleur.ToString();
        }
    }
}
