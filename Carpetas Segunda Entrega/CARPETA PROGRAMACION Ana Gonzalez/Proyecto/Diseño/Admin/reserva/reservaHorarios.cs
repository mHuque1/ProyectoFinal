using System;
using System.Collections;
using System.Windows.Forms;

namespace Spa
{
    public partial class reservaHorarios : Form
    { 
        // Declaraciones.
        //#############################################################################################
        string Servicios = "";
        static string fecha;
        static int cedula;
        static int Nro =0;
        ArrayList horas = new ArrayList();
        ArrayList horas2 = new ArrayList();
        static string Ida = "";
        static string Vuelta = "";
        //#############################################################################################
        // Getters and setters.
        //#############################################################################################
        private static string fechatext;
        public static string fechaText
        {
            get { return fechatext; }
            set { fechatext = value; }
        }
        private static string horatext;
        public static string horaText
        {
            get { return horatext; }
            set { horatext = value; }
        }
        //#############################################################################################  
       
        // Metodos.
        //#############################################################################################
        public reservaHorarios(string servicio, int Cedula, string tipoUsuario, string Fecha,ArrayList horasNoDisponibles,ArrayList horasNoDisponibles2,string ida, string vuelta,int nro)
        {
            Nro = nro;
            Ida = ida;
            Vuelta = vuelta;
            horas = horasNoDisponibles;
            horas2 = horasNoDisponibles2;
            cedula = Cedula;
            fecha = Fecha;
            Servicios = servicio;
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
            if (cboxHoras.Text == "")
            {
                MessageBox.Show("Verifique la disponibilidad de las fechas antes de guardarlas");
                this.DialogResult = DialogResult.None;
            }
            else
            {     
                horatext = cboxHoras.GetItemText(cboxHoras.SelectedItem);        
            }

            fechaText = fecha;
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cboxHoras.Text = "";
            cboxHoras.Enabled = false;
        }
        private void reservaHorarios_Load(object sender, EventArgs e)
        {

            cboxHoras.Items.Clear();
            cboxHoras.Enabled = true;
            Logica.Fecha.CargarHoras(cboxHoras, Servicios, fecha,horas,horas2, Ida,Vuelta,cedula,Nro);
        }
        //#############################################################################################
    }
}
