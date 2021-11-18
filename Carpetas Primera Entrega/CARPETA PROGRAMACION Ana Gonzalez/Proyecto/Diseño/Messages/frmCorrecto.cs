using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Messages
{
    public partial class frmCorrecto : Form
    {
        public frmCorrecto(string mensaje, int tipo)
        {
            InitializeComponent();
            
            lbltexto.Text = mensaje;
            

            switch (tipo)
            {
                case 1:
                    this.BackColor = Color.SeaGreen;
                    this.pictureBox1.Image = global::Spa.Properties.Resources.correctoLogo;
                    btnAceptar.Location = new System.Drawing.Point(129, 103);
                   
                    break;
                case 2:
                    this.BackColor = Color.Crimson;
                    btnAceptar.Location = new System.Drawing.Point(129, 103);
                    this.pictureBox1.Image = global::Spa.Properties.Resources.errorLogo;
                    playExclamation();
                    break;
                case 3:
                    this.BackColor = Color.Gray;
                    btnAceptar.Location = new System.Drawing.Point(44, 103);
                    btnCancelar.Visible = true;
                    this.lbltexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.pictureBox1.Image = global::Spa.Properties.Resources.warningLogo;
                    break;
                case 4:
                    this.BackColor = Color.Orange;
                    btnAceptar.Location = new System.Drawing.Point(129, 103);
                    btnCancelar.Visible = false;
                    this.lbltexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.pictureBox1.Image = global::Spa.Properties.Resources.warningLogo;
                    break;

            }
            
        }


        public void playExclamation()
        {
            SystemSounds.Exclamation.Play();
        }
 private void frmCorrecto_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
