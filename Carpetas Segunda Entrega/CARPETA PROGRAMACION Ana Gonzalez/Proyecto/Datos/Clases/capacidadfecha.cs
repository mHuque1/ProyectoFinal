using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos
{
    public class capacidadfecha
    {

        //##########################INSERT###################################
        public static bool AgregarCapacidad(string servicio, string fecha)
        {
            int capMax = Servicio.GetCapacidadMaxima(servicio);
            if (!CheckFechaCapacidad(fecha, servicio))
            {
                try
                {
                    string Query = "INSERT INTO Pollux.capacidadfecha (`Servicio`, `Fecha`, `CapacidadActual`) VALUES (@servicio,@fecha,@capMax);";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@servicio", servicio);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@capMax", capMax);
                    MySqlDataReader Lector;
                    ConexionBD.miConexion.Open();
                    Lector = comando.ExecuteReader();
                    while (Lector.Read()) { }
                    ConexionBD.miConexion.Close();
                    return true;
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("AgregarCapacidad:" + f.Message);
                    return false;
                }

            }
            return false;
        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static int GetCapacidadFecha(string servicio, string fecha)
        {
            int capacidad = 0;
            try
            {
                string Query = "SELECT CapacidadActual FROM Pollux.capacidadfecha where Servicio= @servicio AND Fecha= @fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio",servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                     {
                        capacidad = lector.GetInt32("CapacidadActual");
                        ConexionBD.miConexion.Close();
                        return capacidad;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("getCapacidadFecha:" + f.Message);
                return capacidad;
            }
            return capacidad;
        }
        public static bool CheckFechaCapacidad(string fecha, string servicio)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.capacidadfecha WHERE Fecha= @fecha and Servicio=@servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();

                if (Convert.ToInt32(obj) > 0)
                {
                    ConexionBD.miConexion.Close();
                    return true;

                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("checkFechaCapacidad:" + f.Message);
                return false;
            }
            return false;
        }
        public static DataTable OcupacionServiciosTop(string rango)
        {
            string Query = "";
            if (rango == "Hoy")
            {
                Query = "SELECT r.Fecha,rs.Servicio, Floor((100-(cf.CapacidadActual*100/s.CapacidadMax))) 'Porcentaje' FROM Pollux.reservas rs join Pollux.reserva r join Pollux.servicio s join Pollux.capacidadfecha cf on rs.nroReserva = r.IdReserva and s.Nombre = rs.Servicio  and cf.Servicio = rs.Servicio where r.Fecha=Current_date() group by rs.Servicio order by count(rs.servicio) desc limit 5; ";
            }
            else if (rango == "Esta Semana")
            {
                Query = "SELECT r.Fecha,rs.Servicio,count(rs.Servicio) 'Nro Reservas' FROM Pollux.reservas rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Fecha>=Current_date() and Fecha<=DATE_ADD(Current_date(), INTERVAL 7 DAY) group by rs.servicio order by count(rs.Servicio) desc limit 5;";
            }
            else if (rango == "Este Mes")
            {
                Query = "SELECT r.Fecha,rs.Servicio,count(rs.Servicio) 'Nro Reservas' FROM Pollux.reservas rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Fecha>=Current_date() and Fecha<=DATE_ADD(Current_date(), INTERVAL 1 month) group by rs.Servicio order by count(rs.Servicio) desc limit 5;";
            }
            DataTable xd = new DataTable("");
            try
            {

                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                ConexionBD.miConexion.Open();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(xd);
                ConexionBD.miConexion.Close();
                return xd;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("OcupacionServiciosTop: " + f.Message);
                return xd;
            }
        }
        //##########################SELECT###################################
    }
}
