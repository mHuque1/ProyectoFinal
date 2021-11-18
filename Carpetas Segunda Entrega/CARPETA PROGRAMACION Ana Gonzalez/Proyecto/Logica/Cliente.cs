using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
namespace Logica
{
    public class Cliente
    {
        public static bool ReservarCliente(int ci, string nombre, string apellido, string correo, string telefono, string direccion,string entrada, int total, string nacimiento)
        {
           return Datos.Cliente.ReservarCliente(ci, nombre, apellido, correo, telefono, direccion, entrada, total,nacimiento);
        }
        public static bool CargarClientes(DataGridView tabla)
        {
            return Datos.Cliente.CargarClientes(tabla);
        }
        public static bool CheckClienteExiste(int cedula)
        {
            return Datos.Cliente.CheckClienteExiste(cedula);
        }
        public static bool CheckReservaExiste(int ci, string fecha)
        {
            return Datos.Cliente.CheckReservaExiste(ci, fecha);
        }
        public static bool cargarDatosClienteExistente(BunifuTextBox Cedula, BunifuTextBox Nombre, BunifuTextBox Apellido, BunifuTextBox Correo, BunifuTextBox Telefono, BunifuTextBox Direccion, ComboBox cb,BunifuDatePicker fecha)
        {
            return Datos.Cliente.CargarDatosClienteExistente(Cedula,Nombre,Apellido,Correo,Telefono,Direccion,cb,fecha);

        }
        public static bool bajaCliente(int ci)
        {
          return Datos.Cliente.BajaCliente(ci);
        }
        public static int getTotalAPagar(int ci)
        {
            return Datos.Cliente.GetTotalAPagar(ci);
        }
        public static bool modificarCliente(int ci, int ci2, string nombre, string apellido, string correo, string telefono, string direccion,string nacimiento,string entrada, int totalAPagar)
        {
            return Datos.Cliente.ModificarCliente(ci,ci2,nombre,apellido,correo,telefono,direccion,nacimiento,entrada,totalAPagar);
        }
        public static bool quitarPrecioServicio(int ci, int valor)
        {
            return Datos.Cliente.QuitarPrecioServicio(ci, valor);
        }
        public static bool BuscarCliente(DataGridView tabla, string filtro)
        {
            return Datos.Cliente.BuscarCliente(tabla, filtro);
        }
        public static bool ModificarTotalAPagar(int ci, int valor)
        {
            return Datos.Cliente.ModificarTotalAPagar(ci, valor);
        }

        }

}
