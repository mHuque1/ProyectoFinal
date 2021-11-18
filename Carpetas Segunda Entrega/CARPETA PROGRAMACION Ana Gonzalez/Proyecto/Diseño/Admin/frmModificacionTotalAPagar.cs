using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmModificacionTotalAPagar : Form
    {
        //Declaraciones
        //#############################################################################################

        private int Nro;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //#############################################################################################

        //botones etc.
        //#############################################################################################
        public frmModificacionTotalAPagar(int nro, string tipoUsuario)
        {
            InitializeComponent();
            if(tipoUsuario=="Admin")
            {
                btnModificarPrecio.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificarPrecio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificarPrecio.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnModificarPrecio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificarPrecio.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificarPrecio.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnModificarPrecio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificarPrecio.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCosto.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCosto.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            Nro = nro;
           
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            if(Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                Reserva.SetAPagar(Nro,Int32.Parse(txtCosto.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                frmNegativo ff = new frmNegativo("Debe ingresar un valor");
            }
           
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }

        private void frmModificacionPrecioServicio_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //#############################################################################################
    }
}
