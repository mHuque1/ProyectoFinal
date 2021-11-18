using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Reservas
    {
        public static ArrayList checkServiciosContratados(string cedula, string fecha)
        {
            return Datos.Reservas.CheckServiciosContratados(cedula, fecha);
        }
        public static bool cargarServiciosCliente(DataGridView tabla, int nro)
        {
            return Datos.Reservas.CargarServiciosCliente(tabla, nro);
        }
        public static int contarServiciosCliente(int cedula)
        {
            return Datos.Reservas.ContarServiciosCliente(cedula);
        }
        public static DataTable cargarServiciosReservados(int nro)
        {
            return Datos.Reservas.CargarServiciosReservados(nro);
        }
        public static DataTable cargarServiciosReservados2(int ci)
        {
            return Datos.Reservas.CargarServiciosReservados2(ci);
        }
        public static bool ReservarServicio(int nro, string hora, string servicio, int costo, int Empleado)
        {
            return Datos.Reservas.ReservarServicio(nro, hora, servicio, costo, Empleado);
        }
        public static bool bajaServicioCliente(int nro, string hora)
        {
            return Datos.Reservas.BajaServicioCliente(nro,hora);
        }
        public static bool cambiarHoraReserva(int nro, string horaVieja, string horaNueva)
        {
            return Datos.Reservas.CambiarHoraReserva(nro, horaVieja, horaNueva);
        }
        public static int ContarReservasRealizadasHoy()
        {
            return Datos.Reservas.ContarReservasRealizadasHoy();
        }
        public static int ContarClientesCurrentHora()
        {
            return Datos.Reservas.ContarClientesCurrentHora();
        }
        }
}
