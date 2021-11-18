using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Logica
{
    public class Entrada
    {
        public static bool mostrarTablaEntradas(DataGridView tabla)
        {
            return Datos.Entrada.MostrarTablaEntradas(tabla);

        }
        public static int getPrecioEntrada(string servicio)
        {
            return Datos.Entrada.GetPrecioEntrada(servicio);
        }
        public static bool MostrarEntradas(ComboBox cb)
        {
            return Datos.Entrada.MostrarEntradas(cb);
        }
        public static bool AltaEntrada(string nombre, int costo)
        {
            return Datos.Entrada.AltaEntrada(nombre, costo);
        }
        public static bool GetHabilitadaEntrada(string Entrada)
        {
            return Datos.Entrada.GetHabilitadaEntrada(Entrada);
        }
        public static bool modificarEntrada(string tipo, int costo, int habilitada, string entrada)
        {
            return Datos.Entrada.modificarEntrada(tipo, costo, habilitada, entrada);

        }

    }

}
