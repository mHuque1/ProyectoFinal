using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class ConexionBD
    {
        public static string conexion = "datasource = 192.168.2.53; port = 3306; username = wantognazza; password = 54197669; persistsecurityinfo = True; SSL Mode = None"; //string para conectar
        public static MySqlConnection miConexion = new MySqlConnection(conexion);

        public static bool ConexionEstable()
        {
            try
            {
                miConexion.Open();
                miConexion.Close();
                return true;
            }
            catch (Exception f) {
                miConexion.Close();
                MessageBox.Show("ERROR: "+f.Message);
                return false;
            }
        }
        //public static void ModificarString(string rol)
        //{
        //     if(rol == "Gerente")
        //    { 
        //        conexion = "datasource = localhost; port = 3306; username = Gerente; password = \\{,6=fp*d`:;&FwpS2fRyBG\\&rf+w^mzvJ5; persistsecurityinfo = True; SSL Mode = None";   
        //
        //    }
        //    if (rol == "Administrativo")
        //    {
        //        conexion = "datasource = localhost; port = 3306; username = Administrador; password = 8XTFL,j-7hq3>5sM6*Ty; persistsecurityinfo = True; SSL Mode = None";
        //    }
        //    else
        //    {
        //        conexion = "datasource = localhost; port = 3306; username = Empleado; password = _$`\"d7p5fe+'LZrx; persistsecurityinfo = True; SSL Mode = None";
        //    }
        //
        //}

    }
}
