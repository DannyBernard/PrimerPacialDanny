using PrimerParcialDanny.BLL;
using PrimerParcialDanny.DAL;
using PrimerParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialDanny.UI
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Vendedores LlenarClase()
        {
            Vendedores vendedores = new Vendedores();

            vendedores.IDVendedor = Convert.ToInt32(IDnumericUpDown.Value);
            vendedores.Nombre = NombretextBox.Text;
            vendedores.Sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            vendedores.Retencion = Convert.ToDecimal(RetencionnumericUpDown.Value);

            return vendedores;
        }
        private bool Validar()
        {
            bool paso = true;
            if (RetencionnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(RetencionnumericUpDown, "Campo no puede estar en 0");
                paso = false;
            }
            if (SueldonumericUpDown.Value == 0)
            {
                errorProvider1.SetError(SueldonumericUpDown, "Campo no puede estar en 0");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Campo Vacio");
                paso = false;
            }
            return paso;
        }
        private bool EstaEnLaBaseDeDatos()
        {
            Vendedores vendedores = VendedoresBLL.Buscar((int)IDnumericUpDown.Value);
            return (vendedores != null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool paso = false;
            Vendedores vendedores;
            Contexto contexto = new Contexto();

            if (!Validar())
                return;
            vendedores = LlenarClase();
            try
            {
                if (IDnumericUpDown.Value == 0)
                    paso = VendedoresBLL.Guardar(vendedores);
                else
                {
                    if (!EstaEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    paso = VendedoresBLL.Modificar(vendedores);
                }
                if (paso)
                {
                    MessageBox.Show("Se Guardo Exitosamente", "Imformacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se Gurdo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            int id;

            int.TryParse(IDnumericUpDown.Text, out id);
            if (VendedoresBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            errorProvider1.SetError(IDnumericUpDown, "no se puede eliminar");


        }
        private void LlenarCampo(Vendedores vendedores)
        {

            IDnumericUpDown.Value = vendedores.IDVendedor;
            NombretextBox.Text = vendedores.Nombre;
            SueldonumericUpDown.Value = vendedores.Sueldo;
            RetencionnumericUpDown.Value = vendedores.Retencion;
            TotaltextBox.Text = Convert.ToString(vendedores.Total);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            Vendedores vendedores = new Vendedores();
            int.TryParse(IDnumericUpDown.Text, out id);

            vendedores = VendedoresBLL.Buscar(id);

            if (vendedores != null)
            {
                LlenarCampo(vendedores);
                MessageBox.Show("Encotrado");


            }
            else
            {
                MessageBox.Show("No Exite");
            }






        }

     

        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            porciento /= 100;
            decimal retencion = porciento * sueldo;

            TotaltextBox.Text = Convert.ToString(retencion);
        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            porciento /= 100;
            decimal retencion = porciento * sueldo;

            TotaltextBox.Text = Convert.ToString(retencion);

        }
    }

}


