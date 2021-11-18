using Bunifu.Framework.UI;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Logica
{
    public class logica
    {
        public static Panel leftBorderBtn;
        public static BunifuFlatButton CurrentButton;
        public static bool PagoTraslado = false;
        public static bool pagoTraslado2 = false;
        public static DataTable DatosClientes = new DataTable("tabla datos Cliente");
        public static DataTable ServiciosClientes = new DataTable("Servicios");
        public static DataTable precios = new DataTable("Precios");
        public static DataTable FechasDisponibles = new DataTable("Fechas");
        public static DataTable CapacidadesDiarias = new DataTable("Capacidades Diarias");
        public static int[] ClientesPorDia = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public static int precioTotal = 0;
        public static int UsuarioActual;
        public static string passActual;
        public static string token;
        public static Color fondo = Color.FromArgb(22, 23, 27);
        //add in tables


        //Funciones Gerente.
        //############################################################################################# 
        public static bool reservarServicios(int nro, string fecha,DataGridView dgv)
        {
            DataGridViewRow Row;
            for(int i = 0; i < dgv.Rows.Count; i++)
            {
               Row = dgv.Rows[i];
                if(Row.Cells["check"].Value != null) {
                    if (Row.Cells["check"].Value.Equals(true))
                    {
                        if(checkIda(dgv))
                        {
                            if (checkVuelta(dgv))
                            {
                                if(Row.Cells["Servicio"].Value.ToString()=="Traslado Ida" || Row.Cells["Servicio"].Value.ToString() == "Traslado Vuelta")
                                {
                                    if (PagoTraslado)
                                    {
                                      Datos.Reservas.ReservarServicio(nro, Row.Cells["Hora"].Value.ToString(), Row.Cells["Servicio"].Value.ToString(), 0,UsuarioActual);
                                    }
                                    else
                                    {
                                        Datos.Reservas.ReservarServicio(nro, Row.Cells["Hora"].Value.ToString(), Row.Cells["Servicio"].Value.ToString(),
                                     Datos.Servicio.VerificiarPrecio(Row.Cells["Servicio"].Value.ToString()), UsuarioActual);
                                        PagoTraslado = true;
                                    }
                                }
                                else
                                {
                                    Datos.Reservas.ReservarServicio(nro, Row.Cells["Hora"].Value.ToString(), Row.Cells["Servicio"].Value.ToString(),
                                 Datos.Servicio.VerificiarPrecio(Row.Cells["Servicio"].Value.ToString()), UsuarioActual);
                                }
                                   
                                Datos.Fecha.ModificarCupos(fecha, Row.Cells["Hora"].Value.ToString(), Row.Cells["Servicio"].Value.ToString(), false);
                                Datos.Fecha.modificarCapacidad(Row.Cells["Servicio"].Value.ToString(), fecha,false);

                            }
                            else
                            {
                                MessageBox.Show("Verifique la hora de los servicios en relación a la hora de Regreso");
                                return false;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Verifique la hora de los servicios en relación a la hora de Ida");
                            return false;
                        }    
                    }
                }
            }
            return true;
        }
        public static bool checkIda(DataGridView dgv)
        {

            string Ida = DateTime.MinValue.ToString("HH:mm:ss");
            DataGridViewRow Row;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Row = dgv.Rows[i];
                if (Row.Cells["check"].Value != null)
                {
                    if (Row.Cells["check"].Value.Equals(true) && Row.Cells["Servicio"].Value.ToString() == "Traslado Ida")
                    {
                        Ida = Row.Cells["Hora"].Value.ToString();
                        break;
                    }
                }
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Row = dgv.Rows[i];
                if (Row.Cells["check"].Value != null)
                {
                    if (Row.Cells["check"].Value.Equals(true))
                    {
                        if (Convert.ToDateTime(Row.Cells["Hora"].Value.ToString()) < Convert.ToDateTime(Ida))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static bool checkVuelta(DataGridView dgv)
        {
            string Vuelta = DateTime.MaxValue.ToString("HH:mm:ss");
            DataGridViewRow Row;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Row = dgv.Rows[i];
                if (Row.Cells["check"].Value != null)
                {
                    if (Row.Cells["check"].Value.Equals(true) && Row.Cells["Servicio"].Value.ToString() == "Traslado Vuelta")
                    {
                        Vuelta = Row.Cells["Hora"].Value.ToString();
                        break;
                    }
                }

            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Row = dgv.Rows[i];
                if (Row.Cells["check"].Value != null)
                {
                    if (Row.Cells["check"].Value.Equals(true))
                    {
                        if (Convert.ToDateTime(Row.Cells["Hora"].Value.ToString()) > Convert.ToDateTime(Vuelta))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static bool existeCI(TextBox a)
        {
            if (DatosClientes.Columns.Count > 0)
            {
                string buscar = "CI = '" + a.Text + "'";
                DataRow[] foundRows = DatosClientes.Select(buscar);
                if (foundRows.Length > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }
        //public static void bajaClienteCompleto(int ci)
        //{
        //    if (Datos.Reservas.ContarServiciosCliente(ci) > 0)
        //    {
        //        MessageBox.Show(Datos.Reservas.ContarServiciosCliente(ci) + "");
        //       DataTable hola = Datos.Reservas.CargarServiciosReservados2(ci);
        //        
        //        foreach (DataRow dr in hola.Rows)
        //        {
        //            string hora = dr["Hora"].ToString();
        //            string fecha = Convert.ToDateTime(dr["Fecha"].ToString()).ToString("yyyy-MM-dd");
        //            string servicio = dr["Servicio"].ToString();
        //            Datos.Reservas.BajaServicioCliente(ci, hora, fecha);
        //            Datos.Fecha.modificarCapacidad(servicio, fecha, true);
        //            Datos.Fecha.ModificarCupos(fecha, hora, servicio, true);
        //            
        //        }
        //        
        //    }
        //    Datos.Cliente.BajaCliente(ci);
        //}
        public static bool checkServiciosContratados(DataGridView a)
        {
            DataGridViewRow row;
            for (int i = 0; i < a.Rows.Count; i++)
            {
                row = a.Rows[i];

                if (row.Cells["Check"].Value != null)
                {
                    if (row.Cells["Check"].Value.Equals(true) && !row.Cells["Servicio"].Value.ToString().Equals("Traslado Ida") && !row.Cells["Servicio"].Value.ToString().Equals("Traslado Vuelta"))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public static void ContarClientesFecha()
        {
            int bandera = 0;
            int l = 0;
            int m = 0;
            int mi = 0;
            int j = 0;
            int v = 0;
            int s = 0;
            int d = 0;
            DataView view = new DataView(ServiciosClientes);
            view.Sort = "Fecha ASC";
            ArrayList cedulas = new ArrayList();
            string dia = "";
            foreach (DataRowView dr in view)
            {

                if (dr["Fecha"].ToString() != dia)
                {
                    bandera = 0;
                    cedulas.Clear();
                }
                if (bandera == 0)
                {
                    dia = dr["Fecha"].ToString();
                    bandera = 1;
                }
                if (!cedulas.Contains(dr["CI"].ToString()) && dr["Fecha"].ToString() == dia && dr["Fecha"].ToString() != "")
                {
                    cedulas.Add(dr["CI"].ToString());
                    DateTime fechita = DateTime.Parse(dr["Fecha"].ToString());
                    
                    switch (fechita.ToString("dddd"))
                    {
                        case "lunes":
                            l++;
                            break;
                        case "martes":
                            m++;
                            break;
                        case "miércoles":
                            mi++;
                            break;
                        case "jueves":
                            j++;
                            break;
                        case "viernes":
                            v++;
                            break;
                        case "sábado":
                            s++;
                            break;
                        case "domingo":
                            d++;
                            break;
                    }
                }
            }
            ClientesPorDia[0] = l;
            ClientesPorDia[1] = m;
            ClientesPorDia[2] = mi;
            ClientesPorDia[3] = j;
            ClientesPorDia[4] = v;
            ClientesPorDia[5] = s;
            ClientesPorDia[6] = d;
        }
        public static void restarClientesFecha(string fecha)
        {
            DateTime fechita = DateTime.Parse(fecha);
            switch (fechita.ToString("dddd"))
            {
                case "lunes":
                    if(ClientesPorDia[0]>0)
                    ClientesPorDia[0]--;
                    break;
                case "martes":
                    if (ClientesPorDia[1] > 0)
                        ClientesPorDia[1]--;
                    break;
                case "miércoles":
                    if (ClientesPorDia[2] > 0)
                        ClientesPorDia[2]--;
                    break;
                case "jueves":
                    if (ClientesPorDia[3] > 0)
                        ClientesPorDia[3]--;
                    break;
                case "viernes":
                    if (ClientesPorDia[4] > 0)
                        ClientesPorDia[4]--;
                    break;
                case "Sábado":
                    if (ClientesPorDia[5] > 0)
                        ClientesPorDia[5]--;
                    break;
                case "domingo":
                    if (ClientesPorDia[6] > 0)
                        ClientesPorDia[6]--;
                    break;
            }
        }
        //#############################################################################################

        //Funciones Administrador.
        //#############################################################################################     
        public static void calcularPrecio(Label a, CheckBox b, CheckBox c, string cedula, string fecha)
        {
            int precio = 0;
            if (ServiciosClientes.Columns.Count > 0)
            {
                string buscar = "CI = '" + cedula + "' AND Fecha = '" + fecha + "'";
                DataRow[] foundRows = ServiciosClientes.Select(buscar);
                if (foundRows.Length > 0)
                {
                    a.Text = "" + precioTotal;
                }
                else
                {
                    if (b.Checked)
                    {

                        foreach (DataRow dr in logica.precios.Rows)
                        {
                            if (dr["Servicio"].ToString() == "Entrada Jubilados")
                            {
                                precio = Int32.Parse(dr["Precio"].ToString());
                                break;
                            }
                        }

                    }
                    if (c.Checked)
                    {
                        foreach (DataRow dr in logica.precios.Rows)
                        {
                            if (dr["Servicio"].ToString() == "Entrada Turistas")
                            {
                                precio = Int32.Parse(dr["Precio"].ToString());
                                break;
                            }
                        }
                    }
                    if (!b.Checked && !c.Checked)
                    {
                        foreach (DataRow dr in logica.precios.Rows)
                        {
                            if (dr["Servicio"].ToString() == "Entrada Estandar")
                            {
                                precio = Int32.Parse(dr["Precio"].ToString());
                                break;
                            }
                        }
                    }
                    precio += precioTotal;
                    a.Text = "" + precio;
                }
            }
            else
            {
                if (b.Checked)
                {

                    foreach (DataRow dr in logica.precios.Rows)
                    {
                        if (dr["Servicio"].ToString() == "Entrada Jubilados")
                        {
                            precio = Int32.Parse(dr["Precio"].ToString());
                            break;
                        }
                    }

                }
                if (c.Checked)
                {
                    foreach (DataRow dr in logica.precios.Rows)
                    {
                        if (dr["Servicio"].ToString() == "Entrada Turistas")
                        {
                            precio = Int32.Parse(dr["Precio"].ToString());
                            break;
                        }
                    }
                }
                if (!b.Checked && !c.Checked)
                {
                    foreach (DataRow dr in logica.precios.Rows)
                    {
                        if (dr["Servicio"].ToString() == "Entrada Estandar")
                        {
                            precio = Int32.Parse(dr["Precio"].ToString());
                            break;
                        }
                    }
                }
                precio += precioTotal;
                a.Text = "" + precio;
            }


        }

        public static bool compararHoras(Label hora, Label hora1, Label hora2, Label hora3, Label hora4, Label hora5, Label hora6, Label hora7, Label hora8, Label hora9, Label hora10, Label hora11)
        {

            DateTime t0 = DateTime.MinValue;
            DateTime t1 = DateTime.MinValue;
            DateTime t2 = DateTime.MinValue;
            DateTime t3 = DateTime.MinValue;
            DateTime t4 = DateTime.MinValue;
            DateTime t5 = DateTime.MinValue;
            DateTime t6 = DateTime.MinValue;
            DateTime t7 = DateTime.MinValue;
            DateTime t8 = DateTime.MinValue;
            DateTime t9 = DateTime.MinValue;
            DateTime t10 = DateTime.MinValue;
            DateTime t11 = DateTime.MinValue;
            try
            {
                if (hora.Text != "Hora ACA")
                {
                    t0 = Convert.ToDateTime(hora.Text);
                }
                if (hora1.Text != "Hora ACA")
                    t1 = Convert.ToDateTime(hora1.Text);

                if (hora2.Text != "Hora ACA")
                    t2 = Convert.ToDateTime(hora2.Text);

                if (hora3.Text != "Hora ACA")
                    t3 = Convert.ToDateTime(hora3.Text);

                if (hora4.Text != "Hora ACA")
                    t4 = Convert.ToDateTime(hora4.Text);

                if (hora5.Text != "Hora ACA")
                    t5 = Convert.ToDateTime(hora5.Text);

                if (hora6.Text != "Hora ACA")
                    t6 = Convert.ToDateTime(hora6.Text);

                if (hora7.Text != "Hora ACA")
                    t7 = Convert.ToDateTime(hora7.Text);

                if (hora8.Text != "Hora ACA")
                    t8 = Convert.ToDateTime(hora8.Text);

                if (hora9.Text != "Hora ACA")
                    t9 = Convert.ToDateTime(hora9.Text);

                if (hora10.Text != "Hora ACA")
                    t10 = Convert.ToDateTime(hora10.Text);

                if (hora11.Text != "Hora ACA")
                    t11 = Convert.ToDateTime(hora11.Text);

            }
            catch (System.FormatException) { }

            if (t0 != DateTime.MinValue)
            {
                if (DateTime.Compare(t0, t1) == 0 || DateTime.Compare(t0, t2) == 0 || DateTime.Compare(t0, t3) == 0 || DateTime.Compare(t0, t4) == 0 ||
                    DateTime.Compare(t0, t5) == 0 || DateTime.Compare(t0, t6) == 0 || DateTime.Compare(t0, t7) == 0 || DateTime.Compare(t0, t8) == 0 ||
                    DateTime.Compare(t0, t9) == 0 || DateTime.Compare(t0, t10) == 0 || DateTime.Compare(t0, t11) == 0)
                {
                    return false;
                }
            }
            if (t1 != DateTime.MinValue)
            {
                if (DateTime.Compare(t1, t0) == 0 || DateTime.Compare(t1, t2) == 0 || DateTime.Compare(t1, t3) == 0 || DateTime.Compare(t1, t4) == 0 ||
                DateTime.Compare(t1, t5) == 0 || DateTime.Compare(t1, t6) == 0 || DateTime.Compare(t1, t7) == 0 || DateTime.Compare(t1, t8) == 0 ||
                DateTime.Compare(t1, t9) == 0 || DateTime.Compare(t1, t10) == 0 || DateTime.Compare(t1, t11) == 0)
                {

                    return false;
                }
            }
            if (t2 != DateTime.MinValue)
            {
                if (DateTime.Compare(t2, t0) == 0 || DateTime.Compare(t2, t1) == 0 || DateTime.Compare(t2, t3) == 0 || DateTime.Compare(t2, t4) == 0 ||
                DateTime.Compare(t2, t5) == 0 || DateTime.Compare(t2, t6) == 0 || DateTime.Compare(t2, t7) == 0 || DateTime.Compare(t2, t8) == 0 ||
                DateTime.Compare(t2, t9) == 0 || DateTime.Compare(t2, t10) == 0 || DateTime.Compare(t2, t11) == 0)
                    return false;
            }
            if (t3 != DateTime.MinValue)
            {
                if (DateTime.Compare(t3, t0) == 0 || DateTime.Compare(t3, t1) == 0 || DateTime.Compare(t3, t2) == 0 || DateTime.Compare(t3, t4) == 0 ||
                DateTime.Compare(t3, t5) == 0 || DateTime.Compare(t3, t6) == 0 || DateTime.Compare(t3, t7) == 0 || DateTime.Compare(t3, t8) == 0 ||
                DateTime.Compare(t3, t9) == 0 || DateTime.Compare(t3, t10) == 0 || DateTime.Compare(t3, t11) == 0)
                {
                    return false;
                }
            }
            if (t4 != DateTime.MinValue)
            {
                if (DateTime.Compare(t4, t0) == 0 || DateTime.Compare(t4, t1) == 0 || DateTime.Compare(t4, t2) == 0 || DateTime.Compare(t4, t3) == 0 ||
                DateTime.Compare(t4, t5) == 0 || DateTime.Compare(t4, t6) == 0 || DateTime.Compare(t4, t7) == 0 || DateTime.Compare(t4, t8) == 0 ||
                DateTime.Compare(t4, t9) == 0 || DateTime.Compare(t4, t10) == 0 || DateTime.Compare(t4, t11) == 0)
                {
                    return false;
                }
            }
            if (t5 != DateTime.MinValue)
            {
                if (DateTime.Compare(t5, t0) == 0 || DateTime.Compare(t5, t1) == 0 || DateTime.Compare(t5, t2) == 0 || DateTime.Compare(t5, t3) == 0 ||
                DateTime.Compare(t5, t4) == 0 || DateTime.Compare(t5, t6) == 0 || DateTime.Compare(t5, t7) == 0 || DateTime.Compare(t5, t8) == 0 ||
                DateTime.Compare(t5, t9) == 0 || DateTime.Compare(t5, t10) == 0 || DateTime.Compare(t5, t11) == 0)
                {
                    return false;
                }
            }
            if (t6 != DateTime.MinValue)
            {
                if (DateTime.Compare(t6, t0) == 0 || DateTime.Compare(t6, t1) == 0 || DateTime.Compare(t6, t2) == 0 || DateTime.Compare(t6, t3) == 0 ||
                DateTime.Compare(t6, t4) == 0 || DateTime.Compare(t6, t5) == 0 || DateTime.Compare(t6, t7) == 0 || DateTime.Compare(t6, t8) == 0 ||
                DateTime.Compare(t6, t9) == 0 || DateTime.Compare(t6, t10) == 0 || DateTime.Compare(t6, t11) == 0)
                {
                    return false;
                }
            }
            if (t7 != DateTime.MinValue)
            {
                if (DateTime.Compare(t7, t0) == 0 || DateTime.Compare(t7, t1) == 0 || DateTime.Compare(t7, t2) == 0 || DateTime.Compare(t7, t3) == 0 ||
                DateTime.Compare(t7, t4) == 0 || DateTime.Compare(t7, t5) == 0 || DateTime.Compare(t7, t6) == 0 || DateTime.Compare(t7, t8) == 0 ||
                DateTime.Compare(t7, t9) == 0 || DateTime.Compare(t7, t10) == 0 || DateTime.Compare(t7, t11) == 0)
                {
                    return false;
                }
            }
            if (t8 != DateTime.MinValue)
            {
                if (DateTime.Compare(t8, t0) == 0 || DateTime.Compare(t8, t1) == 0 || DateTime.Compare(t8, t2) == 0 || DateTime.Compare(t8, t3) == 0 ||
                DateTime.Compare(t8, t4) == 0 || DateTime.Compare(t8, t5) == 0 || DateTime.Compare(t8, t6) == 0 || DateTime.Compare(t8, t7) == 0 ||
                DateTime.Compare(t8, t9) == 0 || DateTime.Compare(t8, t10) == 0 || DateTime.Compare(t8, t11) == 0)
                {
                    return false;
                }
            }
            if (t9 != DateTime.MinValue)
            {
                if (DateTime.Compare(t9, t0) == 0 || DateTime.Compare(t9, t1) == 0 || DateTime.Compare(t9, t2) == 0 || DateTime.Compare(t9, t3) == 0 ||
                DateTime.Compare(t9, t4) == 0 || DateTime.Compare(t9, t5) == 0 || DateTime.Compare(t9, t6) == 0 || DateTime.Compare(t9, t7) == 0 ||
                DateTime.Compare(t9, t8) == 0 || DateTime.Compare(t9, t10) == 0 || DateTime.Compare(t9, t11) == 0)
                {
                    return false;
                }
            }
            if (t10 != DateTime.MinValue)
            {
                if (DateTime.Compare(t10, t0) == 0 || DateTime.Compare(t10, t1) == 0 || DateTime.Compare(t10, t2) == 0 || DateTime.Compare(t10, t3) == 0 ||
                DateTime.Compare(t10, t4) == 0 || DateTime.Compare(t10, t5) == 0 || DateTime.Compare(t10, t6) == 0 || DateTime.Compare(t10, t7) == 0 ||
                DateTime.Compare(t10, t8) == 0 || DateTime.Compare(t10, t9) == 0 || DateTime.Compare(t10, t11) == 0)
                {
                    return false;
                }
            }
            if (t11 != DateTime.MinValue)
            {
                if (DateTime.Compare(t11, t0) == 0 || DateTime.Compare(t11, t1) == 0 || DateTime.Compare(t11, t2) == 0 || DateTime.Compare(t11, t3) == 0 ||
                DateTime.Compare(t11, t4) == 0 || DateTime.Compare(t11, t5) == 0 || DateTime.Compare(t11, t6) == 0 || DateTime.Compare(t11, t7) == 0 ||
                DateTime.Compare(t11, t8) == 0 || DateTime.Compare(t11, t9) == 0 || DateTime.Compare(t11, t10) == 0)
                {
                    return false;
                }
            }
            return true;

        }


        //#############################################################################################   

        //Otros.
        //#############################################################################################


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static bool validarEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
        
        public static void move(IntPtr asd,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(asd, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public static bool validarCampoVacio(string txt)
        {
            if (txt == string.Empty)
                return false;

            else
                return true;
        }
        public static bool validar50CaracteresMax(string x)
        {
            if (x.Length < 50)
                return true;
            else
                return false;
        }
        public static void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        public static void ValidarSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        public static int ListarServiciosTicket(DataGridView dgv, PrintPageEventArgs e,int total, int f)
        {
            DataGridViewRow Row;
            Graphics graphics = e.Graphics;
            System.Drawing.Font fuente = new System.Drawing.Font("calibri", 10, FontStyle.Regular);
            System.Drawing.Font Titulos = new System.Drawing.Font("calibri", 10, FontStyle.Bold);
            System.Drawing.Font superTitulo = new System.Drawing.Font("Segoe Ui", 16, FontStyle.Bold);
            System.Drawing.Font subTitulo = new System.Drawing.Font("calibri", 8, FontStyle.Bold);
            int x = 0;
            int y = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                
                  Row = dgv.Rows[i];
                if (Row.Cells["check"].Value != null)
                {
                    if (Row.Cells["check"].Value.Equals(true))
                    {
                        x++;
                        y = f + (15 * x);
                        if (Row.Cells["Servicio"].Value.ToString() == "Traslado Ida" || Row.Cells["Servicio"].Value.ToString() == "Traslado Vuelta")
                        {
                            
                            if (pagoTraslado2)
                            {
                                graphics.DrawString(Row.Cells["Servicio"].Value.ToString(), fuente, Brushes.Black, new Point(10, y));
                                graphics.DrawString(Row.Cells["Hora"].Value.ToString(), fuente, Brushes.Black, new Point(120, y));
                                graphics.DrawString("0", fuente, Brushes.Black, new Point(230, y));
                            }
                            else
                            {
                                
                                graphics.DrawString(Row.Cells["Servicio"].Value.ToString(), fuente, Brushes.Black, new Point(10, y));
                                graphics.DrawString(Row.Cells["Hora"].Value.ToString(), fuente, Brushes.Black, new Point(120, y));
                                graphics.DrawString(Row.Cells["Costo"].Value.ToString(), fuente, Brushes.Black, new Point(230, y));
                            }
                            pagoTraslado2 = true;
                        }
                        else {
                            graphics.DrawString(Row.Cells["Servicio"].Value.ToString(), fuente, Brushes.Black, new Point(10, y));
                            graphics.DrawString(Row.Cells["Hora"].Value.ToString(), fuente, Brushes.Black, new Point(120, y));
                            graphics.DrawString(Row.Cells["Costo"].Value.ToString(), fuente, Brushes.Black, new Point(230, y));
                        } 
                    }
                }
            }
            y += 15;
            graphics.DrawString("-------------------", fuente, Brushes.Black, new Point(185, y));
            y += 10;
            graphics.DrawString("Total:", Titulos, Brushes.Black, new Point(185, y));
            graphics.DrawString("$"+total, fuente, Brushes.Black, new Point(225, y));
            return y;
        }
    
        public static void ImprimirTicket(PrintDocument ticket)
        {
            PrintDialog Dialogticket = new PrintDialog();
            Dialogticket.Document = ticket;
            if (Dialogticket.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ticket.Print();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void InformacionImprimir(PrintPageEventArgs e,int nroReserva,string FormaPago,string nombre,string apellido,int cedula,string fecha,DataGridView dgv,int total,string entrada,bool yaExiste)
        {
            try
            {
                int y = 0;
                Graphics graphics = e.Graphics;
                System.Drawing.Font fuente = new System.Drawing.Font("calibri", 10, FontStyle.Regular);
                System.Drawing.Font Titulos = new System.Drawing.Font("calibri", 10, FontStyle.Bold);
                System.Drawing.Font superTitulo = new System.Drawing.Font("Segoe Ui", 16, FontStyle.Bold);
                System.Drawing.Font subTitulo = new System.Drawing.Font("calibri", 8, FontStyle.Bold);
                //fuentes
                string separador = "-------------------------------------------------------------";
                string separador2 = "-------------------------Cliente---------------------------";
                
                graphics.DrawImage(Datos.Spa.CargarlogoSpa(), new Point(10, 60));
                graphics.DrawString("Spa termal Onsen", superTitulo, Brushes.Black, new Point(70, 75));
                graphics.DrawString(separador, fuente, Brushes.Black, new Point(10, 130));
                graphics.DrawString("Reserva:", Titulos, Brushes.Black, new Point(10, 150));
                graphics.DrawString(""+nroReserva, fuente, Brushes.Black, new Point(65, 150));
                graphics.DrawString("Forma pago:", Titulos, Brushes.Black, new Point(10, 165));
                graphics.DrawString(FormaPago, fuente, Brushes.Black, new Point(85, 165));
                graphics.DrawString(separador2, fuente, Brushes.Black, new Point(10, 180));
                graphics.DrawString("Nombre:", Titulos, Brushes.Black, new Point(10, 200));
                graphics.DrawString(nombre, fuente, Brushes.Black, new Point(65, 200));
                graphics.DrawString("Apellido:", Titulos, Brushes.Black, new Point(10, 215));
                graphics.DrawString("Fecha:", Titulos, Brushes.Black, new Point(155, 215));
                graphics.DrawString(fecha, fuente, Brushes.Black, new Point(200, 215));
                graphics.DrawString(apellido, fuente, Brushes.Black, new Point(65, 215));
                graphics.DrawString("CI:", Titulos, Brushes.Black, new Point(10, 230));
                graphics.DrawString(""+cedula, fuente, Brushes.Black, new Point(40, 230));
                graphics.DrawString(separador, fuente, Brushes.Black, new Point(10, 245));
                graphics.DrawRectangle(new Pen(Color.Black, 1), new System.Drawing.Rectangle(10, 265, 260, 40));
                graphics.DrawString("SERVICIOS RESERVADOS", fuente, Brushes.Black, new Point(70, 275));
                graphics.DrawString(separador, fuente, Brushes.Black, new Point(10, 320));
                graphics.DrawString("Servicio", subTitulo, Brushes.Black, new Point(10, 340));
                graphics.DrawString("Hora", subTitulo, Brushes.Black, new Point(120, 340));
                graphics.DrawString("Costo", subTitulo, Brushes.Black, new Point(230, 340));
                graphics.DrawString(separador, fuente, Brushes.Black, new Point(10, 350));
                if (!yaExiste)
                {
                    graphics.DrawString(entrada, fuente, Brushes.Black, new Point(10, 365));
                    graphics.DrawString("-------", fuente, Brushes.Black, new Point(120, 365));
                    graphics.DrawString("$" + Datos.Entrada.GetPrecioEntrada(entrada), fuente, Brushes.Black, new Point(230, 365));
                    y = ListarServiciosTicket(dgv, e, total, 365);
                }
                else
                {
                    y = ListarServiciosTicket(dgv, e, total, 350);
                }
                graphics.DrawString(separador, fuente, Brushes.Black, new Point(10, y+15));
                graphics.DrawString("Generado el:", Titulos, Brushes.Black, new Point(10, y+30));
                graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuente, Brushes.Black, new Point(120, y + 30));
                graphics.DrawString("Generado por:", Titulos, Brushes.Black, new Point(10, y + 45));
                graphics.DrawString(Datos.Usuarios.NApellidoUsuario(logica.UsuarioActual), fuente, Brushes.Black, new Point(120, y + 45));
                graphics.DrawString("Generado en:", Titulos, Brushes.Black, new Point(10, y + 60));
                graphics.DrawString(Environment.MachineName, fuente, Brushes.Black, new Point(120, y + 60));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static bool EsPrimo(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    
        public static ArrayList horasNoDisponibles(DataGridView a)
        {
            ArrayList hola = new ArrayList();
            DataGridViewRow row;
            for (int i = 0; i < a.Rows.Count; i++)
            {
                row = a.Rows[i];

                if (!row.Cells["Hora"].Value.Equals(""))
                {
                    hola.Add(row.Cells["Hora"].Value.ToString());
                }
            }
            return hola;
        }
        public static ArrayList horasNoDisponibles2(DataGridView a)
        {
            ArrayList hola = new ArrayList();
            DateTime xd = new DateTime();
            DataGridViewRow row;
            for (int i = 0; i < a.Rows.Count; i++)
            {
                row = a.Rows[i];

                if (!row.Cells["Hora"].Value.Equals(""))
                {
                    xd = Convert.ToDateTime(row.Cells["Hora"].Value.ToString());

                    hola.Add(xd.AddMinutes(Datos.Servicio.GetPermanencia(row.Cells["Servicio"].Value.ToString())).ToString("HH:mm:ss"));
                }
            }
            return hola;
        }
       
        public static ArrayList ServiciosReservados(DataGridView a)
        {
            ArrayList hola = new ArrayList();
            DataGridViewRow row;
            for (int i = 0; i < a.Rows.Count; i++)
            {
                row = a.Rows[i];

                if (row.Cells["Check"].Value.Equals(true))
                {
                    hola.Add(row.Cells["Servicio"].Value.ToString());
                }
            }
            return hola;
        }
        public static string passGenerator(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        public static async Task Email(string email)
        {
            string token1 = passGenerator(6);
            token = token1;

            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("spaonsennoreply@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Verificar identidad";
                mail.Body = "Tremendo token: " + token;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("spaonsennoreply@gmail.com", "v5_#(SvkewVg6#X#HU`QQGz_29RL5a");
                SmtpServer.EnableSsl = true;
                Console.WriteLine("EMPEZZOOO");
                await SmtpServer.SendMailAsync(mail);
                Console.WriteLine("terminoooo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el email: " + ex.Message);
                
            }
        }
        public static string randomLink()
        {
                string[] links = { "https://youtu.be/VRj4reiG9i0", "https://youtu.be/puv3lU6epoA", "https://youtu.be/UqXasKJ-uXY", "https://youtu.be/MUUrW7xJSw4",
                "https://youtu.be/u84DkYol2vQ", "https://youtu.be/S_bEK0Vtr20", "https://youtu.be/UeFC_9oGqWg", "https://youtu.be/it3jhbAsOn8",
            "https://youtu.be/GqKwp6zXQG8"}; 
            Random rand = new Random(); 
            int index = rand.Next(links.Length);
            return links[index];
        }
        public static System.Drawing.Image qrGenerator(string link)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData data = qr.CreateQrCode(link, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            return code.GetGraphic(3);
        }
        public static MemoryStream Documento(DataTable infoPersona,DataTable Servicios)
        {
            MemoryStream ms = new MemoryStream();
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(50, 50, 50, 50);
            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            doc.Open(); //open doc for editing

            Paragraph foto = new Paragraph();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(Datos.Spa.CargarlogoAColorSpa(), System.Drawing.Imaging.ImageFormat.Png);
            png.ScaleToFit(128f, 128f);
            png.Alignment = Element.ALIGN_MIDDLE;
            foto.Add(png);
            doc.Add(foto);

            //Nombre
            string segoeui = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "segoeui.ttf");
            BaseFont Normal = BaseFont.CreateFont(segoeui, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font negritaNormal = new iTextSharp.text.Font(Normal, 10, 1, iTextSharp.text.BaseColor.BLACK);
            //Paragraph Nombre = new Paragraph();
            //Nombre.Alignment = Element.ALIGN_LEFT;
            //Nombre.Add(new Chunk("Mathias Nicolas Huque Gomez".ToUpper(), negritaNormal));
            //doc.Add(Nombre);

            //infoPersona
            PdfPTable tabla = new PdfPTable(infoPersona.Columns.Count);
            tabla.TotalWidth = 500f;
            tabla.LockedWidth = true;
            tabla.HorizontalAlignment = 1;
            tabla.SpacingAfter = 10;
            foreach (DataRow dr in infoPersona.Rows)
            {
                for(int i=0;i<infoPersona.Columns.Count;i++) {
                    PdfPCell headerPersona = new PdfPCell();
                    headerPersona.BorderColor = new iTextSharp.text.BaseColor(0, 129, 249,128);
                    headerPersona.BorderColor = new iTextSharp.text.BaseColor(0, 129, 249,128);
                    //headerPersona.PaddingLeft = 25;
                    //headerPersona.PaddingBottom = 10;
                    BaseFont headerPersonaBase = BaseFont.CreateFont(segoeui, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font headerPersonaFont = new iTextSharp.text.Font(headerPersonaBase, 12, 1, iTextSharp.text.BaseColor.DARK_GRAY);
                    headerPersona.AddElement(new Chunk(dr[i].ToString(), headerPersonaFont));
                    headerPersona.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabla.AddCell(headerPersona);
                }
            }
            doc.Add(tabla);

            //ServiciosTabla
            PdfPTable table = new PdfPTable(Servicios.Columns.Count);
            table.TotalWidth = 500f;
            table.LockedWidth = true;
             BaseFont header = BaseFont.CreateFont(segoeui, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(header, 15, 1, iTextSharp.text.BaseColor.WHITE); ;
            for (int i = 0; i < Servicios.Columns.Count; i++)
            {
                PdfPCell header1 = new PdfPCell();
                header1.BackgroundColor = new iTextSharp.text.BaseColor(0, 129, 249);
                header1.BackgroundColor = new iTextSharp.text.BaseColor(0, 129, 249);
                header1.AddElement(new Chunk(Servicios.Columns[i].ColumnName, headerFont));
                header1.PaddingLeft = 60;
                header1.PaddingBottom = 10;
                table.AddCell(header1);
            }
            int x = 0;
            int total = 0;
            foreach (DataRow dr in Servicios.Rows)
            {
                MessageBox.Show(dr[2].ToString());
                total+=Int32.Parse(dr[2].ToString().Remove(0,1));
                x++;
                for (int i=0;i<Servicios.Columns.Count;i++)
                {
                    PdfPCell header1 = new PdfPCell();
                    if(x%2==0)
                    {
                        header1.BackgroundColor = new iTextSharp.text.BaseColor(0, 129, 249,128);
                    }
                    header1.AddElement(new Chunk(dr[i].ToString(), negritaNormal));
                    //header1.PaddingLeft = 60;
                    //header1.PaddingBottom = 10;
                    table.AddCell(header1);
                }             
            }
            //ServiciosTabla
            PdfPTable todo = new PdfPTable(2);
            todo.SpacingBefore = 15;
            todo.TotalWidth = 500f;
            todo.LockedWidth = true;
            PdfPTable tablaqr = new PdfPTable(1);
            tablaqr.TotalWidth = 250f;
            tablaqr.LockedWidth = true;
            tablaqr.HorizontalAlignment = 0;

            iTextSharp.text.Image qrLink = iTextSharp.text.Image.GetInstance(qrGenerator(randomLink()), System.Drawing.Imaging.ImageFormat.Png);
            qrLink.ScaleAbsolute(80f, 80f);
            PdfPCell celdaqr = new PdfPCell(qrLink);
            celdaqr.BorderColor = new iTextSharp.text.BaseColor(255, 255, 255);
            tablaqr.AddCell(celdaqr);

            PdfPTable tablaTotal = new PdfPTable(1);
            tablaTotal.HorizontalAlignment = 2;
            tablaTotal.TotalWidth = 250f;
            tablaTotal.LockedWidth = true;

            PdfPCell celdaTotalHeader = new PdfPCell();
            celdaTotalHeader.BackgroundColor = new iTextSharp.text.BaseColor(0, 129, 249);
            celdaTotalHeader.AddElement(new Chunk("Total a pagar", headerFont));
            tablaTotal.AddCell(celdaTotalHeader);

            PdfPCell celdaTotal = new PdfPCell();
            
            celdaTotal.AddElement(new Chunk(String.Format("${0}",total), negritaNormal));
            tablaTotal.AddCell(celdaTotal);

            x = 0;

            todo.AddCell(tablaqr);
            todo.AddCell(tablaTotal);
            doc.Add(table);
            doc.Add(todo);
            

            writer.CloseStream = false; //important
            doc.Close(); //build the doc.
            ms.Position = 0;
            return ms;
        }

        public static async Task EmailAtachmentPdf(string email,MemoryStream ms)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("spaonsennoreply@gmail.com");
                mail.To.Add(email);
                mail.Attachments.Add(new Attachment(ms, "dou.pdf"));
                mail.Subject = "Boleta SPA "+DateTime.Now.ToString("ddMMyyyyHHmmss");

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("spaonsennoreply@gmail.com", "v5_#(SvkewVg6#X#HU`QQGz_29RL5a");
                SmtpServer.EnableSsl = true;
                Console.WriteLine("EMPEZZOOO");
                await SmtpServer.SendMailAsync(mail);
                Console.WriteLine("terminoooo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la boleta: " + ex.Message);

            }
        }

        //#############################################################################################  
    }
}



