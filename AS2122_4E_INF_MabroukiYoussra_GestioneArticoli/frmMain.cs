using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_MabroukiYoussra_GestioneArticoli
{
    public partial class frmMain : Form
    {
        Dictionary<string, Articoli> articoli;
        public frmMain()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articoli>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articoli(txtCodice.Text, cmbUnita.Text, txtDescrizione.Text, Convert.ToDouble(txtPrezzo.Text));
            }
            else
            {
                articoli.Add(txtCodice.Text, new Articoli(txtCodice.Text, cmbUnita.Text, txtDescrizione.Text, Convert.ToDouble(txtPrezzo.Text)));
            }
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            switch (cmbVisualizza.Text)
            {
                case "Visualizza Articoli":

                    lstMostra.Items.Clear();
                    foreach (KeyValuePair<string, Articoli> articolo in articoli)
                    {
                        lstMostra.Items.Add(articolo.Value.ToString());
                    }

                    break;
            }
        }

        private void lstMostra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
