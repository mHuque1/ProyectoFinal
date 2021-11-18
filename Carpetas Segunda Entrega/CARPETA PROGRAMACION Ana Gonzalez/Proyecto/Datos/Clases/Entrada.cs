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
    public class Entrada
    {


        public static bool MostrarTablaEntradas(DataGridView tabla)
        {
            try
            {
                string Query = "select TipoEntrada Entrada,Costo,Habilitada from Pollux.entrada;";
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
                Console.WriteLine("MostrarTablaEntradas: " + f.Message);
                return false;
            }
            return true;
        }
        public static int GetPrecioEntrada(string servicio)
        {
            int costo = 0;
            try
            {

                string Query = "SELECT Costo FROM Pollux.entrada where TipoEntrada= @servicio;";
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
            catch (Exception e)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("Costo entrada: " + e.Message);
                return costo;
            }
            return costo;
        }
        public static bool MostrarEntradas(ComboBox cb)
        {
            try
            {
                string Query = "SELECT TipoEntrada FROM Pollux.entrada where Habilitada=1;";
                MySqlConnection miConexion = new MySqlConnection(ConexionBD.conexion);
                MySqlCommand comando = new MySqlCommand(Query, miConexion);
                miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    cb.Items.Add(lector.GetString("TipoEntrada"));
                }
                miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("MostrarEntradas: " + f.Message);
                return false;
            }
        }
        public static bool GetHabilitadaEntrada(string Entrada)
        {
            bool costo = false;
            try
            {

                string Query = "SELECT Habilitada FROM Pollux.entrada where TipoEntrada= @Entrada;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@Entrada", Entrada);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    costo = lector.GetBoolean("Habilitada");
                    ConexionBD.miConexion.Close();
                    return costo;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception e)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("GetHabilitadaEntrada: " + e.Message);
                return costo;
            }
            return costo;
        }

        public static bool AltaEntrada(string nombre, int costo)
        {
            try
            {

                string Query = "insert into Pollux.entrada(TipoEntrada,Costo)" +
                    "values(@Nombre,@Costo);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Costo", costo);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("AltaEntrada: " + f.Message);
                return false;
            }
        }

        public static bool modificarEntrada(string tipo, int costo, int habilitada, string entrada)
        {
            try
            {

                string Query = "UPDATE Pollux.entrada SET TipoEntrada= @tipo,Costo= @costo,Habilitada= @habilitada WHERE TipoEntrada=@entrada;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@costo", costo);
                comando.Parameters.AddWithValue("@habilitada", habilitada);
                comando.Parameters.AddWithValue("@entrada", entrada);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("ModificarPrecio: " + f.Message);
                return false;
            }
            return true;
        }
    }
}
