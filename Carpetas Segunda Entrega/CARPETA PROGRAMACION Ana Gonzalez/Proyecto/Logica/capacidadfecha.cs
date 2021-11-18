using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class capacidadfecha
    {
        public static bool agregarCapacidad(string servicio, string fecha)
        {
            return Datos.capacidadfecha.AgregarCapacidad(servicio,fecha);
        }
        public static DataTable OcupacionServiciosTop(string rango)
        {
            return Datos.capacidadfecha.OcupacionServiciosTop(rango);
        }
    }
}
