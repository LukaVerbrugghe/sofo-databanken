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
                lsvBrouwerijen.Items.Add(item);
            }
        }
    }
}
