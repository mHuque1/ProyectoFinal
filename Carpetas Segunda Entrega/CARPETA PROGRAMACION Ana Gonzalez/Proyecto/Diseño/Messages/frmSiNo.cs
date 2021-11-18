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
    public partial class frmSiNo : Form
    {
        public frmSiNo(string x)
        {
            InitializeComponent();
            lblMensaje.Text = x;
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;

            if (Opacity == 1)
            {
                icono.Enabled = true;
                icono.Visible = true;
                fadeIn.Stop();

            }
        }

        private void frmSiNo_Load(object sender, EventArgs e)
        {

        }
    }
}
