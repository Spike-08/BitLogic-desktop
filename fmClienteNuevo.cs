using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace BitLogic_App_Escritorio
{
    public partial class fmClienteNuevo : Form
    {
     
        public fmClienteNuevo()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            String nombre = tbNombre.Text.Trim();
            String apellido = tbApellido.Text.Trim();
            String tel = tbTelefono.Text.Trim();
            String agarrarCorreo = tbCorreo.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(agarrarCorreo))
            {
                MessageBox.Show("Rellene los campos");
                return;
            }
            if  (!agarrarCorreo.Contains("@") || !agarrarCorreo.Contains("."))
            {
                MessageBox.Show("Introduzca un correo valido");
                return;
            }

            if (!tel.All(char.IsDigit))
            {
                MessageBox.Show("Introduce un teléfono válido.");
                return;
            }

            ClienteRepositorio cp = new ClienteRepositorio();



            if (!cp.Existe(agarrarCorreo))
            {
                int id = cp.Agregar(agarrarCorreo,nombre, apellido,tel);
                MessageBox.Show("Cliente Registrado. Su id es: " + id + cp.BuscarPorId(1));
                FmImprimir fmi = new FmImprimir();
                this.Hide();
                fmi.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cliente ya registrado. Ingrese por cliente existente");
                fmClienteExistente fce = new fmClienteExistente();
                this.Hide();
                fce.ShowDialog();
                this.Close();
            }

            

        }
    }
}
