using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Spa
    {
        //##########################SELECT###################################
        public static string GethoraApertura()
        {
            string apertura = "";
            try
            {
                string Query = "SELECT horaApertura FROM Pollux.spa where Nombre= 'Onsen';";
               
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        apertura = lector.GetString("horaApertura");
                        ConexionBD.miConexion.Close();
                        return apertura;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GethoraApertura:" + f.Message);
                return apertura;
            }
            return apertura;
        }
        public static string GethoraCierre()
        {
            string cierre = "";
            try
            {
                string Query = "SELECT horaCierre FROM Pollux.spa where Nombre= 'Onsen';";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                
                    if (lector.Read())
                    {
                        cierre = lector.GetString("horaCierre");
                        ConexionBD.miConexion.Close();
                        return cierre;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GethoraCierre:" + f.Message);
                return cierre;
            }
            return cierre;
        }
        public static Image CargarlogoSpa()
        {

            byte[] DatosImagen;
            try
            {
                string Query = "SELECT logo FROM Pollux.spa;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    DatosImagen = (byte[])(lector["logo"]);
                    ConexionBD.miConexion.Close();
                    MemoryStream ms = new MemoryStream(DatosImagen);
                    return Image.FromStream(ms);
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarlogoSpa: " + f.Message);
                return null;
            }
            return null;
        }
        public static Image CargarlogoAColorSpa()
        {

            byte[] DatosImagen;
            try
            {
                string Query = "SELECT logoAColor FROM Pollux.spa;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    DatosImagen = (byte[])(lector["logoAColor"]);
                    ConexionBD.miConexion.Close();
                    MemoryStream ms = new MemoryStream(DatosImagen);
                    return Image.FromStream(ms);
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarlogoSpa: " + f.Message);
                return null;
            }
            return null;
        }
        //##########################SELECT###################################
    }
}
