using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class Reservas
    {
        //##########################SELECT###################################
        public static ArrayList CheckServiciosContratados(string cedula, string fecha)
        {
            ArrayList hola = new ArrayList();
            try
            {
                string Query = "SELECT Hora FROM Pollux.reservas where CI= @cedula and Fecha = @fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@fecha", fecha);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read())
                {
                    hola.Add(Lector.GetString("Hora"));
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CheckServiciosContratados:" + f.Message);
                return hola;
            }
            return hola;
        }
        public static bool CargarServiciosCliente(DataGridView tabla, int nro)
        {
            try
            {

                string Query = "select r.CI,r.Fecha, rs.nroReserva 'Nro. Reserva',rs.Hora,rs.Servicio,rs.Costo,rs.FechaRegistrado 'Fecha de registro',rs.Empleado from Pollux.reserva r join Pollux.reservas rs on r.IdReserva = rs.nroReserva where rs.nroReserva =@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                tabla.DataSource = dTable;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosCliente: " + f.Message);
                return false;
            }
            return true;
        }
        public static int ContarServiciosCliente(int cedula)
        {
            int servicios = 0;
            try
            {

                string Query = "SELECT COUNT(*) FROM Pollux.reserva r join Pollux.reservas rs on r.IdReserva = rs.nroReserva WHERE CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", cedula);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                servicios = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarServiciosCliente:" + f.Message);
                return servicios;
            }
            return servicios;
        }
        public static int ContarReservasRealizadasHoy()
        {
            int reservas = 0;
            try
            {

                string Query = "SELECT COUNT(DISTINCT nroReserva) FROM Pollux.reservas where CAST(FechaRegistrado AS date)=current_date();";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                reservas = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarReservasRealizadasHoy:" + f.Message);
                return reservas;
            }
            return reservas;
        }
        public static DataTable CargarServiciosReservados(int nro)
        {
            DataTable hola = new DataTable("Datos");
            try
            {
                string Query = "select * from Pollux.reservas where nroReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                hola = dt;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosReservados:" + f.Message);
            }
            return hola;
        }
        public static DataTable CargarServiciosReservados2(int nro)
        {
            DataTable hola = new DataTable("Datos");
            try
            {
                string Query = "select * from Pollux.reservas where nroReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                hola = dt;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosReservados:" + f.Message);
            }
            return hola;
        }
        public static int ContarClientesCurrentHora()
        {
            int Clientes = 0;
            try
            {

                string Query = "SELECT Count(nroReserva) FROM Pollux.reservas where hour(Hora)=hour(current_time());";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                Clientes = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarClientesCurrentHora: " + f.Message);
                return Clientes;
            }
            return Clientes;
        }
        //##########################SELECT###################################

        //##########################INSERT###################################
        public static bool ReservarServicio(int nroReserva, string hora, string servicio, int costo, int Empleado)
        {
            try
            {
                string Query = "insert into Pollux.reservas(nroReserva,Hora,Servicio,Costo,FechaRegistrado,Empleado) values(@nro,@hora,@servicio,@costo,@hoy,@Empleado);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@costo", costo);
                comando.Parameters.AddWithValue("@hoy", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                comando.Parameters.AddWithValue("@Empleado", Empleado);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ReservarServicio:" + f.Message);
                return false;
            }

        }
        //##########################INSERT###################################



        //##########################DELETE###################################
        public static bool BajaServicioCliente(int nro, string hora)
        {
            try
            {
                string Query = "delete from Pollux.reservas where nroReserva=@nro AND Hora=@hora;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@hora", hora);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read()) { }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BajaServicioCliente:" + f.Message);
                return false;
            }
            return true;
        }
        //##########################DELETE###################################


        //##########################UPDATE###################################
        public static bool CambiarHoraReserva(int nro, string horaVieja, string horaNueva)
        {
            try
            {
                string Query = "UPDATE Pollux.reservas SET Hora=@horaNueva WHERE nroReserva=@nro and Hora= @horaVieja;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@horaNueva", horaNueva);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@horaVieja", horaVieja);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CambiarHoraReserva:" + f.Message);
                return false;
            }
            return true;
        }
        //##########################UPDATE###################################
    }
}
