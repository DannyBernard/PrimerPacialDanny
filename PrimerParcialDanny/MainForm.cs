using PrimerParcialDanny.UI;
using PrimerParcialDanny.UI.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialDanny
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
           
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVendedores vendedores = new CVendedores();
            vendedores.Show();
        }
    }
}
