using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmModificacionEntrada : Form
    {
        string xd = "";
        public frmModificacionEntrada(string entrada)
        {
            xd = entrada;
            InitializeComponent();
            txtNombre.Text = entrada;
            txtCosto.Text = "" + Logica.Entrada.getPrecioEntrada(entrada);
            cbHabilitado.Checked = Logica.Entrada.GetHabilitadaEntrada(entrada);
        }
        private bool validar()
        {
            if (!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo del nombre del servicio no puede estar vacio.");
                negativo.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo del costo no puede estar vacio.");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (cbHabilitado.Checked)
                    Logica.Entrada.modificarEntrada(txtNombre.Text, Int32.Parse(txtCosto.Text), 1, xd);
                else
                    Logica.Entrada.modificarEntrada(txtNombre.Text, Int32.Parse(txtCosto.Text), 0, xd);
                DialogResult = DialogResult.OK;
            }


        }

        private void frmModificacionEntrada_Load(object sender, EventArgs e)
        {

        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle,e);
        }
    }
}
