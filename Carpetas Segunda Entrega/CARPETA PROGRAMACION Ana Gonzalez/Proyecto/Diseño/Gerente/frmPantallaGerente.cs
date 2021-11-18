using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmPantallaGerente : Form
    {
        public static string banderaResize = "";
        public Panel leftBorderBtn;
        private BunifuFlatButton CurrentButton;
        public frmPantallaGerente()
        {
            InitializeComponent();
            fotoUsuario.Image = Logica.Usuarios.cargarFotoUsuario(Logica.logica.UsuarioActual);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlBotones.Controls.Add(leftBorderBtn);
            lblTitulo.Text = "Inicio";
            this.pnlCargado.Controls.Clear();
            frmInicioGerente frmInicio_carga = new frmInicioGerente()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
            this.pnlCargado.Controls.Add(frmInicio_carga);
            frmInicio_carga.Show();    
            leftBorderBtn.BackColor = Color.White;
            leftBorderBtn.Location = new Point(0, btnInicio.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            CurrentButton = btnInicio;
        }

        //##################METODOS###########################
        private void activarBoton(object senderBtn)
        {
            if (senderBtn != null && senderBtn != CurrentButton)
            {
                DesactivarBoton();
                if (CurrentButton != (BunifuFlatButton)senderBtn)
                {
                    CurrentButton = (BunifuFlatButton)senderBtn;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    leftBorderBtn.BackColor = Color.White;
                    leftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            }
        }
        private void DesactivarBoton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }
        //##################METODOS###########################

        //##################BOTONES###########################
        private void Salir_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (MessageBox.Show("Estas seguro que quieres cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);

            WindowState = FormWindowState.Minimized;
            banderaResize = "Minimized";
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                banderaResize = "Maximized";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                banderaResize = "Normal";
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (MessageBox.Show("Estas seguro que quieres cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(pnlBotones.Width == 270)
            {
                pnlBotones.Visible = false;
                pnlBotones.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(pnlBotones);
            }
            else
            {
                pnlBotones.Visible = false;
                pnlBotones.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(pnlBotones);
            }
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnInicio)
            {
                activarBoton(sender);
                lblTitulo.Text = "Inicio";
                this.pnlCargado.Controls.Clear();
                frmInicioGerente frmInicio_carga = new frmInicioGerente()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmInicio_carga);
                frmInicio_carga.Show();
            }
        }  
        private void frmGerente_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
                this.Hide();
                login login = new login();
                login.Show();
            }
        }
        private void btnDatosClientes_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnDatosClientes)
            {
                activarBoton(sender);
                lblTitulo.Text = "Datos de Clientes";
                this.pnlCargado.Controls.Clear();
                frmDatosClientes frmInicio_carga = new frmDatosClientes(pnlBotones, "Gerente")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmInicio_carga);
                frmInicio_carga.Show();
            }
        }
        private void btnReservarCliente_Click(object sender, EventArgs e)
        {
            try { 
            
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnReservarCliente) {
                activarBoton(sender);
                lblTitulo.Text = "Reserva Cliente";
                this.pnlCargado.Controls.Clear();
                    //frmReservaCliente3 frmReservaCliente3xd = new frmReservaCliente3(pnlBotones,"Gerente")
                    frmReservaCliente2 frmReservaCliente3xd = new frmReservaCliente2(pnlBotones, "Gerente")
                    {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                    frmReservaCliente3xd.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmReservaCliente3xd);
                    frmReservaCliente3xd.Show();
            }
            } catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnEmpleados)
            {
                activarBoton(sender);
                lblTitulo.Text = "Empleados";
                this.pnlCargado.Controls.Clear();
                frmDatosEmpleados frmInicio_carga = new frmDatosEmpleados(pnlBotones, "Gerente")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmInicio_carga);
                frmInicio_carga.Show();
            }
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnServicios)
            {
                activarBoton(sender);
                lblTitulo.Text = "Servicios y costos";
                this.pnlCargado.Controls.Clear();
                frmServiciosYCostos frmInicio_carga = new frmServiciosYCostos()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmInicio_carga);
                frmInicio_carga.Show();
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnConfig)
            {
                activarBoton(sender);
                lblTitulo.Text = "Mi Perfil";
                this.pnlCargado.Controls.Clear();
                frmConfiguraciones frmInicio_carga = new frmConfiguraciones(fotoUsuario,"Gerente")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmInicio_carga);
                frmInicio_carga.Show();
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }
        //##################BOTONES###########################

    }
}
