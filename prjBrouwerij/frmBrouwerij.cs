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

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Bier bier = new Bier();

            bier.Biernaam = txtBiernaam.Text; //of hetgene dat in de listview geselecteerd is

            BierDA.Verwijder(bier);

            //listbox vernieuwen (omdat het er anders nog in staat)
            //brouwerijen zonder items komen niet in de lijst met brouwerijen (want dat zou niet zo handig zijn)
            herlaad();
        }

        private void btnBierAanpassen_Click(object sender, EventArgs e)
        {
            Bier nieuwBier = new Bier();
            nieuwBier.Biernaam = txtBiernaam.Text;
            nieuwBier.Brouwerij = txtBrouwerij.Text;
            nieuwBier.Kleur = txtKleur.Text;
            nieuwBier.Alcohol = Convert.ToDecimal(txtAlcohol.Text);

            BierDA.Aanpassen(nieuwBier, lsvBier.SelectedItems[0].SubItems[0].Text);
            herlaad();
        }

        private void btnBierToevoegen_Click(object sender, EventArgs e)
        {
            Bier nieuweBier = new Bier();

            nieuweBier.Biernaam = txtBiernaam.Text;
            nieuweBier.Alcohol = Convert.ToDecimal(txtAlcohol.Text);
            nieuweBier.Kleur = txtKleur.Text;
            nieuweBier.Brouwerij = txtBrouwerij.Text;

            BierDA.Toevoegen(nieuweBier);

            herlaad();
        }
        private void herlaad()
        {
            lsbBrouwerijen.Items.Clear();
            VulLijstBrouwerijen();

            lsvBier.Items.Clear();

            txtAlcohol.Clear();
            txtKleur.Clear();
            txtAlcohol.Clear();
            txtBiernaam.Clear();
            txtBrouwerij.Clear();
        }
    }
}
