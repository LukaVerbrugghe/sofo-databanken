using prjApollo.DA;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjApollo.Model;
using prjApollo.DA;

namespace prjApollo
{
    public partial class frmApollo : Form
    {
        public frmApollo()
        {
            InitializeComponent();
            //levernaciers in de lsv laden adhv levernaciersda
            //foreach (Leveranciers leverancier in LeveranciersDA.getLeveranciers())
            //{
            //    ListViewItem item = new ListViewItem(new String[] { Convert.ToString(leverancier.leveranciernummer), leverancier.firmanaam, leverancier.adres, leverancier.postnr, leverancier.gemeente });
            //    item.Tag = leverancier;
            //    lsvLeveranciers.Items.Add(item);
            //}
            LeveranciersDA DA = new LeveranciersDA();
            List<Model.Leveranciers> leveranciersList = LeveranciersDA.getLeveranciers();
            foreach (Leveranciers leverancier in leveranciersList)
            {
                ListViewItem item = new ListViewItem(new String[] { Convert.ToString(leverancier.leveranciernummer), leverancier.firmanaam, leverancier.adres, leverancier.postnr, leverancier.gemeente });
                item.Tag = leverancier;
                lsvLeveranciers.Items.Add(item);
            }

        }
    }
}
