using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Reserva
    {
        public static bool ReservarServicio(string fecha, int ci, int confirmada, int APagar, int total, string medioDePago)
        {
            return Datos.Reserva.CrearReserva(fecha, ci, confirmada, APagar, total, medioDePago);
        }
        public static int GetIdReserva(string fecha, int ci)
        {
            return Datos.Reserva.GetIdReserva(fecha, ci);
        }
        public static bool CargarReservaCliente(DataGridView tabla, int ci)
        {
            return Datos.Reserva.CargarReservaCliente(tabla, ci);
        }
        public static bool sumarTotal(int nro, int valor)
        {
            return Datos.Reserva.SumarTotal(nro, valor);
        }
        public static bool SumarAPagar(int nro, int valor)
        {
            return Datos.Reserva.SumarAPagar(nro, valor);
        }
        public static bool borrarConfirmacion(int nro, int valor)
        {
            return Datos.Reserva.borrarConfirmacion(nro, valor);
        }
        public static bool SumarTotalAPagarCliente(int ci)
        {
            return Datos.Reserva.SumarTotalAPagarCliente(ci);
        }
        public static bool SetAPagar(int idReserva, int valor)
        {
            return Datos.Reserva.SetAPagar(idReserva, valor);
        }
        public static int ContarClientesHoy()
        {
            return Datos.Reserva.ContarClientesHoy();
        }
        public static int IngresosEstaSemana()
        {

            return Datos.Reserva.IngresosEstaSemana();
        }
        public static DataTable ServiciosMasReservados(string rango)
        {
            return Datos.Reserva.ServiciosMasReservados(rango);
        }
        public static DataTable NroClientes(string rango)
        {
            return Datos.Reserva.NroClientes(rango);
        }
        public static int GetPorcentajeConfirmados()
        {
            return Datos.Reserva.GetPorcentajeConfirmados();
        }

        public static bool BorrarDelCostoTotalXCantidad(int nroReserva, int valor)
        {
            return Datos.Reserva.BorrarDelCostoTotalXCantidad(nroReserva,valor);
        }
        public static bool BorrarDeAPagarXCantidad(int nroReserva, int valor)
        {
            return Datos.Reserva.BorrarDeAPagarXCantidad(nroReserva, valor);
        }
        public static bool BorrarSoloReserva(int nro)
        {
            return Datos.Reserva.BorrarSoloReserva(nro);
        }
        public static bool BorrarReservaCompleta(int nro, string fecha)
        {
            return Datos.Reserva.BorrarReservaCompleta(nro,fecha);
        }
        public static bool borrarTodasReservasCliente(int ci)
        {
            return Datos.Reserva.borrarTodasReservasCliente(ci);
        }
        }
}
