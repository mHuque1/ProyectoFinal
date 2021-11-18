using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class acompañantes
    {
        public static bool agregarAcompañante(int ci,int ciAcompañante, string fecha)
        {
            try
            {
                string Query = "insert into Pollux.acompañante(CI,CIAcompañante,fecha) values(@ci,@ciAcompañante,@fecha);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@ciAcompañante", ciAcompañante);
                comando.Parameters.AddWithValue("@fecha", fecha);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("agregarAcompañante: " + f.Message);
                return false;
            }

        }
        public static bool CargarAcompañantes (DataGridView tabla,string fecha, int ci)
        {
            try
            {

                string Query = "SELECT c.CI,c.Nombre, c.Apellido,c.Correo,c.Telefono,c.Direccion 'Dirección',c.FechaNacimiento 'Fecha Nacimiento',c.Entrada FROM Pollux.cliente c join Pollux.acompañante a on c.CI=a.CIAcompañante where a.fecha=@fecha and a.CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@fecha", fecha);
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
                Console.WriteLine("CargarAcompañantes: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool BajaAcompañante (int ci,int ci2,string fecha)
        {
            try
            {
                string Query = "delete from Pollux.acompañante where CI=@ci and CIAcompañante=@ci2 and fecha=@Fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@ci2", ci2);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BajaCliente: " + f.Message);
                return false;
            }
            return true;
        }

    }
}
