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
        }
    }
}
