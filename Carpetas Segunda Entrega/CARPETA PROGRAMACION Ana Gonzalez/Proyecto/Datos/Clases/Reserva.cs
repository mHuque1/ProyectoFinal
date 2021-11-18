
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
   public class Reserva
    {
        public static bool CrearReserva(string fecha, int ci, int confirmada, int aPagar,int total, string medioDePago)
        {
            try
            {

                string Query = "insert into Pollux.reserva(Fecha,CI,Confirmada,APagar,CostoTotal,MedioDePago) values(@fecha,@ci,@Confirmada,@aPagar,@total,@MedioDePago);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@Confirmada", confirmada);
                comando.Parameters.AddWithValue("@aPagar", aPagar);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@MedioDePago", medioDePago);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CrearReserva: " + f.Message);
                return false;
            }

        }
        public static int GetIdReserva(string fecha, int ci)
        {
            int id = -1;
            try
            {
                string Query = "select IdReserva from Pollux.reserva where Fecha=@fecha and CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    id = lector.GetInt32("IdReserva");
                    ConexionBD.miConexion.Close();
                    return id;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetIdReserva: " + f.Message);
                return id;
            }
            return id;
        }
        public static bool CargarReservaCliente(DataGridView tabla, int ci)
        {
            try
            {

                string Query = "select * from Pollux.reserva where CI =@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
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
                Console.WriteLine("CargarReservaCliente: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool SumarTotal(int nro,int valor)
        {
            int suma = 0;
            try
            {

                string Query = "select CostoTotal from Pollux.reserva where IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("CostoTotal");
                    ConexionBD.miConexion.Close();
                   
                }
                ConexionBD.miConexion.Close();
                suma += valor;
                Query = "update Pollux.reserva set CostoTotal=@suma where IdReserva=@nro;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@suma", suma);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("SumarTotal: " + f.Message);
                return false;
            }
        }
        public static bool SumarAPagar(int nro, int valor)
        {
            int suma = 0;
            try
            {

                string Query = "select APagar from Pollux.reserva where IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("APagar");
                    ConexionBD.miConexion.Close();

                }
                ConexionBD.miConexion.Close();
                suma += valor;
                Query = "update Pollux.reserva set APagar=@suma where IdReserva=@nro;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@suma", suma);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("sumarAPagar: " + f.Message);
                return false;
            }
        }
        public static bool SumarTotalAPagarCliente(int ci)
        {
            int suma = 0;
            try
            {

                string Query = "select sum(APagar) from Pollux.reserva where CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    if(!lector.IsDBNull(0))
                        suma = lector.GetInt32("sum(APagar)");
                    ConexionBD.miConexion.Close();

                }
                ConexionBD.miConexion.Close();
                
                Query = "update Pollux.cliente set TotalAPagar=@suma where CI=@ci;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@suma", suma);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("SumarTotalAPagarCliente: " + f.Message);
                return false;
            }
        }
        public static bool borrarConfirmacion(int nro, int valor)
        {
            int confirmado= 1;
            int suma = 0;
            try
            {

                string Query = "select APagar,Confirmada from Pollux.reserva where IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("APagar");
                    confirmado = lector.GetInt32("Confirmada");
                    ConexionBD.miConexion.Close();

                }
                ConexionBD.miConexion.Close();
                suma -= valor;
                if (suma > 0)
                {
                    confirmado = 0;
                }
                Query = "update Pollux.reserva set APagar=@suma,Confirmada=@confirm where IdReserva=@nro;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@suma", suma);
                comando.Parameters.AddWithValue("@confirm", confirmado);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetCosto: " + f.Message);
                return false;
            }
        }
        public static bool SetAPagar(int idReserva,int valor)
        {
            try {
                string Query = "";
                MySqlCommand comando = new MySqlCommand();
                if (valor <= 0)
                {
                   Query = "update Pollux.reserva set APagar=0, Confirmada=1 where IdReserva=@nro;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@nro", idReserva);
                }
                else
                {
                    Query = "update Pollux.reserva set APagar=@valor, Confirmada=0 where IdReserva=@nro;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters.AddWithValue("@nro", idReserva);
                } 
            ConexionBD.miConexion.Open();
            comando.ExecuteReader();
            ConexionBD.miConexion.Close();
            return true;

            } catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("SetAPagar: " + f.Message);
                return false;
            }
}
        public static int ContarClientesHoy()
        {
            int Clientes = 0;
            try
            {

                string Query = "SELECT COUNT(DISTINCT CI) FROM Pollux.reserva where Fecha = current_date();";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                Clientes = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarClientesHoy:" + f.Message);
                return Clientes;
            }
            return Clientes;
        }
        public static int ContarReservasRealizadasHoy()
        {
            int Clientes = 0;
            try
            {

                string Query = "SELECT COUNT(DISTINCT nroReserva) FROM Pollux.reservas where CAST(FechaRegistrado AS date)=current_date();";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                Clientes = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarReservasRealizadasHoy:" + f.Message);
                return Clientes;
            }
            return Clientes;
        }
        public static int IngresosEstaSemana()
        {
            int Ingresos = 0;
            try
            {
                string Query = "SELECT Sum(CostoTotal) FROM Pollux.reserva where Confirmada=1 and Fecha>=current_Date() and Fecha<=DATE_ADD(current_Date(), INTERVAL 7 DAY);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                Ingresos = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("IngresosEstaSemana: " + f.Message);
                return Ingresos;
            }
            return Ingresos;
        }
        public static DataTable ServiciosMasReservados(string rango)
        {
            string Query = "";
            if (rango == "Hoy")
            {
                Query = "SELECT r.Fecha,rs.Servicio,count(rs.Servicio) 'Nro Reservas' FROM Pollux.reservas rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Fecha=Current_date() group by rs.Servicio order by count(rs.Servicio) desc limit 5;";
            }
            else if (rango == "Esta Semana")
            {
                Query = "SELECT r.Fecha,rs.Servicio,count(rs.Servicio) 'Nro Reservas' FROM Pollux.reservas rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Fecha>=Current_date() and Fecha<=DATE_ADD(Current_date(), INTERVAL 7 DAY) group by rs.Servicio order by count(rs.Servicio) desc limit 5;";
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
                Console.WriteLine("ServiciosMasReservados: " + f.Message);
                return xd;
            }
        }
        public static DataTable NroClientes(string rango)
        {
            string Query = "";
            if (rango == "Esta Semana")
            {
                Query = "SELECT Fecha, count(CI) Clientes FROM Pollux.reserva where Fecha>=Current_Date() and Fecha<=(date_add(Current_Date(),interval 7 day)) group by Fecha asc;";
            }
            else if (rango == "Este Mes")
            {
                Query = "SELECT Fecha, count(CI) Clientes FROM Pollux.reserva where Fecha>=Current_Date() and Fecha<=(date_add(Current_Date(),interval 1 month)) group by Fecha asc;";
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
                Console.WriteLine("NroClientes: " + f.Message);
                return xd;
            }
        }
        public static int GetPorcentajeConfirmados()
        {
            int PorcentajeConfirmados = 0;
            try
            {
                string Query = "select floor((SELECT (count(Confirmada)) FROM Pollux.reserva where Confirmada=1 and Fecha>=Current_date())/(SELECT (count(IdReserva)) FROM Pollux.reserva Where Fecha>=Current_date())*100) Porcentaje;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                PorcentajeConfirmados = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
                
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetPorcentajeConfirmados:" + f.Message);
                return PorcentajeConfirmados;
            }
            return PorcentajeConfirmados;
        }
        public static bool BorrarDelCostoTotalXCantidad(int nroReserva, int valor)
        {
            int suma = 0;
            try
            {

                string Query = "select CostoTotal from Pollux.reserva where IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("CostoTotal");
                    ConexionBD.miConexion.Close();
                }
                ConexionBD.miConexion.Close();
                suma -= valor;
                if (suma <= 0)
                    suma = 0;
                Query = "update Pollux.reserva set CostoTotal=@suma where IdReserva=@nro;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@suma", suma);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BorrarDelCostoTotalXCantidad: " + f.Message);
                return false;
            }
        }
        public static bool BorrarDeAPagarXCantidad(int nroReserva, int valor)
        {
            int suma = 0;
            try
            {

                string Query = "select APagar from Pollux.reserva where IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("APagar");
                    ConexionBD.miConexion.Close();
                }
                ConexionBD.miConexion.Close();
                suma -= valor;
                if (suma <= 0)
                    suma = 0;
                Query = "update Pollux.reserva set APagar=@suma where IdReserva=@nro;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@suma", suma);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BorrarDeAPagarXCantidad: " + f.Message);
                return false;
            }
        }
        public static bool BorrarSoloReserva(int nro)
        {
                try
                {
                    string Query = "delete from Pollux.reserva where IdReserva=@nro;";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@nro", nro);
                    ConexionBD.miConexion.Open();
                    comando.ExecuteReader();
                    ConexionBD.miConexion.Close();
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("BorrarSoloReserva: " + f.Message);
                    return false;
                }
                return true;
            }
        public static bool BorrarReservaCompleta(int nro,string fecha)
        {
            
             string conexion = "datasource = 192.168.2.53; port = 3306; username = mhuque; password = 53936800; persistsecurityinfo = True; SSL Mode = None"; //string para conectar
             MySqlConnection miConexion = new MySqlConnection(conexion);
                string Fecha1 = Convert.ToDateTime(fecha).ToString("yyyy/MM/dd");
            try
            {
                string Query = "Select Hora, Servicio from Pollux.reservas where nroReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, miConexion);
                comando.Parameters.AddWithValue("@nro", nro);

                miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                    Fecha.modificarCapacidad(lector.GetString("Servicio"), Fecha1, true);
                    Fecha.ModificarCupos(Fecha1, lector.GetString("Hora"), lector.GetString("Servicio"), true);
                }
                miConexion.Close();
                BorrarSoloReserva(nro);
            }
            catch (Exception f)
            {
                miConexion.Close();
                Console.WriteLine("BorrarReservaCompleta: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool borrarTodasReservasCliente(int ci)
        {
            string conexion = "datasource = 192.168.2.53; port = 3306; username = mhuque; password = 53936800; persistsecurityinfo = True; SSL Mode = None"; //string para conectar
            MySqlConnection miConexion = new MySqlConnection(conexion);
            try
            {
                string Query = "Select IdReserva, Fecha from Pollux.reserva where CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    MessageBox.Show(lector.GetInt32("IdReserva")+ lector.GetString("Fecha"));
                    BorrarReservaCompleta(lector.GetInt32("IdReserva"),lector.GetString("Fecha"));
                }
                miConexion.Close();
                Cliente.BajaCliente(ci);
            }
            catch (Exception f)
            {
                miConexion.Close();
                Console.WriteLine("BorrarReservaCompleta: " + f.Message);
                return false;
            }
            return true;
        }
    }
}
