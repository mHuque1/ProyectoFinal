using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto;

namespace Diseño
{
    public partial class frmPantallaAdmin : Form
    {
        public static string banderaResize = "";
        // No tocar.
        //#############################################################################################
        public frmPantallaAdmin(){
            InitializeComponent();
            Logica.leftBorderBtn = new Panel();
            Logica.leftBorderBtn.Size = new Size(7, 45);
            panelBotones.Controls.Add(Logica.leftBorderBtn);

            lblTitulo.Text = "Inicio";
            this.pnlCargado.Controls.Clear();
            frmInicioAdmin frmInicio_carga = new frmInicioAdmin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmInicio_carga.FormBorderStyle = FormBorderStyle.None;
            this.pnlCargado.Controls.Add(frmInicio_carga);
            frmInicio_carga.Show();
            BtnInicio.ForeColor = Color.White;
            BtnInicio.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnInicio.ImageAlign = ContentAlignment.MiddleRight;
            BtnInicio.TextAlign = ContentAlignment.MiddleCenter;
            Logica.leftBorderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            Logica.leftBorderBtn.Location = new Point(0, BtnInicio.Location.Y);
            Logica.leftBorderBtn.Visible = true;
            Logica.leftBorderBtn.BringToFront();
            Logica.CurrentButton = BtnInicio;

        }
        //#############################################################################################

        //Fade in de la pantalla.
        //#############################################################################################
        private void frmPantalla_Load(object sender, EventArgs e){
            this.Opacity = 0.0;
            timerAbrir.Start();
            if (Logica.precios.Columns.Count <= 0)
            {
                Logica.precios.Columns.Add("Servicio", typeof(string));
                Logica.precios.Columns.Add("Precio", typeof(string));
                Logica.precios.Rows.Add("Entrada Estandar", "150");
                Logica.precios.Rows.Add("Entrada Turistas", "100");
                Logica.precios.Rows.Add("Entrada Jubilados", "80");
                Logica.precios.Rows.Add("Masaje Tradicional", "600");
                Logica.precios.Rows.Add("Masaje Oriental", "700");
                Logica.precios.Rows.Add("Yoga / Pilates", "800");
                Logica.precios.Rows.Add("Meditación", "500");
                Logica.precios.Rows.Add("Bicicletas", "100");
                Logica.precios.Rows.Add("Cabalgatas", "500");
                Logica.precios.Rows.Add("Botes", "400");
                Logica.precios.Rows.Add("Traslados", "350");
            }
        }
        private void timerAbrir_Tick(object sender, EventArgs e) { 
            this.Opacity += 0.08;
        }
        //#############################################################################################

        // esto te permite mover de lugar la ventana.
        //#############################################################################################
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Proyecto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //#############################################################################################

        //Botones de ventana.
        //#############################################################################################
        private void btnSalir_Click(object sender, EventArgs e){
            if (MessageBox.Show("Estas seguro que quieres cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }
        private void btnMaximizar_Click(object sender, EventArgs e){
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                banderaResize = "" + this.WindowState;
            }    
            else
            {
                WindowState = FormWindowState.Normal;
                banderaResize = "" + this.WindowState;
            }
           
        }
        private void btnMinimizar_Click(object sender, EventArgs e) {
                WindowState = FormWindowState.Minimized;
                banderaResize = "" + this.WindowState;
            }
        //#############################################################################################

        //Botones de menu de botones.
        //#############################################################################################
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (Logica.CurrentButton != BtnInicio)
            {
                Logica.activarBotonAdministrador(sender, iconoTitulo);
                lblTitulo.Text = "Inicio";
                this.pnlCargado.Controls.Clear();
                frmInicioAdmin frmInicio_carga = new frmInicioAdmin()
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
        private void btnReservaCliente_Click(object sender, EventArgs e)
        {
            if (Logica.CurrentButton != btnReservaCliente)
            {
                Logica.activarBotonAdministrador(sender, iconoTitulo);
                lblTitulo.Text = "Reserva Cliente";
                this.pnlCargado.Controls.Clear();
                frmReservaCliente frmReservaCliente_carga = new frmReservaCliente(panelBotones, "User")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmReservaCliente_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmReservaCliente_carga);
                frmReservaCliente_carga.Show();
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (Logica.CurrentButton != btnModificarCliente)
            {
                Logica.activarBotonAdministrador(sender, iconoTitulo);
                lblTitulo.Text = "Modificar datos del Cliente";
                this.pnlCargado.Controls.Clear();
                frmModificacionCliente frmReservaCliente_carga = new frmModificacionCliente(panelBotones, "User")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmReservaCliente_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmReservaCliente_carga);
                frmReservaCliente_carga.Show();
            }
        }
        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (Logica.CurrentButton != btnDatos)
            {
                Logica.activarBotonAdministrador(sender, iconoTitulo);
                lblTitulo.Text = "Datos";
                this.pnlCargado.Controls.Clear();
                frmDatos frmReservaCliente_carga = new frmDatos(panelBotones, "User")
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmReservaCliente_carga.FormBorderStyle = FormBorderStyle.None;
                this.pnlCargado.Controls.Add(frmReservaCliente_carga);
                frmReservaCliente_carga.Show();
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Show();
            }
            

        }
        private void frmPantallaAdmin_Resize(object sender, EventArgs e)
        {
            banderaResize = "" + this.WindowState;
        }
        //#############################################################################################


    }
}
