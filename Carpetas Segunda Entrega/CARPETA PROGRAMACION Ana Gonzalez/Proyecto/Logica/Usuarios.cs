using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Bunifu.UI.WinForms;


namespace Logica
{
    public class Usuarios
    {
        public static bool altaEmpleado(int ci, string nombre, string apellido, string correo, int telefono, string direccion, string TipoUsuario, float sueldo, string pass, byte[] foto)
        {
            return Datos.Usuarios.AltaEmpleado(ci,nombre,apellido,correo,telefono,direccion,TipoUsuario,sueldo,pass,foto);
        }
        public static bool checkEstadoConexionUsuario(int cedula)
        {
            return Datos.Usuarios.CheckEstadoConexionUsuario(cedula);
        }
        public static bool cambiarEstadoConexionUsuario(bool conectado, int cedula)
        {
            return Datos.Usuarios.CambiarEstadoConexionUsuario(conectado,cedula);
        }
        public static bool cambiarMomentoUltimaActividadUsuario(int cedula)
        {
            return Datos.Usuarios.CambiarMomentoUltimaActividadUsuario(cedula);
        }
        public static bool cambiarUltimoLogin(int cedula)
        {
            return Datos.Usuarios.CambiarUltimoLogin(cedula);
        }
        public static string getUserType(int cedula)
        {
            return Datos.Usuarios.GetUserType(cedula);
        }
        public static bool getUserPass(int cedula, string pass)
        {
            return Datos.Usuarios.GetUserPass(cedula,pass);
        }
        public static string getEmail(int cedula)
        {
            return Datos.Usuarios.GetEmail(cedula);
        }
        public static bool getUserID(int cedula)
        {
            return Datos.Usuarios.GetUserID(cedula);
        }
        public static bool getTokenTrue(int cedula)
        {
            return Datos.Usuarios.GetTokenTrue(cedula);

        }
        public static bool cargarEmpleados(DataGridView tabla)
        {
            return Datos.Usuarios.CargarEmpleados(tabla);
        }
        public static bool cargarFotosUsuarios(DataGridView tabla)
        {
            return Datos.Usuarios.CargarEmpleados(tabla);
        }           
        public static bool cargarDatosUsuarioExistente(BunifuTextBox Cedula, BunifuTextBox Nombre, BunifuTextBox Apellido, BunifuTextBox Correo, BunifuTextBox Telefono, BunifuTextBox Direccion, BunifuTextBox Sueldo)
        {
            return Datos.Usuarios.CargarDatosUsuarioExistente(Cedula,Nombre,Apellido,Correo,Telefono,Direccion,Sueldo);
        }
        public static bool cargarCargos(ComboBox cargos)
        {
            return Datos.Usuarios.CargarCargos(cargos);
        }
        public static bool modificarEmpleado(int ci, int ci2, string nombre, string apellido, string correo, string telefono, string direccion, string cargo, float Sueldo)
        {
            return Datos.Usuarios.ModificarEmpleado(ci,ci2,nombre,apellido,correo,telefono,direccion,cargo,Sueldo);
        }
        public static bool bajaUsuario(int ci)
        {
            return Datos.Usuarios.BajaUsuario(ci);
        }
        public static bool cargarPerfil(int usuario, Label Nombre, Label Apellido, Label Cedula, Label Cargo, Label Correo, Label Direccion, Label Telefono)
        {
            return Datos.Usuarios.CargarPerfil(usuario,Nombre,Apellido,Cedula,Cargo,Correo,Direccion,Telefono);
        }
        public static Image cargarFotoUsuario(int cedula)
        {
            return Datos.Usuarios.CargarFotoUsuario(cedula);
        }
        public static bool cambiarFotoUsuario(byte[] foto, int ci)
        {
            return Datos.Usuarios.CambiarFotoUsuario(foto,ci);
        }
        public static bool activarToken(bool activado, int ci)
        {
            return Datos.Usuarios.ActivarToken(activado, ci);
        }
        public static bool CambiarColorPantalla(bool activado, int ci)
        {
            return Datos.Usuarios.CambiarColorPantalla(activado, ci);
        }
        public static bool editarInfoContacto(string correo, string direccion, string telefono, int ci)
        {
            return Datos.Usuarios.EditarInfoContacto(correo, direccion,telefono,ci);

        }
        public static bool cargarDetallesUsuario(Bunifu.UI.WinForms.BunifuToggleSwitch dosPasos,
           Bunifu.UI.WinForms.BunifuToggleSwitch colorPantalla, int ci, Bunifu.UI.WinForms.BunifuTextBox correo,
           Bunifu.UI.WinForms.BunifuTextBox direccion, Bunifu.UI.WinForms.BunifuTextBox telefono)
        {
        return Datos.Usuarios.CargarDetallesUsuario(dosPasos, colorPantalla,ci,correo,direccion,telefono);
        }
        public static bool BuscarEmpleado(DataGridView tabla, string filtro)
        {
            return Datos.Usuarios.BuscarEmpleado(tabla, filtro);
        }
        public static bool EditarContraseña(string contraseña,int cedula)
        {
            return Datos.Usuarios.EditarContraseña(contraseña, cedula);
        }


        }
}

