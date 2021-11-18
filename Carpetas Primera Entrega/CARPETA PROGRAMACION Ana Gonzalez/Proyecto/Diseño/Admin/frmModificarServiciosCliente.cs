using Diseño.Messages;
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
    public partial class frmModificarServiciosCliente : Form
    {
        //Declaraciones
        //#############################################################################################
        static string Servicios = "";
        static int capacidad = 0;
        static int cupos = 0;
        static bool bandera;
        int x;
        string hora;
        string b;
        string horaRetorno;
        string CI;
        string Servicio;
        string Fecha;
        string Hora;
        string HoraRetorno;
        int Precio;
        //#############################################################################################
        public frmModificarServiciosCliente(string tipoUsuario)
        {
            b = tipoUsuario;
            InitializeComponent();
            if (tipoUsuario == "Gerente")
            {
                btnCambiarFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                btnCambiarFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnMostrarDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBorrarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }

        }
        //Metodos
        //#############################################################################################
        public static void hola()
        {
            switch (Servicios)
            {
                case "Masaje Tradicional":
                    capacidad = 50;
                    cupos = 2;
                    break;
                case "Masaje Oriental":
                    capacidad = 50;
                    cupos = 2;
                    break;
                case "Yoga / Pilates":
                    capacidad = 10000;
                    cupos = 10;
                    break;
                case "Meditación":
                    capacidad = 10000;
                    cupos = 10;
                    break;
                case "Bicicletas":
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Cabalgatas":
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Botes":
                    capacidad = 10000;
                    cupos = 10000;
                    break;
                case "Piscina abierta":
                    capacidad = 200;
                    cupos = 50;
                    break;
                case "Piscina cerrada":
                    capacidad = 200;
                    cupos = 50;
                    break;
                case "Piscina barro":
                    capacidad = 80;
                    cupos = 40;
                    break;
                case "Hidromasaje":
                    capacidad = 90;
                    cupos = 4;
                    break;
                case "Sauna":
                    capacidad = 75;
                    cupos = 6;
                    break;

            }
        }
        public static void desactivarCombobox( ComboBox a)
        {  
            a.Enabled = false;
            a.Text = "";
        }
        public static bool verificarHoraRetorno(string horaIda, string fecha, string servicio) {
            DateTime hora1 = DateTime.MinValue;
            DateTime hora2 = DateTime.MaxValue;
            if (horaIda != "" || horaIda!=null) 
            hora1 = Convert.ToDateTime(horaIda);

           
            foreach (DataRow dr in Logica.ServiciosClientes.Rows)
            {
                if(dr["Servicio"].ToString()== "Traslado Vuelta" && dr["Fecha"].ToString() == fecha )
                {
                    hora2= Convert.ToDateTime(dr["Hora"]);
                    break;
                }
            }
            if (hora1 >= hora2 && servicio != "Traslado Vuelta")
                return true;
            else
            return false;
        }
        //#############################################################################################
        //Botones
        //#############################################################################################
        private void frmModificarServiciosCliente_Load(object sender, EventArgs e)
        {
            dgvServicios.DataSource = Logica.ServiciosClientes;
            if (dgvServicios.Columns.Count > 0)
            {


                string buscar = "CI = '" + frmModificacionCliente.txtID + "'";
                DataRow[] foundRows = Logica.ServiciosClientes.Select(buscar);
                if (foundRows.Length <= 0)
                {
                    MessageBox.Show("No hay servicios registrados para este cliente");
                    this.Close();
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvServicios.DataSource;
                    bs.Filter = "CI = '" + frmModificacionCliente.txtID + "'";
                    dgvServicios.DataSource = bs;

                }
            }
            else
            {
                MessageBox.Show("No hay servicios registrados");
                this.Close();
            }


        }
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            try
            {
                cboxHoras.Text = "";
                cboxHoras.Enabled = false;
                DataGridViewRow row = this.dgvServicios.Rows[e.RowIndex];
                x = e.RowIndex;
                if (row.Cells["CI"].Value.ToString() != "")
                {
                    CI = row.Cells["CI"].Value.ToString();
                    Servicio = row.Cells["Servicio"].Value.ToString();
                    Fecha = row.Cells["Fecha"].Value.ToString();
                    try {
                        Precio = Int32.Parse(row.Cells["Precio"].Value.ToString());
                    } catch(System.FormatException)
                    {
                        Precio = Int32.Parse(row.Cells["Precio"].Value.ToString().Remove(0, 1));
                    }
                    
                    Hora = row.Cells["Hora"].Value.ToString();
                    lblServicio.Text = row.Cells["Servicio"].Value.ToString();
                    panelHoras.Enabled = true;                  
                    
                }

            }
            catch (System.ArgumentOutOfRangeException) { }
        }
        private void btnMostrarDisponibilidad_Click(object sender, EventArgs e)
        {
            hola();
            Servicios = lblServicio.Text;

            cboxHoras.Items.Clear();
            cboxHoras.Enabled = true;
            Logica.agregarFechas(Servicios, Fecha, cupos);
            Logica.agregarCapacidad(Servicios, Fecha, capacidad);
            Logica.llenarFechas(cboxHoras, Servicios, Fecha);
            

        }
        private void btnCambiarFechaHora_Click(object sender, EventArgs e)
        {
            DateTime horaIda = DateTime.MinValue;
            DateTime horaVuelta = DateTime.MaxValue;
          
            hora = cboxHoras.GetItemText(cboxHoras.SelectedItem);
            if(hora !="")
            horaIda = Convert.ToDateTime(hora);
            if (horaRetorno != "")
                horaVuelta = Convert.ToDateTime(horaRetorno);
            try
            {
                DataGridViewRow row = dgvServicios.Rows[x];
                if ((lblServicio.Text == "Traslados" && cboxHoras.Text != "") || (lblServicio.Text != "traslados" && cboxHoras.Text != ""))
                {
                    if (hora == row.Cells["Hora"].Value.ToString() && lblServicio.Text == row.Cells["Servicio"].Value.ToString())
                    {

                    }
                    else if (verificarHoraRetorno(hora,Fecha,lblServicio.Text))
                        {
                            MessageBox.Show("La hora de regreso es inferior a la hora de ida");
                        }
                    else if (Logica.verificarReservado(frmModificacionCliente.txtID, Fecha, hora, lblServicio.Text, HoraRetorno))
                    {
                        MessageBox.Show("El cliente ya tiene agendado otro servicio en esa hora");
                    }
                    else
                    {
                        foreach (DataRow dr in Logica.ServiciosClientes.Rows)
                        {                          
                            if (dr["Servicio"].ToString() == lblServicio.Text)
                            {
                                if (dr["Hora"].ToString() != hora)
                                {
                                    
                                    Logica.borrarCupo("Traslados", dr["Fecha"].ToString(), dr["Hora"].ToString());
                                    dr["Hora"] = hora;
                                    Logica.ReservarCupo("Traslados", dr["Fecha"].ToString(), dr["Hora"].ToString());
                                 
                                }
                            }
                        }
                        frmCorrecto dou = new frmCorrecto("Servicio modificado \ncorrectamente", 1);
                        if (dou.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException ) { }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cboxHoras.Text = "";
            cboxHoras.Enabled = false;
        }
        private void btnBorrarReserva_Click(object sender, EventArgs e)
        {
            Logica.borrarTotal(CI, Precio);
            Logica.borrarServicio(CI, Servicio, Fecha, Hora, HoraRetorno);
            Logica.restarClientesFecha(Fecha);
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //#############################################################################################
    }
}
