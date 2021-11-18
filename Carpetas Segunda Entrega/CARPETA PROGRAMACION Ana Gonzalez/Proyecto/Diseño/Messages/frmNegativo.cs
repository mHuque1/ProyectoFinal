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
    public partial class frmNegativo : Form
    {
        public frmNegativo(string xd)
        {
            InitializeComponent();
            lblMensaje.Text = xd;
        }
        
        private void frmPositivo_Load(object sender, EventArgs e)
        {
            icono.Enabled = true;
            icono.Visible = true;
        }

        private void iconDelay_Tick(object sender, EventArgs e)
        {
            icono.Enabled = false;
            iconDelay.Stop();
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
           
            if (Opacity == 1)
            {
                
                fadeIn.Stop();
                iconDelay.Start();   
            }
        }
    }
}
