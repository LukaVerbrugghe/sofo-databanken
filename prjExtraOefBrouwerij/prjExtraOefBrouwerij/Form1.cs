using prjExtraOefBrouwerij.DA;
using prjExtraOefBrouwerij.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExtraOefBrouwerij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToonData_Click(object sender, EventArgs e)
        {
            lsvBrouwerijen.Items.Clear();
            foreach(Brouwerij b in BrouwerijDA.ophalenBrouwerijen())
            {
                ListViewItem item = new ListViewItem(new string[] {b.id.ToString(), b.Name, b.Email, b.Website });
                item.Tag = b;
                item.BackColor = BrouwerijDA.pickRowColor(b.ImagesURL);
                lsvBrouwerijen.Items.Add(item);
            }
        }

        private void lsvBrouwerijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brouwerij BO = new Brouwerij();
            //ophalen van het gekozen object
            if (lsvBrouwerijen.SelectedItems.Count == 0)
                return;
            ListViewItem item = lsvBrouwerijen.SelectedItems[0];

            BO.id = Convert.ToInt32(item.Text);
            //in principe niet nodig
            //BO.Name = item.SubItems[1].Text;
            //BO.Email = item.SubItems[2].Text;
            //BO.Website = item.SubItems[3].Text;
            rtxtBeschrijvingNL.Text = BrouwerijDA.returnDescriptionNL(BO.id);
            //rtxtBeschrijvingEN.Text = BrouwerijDA.returnDescriptionEN(BO.id);
        }

        private void btnEditDescription_Click(object sender, EventArgs e)
        {
            string descrNL = rtxtBeschrijvingNL.Text;
            string descrEN = rtxtBeschrijvingEN.Text;

            BrouwerijDA.UpdateDescriptions(descrNL, descrEN);
        }
    }
}
