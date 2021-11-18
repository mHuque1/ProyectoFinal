using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmmodificacionServicio : Form
    {
        string xd = "";
        public frmmodificacionServicio(string servicio)
        {
            xd = servicio;
            InitializeComponent();
            txtNombre.Text = servicio;
            txtCapacidad.Text = "" + Servicio.getCapacidadMaxima(servicio);
            txtPermanencia.Text = "" + Servicio.getPermanencia(servicio);
            txtCupos.Text = "" + Servicio.getCupos(servicio);
            txtCosto.Text = "" + Servicio.verificiarPrecio(servicio);
            cbHabilitado.Checked = Servicio.GetHabilitado(servicio);
        }
        private void Modificar()
        {
            if (!Logica.logica.validarCampoVacio(txtNombre.Text))
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
            else
            {
                if (cbHabilitado.Checked)
                {
                    Servicio.ModificarServicio(txtNombre.Text, Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text), 1, xd);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Servicio.ModificarServicio(txtNombre.Text, Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text), 0, xd);
                    DialogResult = DialogResult.OK;
                }
            }

        }
        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            Modificar();
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



        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void frmmodificacionServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
