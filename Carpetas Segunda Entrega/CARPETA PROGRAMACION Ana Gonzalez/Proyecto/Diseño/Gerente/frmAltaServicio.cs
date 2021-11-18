using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmAltaServicio : Form
    {
        public frmAltaServicio()
        {
            InitializeComponent();
        }
        private void agregar() {
            if(!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if (!Logica.logica.validarCampoVacio(txtCapacidad.Text))
            {
                MessageBox.Show("Ingrese una capacidad diaria");
            }
            else if (!Logica.logica.validarCampoVacio(txtPermanencia.Text))
            {
                MessageBox.Show("Ingrese una permanecia");
            }
            else if (!Logica.logica.validarCampoVacio(txtCupos.Text))
            {
                MessageBox.Show("Ingrese una cantidad de cupos por hora");
            }
            else if (!Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                MessageBox.Show("Ingrese un costo");
            }
            else {
                Logica.Servicio.altaServicio(txtNombre.Text, Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text));
                DialogResult = DialogResult.OK;
            }
        }
        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }
        private void txtPermanencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }
        private void txtCupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }

        private void frmAltaServicio_Load(object sender, EventArgs e)
        {

        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }
    }
}
