using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto
{
    public class Logica
    {
        public static Panel leftBorderBtn;
        public static Button CurrentButton;
        public static DataTable DatosClientes = new DataTable("tabla datos Cliente");
        public static DataTable ServiciosClientes = new DataTable("Servicios");
        public static DataTable precios = new DataTable("Precios");
        public static DataTable FechasDisponibles = new DataTable("Fechas");
        public static DataTable CapacidadesDiarias = new DataTable("Capacidades Diarias");
        public static int[] ClientesPorDia = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public static int precioTotal = 0;
        //add in tables


        //Funciones Gerente.
        //#############################################################################################
        public static void activarBotonGerente(object senderBtn, PictureBox iconCurrentChildForm)
        {
            if (senderBtn != null && senderBtn != CurrentButton)
            {
                DesactivarBotonGerente(CurrentButton);
                if (CurrentButton != (Button)senderBtn)
                {
                    CurrentButton = (Button)senderBtn;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                    CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                    leftBorderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    leftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    iconCurrentChildForm.Image = CurrentButton.Image;
                }
            }
        }
        public static void DesactivarBotonGerente(Button CurrentButton)
        {
            if (CurrentButton != null)
            {
                CurrentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                CurrentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleCenter;
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;

            }
        }
        public static void reservarCliente(TextBox cedula, TextBox nombre, TextBox apellido, TextBox correo, TextBox telefono, TextBox Direccion, Label lblPrecio, CheckBox Jubilado, CheckBox Turista)
        {
            string Jubilado1 = "NO";
            string Turista1 = "NO";
            if (Jubilado.Checked)
            {
                Jubilado1 = "SI";
            }
            if (Turista.Checked)
            {
                Turista1 = "SI";
            }

            if (DatosClientes.Columns.Count > 0)
                DatosClientes.Rows.Add(cedula.Text, nombre.Text, apellido.Text, correo.Text, telefono.Text, Direccion.Text, lblPrecio.Text, Jubilado1, Turista1);
            else
            {
                Logica.DatosClientes.Columns.Add("CI", typeof(string));
                Logica.DatosClientes.Columns.Add("Nombre", typeof(string));
                Logica.DatosClientes.Columns.Add("Apellido", typeof(string));
                Logica.DatosClientes.Columns.Add("Correo", typeof(string));
                Logica.DatosClientes.Columns.Add("Telefono", typeof(string));
                Logica.DatosClientes.Columns.Add("Dirección", typeof(string));
                Logica.DatosClientes.Columns.Add("Total a pagar", typeof(string));
                Logica.DatosClientes.Columns.Add("Jubilado/Pensionista", typeof(string));
                Logica.DatosClientes.Columns.Add("Turista", typeof(string));
                DatosClientes.Rows.Add(cedula.Text, nombre.Text, apellido.Text, correo.Text, telefono.Text, Direccion.Text, lblPrecio.Text, Jubilado1, Turista1);
            }

        }
        public static void reservarServicios(CheckBox servicio, Label precio, Label hora, TextBox cedula, string fecha, string retorno)
        {
            if (ServiciosClientes.Columns.Count > 0)
            {
                if (servicio.Checked)
                {
                    if(servicio.Text == "Traslados")
                    {

                        if(retorno != "Ninguno") {
                            ServiciosClientes.Rows.Add(cedula.Text, "Traslado Vuelta", fecha, precio.Text, retorno);
                        }
                        else
                        {
                          ServiciosClientes.Rows.Add(cedula.Text, "Traslado Ida", fecha, precio.Text, hora.Text);
                        }
                          
                        
                    }
                    else
                    {
                        ServiciosClientes.Rows.Add(cedula.Text, servicio.Text, fecha, precio.Text, hora.Text);
                    }
                   
                }
            }
            else
            {
                if (servicio.Checked)
                {
                    Logica.ServiciosClientes.Columns.Add("CI", typeof(string));
                    Logica.ServiciosClientes.Columns.Add("Servicio", typeof(string));
                    Logica.ServiciosClientes.Columns.Add("Fecha", typeof(string));
                    Logica.ServiciosClientes.Columns.Add("Precio", typeof(string));
                    Logica.ServiciosClientes.Columns.Add("Hora", typeof(string));
                    if (servicio.Text == "Traslados")
                    {

                        if (retorno != "Ninguno")
                        {
                            ServiciosClientes.Rows.Add(cedula.Text, "Traslado Vuelta", fecha, precio.Text, retorno);
                        }
                        else
                        {
                            ServiciosClientes.Rows.Add(cedula.Text, "Traslado Ida", fecha, precio.Text, hora.Text);
                        }
                    }
                    else {
                        ServiciosClientes.Rows.Add(cedula.Text, servicio.Text, fecha, precio.Text, hora.Text);
                    }                   
                }
            }

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
        public static bool cargarCliente(TextBox Cedula, TextBox Nombre, TextBox Apellido, TextBox Correo, TextBox Telefono, TextBox Direccion, CheckBox Jubilado, CheckBox Turista)
        {

            foreach (DataRow dr in Logica.DatosClientes.Rows)
            {

                if (dr["CI"].ToString() == Cedula.Text)
                {
                    Nombre.Text = dr["Nombre"].ToString();
                    Apellido.Text = dr["Apellido"].ToString();
                    Correo.Text = dr["Correo"].ToString();
                    Telefono.Text = dr["Telefono"].ToString();
                    Direccion.Text = dr["Dirección"].ToString();
                    if (dr["Jubilado/Pensionista"].ToString() == "SI")
                    {
                        Jubilado.Checked = true;
                    }
                    if (dr["Turista"].ToString() == "SI")
                    {
                        Turista.Checked = true;
                    }
                    return true;
                }

            }
            return false;
        }
        public static void cargarServicio(TextBox Cedula, CheckBox a, Label Fecha, Label Hora, Label Hora2)
        {
            foreach (DataRow dr in Logica.ServiciosClientes.Rows)
            {

                if (dr["CI"].ToString() == Cedula.Text)
                {
                    if (dr["Servicio"].ToString() == a.Text)
                    {
                        if (a.Text == "Traslados")
                        {
                            Hora2.Text = dr["Hora Retorno"].ToString();
                        }

                        a.Checked = true;
                        Fecha.Text = dr["Fecha"].ToString();
                        Hora.Text = dr["Hora"].ToString();


                    }

                }
                break;
            }
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
        public static void activarBotonAdministrador(object senderBtn, PictureBox iconCurrentChildForm)
        {
            if (senderBtn != null && senderBtn != CurrentButton)
            {
                DesactivarBotonAdministrador(CurrentButton);
                if (CurrentButton != (Button)senderBtn)
                {
                    CurrentButton = (Button)senderBtn;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                    CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                    leftBorderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                    leftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    iconCurrentChildForm.Image = CurrentButton.Image;
                }
            }
        }
        public static void DesactivarBotonAdministrador(Button CurrentButton)
        {
            if (CurrentButton != null)
            {
                CurrentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                CurrentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleCenter;
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;

            }
        }
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

                        foreach (DataRow dr in Logica.precios.Rows)
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
                        foreach (DataRow dr in Logica.precios.Rows)
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
                        foreach (DataRow dr in Logica.precios.Rows)
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

                    foreach (DataRow dr in Logica.precios.Rows)
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
                    foreach (DataRow dr in Logica.precios.Rows)
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
                    foreach (DataRow dr in Logica.precios.Rows)
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
        public static void agregarFechas(string Servicio, string Fecha, int Cupos)
        {
            if (FechasDisponibles.Columns.Count == 0)
            {
                Logica.FechasDisponibles.Columns.Add("Servicio", typeof(string));
                Logica.FechasDisponibles.Columns.Add("Fecha", typeof(string));
                Logica.FechasDisponibles.Columns.Add("Hora", typeof(string));
                Logica.FechasDisponibles.Columns.Add("Cupos", typeof(int));
                if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                {
                    agregarFechas2("Masaje", Cupos);

                }
                else
                    agregarFechas2(Servicio, Cupos);
            }
            else
            {
                int nro = 0;
                foreach (DataRow dr in Logica.FechasDisponibles.Rows)
                {
                    if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                    {
                        if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha)
                        {

                            nro++;
                            break;
                        }
                    }
                    else
                    {
                        if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha)
                        {

                            nro++;
                        }
                    }



                }
                if (nro == 1)
                {
                }
                else if (nro == 0)
                {

                    if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                    {
                        agregarFechas2("Masaje", Cupos);
                    }

                    else
                    {
                        agregarFechas2(Servicio, Cupos);
                    }
                }
                nro = 0;
            }
        }
        public static void agregarFechas2(string Servicio, int cupos)
        {
            DateTime hola = new DateTime(2008, 4, 1, 10, 00, 0);
            if (Servicio == "Bicicletas")
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        FechasDisponibles.Rows.Add(Servicio, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), hola.AddMinutes(30 * j).ToString("HH:mm"), cupos);

                    }
                }
            }
            else if (Servicio == "Traslados")
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {

                        FechasDisponibles.Rows.Add(Servicio, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), hola.AddHours(1 * j).ToString("HH:mm"), cupos);

                        j++;
                    }
                }
            }
            else if (Servicio == "Piscina abierta" || Servicio == "Piscina cerrada")
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        FechasDisponibles.Rows.Add(Servicio, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), hola.AddHours(j).ToString("HH:mm"), cupos);

                        j++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        FechasDisponibles.Rows.Add(Servicio, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), hola.AddHours(j).ToString("HH:mm"), cupos);
                    }
                }
            }


        }
        public static int verificarPrecio(string Servicio)
        {
            int precio = 0;
            foreach (DataRow dr in Logica.precios.Rows)
            {
                if (dr["Servicio"].ToString() == Servicio)
                {
                    precio = Int32.Parse(dr["Precio"].ToString());
                    break;
                }
            }
            return precio;
        }
        public static void llenarFechas(ComboBox a, string Servicio, string Fecha)
        {
           
            if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
            {
                foreach (DataRow dra in Logica.CapacidadesDiarias.Rows)
                {
                    foreach (DataRow dr in Logica.FechasDisponibles.Rows)
                    {
                        if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha && Int32.Parse(dr["Cupos"].ToString()) > 0)
                        {

                            if (dra["Servicio"].ToString() == "Masaje" && dra["Fecha"].ToString() == Fecha && Int32.Parse(dra["CapacidadActual"].ToString()) < Int32.Parse(dra["CapacidadMaxima"].ToString()))
                            {

                                a.Items.Add(dr["Hora"].ToString());


                            }
                        }
                    }
                }
            }
            else if (Servicio == "Traslado Ida" || Servicio == "Traslado Vuelta")
            { 
                    foreach (DataRow dr in Logica.FechasDisponibles.Rows)
                    {
                        if (dr["Servicio"].ToString() == "Traslados" && dr["Fecha"].ToString() == Fecha && Int32.Parse(dr["Cupos"].ToString()) > 0)
                        {
                            a.Items.Add(dr["Hora"].ToString());
                        }
                    }
            }
            else
            {
                foreach (DataRow dra in Logica.CapacidadesDiarias.Rows)
                {
                    foreach (DataRow dr in Logica.FechasDisponibles.Rows)
                    {
                        if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha && Int32.Parse(dr["Cupos"].ToString()) > 0)
                        {
                            if (dra["Servicio"].ToString() == Servicio && dra["Fecha"].ToString() == Fecha && Int32.Parse(dra["CapacidadActual"].ToString()) < Int32.Parse(dra["CapacidadMaxima"].ToString()))
                            {
                                a.Items.Add(dr["Hora"].ToString());

                            }
                        }
                    }
                }
            }

        }
        public static void ReservarCupo(string Servicio, string Fecha, string Hora) //no tengo idea de como funciona esto xd tipo si borras string Hora funciona lujo igualmente
        {
            int cupos = 0;
            foreach (DataRow dr in Logica.FechasDisponibles.Rows)
            {
                if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                {
                    if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha && Int32.Parse(dr["Cupos"].ToString()) > 0 && dr["Hora"].ToString() == Hora)
                    {
                        cupos = Int32.Parse(dr["Cupos"].ToString());
                        if (cupos > 0)
                        {
                            cupos -= 1;
                            Console.WriteLine("**********************************************************************");
                            Console.WriteLine("Servicio: " + dr["Servicio"].ToString());
                            Console.WriteLine(Hora + " Cupos Antes: " + dr["Cupos"].ToString());
                            dr["Cupos"] = cupos;
                            Console.WriteLine(Hora + " Cupos Despues: " + dr["Cupos"].ToString());
                            break;
                        }
                    }
                }
                else
                {
                    if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha && Int32.Parse(dr["Cupos"].ToString()) > 0 && dr["Hora"].ToString() == Hora)
                    {
                        cupos = Int32.Parse(dr["Cupos"].ToString());
                        if (cupos > 0)
                        {
                            cupos -= 1;
                            Console.WriteLine("**********************************************************************");
                            Console.WriteLine("Servicio: " + dr["Servicio"].ToString());
                            Console.WriteLine(Hora + " Cupos Antes: " + dr["Cupos"].ToString());
                            dr["Cupos"] = cupos;
                            Console.WriteLine(Hora + " Cupos Despues: " + dr["Cupos"].ToString());
                            break;
                        }
                    }
                }

            }
        }
        public static void borrarCupo(string Servicio, string Fecha, string Hora)
        {
            int cupos = 0;
            foreach (DataRow dr in Logica.FechasDisponibles.Rows)
            {

                if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                {
                    if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha && dr["Hora"].ToString() == Hora)
                    {
                        cupos = Int32.Parse(dr["Cupos"].ToString());
                        cupos += 1;
                        Console.WriteLine(Hora + " Cupos Antes: " + dr["Cupos"].ToString());
                        dr["Cupos"] = cupos;
                        Console.WriteLine(Hora + " Cupos Despues: " + dr["Cupos"].ToString());
                        break;
                    }
                }
                else
                {
                    if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha && dr["Hora"].ToString() == Hora)
                    {
                        cupos = Int32.Parse(dr["Cupos"].ToString());
                        cupos += 1;
                        Console.WriteLine(Hora + " Cupos Antes: " + dr["Cupos"].ToString());
                        dr["Cupos"] = cupos;
                        Console.WriteLine(Hora + " Cupos Despues: " + dr["Cupos"].ToString());
                        break;
                    }
                }
                if (Int32.Parse(dr["Cupos"].ToString()) <= 0) 
                dr["Cupos"] = 0;
            }
        }
        public static void agregarCapacidad(string Servicio, string Fecha, int CapacidadMaxima)
        {
            if (CapacidadesDiarias.Columns.Count == 0)
            {
                Logica.CapacidadesDiarias.Columns.Add("Servicio", typeof(string));
                Logica.CapacidadesDiarias.Columns.Add("Fecha", typeof(string));
                Logica.CapacidadesDiarias.Columns.Add("CapacidadActual", typeof(int));
                Logica.CapacidadesDiarias.Columns.Add("CapacidadMaxima", typeof(int));
                if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                    CapacidadesDiarias.Rows.Add("Masaje", Fecha, 0, CapacidadMaxima);
                else
                    CapacidadesDiarias.Rows.Add(Servicio, Fecha, 0, CapacidadMaxima);

            }
            else
            {
                int nro = 0;
                foreach (DataRow dr in Logica.CapacidadesDiarias.Rows)
                {
                    if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                    {
                        if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha)
                        {
                            nro++;

                        }
                    }
                    else
                    {
                        if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha)
                        {
                            nro++;

                        }
                    }

                }
                if (nro == 0)
                {
                    if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                        CapacidadesDiarias.Rows.Add("Masaje", Fecha, 0, CapacidadMaxima);
                    else
                        CapacidadesDiarias.Rows.Add(Servicio, Fecha, 0, CapacidadMaxima);
                }
            }
        }
        public static void agregarCapacidad2(string Servicio, string Fecha)
        {
            string masaje = "Masaje";
            if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
            {
                foreach (DataRow dr in Logica.CapacidadesDiarias.Rows)
                {
                    if (dr["Servicio"].ToString() == masaje && dr["Fecha"].ToString() == Fecha)
                    {
                        Console.WriteLine("CapacidadActualAntes: " + dr["CapacidadActual"].ToString());
                        int capacidadActual = Int32.Parse(dr["CapacidadActual"].ToString()) + 1;
                        dr["CapacidadActual"] = capacidadActual;
                        Console.WriteLine("CapacidadActualDespues: " + dr["CapacidadActual"].ToString());
                        Console.WriteLine("**********************************************************************");
                    }
                }
            }
            else
            {
                foreach (DataRow dr in Logica.CapacidadesDiarias.Rows)
                {
                    if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha)
                    {
                        Console.WriteLine("CapacidadActualAntes: " + dr["CapacidadActual"].ToString());
                        int capacidadActual = Int32.Parse(dr["CapacidadActual"].ToString()) + 1;
                        dr["CapacidadActual"] = capacidadActual;
                       Console.WriteLine("CapacidadActualDespues: " + dr["CapacidadActual"].ToString());
                       Console.WriteLine("**********************************************************************");
                    }
                }
            }

        }
        public static void borrarCapacidad(string Servicio, string Fecha)
        {
            foreach (DataRow dr in Logica.CapacidadesDiarias.Rows)
            {
                if (Servicio == "Masaje Oriental" || Servicio == "Masaje Tradicional")
                {
                    if (Int32.Parse(dr["CapacidadActual"].ToString()) <= 0)
                    { dr["CapacidadActual"] = 0;
                        break;
                    }
                        

                    if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == Fecha)
                    {

                        Console.WriteLine("CapacidadActualAntes: " + dr["CapacidadActual"].ToString());
                        int capacidadActual = Int32.Parse(dr["CapacidadActual"].ToString()) - 1;
                        dr["CapacidadActual"] = capacidadActual;
                        Console.WriteLine("CapacidadActualDespues: " + dr["CapacidadActual"].ToString());                        
                        break;
                    }
                }
                else
                {
                    if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha)
                    {
                        Console.WriteLine("CapacidadActualAntes: " + dr["CapacidadActual"].ToString());
                        int capacidadActual = Int32.Parse(dr["CapacidadActual"].ToString()) - 1;
                        dr["CapacidadActual"] = capacidadActual;
                        Console.WriteLine("CapacidadActualDespues: " + dr["CapacidadActual"].ToString());                 
                        break;
                    }
                }
              
            }
        }
        public static void borrarServicio(string Cedula, string Servicio, string Fecha, string Hora, string HoraRetorno)
        {
            foreach (DataRow dr in ServiciosClientes.Rows)
            {
                if (Cedula != "")
                {
                    if (Servicio == "Traslados")
                    {
                        if (dr["CI"].ToString() == Cedula && dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha && dr["Hora"].ToString() == Hora && dr["Hora Retorno"].ToString() == HoraRetorno)
                        {
                            borrarCupo(Servicio, Fecha, Hora);
                            borrarCupo(Servicio, Fecha, HoraRetorno);
                            dr.Delete();
                            break;
                        }
                    }
                    else
                    {
                        if (dr["CI"].ToString() == Cedula && dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == Fecha && dr["Hora"].ToString() == Hora)
                        {
                            borrarCupo(Servicio, Fecha, Hora);
                            borrarCapacidad(Servicio, Fecha);
                            dr.Delete();
                            break;
                        }
                    }
                }

            }
            ServiciosClientes.AcceptChanges();

        }
        public static void borrarCliente(string Cedula)
        {
            foreach (DataRow dr in DatosClientes.Rows)
            {
                if (dr["CI"].ToString() == Cedula)
                {
                    dr.Delete();
                    break;
                }
            }
            ServiciosClientes.AcceptChanges();
        }
        public static bool verificarReservado(string CI, string fecha, string hora, string servicio, string retorno)
        {
            if (ServiciosClientes.Rows.Count > 0)
            {
                foreach (DataRow dr in ServiciosClientes.Rows)
                {
                    if (servicio == "Traslado Ida" || servicio == "Traslado Vuelta")
                    {
                            return false;
                    }
                    else if (dr["CI"].ToString() == CI && dr["Fecha"].ToString() == fecha && dr["Hora"].ToString() == hora)
                        return true;

                }
            }
            return false;
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
            catch (System.FormatException e) { }

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
        public static bool verificarFecha(string cedula, string fecha)
        {
            if (ServiciosClientes.Columns.Count > 0)
            {
                string buscar = "CI = '" + cedula + "' AND Fecha = '" + fecha + "'";
                DataRow[] foundRows = ServiciosClientes.Select(buscar);
                if (foundRows.Length > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public static void agregarTotal(Label precioTotal, string cedula)
        {
            int precio;

            foreach (DataRow dr in Logica.DatosClientes.Rows)
            {
                if (dr["CI"].ToString() == cedula)
                {
                    precio = Int32.Parse(dr["Total a pagar"].ToString()) + Int32.Parse(precioTotal.Text);
                    dr["Total a pagar"] = precio;
                    break;

                }
            }
        }
        public static void borrarTotal(string Cedula, int Cantidad)
        {
            int precio;

            foreach (DataRow dr in Logica.DatosClientes.Rows)
            {
                if (dr["CI"].ToString() == Cedula)
                {
                    precio = Int32.Parse(dr["Total a pagar"].ToString()) - Cantidad;
                    if (precio <= 0)
                    {
                        dr["Total a pagar"] = 0;
                    }
                    else
                    {
                        dr["Total a pagar"] = precio;
                    }

                    break;

                }
            }
        }
        public static void revisarFecha(string cedula,string fecha) {
            foreach (DataRow dr in Logica.ServiciosClientes.Rows)
            {
                int precio = 0;
                string tipoEntrada ="Entrada Estandar";
                foreach (DataRow dra in Logica.DatosClientes.Rows)
                {
                    
                    if (dr["Cedula"].ToString() == cedula && dr["Fecha"].ToString() != fecha)
                    {
                        if (dra["Jubilado/Pensionista"].ToString() == "SI")
                        {
                            tipoEntrada = "Entrada Jubilado";
                        }
                        else if (dra["Jubilado/Pensionista"].ToString() == "SI")
                        {
                            tipoEntrada = "Entrada Turista";
                        }
                        precio = Int32.Parse(dra["Total a pagar"].ToString())+verificarPrecio(tipoEntrada);
                        dra["Total a pagar"] = precio;

                    }
                }
            }
        }
        //#############################################################################################   

        //Otros.
        //#############################################################################################
        public static int calcularCapacidadDiaria(string Servicio)
  
      {
            foreach (DataRow dr in Logica.CapacidadesDiarias.Rows)
            {
                if (Servicio == "Masaje Tradicional" || Servicio == "Masaje Oriental")
                {
                    DateTime hoy = DateTime.Today;
                    if (dr["Servicio"].ToString() == "Masaje" && dr["Fecha"].ToString() == hoy.ToString("yyyy-MM-dd"))
                    {
                        return (Int32.Parse(dr["CapacidadActual"].ToString()) * 100) / (Int32.Parse(dr["CapacidadMaxima"].ToString()));
                    }
                }
                else
                {
                    DateTime hoy = DateTime.Today;
                    if (dr["Servicio"].ToString() == Servicio && dr["Fecha"].ToString() == hoy.ToString("yyyy-MM-dd"))
                    {
                        return (Int32.Parse(dr["CapacidadActual"].ToString()) * 100) / (Int32.Parse(dr["CapacidadMaxima"].ToString()));
                    }
                }

            }
            return 0;
        }
        public static String contarServiciosFavoritos()
        {
            string FavoritoDeLaSemana = "";
            int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (DataRow dr in Logica.ServiciosClientes.Rows)
            {
                switch (dr["Servicio"].ToString())
                {
                    case "Masaje Tradicional":
                        array[0]++;
                        break;
                    case "Masaje Oriental":
                        array[1]++;
                        break;
                    case "Yoga / Pilates":
                        array[2]++;
                        break;
                    case "Meditación":
                        array[3]++;
                        break;
                    case "Bicicletas":
                        array[4]++;
                        break;
                    case "Cabalgatas":
                        array[5]++;
                        break;
                    case "Botes":
                        array[6]++;
                        break;
                    case "Piscina abierta":
                        array[7]++;
                        break;
                    case "Piscina cerrada":
                        array[8]++;
                        break;
                    case "Piscina barro":
                        array[9]++;
                        break;
                    case "Hidromasaje":
                        array[10]++;
                        break;
                    case "Sauna":
                        array[11]++;
                        break;

                }
               
            }
            int maxValue = array.Max();
            if (maxValue == 0) { return "Ninguno"; };
            int maxIndex = array.ToList().IndexOf(maxValue);
            switch (maxIndex)
            {
                case 0:
                    FavoritoDeLaSemana = "Masaje Tradicional";
                    break;
                case 1:
                    FavoritoDeLaSemana = "Masaje Oriental";
                    break;
                case 2:
                    FavoritoDeLaSemana = "Yoga/Pilates";
                    break;     
                case 3:
                    FavoritoDeLaSemana = "Meditación";
                    break;
                case 4:
                    FavoritoDeLaSemana = "Bicicletas";
                    break;
                case 5:
                    FavoritoDeLaSemana = "Cabalgatas";
                    break;
                case 6:
                    FavoritoDeLaSemana = "Botes";
                    break;
                case 7:
                    FavoritoDeLaSemana = "Piscina abierta";
                    break;
                case 8:
                    FavoritoDeLaSemana = "Piscina cerrada";
                    break;
                case 9:
                    FavoritoDeLaSemana = "Piscina barro";
                    break;
                case 10:
                    FavoritoDeLaSemana = "Hidromasaje";
                    break;
                case 11:
                    FavoritoDeLaSemana = "Sauna";
                    break;
            }
            return FavoritoDeLaSemana;
        }
        public static int contarClientesConfirmados()
        {
            int nro = 0;
            foreach (DataRow dr in Logica.DatosClientes.Rows)
            {
                if (Int32.Parse(dr["Total a pagar"].ToString()) == 0)
                {
                    nro++;
                }
            }
            return nro;
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
        public static void agregarClientesRelleno()
        {
            Random num = new Random();
            DateTime hoy = DateTime.Today;
            DateTime hora = new DateTime(2008, 4, 1, 10, 00, 0);

            if (DatosClientes.Columns.Count <= 0)
            {
                Logica.DatosClientes.Columns.Add("CI", typeof(string));
                Logica.DatosClientes.Columns.Add("Nombre", typeof(string));
                Logica.DatosClientes.Columns.Add("Apellido", typeof(string));
                Logica.DatosClientes.Columns.Add("Correo", typeof(string));
                Logica.DatosClientes.Columns.Add("Telefono", typeof(string));
                Logica.DatosClientes.Columns.Add("Dirección", typeof(string));
                Logica.DatosClientes.Columns.Add("Total a pagar", typeof(string));
                Logica.DatosClientes.Columns.Add("Jubilado/Pensionista", typeof(string));
                Logica.DatosClientes.Columns.Add("Turista", typeof(string));
            }
            if (ServiciosClientes.Columns.Count <= 0)
            {
                Logica.ServiciosClientes.Columns.Add("CI", typeof(string));
                Logica.ServiciosClientes.Columns.Add("Servicio", typeof(string));
                Logica.ServiciosClientes.Columns.Add("Fecha", typeof(string));
                Logica.ServiciosClientes.Columns.Add("Precio", typeof(string));
                Logica.ServiciosClientes.Columns.Add("Hora", typeof(string));
                Logica.ServiciosClientes.Columns.Add("Hora Retorno", typeof(string));
            }
            if (CapacidadesDiarias.Columns.Count <= 0)
            {
                Logica.CapacidadesDiarias.Columns.Add("Servicio", typeof(string));
                Logica.CapacidadesDiarias.Columns.Add("Fecha", typeof(string));
                Logica.CapacidadesDiarias.Columns.Add("CapacidadActual", typeof(int));
                Logica.CapacidadesDiarias.Columns.Add("CapacidadMaxima", typeof(int));
            }



            for (int i = 0; i < num.Next(36, 100); i++)
            {
                if (EsPrimo(i))
                {
                    DatosClientes.Rows.Add(i.ToString(), "Cliente" + i.ToString(), "Ejemplo" + i.ToString(), "Correo" + i.ToString(), "099" + i.ToString(), "Direccion" + i.ToString(), "10000", "NO", "NO");
                }
                else
                {
                    DatosClientes.Rows.Add(i.ToString(), "Cliente" + i.ToString(), "Ejemplo" + i.ToString(), "Correo" + i.ToString(), "099" + i.ToString(), "Direccion" + i.ToString(), "0", "NO", "NO");
                }


                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {

                        switch (num.Next(1, 14))
                        {

                            case 1:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Masaje Tradicional", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Masaje Tradicional", hoy.AddDays(k).ToString("yyyy-MM-dd"), 50);
                                 agregarCapacidad2("Masaje Tradicional", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Masaje Tradicional", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));

                                ServiciosClientes.Rows.Add(i.ToString(), "Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"), 75);
                                agregarCapacidad2("Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));

                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"), 200);
                                agregarCapacidad2("Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));

                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"), 200);
                                agregarCapacidad2("Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));

                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"), 80);
                                agregarCapacidad2("Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));

                                ServiciosClientes.Rows.Add(i.ToString(), "Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"), 90);
                                agregarCapacidad2("Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 2:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Masaje Oriental", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Masaje Oriental", hoy.AddDays(k).ToString("yyyy-MM-dd"), 50);
                                agregarCapacidad2("Masaje Oriental", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Masaje Oriental", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 3:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Yoga / Pilates", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Yoga / Pilates", hoy.AddDays(k).ToString("yyyy-MM-dd"), 5000);
                                agregarCapacidad2("Yoga / Pilates", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Yoga / Pilates", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 4:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Meditación", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Meditación", hoy.AddDays(k).ToString("yyyy -MM-dd"), 5000);
                                agregarCapacidad2("Meditación", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Meditación", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 5:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Bicicletas", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Bicicletas", hoy.AddDays(k).ToString("yyyy -MM-dd"), 5000);
                                agregarCapacidad2("Bicicletas", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Bicicletas", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 6:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Cabalgatas", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Cabalgatas", hoy.AddDays(k).ToString("yyyy -MM-dd"), 5000);
                                agregarCapacidad2("Cabalgatas", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Cabalgatas", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 7:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Botes", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Botes", hoy.AddDays(k).ToString("yyyy -MM-dd"), 5000);
                                agregarCapacidad2("Botes", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Botes", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 8:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Traslados", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Traslados", hoy.AddDays(k).ToString("yyyy -MM-dd"), 5000);
                                agregarCapacidad2("Traslados", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Traslados", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 9:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina abierta", hoy.AddDays(k).ToString("yyyy -MM-dd"), 200);
                                agregarCapacidad2("Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina abierta", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 10:

                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina cerrada", hoy.AddDays(k).ToString("yyyy -MM-dd"), 200);
                                agregarCapacidad2("Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina cerrada", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 11:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Piscina barro", hoy.AddDays(k).ToString("yyyy -MM-dd"), 80);
                                agregarCapacidad2("Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Piscina barro", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 12:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Sauna", hoy.AddDays(k).ToString("yyyy -MM-dd"), 75);
                                agregarCapacidad2("Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Sauna", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;
                            case 13:
                                if (num.Next(1, 7) == 5 || k == 5)
                                {
                                    k += 3;
                                }
                                if (num.Next(1, 7) == 3)
                                {
                                    k -= 2;
                                }
                                ServiciosClientes.Rows.Add(i.ToString(), "Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"), "0", hora.AddHours(j).ToString("HH:mm"), "----------");
                                agregarCapacidad("Hidromasaje", hoy.AddDays(k).ToString("yyyy -MM-dd"), 90);
                                agregarCapacidad2("Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"));
                                ReservarCupo("Hidromasaje", hoy.AddDays(k).ToString("yyyy-MM-dd"), hora.AddHours(j).ToString("HH:mm"));
                                break;

                        }


                    }
                }
                Logica.ContarClientesFecha();
            }
        }
        public static int calcularIngresos()
        {
            int x=0;
            foreach (DataRow dr in Logica.DatosClientes.Rows)
            {
                x += Int32.Parse(dr["Total a pagar"].ToString());   
            }
            return x;
            }
        //#############################################################################################  

    }
}



