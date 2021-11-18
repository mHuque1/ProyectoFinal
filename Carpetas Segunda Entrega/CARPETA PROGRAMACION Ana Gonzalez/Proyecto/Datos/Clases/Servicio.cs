using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class Servicio
    {
        //##########################SELECT###################################
        public static ArrayList GetServicios()
        {
            ArrayList hola = new ArrayList();
            try
            {
                string Query = "SELECT nombre FROM Pollux.servicio";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read())
                {
                    hola.Add(Lector.GetString("Nombre"));
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("GetServicios: " + f.Message);
            }
            return hola;
        }
        public static int VerificiarPrecio(string servicio)
        {
            int costo = 0;
            try
            {
                string Query = "SELECT Costo FROM Pollux.servicio where Nombre= @servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    costo = lector.GetInt32("Costo");
                    ConexionBD.miConexion.Close();
                    return costo;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("verificiarPrecio: " + f.Message);
                return costo;
            }
            return costo;
        }
        public static bool MostrarTablaServicios(DataGridView tabla)
        {
            try
            {
                string Query = "select Nombre Servicio,CapacidadMax 'Capacidad Diaria',PermanenciaMinutos 'Permanencia (Minutos)', CuposMax Cupos, Costo, Habilitado from Pollux.servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
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
                MessageBox.Show("MostrarTablaServicios: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool BuscarServicio(string servicio, DataGridView tabla)
        {
            MessageBox.Show(servicio);
            try
            {

                string Query = "SELECT Nombre Servicio,CapacidadMax 'Capacidad Diaria',PermanenciaMinutos 'Permanencia (Minutos)', CuposMax Cupos, Costo from Pollux.servicio WHERE Nombre like ('%" + servicio + "%');";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                //comando.Parameters.AddWithValue("@servicio", servicio);
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
                MessageBox.Show("BuscarServicio: " + f.Message);
                return false;
            }
            return true;
        }
        public static int GetPermanencia(string servicio)
        {
            int permanencia = 0;
            try
            {
                string Query = "SELECT PermanenciaMinutos FROM Pollux.servicio where Nombre= @servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    permanencia = lector.GetInt32("PermanenciaMinutos");
                    ConexionBD.miConexion.Close();
                    return permanencia;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("getPermanencia: " + f.Message);
                return permanencia;
            }
            return permanencia;
        }
        public static int GetCupos(string servicio)
        {
            int cupos = 0;
            try
            {
                string Query = "SELECT CuposMax FROM Pollux.servicio where Nombre= @servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    cupos = lector.GetInt32("CuposMax");
                    ConexionBD.miConexion.Close();
                    return cupos;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("GetCupos: " + f.Message);
                return cupos;
            }
            return cupos;
        }
        public static int GetCapacidadMaxima(string servicio)
        {
            int capacidad = 0;
            try
            {
                string Query = "SELECT CapacidadMax FROM Pollux.servicio where Nombre= @servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    capacidad = lector.GetInt32("CapacidadMax");
                    ConexionBD.miConexion.Close();
                    return capacidad;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("GetCapacidadMaxima: " + f.Message);
                return capacidad;
            }
            return capacidad;
        }
        public static int GetPorcentajeServiciosHabilitados()
        {
            int PorcentajeConfirmados = 0;
            try
            {
                string Query = "Select Floor((SELECT Count(Habilitado) FROM Pollux.servicio where Habilitado=1)/(SELECT Count(Habilitado) FROM Pollux.servicio)*100) Porcentaje;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                PorcentajeConfirmados = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();

            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetPorcentajeServiciosHabilitados: " + f.Message);
                return PorcentajeConfirmados;
            }
            return PorcentajeConfirmados;
        }
        public static bool GetHabilitado(string servicio)
        {
            bool ekisde = false;
            try
            {
                string Query = "SELECT Habilitado FROM Pollux.servicio where Nombre= @servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    ekisde = lector.GetBoolean("Habilitado");
                    ConexionBD.miConexion.Close();
                    return ekisde;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("GetHabilitado: " + f.Message);
                return ekisde;
            }
            return ekisde;
        }
        //##########################SELECT###################################

        //##########################INSERT###################################
        public static bool AltaServicio(string nombre,int capacidadMax, int permanenciaMinutos,int cuposMax, int costo)
        {
            try
            {

                string Query = "insert into Pollux.servicio(Nombre,CapacidadMax,PermanenciaMinutos,CuposMax, Costo)" +
                    "values(@Nombre,@CapacidadMax,@PermaneciaMinutos,@CuposMax,@Costo);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@Nombre",nombre);
                comando.Parameters.AddWithValue("@CapacidadMax", capacidadMax);
                comando.Parameters.AddWithValue("@PermaneciaMinutos", permanenciaMinutos);
                comando.Parameters.AddWithValue("@CuposMax", cuposMax);
                comando.Parameters.AddWithValue("@Costo", costo);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("AltaServicio: " + f.Message);
                return false;
            }
        }
        //##########################INSERT###################################

        //##########################DELETE###################################
        public static bool BajaServicio(string nombre)
        {
            try
            {

                string Query = "DELETE FROM Pollux.servicio WHERE Nombre=@nombre;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("BajaServicio: " + f.Message);
                return false;
            }
        }
        //##########################DELETE###################################


        //##########################UPDATE###################################
        public static bool ModificarServicio(string nombre, int capacidad, int permanencia, int cupos, int costo, int hab, string servicio)
        {
            try
            {

                string Query = "UPDATE Pollux.servicio SET Nombre=@nombre, CapacidadMax=@capacidad,PermanenciaMinutos=@permanencia," +
                    "CuposMax=@cupos, Costo=@costo, Habilitado=@hab WHERE Nombre=@servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@capacidad", capacidad);
                comando.Parameters.AddWithValue("@permanencia", permanencia);
                comando.Parameters.AddWithValue("@cupos", cupos);
                comando.Parameters.AddWithValue("@costo", costo);
                comando.Parameters.AddWithValue("@hab", hab);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("ModificarServicio: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool HabilitarDesabilitarServicio(string servicio,bool deshabilitar,string fecha)
        {
            try { 
            DateTime Fecha = Convert.ToDateTime(fecha);
                
                string Query;
            MySqlCommand comando = new MySqlCommand();
            if (deshabilitar)
            {
                if(Fecha.Date == DateTime.Today.Date)
                {
                    Query = "UPDATE Pollux.servicio SET Habilitado= '0',FechaDeDeshabilitacion = @fecha WHERE Nombre=(@servicio);";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@fecha", Fecha.ToString("yyyy-MM-dd HH:mm:ss"));

                    }
                else
                {
                     Query = "UPDATE Pollux.servicio SET FechaDeDeshabilitacion = @fecha WHERE Nombre = @servicio;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@fecha", Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                }

            }
            if (!deshabilitar)
            { 

                        Query = "UPDATE Pollux.servicio SET FechaDeHabilitacion = @fecha WHERE Nombre = @servicio;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
            }
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();

            ConexionBD.miConexion.Close();

            return true;
            }catch(Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("HabilitarDesabilitarServicio: " + f.Message);
                return false;
            }
        }
        //##########################UPDATE###################################

    }
}
