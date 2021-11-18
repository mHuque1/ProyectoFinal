using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmPantallaAdmin : Form
    {
        public static string banderaResize = "";
        public Panel leftBorderBtn;
        private BunifuFlatButton CurrentButton;
        public frmPantallaAdmin()
        {
            InitializeComponent();
            fotoUsuario.Image = Logica.Usuarios.cargarFotoUsuario(Logica.logica.UsuarioActual);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlBotones.Controls.Add(leftBorderBtn);
            lblTitulo.Text = "Inicio";
            pnlCargado.Controls.Clear();
            frmInicioAdministrativo frmInicio_carga = new frmInicioAdministrativo()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
            pnlCargado.Controls.Add(frmInicio_carga);
            frmInicio_carga.Show();
            leftBorderBtn.BackColor = Color.White;
            leftBorderBtn.Location = new Point(0, btnInicio.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            CurrentButton = btnInicio;


        }

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
                    //CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    // CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                    leftBorderBtn.BackColor = Color.White; //System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (pnlBotones.Width == 270)
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
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnInicio)
            {
                activarBoton(sender);
                lblTitulo.Text = "Inicio";
                this.pnlCargado.Controls.Clear();
                frmInicioAdministrativo frmInicio_carga = new frmInicioAdministrativo()
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            banderaResize = "Minimized";
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
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
                if (MessageBox.Show("Estas seguro que quieres cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnClientes)
            {
                activarBoton(sender);
                lblTitulo.Text = "Modificar Cliente";
                this.pnlCargado.Controls.Clear();
                frmDatosClientes frmInicio_carga = new frmDatosClientes(pnlBotones, "Admin")
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
        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (MessageBox.Show("Estas seguro que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Show();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnConfig)
            {
                activarBoton(sender);
                lblTitulo.Text = "Modificar Cliente";
                this.pnlCargado.Controls.Clear();
                frmConfiguraciones frmInicio_carga = new frmConfiguraciones(fotoUsuario,"Admin")
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
            Logica.Usuarios.checkEstadoConexionUsuario(Logica.logica.UsuarioActual);
            if (CurrentButton != btnReservarCliente)
            {
                activarBoton(sender);
                lblTitulo.Text = "Reserva Cliente";
                this.pnlCargado.Controls.Clear();
                frmReservaCliente2 frmInicio_carga = new frmReservaCliente2(pnlBotones, "Admin")
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
    }
}
