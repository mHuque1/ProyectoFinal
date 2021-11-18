using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class ConexionBD
    {
        public static bool conexionEstable()
        {
            return Datos.ConexionBD.ConexionEstable();
        }
        //public static void modificarString(string rol)
        //{
        //    Datos.ConexionBD.ModificarString(rol);
        //
        //}
    }
}
