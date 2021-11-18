using Logica;
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
    public partial class frmToken : Form
    {

        static private int cedula=0;
        
        public frmToken(int ci)
        {
            cedula = ci;
            
            InitializeComponent();
        }
        private static async void cargar()
        {
            frmCargar asd = new frmCargar();
            asd.Show();
            await Logica.logica.Email(Logica.Usuarios.getEmail(Logica.logica.UsuarioActual));
            asd.Close();
        }
        private void verificar() {

            if (bftxtCodigo.Text == Logica.logica.token) {
                this.DialogResult = DialogResult.OK;
            }
            
            else
            {
                cargar();
                MessageBox.Show("El codigo ingresado no es correcto, se te ha enviado un nuevo codigo a tu correo.");
            }
        }
  

        private void frmToken_Load(object sender, EventArgs e)
        {
        }

        private void bfbtnVerificar_Click(object sender, EventArgs e)
        {
            verificar();
        }

        private void bftxtCodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
