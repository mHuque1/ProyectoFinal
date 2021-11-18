using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Spa
    {
        public static string gethoraApertura()
        {
            return Datos.Spa.GethoraApertura();
        }
        public static string gethoraCierre()
        {
            return Datos.Spa.GethoraCierre();
        }
        public static Image CargarlogoAColorSpa()
        {
            return Datos.Spa.CargarlogoAColorSpa(); 
        }
        }
}
