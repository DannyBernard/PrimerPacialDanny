using PrimerParcialDanny.BLL;
using PrimerParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialDanny.UI.Consulta
{
    public partial class CVendedores : Form
    {
        public CVendedores()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            var listado = new List<Vendedores>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {


                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = VendedoresBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = VendedoresBLL.GetList(p => p.IDVendedor == id);
                        break;
                    case 2:
                        listado = VendedoresBLL.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                        break;
                    case 3:
                        decimal sueldo = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = VendedoresBLL.GetList(p => p.Sueldo == sueldo);
                        break;
                    case 4:
                        decimal retencion = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = VendedoresBLL.GetList(p => p.Retencion == retencion);
                        break;
                    case 5:
                        decimal total = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = VendedoresBLL.GetList(p => p.Total == total);
                        break;
                }
                listado = listado.Where(c => c.Fecha >= DesdedateTimePicker.Value.Date && c.Fecha <= HastadateTimePicker.Value.Date).ToList();
            }
          



        else
            {
                listado = VendedoresBLL.GetList(p => true);
            }
             dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }
    }
}
