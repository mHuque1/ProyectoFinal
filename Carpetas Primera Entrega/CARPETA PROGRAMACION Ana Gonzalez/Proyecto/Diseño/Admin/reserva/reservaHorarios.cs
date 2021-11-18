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
    public partial class reservaHorarios : Form
    { 
        // Declaraciones.
        //#############################################################################################
        string Servicios = "";
        static string fecha;
        int capacidad;
        int cupos;
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
        private static string horatext;
        public static string horaText
        {
            get { return horatext; }
            set { horatext = value; }
        }
        //#############################################################################################  
       
        // Metodos.
        //#############################################################################################
        public reservaHorarios(CheckBox a, string Cedula, string tipoUsuario, String Fecha)
        {
            cedula = Cedula;
            fecha = Fecha;
            Servicios = a.Text;
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
            switch (a.Text)
            {
                case "Masaje Tradicional":
                    Servicios = a.Text;
                    capacidad = 50;
                    cupos = 2;
                    break;
                case "Masaje Oriental":
                    Servicios = a.Text;
                    capacidad = 50;
                    cupos = 2;
                    break;
                case "Yoga / Pilates":
                    Servicios = a.Text;
                    capacidad = 10000;
                    cupos = 10;
                    break;
                case "Meditación":
                    Servicios = a.Text;
                    capacidad = 10000;
                    cupos = 10;
                    break;
                case "Bicicletas":
                    Servicios = a.Text;
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Cabalgatas":
                    Servicios = a.Text;
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Botes":
                    Servicios = a.Text;
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Piscina abierta":
                    Servicios = a.Text;
                    capacidad = 200;
                    cupos = 50;
                    break;
                case "Piscina cerrada":
                    Servicios = a.Text;
                    capacidad = 200;
                    cupos = 50;
                    break;
                case "Piscina barro":
                    Servicios = a.Text;
                    capacidad = 80;
                    cupos = 40;
                    break;
                case "Hidromasaje":
                    Servicios = a.Text;
                    capacidad = 90;
                    cupos = 4;
                    break;
                case "Sauna":
                    Servicios = a.Text;
                    capacidad = 75;
                    cupos = 6;
                    break;

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
            else if (Logica.verificarReservado(cedula, fecha, cboxHoras.GetItemText(cboxHoras.SelectedItem), Servicios, "----------"))
            {
                MessageBox.Show("Este cliente ya tiene un servicio contratado para esa hora y fecha");
                this.DialogResult = DialogResult.None;
            }
            else
            {     
                horatext = cboxHoras.GetItemText(cboxHoras.SelectedItem);
                Logica.ReservarCupo(Servicios, fecha, horatext);
                Logica.agregarCapacidad2(Servicios, fecha);
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
             Logica.agregarFechas(Servicios, fecha, cupos);
            Logica.agregarCapacidad(Servicios, fecha, capacidad);
            cboxHoras.Items.Clear();
            cboxHoras.Enabled = true;
            Logica.llenarFechas(cboxHoras, Servicios, fecha);
        }
        //#############################################################################################
    }
}
