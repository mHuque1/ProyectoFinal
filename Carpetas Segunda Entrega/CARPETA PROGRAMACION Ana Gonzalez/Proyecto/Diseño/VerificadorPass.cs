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
    
    public partial class VerificadorPass : Form
    {
        int contador = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public VerificadorPass()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(Logica.Usuarios.getUserPass(Logica.logica.UsuarioActual,txtPass.Text))
            {
                contador = 0;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                contador +=1;
               this.DialogResult = DialogResult.None;
                MessageBox.Show("Contraseña incorrecta, intento " +contador + " de 3");
                if(contador == 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void VerificadorPass_Load(object sender, EventArgs e)
        {

        }

        private void bfbtnVerificar_Click(object sender, EventArgs e)
        {
            if (Logica.Usuarios.getUserPass(Logica.logica.UsuarioActual, txtPass.Text))
            {
                contador = 0;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                contador += 1;
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Contraseña incorrecta, intento " + contador + " de 3");
                if (contador == 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
    }
}
