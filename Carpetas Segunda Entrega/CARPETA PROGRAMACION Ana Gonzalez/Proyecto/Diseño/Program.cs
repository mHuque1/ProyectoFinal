using System;
using System.Net;
using System.Windows.Forms;

namespace Spa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Logica.agregarClientesRelleno();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Logica.ConexionBD.conexionEstable())
            {
                if (CheckInternetConnection())
                {
                    Application.Run(new login());
                }  
                else
                {
                    frmSiNo fInternet = new frmSiNo("No se ha logrado conectarse a internet, este programa requiere una conexión estable para ciertas funciones. ¿Desea Continuar?");
                    if (fInternet.ShowDialog()==DialogResult.OK) {
                        Application.Run(new login());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha logrado una conexion estable con la base de datos");
            }
            
        }
        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
