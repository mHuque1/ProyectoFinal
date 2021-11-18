using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class reservaTranslado : Form
    {
        // Declaraciones.
        //#############################################################################################
        static string fecha;
        static string cedula;
        //#############################################################################################
        // Getters and setters.
        //#############################################################################################
        private static string fechatext;
        public static string fechaText
        {
            get { return fechatext; }
            set { fechatext = value; }
        }
        private static string horaidatext;
        public static string horaIdaText
        {
            get { return horaidatext; }
            set { horaidatext = value; }
        }
        private static string horavueltatext;
        public static string horaVueltaText
        {
            get { return horavueltatext; }
            set { horavueltatext = value; }
        }
        // Metodos.
        //#############################################################################################
        public reservaTranslado(string Cedula, string tipoUsuario, String fecha1)
        {
            cedula = Cedula;
            fecha = fecha1;
            InitializeComponent();
            if (tipoUsuario == "Gerente")
            {
                
                GuardarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                GuardarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }

        }        
        //#############################################################################################
        
        // Botones etc.
        //#############################################################################################
        private void GuardarHoras_Click(object sender, EventArgs e)
        {
            DateTime horaIda = DateTime.MinValue;
            DateTime horaVuelta = DateTime.MaxValue;

            horaIdaText = "";
            horaVueltaText = "";
            if (cboxHoras.Text == "" && cbHorasVuelta.Text == "")
            {
                MessageBox.Show("Verifique la disponibilidad de las fechas antes de guardarlas");
                this.DialogResult = DialogResult.None;
            }
            else if (cboxHoras.Text == cbHorasVuelta.Text)
            {
                MessageBox.Show("La hora de de ida y vuelta no puede ser las mismas");
                this.DialogResult = DialogResult.None;
            }
            else if (Logica.verificarReservado(cedula, fecha, cboxHoras.GetItemText(cboxHoras.SelectedItem), "Traslados", cbHorasVuelta.GetItemText(cbHorasVuelta.SelectedItem)))
            {
                MessageBox.Show("Este cliente ya tiene hora para ese traslado en esa fecha");
                this.DialogResult = DialogResult.None;
            }
            else if (horaVuelta < horaIda)
            {
                MessageBox.Show("La hora de regreso es inferior a la hora de ida");
                this.DialogResult = DialogResult.None;
            }
            else if (cboxHoras.Visible == true && cboxHoras.Text == "")
            {
                MessageBox.Show("Agregue una hora de ida");
                this.DialogResult = DialogResult.None;
            }
            else if (cbHorasVuelta.Visible == true && cbHorasVuelta.Text == "")
            {
                MessageBox.Show("Agregue una hora de regreso");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                fechaText = fecha;
                if (cboxHoras.Visible == true)
                {
                    horaIda = Convert.ToDateTime(cboxHoras.Text);
                    horaidatext = cboxHoras.GetItemText(cboxHoras.SelectedItem);
                    Logica.ReservarCupo("Traslados", fechaText, horaidatext);
                }
                if (cbHorasVuelta.Visible == true)
                {
                    horaVuelta = Convert.ToDateTime(cbHorasVuelta.Text);
                    horavueltatext = cbHorasVuelta.GetItemText(cbHorasVuelta.SelectedItem);
                    Logica.ReservarCupo("Traslados", fechaText, horavueltatext);
                }
               
                
                
            }

        }             
     
        private void checkIda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIda.Checked) {
                
                cboxHoras.Visible = true;
                lblSalida.Visible = true;
                this.lblVuelta.Location = new System.Drawing.Point(7, 97);
                this.cbHorasVuelta.Location = new System.Drawing.Point(173, 89);

                
            }
           
            if (!checkIda.Checked)
            {
                             
                checkVuelta.Checked = true;
                cboxHoras.Visible = false;
                lblSalida.Visible = false;
                this.lblVuelta.Location = new System.Drawing.Point(7, 61);
                this.cbHorasVuelta.Location = new System.Drawing.Point(173, 53);
                
            }
            
        }
        private void checkVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVuelta.Checked)
            {
                cbHorasVuelta.Visible = true;
                lblVuelta.Visible = true;
                


            }
            
            if (!checkVuelta.Checked)
            {
                checkIda.Checked = true;
                cbHorasVuelta.Visible = false;
                lblVuelta.Visible = false;
                
                
            }
        }
        private void reservaTranslado_Load(object sender, EventArgs e)
        {
            Logica.agregarFechas("Traslados", fecha, 12);
            Logica.agregarCapacidad("Traslados", fecha, 1000);
            cboxHoras.Items.Clear();
            cbHorasVuelta.Items.Clear();
            Logica.llenarFechas(cboxHoras, "Traslados", fecha);
            Logica.llenarFechas(cbHorasVuelta, "Traslados", fecha);
        }
        //#############################################################################################
    }
}
