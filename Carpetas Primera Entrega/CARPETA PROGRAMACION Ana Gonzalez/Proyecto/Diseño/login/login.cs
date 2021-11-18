using Diseño;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtPass.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }
        //enter leave.
        //#############################################################################################     
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
                txtUsuario.Text = "";
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            txtUsuario.Text = "Usuario";
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
                txtPass.Text = "";

        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Contraseña";
            }
                
        }
        //#############################################################################################     
       
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
            if (txtUsuario.Text == "Usuario")
            {
                MessageBox.Show("no sea puto, escriba un usuario");

            }
            else if (txtPass.Text == "Contraseña")
            {
                MessageBox.Show("no sea puto, escriba una contraseña");
            }
           
            if (txtUsuario.Text == "user" && txtPass.Text == "user") {
                this.Hide();
                frmBienvenida bienvenida = new frmBienvenida("Administrador");
                bienvenida.ShowDialog();
                frmPantallaAdmin hola = new frmPantallaAdmin();
                hola.Show();
                

            }
            if (txtUsuario.Text == "gerente" && txtPass.Text == "gerente")
            {
                this.Hide();
                frmBienvenida bienvenida = new frmBienvenida("Gerente");
                bienvenida.ShowDialog();
                frmPantallaGerente hola = new frmPantallaGerente();
                hola.Show();


            }
        }
        //#############################################################################################   
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPass.Text == "Contraseña")
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (txtUsuario.Text == "Usuario")
                {
                    MessageBox.Show("no sea puto, escriba un usuario");

                }
                else if (txtPass.Text == "Contraseña")
                {
                    MessageBox.Show("no sea puto, escriba una contraseña");
                }

                if (txtUsuario.Text == "user" && txtPass.Text == "user")
                {
                   
                    this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida("Administrador");
                    bienvenida.ShowDialog();
                    frmPantallaAdmin hola = new frmPantallaAdmin();
                    hola.Show();


                }
                if (txtUsuario.Text == "gerente" && txtPass.Text == "gerente")
                {

                    this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida("Gerente");
                    bienvenida.ShowDialog();
                    frmPantallaGerente hola = new frmPantallaGerente();
                    hola.Show();


                }
            }
        }   
        private void login_Load(object sender, EventArgs e)
        {
            frmPantallaAdmin.banderaResize = "";
            frmPantallaGerente.banderaResize = "";
            frmInicioGerente.contador = 0;
        }
    }
}
