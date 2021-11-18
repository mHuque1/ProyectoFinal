using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class Fecha
    {

        //##########################INSERT###################################
        public static bool AgregarHoras(string servicio, string fecha)
        {
            
            DateTime horaApertura = Convert.ToDateTime(Spa.GethoraApertura());
            DateTime horaCierre = Convert.ToDateTime(Spa.GethoraCierre());
            TimeSpan ts = horaCierre - horaApertura;
            int j;
            if (!CheckFecha(fecha, servicio))
            {
                try
                {
                    j = Convert.ToInt32(ts.TotalMinutes) / Servicio.GetPermanencia(servicio);
                    for (int i = 0; i < j; i++)
                    {
                        string Query = "insert into Pollux.fechas_disponibles(Servicio,Fecha,Hora,Cupos) values(@servicio,@fecha,@hora,@cupos);";
                        MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                        comando.Parameters.AddWithValue("@servicio", servicio);
                        comando.Parameters.AddWithValue("@fecha", fecha);
                        comando.Parameters.AddWithValue("@hora", horaApertura.AddMinutes(Servicio.GetPermanencia(servicio) * i).ToString("HH:mm:ss"));
                        comando.Parameters.AddWithValue("@cupos", Servicio.GetCupos(servicio));
                        if (fecha == DateTime.Today.ToString("yyyy-MM-dd"))
                        {
                            if (Convert.ToDateTime(horaApertura.AddMinutes(Servicio.GetPermanencia(servicio) * i).ToString("HH:mm:ss")) >= Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")))
                            {
                                ConexionBD.miConexion.Open();
                                comando.ExecuteReader();
                                ConexionBD.miConexion.Close();
                            }
                        }
                        else
                        {
                            ConexionBD.miConexion.Open();
                            comando.ExecuteReader();
                            ConexionBD.miConexion.Close();

                        }

                        ConexionBD.miConexion.Close();
                    }
                    return true;

                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("AgregarHoras: " + f.Message);
                    return false;
                }
            }
            return false;
        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static bool CheckFecha(string fecha, string servicio)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.fechas_disponibles WHERE Fecha= @fecha and Servicio=@servicio;";
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
                Console.WriteLine("CheckFecha: " + f.Message);
                return false;
            }
            return false;
        }
        public static int GetCuposHora(string servicio, string fecha, string hora)
        {
            int cupos = 0;
            try
            {
                string Query = "SELECT Cupos FROM Pollux.fechas_disponibles where Servicio= @servicio AND Fecha= @fecha AND Hora= @hora;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@hora", hora);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();
                
                    if (lector.Read())
                    {
                        cupos = lector.GetInt32("Cupos");
                        ConexionBD.miConexion.Close();
                        return cupos;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetCuposHora: " + f.Message);
                return cupos;
            }
            return cupos;
        }
        public static bool CargarHoras(ComboBox combo, string servicio, string fecha, ArrayList horasNoDisponibles, ArrayList horasNoDisponibles2, string ida, string vuelta, int ci,int nro)
        {
            ArrayList reservadas1 = HorasNoDisponiblesReservadas(nro);
            ArrayList reservadas2 = HorasNoDisponiblesReservadas2(nro);
            DateTime tiempo = new DateTime();
            DateTime tiempo2 = new DateTime();
            DateTime tiempo3 = new DateTime();
            DateTime idaHora = DateTime.MinValue;
            DateTime VueltaHora = DateTime.MaxValue;
            bool bandera = false;
            bool bandera2 = false;
            if (ida != "")
            {
                idaHora = Convert.ToDateTime(ida);
            }
            if (vuelta != "")
            {
                VueltaHora = Convert.ToDateTime(vuelta);
            }
            try
            {
                string Query = "SELECT Hora FROM Pollux.fechas_disponibles WHERE Servicio=@servicio  and Fecha= @fecha;";
                MySqlConnection miConexion = new MySqlConnection(ConexionBD.conexion);
                MySqlCommand comando = new MySqlCommand(Query, miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
                miConexion.Open();
                
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    int cupos = GetCuposHora(servicio, fecha, lector.GetString("Hora"));
                    int Capacidad = capacidadfecha.GetCapacidadFecha(servicio, fecha);
                    if (cupos > 0 || cupos == -1)
                    {
                        if (Capacidad > 0 || Capacidad == -1)
                        {
                            tiempo = Convert.ToDateTime(lector.GetString("Hora"));
                            bandera = false;
                            if (horasNoDisponibles.Count > 0)
                            {

                                if (!horasNoDisponibles.Contains(lector.GetString("Hora")) && !reservadas1.Contains(lector.GetString("Hora")))
                                {

                                    for (int i = 0; i < horasNoDisponibles.Count; i++)
                                    {
                                        tiempo2 = Convert.ToDateTime(horasNoDisponibles[i]);
                                        tiempo3 = Convert.ToDateTime(horasNoDisponibles2[i]);

                                        if (tiempo >= tiempo2 && tiempo < tiempo3)
                                        {
                                            bandera = true;
                                        }
                                    }

                                    for (int i = 0; i < reservadas1.Count; i++)
                                    {
                                        tiempo2 = Convert.ToDateTime(reservadas1[i]);
                                        tiempo3 = Convert.ToDateTime(reservadas2[i]);
                                        if (tiempo >= tiempo2 && tiempo < tiempo3)
                                        {
                                            bandera2 = true;
                                        }
                                    }
                                    
                                    if (!bandera && !bandera2)
                                    {
                                        if (tiempo > idaHora && tiempo < VueltaHora)
                                        {
                                            combo.Items.Add(lector.GetString("Hora"));
                                        }
                                        else if (servicio == "Traslado Ida")
                                        {
                                            if (tiempo < VueltaHora)
                                                combo.Items.Add(lector.GetString("Hora"));
                                        }
                                        else if (servicio == "Traslado Vuelta")
                                        {
                                            if (tiempo > idaHora)
                                                combo.Items.Add(lector.GetString("Hora"));
                                        }
                                    }

                                }
                            }
                            else
                            {

                                for (int i = 0; i < reservadas1.Count; i++)
                                {
                                    tiempo2 = Convert.ToDateTime(reservadas1[i]);
                                    tiempo3 = Convert.ToDateTime(reservadas2[i]);

                                    if (tiempo >= tiempo2 && tiempo < tiempo3)
                                    {
                                        bandera2 = true;
                                    }
                                }

                                if (!bandera2)
                                {
                                    combo.Items.Add(lector.GetString("Hora"));
                                }
                                bandera2 = false;
                            }
                        }
                    }
                }
                miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("AgregarHoras: " + f.Message);
                return false;
            }
        }
        //##########################SELECT###################################

        //##########################UPDATE###################################
        public static bool modificarCapacidad(string servicio, string fecha, bool SumarCapacidad)
        {
            int Capacidad = capacidadfecha.GetCapacidadFecha(servicio, fecha);
            if (Capacidad == -1)
            {
                return true;
            }
            else if (Capacidad > 0)
            {
                if (SumarCapacidad)
                    Capacidad += 1;
                else
                    Capacidad -= 1;
                try
                {

                    string Query = "UPDATE Pollux.capacidadfecha SET CapacidadActual =@Capacidad WHERE Servicio=@servicio and Fecha=@fecha;";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@Capacidad", Capacidad);
                    comando.Parameters.AddWithValue("@servicio", servicio);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    ConexionBD.miConexion.Open();
                    comando.ExecuteReader();
                    ConexionBD.miConexion.Close();
                    return true;
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("modificarCapacidad: " + f.Message);
                    return false;
                }
            }
            return false;
        }
        public static bool ModificarCupos(string fecha, string hora, string servicio, bool SumarCupo)
        {
            int cupos = GetCuposHora(servicio, fecha, hora);
            if (cupos == -1)
            {
                return true;
            }
            else if (cupos > 0)
            {
                if (SumarCupo)
                    cupos += 1;
                else
                    cupos -= 1;
                try
                {

                    string Query = "UPDATE Pollux.fechas_disponibles SET Cupos=@cupos WHERE Servicio=@servicio and Fecha= @fecha and Hora=@hora;";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@cupos", cupos);
                    comando.Parameters.AddWithValue("@servicio", servicio);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@hora", hora);
                    ConexionBD.miConexion.Open();
                    comando.ExecuteReader();
                    ConexionBD.miConexion.Close();
                    return true;
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("ModificarCupos: " + f.Message);
                    return false;
                }
            }
            return false;
        }
        //##########################UPDATE###################################

        public static ArrayList HorasNoDisponiblesReservadas(int nro)
        {

            DataTable datos = Datos.Reservas.CargarServiciosReservados(nro);
            ArrayList hola = new ArrayList();

            if(nro !=-1)
            {
                foreach (DataRow dr in datos.Rows)
                {
                    hola.Add(dr["Hora"].ToString());
                }
            }
           

            return hola;
        }
        public static ArrayList HorasNoDisponiblesReservadas2(int nro)
        {

            ArrayList hola = new ArrayList();
            DateTime xd = new DateTime();
            DataTable datos = Datos.Reservas.CargarServiciosReservados(nro);
            if (nro != -1)
            {
                foreach (DataRow dr in datos.Rows)
                {
                    xd = Convert.ToDateTime(dr["Hora"].ToString());
                    hola.Add(xd.AddMinutes(Datos.Servicio.GetPermanencia(dr["Servicio"].ToString())).ToString("HH:mm:ss"));
                }
            }

            return hola;


        }
      
    }
}
