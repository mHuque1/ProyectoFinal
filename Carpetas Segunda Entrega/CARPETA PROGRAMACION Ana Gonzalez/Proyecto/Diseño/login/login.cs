using Spa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class login : Form
    {
        private bool showPass = false;
        public login()
        {
            InitializeComponent();
            txtPass.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            cargarUsuario();
        }
        public void cargarUsuario()
        {
            if (Properties.Settings.Default.usuario!= string.Empty)
            {
                if(Properties.Settings.Default.recordarme)
                {
                    checkRecordarUsuario.Checked = true;
                    txtUsuario.Text = Properties.Settings.Default.usuario;
                }
                else
                {
                    checkRecordarUsuario.Checked = false;
                    Properties.Settings.Default.usuario = "";
                    Properties.Settings.Default.recordarme = false;
                }
            }  
        }
        public void recordarUsuario()
        {
            if (checkRecordarUsuario.Checked)
            {
                Properties.Settings.Default.usuario = txtUsuario.Text;
                Properties.Settings.Default.recordarme = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.usuario = "";
                Properties.Settings.Default.recordarme = false;
                Properties.Settings.Default.Save();
            }
        }
        private async void cargar()
        {
            frmCargar asd = new frmCargar();
            asd.Show();
            await Logica.logica.Email(Logica.Usuarios.getEmail(Logica.logica.UsuarioActual));
            asd.Close();
            frmToken xd = new frmToken(Logica.logica.UsuarioActual);
            if (xd.ShowDialog() == DialogResult.OK)
            {

                if (Logica.Usuarios.getUserType(Int32.Parse(txtUsuario.Text)) == "Administrativo")
                {
                    Hide();
                    frmBienvenida bienvenida = new frmBienvenida("Administrativo");
                    bienvenida.ShowDialog();
                    frmPantallaAdmin hola = new frmPantallaAdmin();
                    hola.Show();
                }
                if (Logica.Usuarios.getUserType(Int32.Parse(txtUsuario.Text)) == "Gerente")
                {
                    Hide();
                    frmBienvenida bienvenida = new frmBienvenida("Gerente");
                    bienvenida.ShowDialog();
                    frmPantallaGerente hola = new frmPantallaGerente();
                    hola.Show();
                }
            }
        }
        private void inicioSesion() {
            if (Logica.logica.validarCampoVacio(txtUsuario.Text))
            {
                if (Logica.logica.validarCampoVacio(txtPass.Text))
                {
                    if(Logica.logica.validar50CaracteresMax(txtPass.Text)) {
                        try
                        {

                            if (Logica.Usuarios.getUserID(Int32.Parse(txtUsuario.Text)))
                            {
                                if (Logica.Usuarios.getUserPass(Int32.Parse(txtUsuario.Text), txtPass.Text))
                                {
                                    Logica.logica.UsuarioActual = Int32.Parse(txtUsuario.Text);
                                    Logica.logica.passActual = txtPass.Text;
                                    Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
                                    Logica.Usuarios.cambiarUltimoLogin(Logica.logica.UsuarioActual);
                                    //Logica.ConexionBD.modificarString(Logica.Usuarios.getUserType(Int32.Parse(txtUsuario.Text)));
                                    recordarUsuario();
                                    if (Logica.Usuarios.getTokenTrue(Int32.Parse(txtUsuario.Text)))
                                    {
                                        cargar();
                                    }
                                    else
                                    {

                                        if (Logica.Usuarios.getUserType(Int32.Parse(txtUsuario.Text)) == "Administrativo")
                                        {
                                            this.Hide();
                                            frmBienvenida bienvenida = new frmBienvenida("Administrativo");
                                            bienvenida.ShowDialog();
                                            frmPantallaAdmin hola = new frmPantallaAdmin();
                                            hola.Show();
                                        }
                                        if (Logica.Usuarios.getUserType(Int32.Parse(txtUsuario.Text)) == "Gerente")
                                        {
                                            this.Hide();
                                            frmBienvenida bienvenida = new frmBienvenida("Gerente");
                                            bienvenida.ShowDialog();
                                            frmPantallaGerente hola = new frmPantallaGerente();
                                            hola.Show();
                                        }
                                    }
                                }
                                else
                                {
                                    frmNegativo ff = new frmNegativo("La contraseña es incorrecta");
                                    ff.ShowDialog();
                                }
                            }
                            else
                            {
                                frmNegativo ff = new frmNegativo("el usuario no existe");
                                ff.ShowDialog();
                            }
                        }
                        catch (Exception f)
                        {
                            frmNegativo ff = new frmNegativo("El usuario ingresado no es valido");
                            ff.ShowDialog();
                            Console.WriteLine(f.Message);
                        }
                    } else
                    {
                        frmNegativo ff = new frmNegativo("la contraseña supera los 50 caracteres permitidos");
                        ff.ShowDialog();
                    }
                }
                else
                {
                    frmNegativo ff = new frmNegativo("debe ingresar una contraseña");
                    ff.ShowDialog();
                }
            }
            else
            {
                frmNegativo ff = new frmNegativo("debe ingresar un usuario");
                ff.ShowDialog();
            }

        }
    
                
        
         
       
        //Botones.
        //#############################################################################################   
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            inicioSesion();
        }

        //#############################################################################################   
       
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inicioSesion();
            }
        }   
        private void login_Load(object sender, EventArgs e)
        {
            frmPantallaAdmin.banderaResize = "";
            frmPantallaGerente.banderaResize = "";
            frmInicioGerente.contador = 0;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
       

        private void bunifuButton1_ClickAsync(object sender, EventArgs e)
        {
            
        }
    }
}
