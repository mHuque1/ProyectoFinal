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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida(string TipoUsuario)
        {
            InitializeComponent();
            barraProgreso.Value = 0;
            lblTipoUsuario.Text =TipoUsuario;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            barraProgreso.Value += 4;
            this.Opacity += 0.04;
            
           
            if (barraProgreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }        
        }
        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }

        
    }
}
