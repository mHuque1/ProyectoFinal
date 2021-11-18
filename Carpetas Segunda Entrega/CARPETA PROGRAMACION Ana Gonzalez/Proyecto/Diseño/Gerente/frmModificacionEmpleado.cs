using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmModificacionEmpleado : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        Panel xd;
        string b ="";
        int cedula;
        string turista = "NO";
        string jubilado = "NO";

        //#############################################################################################

        //botones etc.
        //#############################################################################################
        public frmModificacionEmpleado(Panel a, string TipoUsuario, int ci)
        {
            cedula = ci;
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            
            txtCedula.Text =""+cedula;
            //if (Logica.Cliente.cargarDatosClienteExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion, checkJubilado, checkTurista))
            //{
            //   txtAPagar.Text=""+ Logica.Cliente.getTotalAPagar(cedula);
            //}
        }
        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            Logica.Usuarios.cargarDatosUsuarioExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion, txtSueldo);
            Logica.Usuarios.cargarCargos(cbRol);
            cbRol.Text = Logica.Usuarios.getUserType(cedula);
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            
          
            
        }
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Logica.Usuarios.modificarEmpleado(cedula, Int32.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text,
              txtDireccion.Text, cbRol.Text, float.Parse(txtSueldo.Text)))
            {
                frmPositivo dou = new frmPositivo("Empleado modificado correctamente");
                dou.ShowDialog();

                cedula = Int32.Parse(txtCedula.Text);
                jubilado = "NO";
                turista = "NO";
            }
        }

        //#############################################################################################
    }
}
