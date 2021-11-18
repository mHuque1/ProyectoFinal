using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmModificacionCliente : Form
    { 

        //Declaraciones
        //#############################################################################################
        public static string txtID;
        Panel xd;
        string b ="";
        int x;
        int cedula;
        string turista = "NO";
        string jubilado = "NO";
        //#############################################################################################

        //botones etc.
        //#############################################################################################
        public frmModificacionCliente(Panel a, string TipoUsuario, int ci)
        {
            cedula = ci;
            InitializeComponent();
            Entrada.MostrarEntradas(cbEntrada);
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                ///this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
              
            }
            else
            {
                //BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtDireccion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtTelefono.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtCedula.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCedula.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCedula.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtApellido.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtTotal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTotal.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTotal.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            txtCedula.Text =""+cedula;
            if (Logica.Cliente.cargarDatosClienteExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion,cbEntrada,dtpNacimiento))
            {
               txtTotal.Text=""+ Logica.Cliente.getTotalAPagar(cedula);
            }
        }        
      
        private bool validar()
        {
            try { int nro = Int32.Parse(txtCedula.Text); }
            catch (Exception f)
            {
                frmNegativo ff = new frmNegativo("documento no valido");
                ff.ShowDialog();
                Console.WriteLine(f.Message);
                return false;
            }

            if (!Logica.logica.validarCampoVacio(txtCedula.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del documento no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            
            else if (!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Nombre no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtNombre.Text))
            {
                frmNegativo ff = new frmNegativo("El nombre no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtApellido.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Apellido no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtApellido.Text))
            {
                frmNegativo ff = new frmNegativo("El Apellido no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Correo no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El Correo no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El Correo Tiene un formato incorrecto");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Telefono no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtTelefono.Text))
            {
                frmNegativo ff = new frmNegativo("El Telefono no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo ff = new frmNegativo("El campo de la dirección no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtDireccion.Text))
            {
                frmNegativo ff = new frmNegativo("la dirección no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtTotal.Text))
            {
                frmNegativo ff = new frmNegativo("El campo de total a pagar no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else
            {
                try { int nro = Int32.Parse(txtTotal.Text);
                    return true;
                }
                catch (Exception f)
                {
                    frmNegativo ff = new frmNegativo("total a pagar no valido");
                    ff.ShowDialog();
                    Console.WriteLine(f.Message);
                    return false;
                }
            }




        }


        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                if (Logica.Cliente.modificarCliente(cedula, Int32.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text,
                txtTelefono.Text, txtDireccion.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cbEntrada.Text, Int32.Parse(txtTotal.Text)))
                {
                    frmPositivo dou = new frmPositivo("Cliente modificado correctamente");
                    dou.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloLetras(e);

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }
        //#############################################################################################
    }
}
