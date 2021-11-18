using Diseño.Messages;
using Proyecto;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diseño
{
    public partial class frmReservaCliente : Form
    {
        static string fecha1;
        Panel xd;
        static string b;
        static string cedula;
        string xdd = "";
        static string checkNombre;
        static int contador = 0;
        bool permitir = true;

        public frmReservaCliente(Panel a, string TipoUsuario)
        {
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Gerente") // si el tipo de usuario es gerente los botones se hacen rojos, en caso contrario azul.
            {
                btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }

        }

        //DatosCliente.
        //#############################################################################################
        private void txtReservaCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void checkJubilado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJubilado.Checked)
            {
                checkTurista.Checked = false;
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);


            }
            if (!checkJubilado.Checked && !checkTurista.Checked)
            {
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
            }


            else
            {
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
            }
        }
        private void checkTurista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTurista.Checked)
            {
                checkJubilado.Checked = false;
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);


            }

            if (!checkJubilado.Checked && !checkTurista.Checked)
            {
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
            }
            else
            {
                Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
            }


        }
        //#############################################################################################

        //Metodos.
        //#############################################################################################
        public static void activarFechas(Label precio, Label hora, Panel pnl, CheckBox a, TextBox xd)
        {
            checkNombre = a.Text;
            reservaHorarios dou = new reservaHorarios(a, cedula, b, fecha1);
            if (dou.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow dr in Logica.precios.Rows)
                {
                    if (a.Text == "Piscina abierta" || a.Text == "Piscina cerrada" || a.Text == "Sauna" || a.Text == "Piscina barro" || a.Text == "Hidromasaje")
                        precio.Text = "$0";
                    else if (dr["Servicio"].ToString() == a.Text)
                        precio.Text = "$" + dr["Precio"].ToString();

                }
                hora.Text = reservaHorarios.horaText;
                pnl.Visible = true;
            }
            else
            {
                a.Checked = false;
            }
        }
        public static void desactivarFechas(Label precio, string fecha, Label hora, Panel pnl, CheckBox a)
        {
            checkNombre = a.Text;
            Logica.borrarCupo(checkNombre, fecha, hora.Text);
            Logica.borrarCapacidad(checkNombre, fecha);
            fecha = "";
            hora.Text = "";
            pnl.Visible = false;

        }
        public static void desactivarFechasTraslado(Label fecha, Label horaSalida, Label horaVuelta, Panel pnl, CheckBox a)
        {
            checkNombre = a.Text;
            Logica.borrarCupo(checkNombre, fecha.Text, horaSalida.Text);
            Logica.borrarCupo(checkNombre, fecha.Text, horaVuelta.Text);
            fecha.Text = "";
            horaSalida.Text = "";
            horaVuelta.Text = "";
            pnl.Visible = false;
        }
        public static void activarFechasCamioneta(Label precio, Label horaSalida, Label horaVuelta, Panel pnl, CheckBox a, TextBox xd)
        {
            reservaTranslado dou = new reservaTranslado(cedula, b, fecha1);
            if (dou.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow dr in Logica.precios.Rows)
                {
                    if (dr["Servicio"].ToString() == a.Text)
                        precio.Text = "$" + dr["Precio"].ToString();

                }
                horaSalida.Text = reservaTranslado.horaIdaText;
                horaVuelta.Text = reservaTranslado.horaVueltaText;

                pnl.Visible = true;
            }
            else
            {
                a.Checked = false;
            }
        }
        private void limpiarCampos()
        {
            foreach (Control c in Panel.Controls)
            {
                if (Panel.GetColumn(c) <= 1 && Panel.GetRow(c) <= 8)
                {
                    c.Enabled = true;
                    if (c is TextBox)
                        c.Text = "";

                    if (Panel.GetColumn(c) > 1 && Panel.GetRow(c) <= 8)
                        c.Visible = false;

                    
                }
            }
        }
        //#############################################################################################

        //Botones de servicios.
        //#############################################################################################
        private void checkTradicional_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTradicional.Checked)
            {
                activarFechas(lblPrecio1, lblHora1, pnlHoras1, checkTradicional, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Masaje Tradicional");

            }
            else
            {
                if (permitir)
                {
                    desactivarFechas(lblPrecio1, fecha1, lblHora1, pnlHoras1, checkTradicional);
                    Logica.precioTotal -= Logica.verificarPrecio("Masaje Tradicional");
                }              
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);

        }
        private void checkOriental_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOriental.Checked)
            {
                activarFechas(lblPrecio2, lblHora2, pnlHoras2, checkOriental, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Masaje Oriental");
            }
            else
            {
                if (permitir)
                {
                    desactivarFechas(lblPrecio2, fecha1, lblHora2, pnlHoras2, checkOriental);
                    Logica.precioTotal -= Logica.verificarPrecio("Masaje Oriental");
                }
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
        }
        private void checkYoga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkYoga.Checked)
            {
                activarFechas(lblPrecio3, lblHora3, pnlHoras3, checkYoga, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Yoga / Pilates");
            }
            else
            {
                if (permitir)
                {
                    desactivarFechas(lblPrecio3, fecha1, lblHora3, pnlHoras3, checkYoga);
                    Logica.precioTotal -= Logica.verificarPrecio("Yoga / Pilates");
                }
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
        }
        private void checkMeditacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMeditacion.Checked)
            {
                activarFechas(lblPrecio4, lblHora4, pnlHoras4, checkMeditacion, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Meditación");
            }
            else
            {
                desactivarFechas(lblPrecio4, fecha1, lblHora4, pnlHoras4, checkMeditacion);
                Logica.precioTotal -= Logica.verificarPrecio("Meditación");
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);

        }
        private void checkBici_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBici.Checked)
            {
                activarFechas(lblPrecio5, lblHora5, pnlHoras5, checkBici, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Bicicletas");
            }
            else
            {
                desactivarFechas(lblPrecio5, fecha1, lblHora6, pnlHoras7, checkBici);
                Logica.precioTotal -= Logica.verificarPrecio("Bicicletas");
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
        }
        private void checkCabalgatas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCabalgatas.Checked)
            {
                activarFechas(lblPrecio6, lblHora6, pnlHoras6, checkCabalgatas, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Cabalgatas");
            }
            else
            {
                desactivarFechas(lblPrecio6, fecha1, lblHora6, pnlHoras6, checkCabalgatas);
                Logica.precioTotal -= Logica.verificarPrecio("Cabalgatas");
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
        }
        private void checkBotes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBotes.Checked)
            {
                Logica.precioTotal += Logica.verificarPrecio("Botes");
                activarFechas(lblPrecio7, lblHora7, pnlHoras7, checkBotes, txtReservaCedula);
            }
            else
            {
                desactivarFechas(lblPrecio7, fecha1, lblHora7, pnlHoras7, checkBotes);
                Logica.precioTotal -= Logica.verificarPrecio("Botes");
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);

        }
        private void checkTraslados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTraslados.Checked)
            {
                activarFechasCamioneta(lblPrecio8, lblHora8, lblHoraVuelta, pnlHoras8, checkTraslados, txtReservaCedula);
                Logica.precioTotal += Logica.verificarPrecio("Traslados");
            }

            else
            {
                desactivarFechasTraslado(lblPrecio8, lblHora8, lblHoraVuelta, pnlHoras8, checkTraslados);
                Logica.precioTotal -= Logica.verificarPrecio("Traslados");
            }
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
        }
        private void CheckPiscinaAbierta_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPiscinaAbierta.Checked)
                activarFechas(lblPrecio9, lblHora9, pnlHoras9, CheckPiscinaAbierta, txtReservaCedula);
            else
                desactivarFechas(lblPrecio9, fecha1, lblHora9, pnlHoras9, CheckPiscinaAbierta);
        }
        private void CheckPiscinaCerrada_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPiscinaCerrada.Checked)
                activarFechas(lblPrecio10, lblHora10, pnlHoras10, CheckPiscinaCerrada, txtReservaCedula);
            else
                desactivarFechas(lblPrecio10, fecha1, lblHora10, pnlHoras10, CheckPiscinaCerrada);
        }
        private void CheckPiscinaBarro_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPiscinaBarro.Checked)
                activarFechas(lblPrecio11, lblHora11, pnlHoras11, CheckPiscinaBarro, txtReservaCedula);
            else
                desactivarFechas(lblPrecio11, fecha1, lblHora11, pnlHoras11, CheckPiscinaBarro);
        }
        private void checkHidromasaje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHidromasaje.Checked)
                activarFechas(lblPrecio12, lblHora12, pnlHoras12, checkHidromasaje, txtReservaCedula);
            else
                desactivarFechas(lblPrecio12, fecha1, lblHora12, pnlHoras12, checkHidromasaje);
        }
        private void checkSauna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSauna.Checked)
                activarFechas(lblPrecio13, lblHora13, pnlHoras13, checkSauna, txtReservaCedula);
            else
                desactivarFechas(lblPrecio13, fecha1, lblHora13, pnlHoras13, checkSauna);
        }
        //#############################################################################################
        private void btnReservar_Click(object sender, EventArgs e)
        {

            if (!checkTradicional.Checked && !checkOriental.Checked &&
                !checkYoga.Checked && !checkMeditacion.Checked && !checkBici.Checked &&
                !checkCabalgatas.Checked && !checkBotes.Checked && !CheckPiscinaAbierta.Checked &&
                !CheckPiscinaCerrada.Checked && !CheckPiscinaBarro.Checked && !checkHidromasaje.Checked && !checkSauna.Checked)
            {
                frmCorrecto dou = new frmCorrecto("Reserve Servicios\n>:v", 2);
                if (dou.ShowDialog() == DialogResult.OK) { }
            }
            else
            {
                if (Logica.compararHoras(lblHora1, lblHora2, lblHora3, lblHora4, lblHora5, lblHora6, lblHora7, lblHora9, lblHora10, lblHora11, lblHora12, lblHora13))
                {
                    if (!Logica.existeCI(txtReservaCedula))
                    {
                        Logica.reservarCliente(txtReservaCedula, txtReservaNombre, txtReservaApellido, txtReservaCorreo, txtReservaTelefono, txtReservaDireccion, lblTotal, checkJubilado, checkTurista);
                        Logica.ServiciosClientes.Rows.Add();
                    }
                    else
                    {
                        Logica.agregarTotal(lblTotal, cedula);
                    }

                    Logica.reservarServicios(checkTradicional, lblPrecio1, lblHora1, txtReservaCedula, fecha1,"Ninguno");
                    Logica.reservarServicios(checkOriental, lblPrecio2, lblHora2, txtReservaCedula,fecha1, "Ninguno");
                    Logica.reservarServicios(checkYoga, lblPrecio3, lblHora3, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(checkMeditacion, lblPrecio4, lblHora4, txtReservaCedula,fecha1, "Ninguno");
                    Logica.reservarServicios(checkBici, lblPrecio5, lblHora5, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(checkCabalgatas, lblPrecio6, lblHora6, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(checkBotes, lblPrecio7, lblHora7, txtReservaCedula, fecha1, "Ninguno");
                    if (lblHora8.Text != "")
                        Logica.reservarServicios(checkTraslados, lblPrecio8, lblHora8, txtReservaCedula, fecha1, "Ninguno");
                 
                    if (lblHoraVuelta.Text != "")
                        Logica.reservarServicios(checkTraslados, lblPrecio8, lblHora8, txtReservaCedula , fecha1,lblHoraVuelta.Text);

                    
                    Logica.reservarServicios(CheckPiscinaAbierta, lblPrecio9, lblHora9, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(CheckPiscinaCerrada, lblPrecio10, lblHora10, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(CheckPiscinaBarro, lblPrecio11, lblHora11, txtReservaCedula, fecha1, "Ninguno");
                    Logica.reservarServicios(checkHidromasaje, lblPrecio12, lblHora12, txtReservaCedula,fecha1, "Ninguno");
                    Logica.reservarServicios(checkSauna, lblPrecio13, lblHora13, txtReservaCedula, fecha1, "Ninguno");
                    Logica.ContarClientesFecha();

                    frmCorrecto hola = new frmCorrecto("Cliente reservado \ncorrectamente", 1);
                    if (hola.ShowDialog() == DialogResult.OK)
                    {
                        permitir = false;
                        if (checkTradicional.Checked)
                        {
                            checkTradicional.Checked = false;
                            lblPrecio1.Text = "Precio ACA";
                            lblHora1.Text = "Hora ACA";
                        }
                        if (checkOriental.Checked)
                        {
                            lblPrecio2.Text = "Precio ACA";
                            lblHora2.Text = "Hora ACA";
                            checkOriental.Checked = false;
                        }
                        if (checkYoga.Checked)
                        {
                            lblPrecio3.Text = "Precio ACA";
                            lblHora3.Text = "Hora ACA";
                            checkYoga.Checked = false;
                        }
                        if (checkMeditacion.Checked)
                        {
                            lblPrecio4.Text = "Precio ACA";
                            lblHora4.Text = "Hora ACA";
                            checkMeditacion.Checked = false;
                        }
                        if (checkBici.Checked)
                        {
                            lblPrecio5.Text = "Precio ACA";
                            lblHora5.Text = "Hora ACA";
                            checkBici.Checked = false;
                        }
                        if (checkCabalgatas.Checked)
                        {
                            lblPrecio6.Text = "Precio ACA";
                            lblHora6.Text = "Hora ACA";
                            checkCabalgatas.Checked = false;
                        }
                        if (checkBotes.Checked)
                        {
                            lblPrecio7.Text = "Precio ACA";
                            lblHora7.Text = "Hora ACA";
                            checkBotes.Checked = false;
                        }
                        if (checkTraslados.Checked)
                        {
                            lblPrecio8.Text = "Precio ACA";
                            lblHora8.Text = "HoraSalida";
                            lblHoraVuelta.Text = "HoraVuelta";
                            checkTraslados.Checked = false;
                        }
                        if (CheckPiscinaAbierta.Checked)
                        {
                            lblPrecio9.Text = "Precio ACA";
                            lblHora9.Text = "Hora ACA";
                            CheckPiscinaAbierta.Checked = false;
                        }
                        if (CheckPiscinaCerrada.Checked)
                        {
                            lblPrecio10.Text = "Precio ACA";
                            lblHora10.Text = "Hora ACA";
                            CheckPiscinaCerrada.Checked = false;
                        }
                        if (CheckPiscinaBarro.Checked)
                        {
                            lblPrecio11.Text = "Precio ACA";
                            lblHora11.Text = "Hora ACA";
                            CheckPiscinaBarro.Checked = false;
                        }
                        if (checkHidromasaje.Checked)
                        {
                            lblPrecio12.Text = "Precio ACA";
                            lblHora12.Text = "Hora ACA";
                            checkHidromasaje.Checked = false;
                        }
                        if (checkSauna.Checked)
                        {
                            lblPrecio13.Text = "Precio ACA";
                            lblHora13.Text = "Hora ACA";
                            checkSauna.Checked = false;
                        }
                        if (checkJubilado.Checked)
                        {
                            checkJubilado.Checked = false;
                        }
                        if (checkTurista.Checked)
                        {
                            checkTurista.Checked = false;
                        }
                        limpiarCampos();
                        Logica.precioTotal = 0;
                        lblTotal.Text = "" + Logica.verificarPrecio("Entrada Estandar");
                        txtReservaCedula.Text = "";
                        xd.Enabled = true; 
                        foreach (Control c in Panel.Controls)
                        {
                            if (Panel.GetColumn(c) > 1 && Panel.GetRow(c) <= 8)
                                c.Visible = false;
                        }
                        Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
                        permitir = true;
                    }
                }
                else
                {
                    frmCorrecto dou = new frmCorrecto("no puede reservar\ndos servicios\ncon la misma hora.", 2);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }

            }

        }
        private void frmReservaCliente_Load(object sender, EventArgs e)
        {
            Logica.calcularPrecio(lblTotal, checkJubilado, checkTurista, cedula, fecha1);
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today.AddDays(6);
            foreach (Control c in Panel.Controls)
            {
                if (Panel.GetColumn(c) > 1 && Panel.GetRow(c) <= 8)
                    c.Visible = false;
            }
            if (frmPantallaGerente.banderaResize == "Maximized" || frmPantallaAdmin.banderaResize == "Maximized")
            {
                contador = -1;
            }

        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Logica.cargarCliente(txtReservaCedula, txtReservaNombre, txtReservaApellido, txtReservaCorreo, txtReservaTelefono, txtReservaDireccion, checkJubilado, checkTurista) && txtReservaCedula.Enabled == true)
            {
                frmCorrecto dou = new frmCorrecto("Se cargaran los datos\ndel cliente", 3);
                if (dou.ShowDialog() == DialogResult.OK)
                {
                    txtReservaCedula.Enabled = false;
                }
            }
            else
            {
                if (txtReservaCedula.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese la cedula", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }
                else if (txtReservaNombre.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese el nombre", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }
                else if (txtReservaApellido.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese el apellido", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }
                else if (txtReservaCorreo.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese el correo", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }
                else if (txtReservaTelefono.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese el telefono", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }
                else if (txtReservaDireccion.Text == "")
                {
                    frmCorrecto dou = new frmCorrecto("Ingrese la dirección", 4);
                    if (dou.ShowDialog() == DialogResult.OK) { }
                }

                else
                {
                    cedula = txtReservaCedula.Text;
                    fecha1 = dtpFecha.Value.ToString("yyyy-MM-dd");
                    xd.Enabled = false;
                    btnCancelar.Visible = true;
                    txtReservaCedula.Enabled = false;
                    foreach (Control c in Panel.Controls)
                    {
                        if (Panel.GetColumn(c)<=1 && Panel.GetRow(c) <= 8)
                            c.Enabled = false;
                        if (Panel.GetColumn(c) > 1 && Panel.GetRow(c) <= 8 && c is CheckBox)
                            c.Visible = true;
                    }
                    


                }
            }




        }
        private void txtReservaTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cancelar la reserva?", "Cancelar Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                permitir = true;
                if (checkTradicional.Checked)
                {
                    checkTradicional.Checked = false;
                    lblPrecio1.Text = "Precio ACA";
                    lblHora1.Text = "Hora ACA";
                }
                if (checkOriental.Checked)
                {
                    lblPrecio2.Text = "Precio ACA";
                    lblHora2.Text = "Hora ACA";
                    checkOriental.Checked = false;
                }
                if (checkYoga.Checked)
                {
                    lblPrecio3.Text = "Precio ACA";
                    lblHora3.Text = "Hora ACA";
                    checkYoga.Checked = false;
                }
                if (checkMeditacion.Checked)
                {
                    lblPrecio4.Text = "Precio ACA";
                    lblHora4.Text = "Hora ACA";
                    checkMeditacion.Checked = false;
                }
                if (checkBici.Checked)
                {
                    lblPrecio5.Text = "Precio ACA";
                    lblHora5.Text = "Hora ACA";
                    checkBici.Checked = false;
                }
                if (checkCabalgatas.Checked)
                {
                    lblPrecio6.Text = "Precio ACA";
                    lblHora6.Text = "Hora ACA";
                    checkCabalgatas.Checked = false;
                }
                if (checkBotes.Checked)
                {
                    lblPrecio7.Text = "Precio ACA";
                    lblHora7.Text = "Hora ACA";
                    checkBotes.Checked = false;
                }
                if (checkTraslados.Checked)
                {
                    lblPrecio8.Text = "Precio ACA";
                    lblHora8.Text = "HoraSalida";
                    lblHoraVuelta.Text = "HoraVuelta";
                    checkTraslados.Checked = false;
                }
                if (CheckPiscinaAbierta.Checked)
                {
                    lblPrecio9.Text = "Precio ACA";
                    lblHora9.Text = "Hora ACA";
                    CheckPiscinaAbierta.Checked = false;
                }
                if (CheckPiscinaCerrada.Checked)
                {
                    lblPrecio10.Text = "Precio ACA";
                    lblHora10.Text = "Hora ACA";
                    CheckPiscinaCerrada.Checked = false;
                }
                if (CheckPiscinaBarro.Checked)
                {
                    lblPrecio11.Text = "Precio ACA";
                    lblHora11.Text = "Hora ACA";
                    CheckPiscinaBarro.Checked = false;
                }
                if (checkHidromasaje.Checked)
                {
                    lblPrecio12.Text = "Precio ACA";
                    lblHora12.Text = "Hora ACA";
                    checkHidromasaje.Checked = false;
                }
                if (checkSauna.Checked)
                {
                    lblPrecio13.Text = "Precio ACA";
                    lblHora13.Text = "Hora ACA";
                    checkSauna.Checked = false;
                }
                if (checkJubilado.Checked)
                {
                    checkJubilado.Checked = false;
                }
                if (checkTurista.Checked)
                {
                    checkTurista.Checked = false;
                }
                Logica.precioTotal = 0;
                txtReservaCedula.Text = "";
                limpiarCampos();

                xd.Enabled = true;
                if (b == "Gerente")
                {
                    btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                }
                else
                {
                    btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                    btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                    btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                }

                foreach (Control c in Panel.Controls)
                {
                    if (Panel.GetColumn(c) > 1 && Panel.GetRow(c) <= 8)
                        c.Visible = false;
                }
                btnCancelar.Visible = false;
            }
 
           
        }
        private void frmReservaCliente_Resize(object sender, EventArgs e)
        {        
            contador++;
            if (contador > 0)
            {
                if (frmPantallaGerente.banderaResize == "Minimized" || frmPantallaAdmin.banderaResize == "Minimized")
                {
                    if (xdd == "Maximized")
                        frmPantallaGerente.banderaResize = "Normal";
                    if (xdd == "Normal")
                        frmPantallaGerente.banderaResize = "Maximized";
                }
                if (frmPantallaGerente.banderaResize == "Maximized" || frmPantallaAdmin.banderaResize == "Maximized")
                {      
                    xdd = "Maximized";
                    txtReservaCedula.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                    
                    txtReservaApellido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                    
                    txtReservaCorreo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaTelefono.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));               
                    txtReservaDireccion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtpFecha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                    
                    checkJubilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTradicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkOriental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkYoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkMeditacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkCabalgatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkBotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));  
                    lblPrecio7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CheckPiscinaAbierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CheckPiscinaCerrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CheckPiscinaBarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkHidromasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkSauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));     
                    checkTraslados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHoraVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
                if (frmPantallaGerente.banderaResize == "Normal" || frmPantallaAdmin.banderaResize == "Normal")
                {
                    Console.WriteLine("***********");
                    Console.WriteLine("Maximizar");
                    Console.WriteLine("***********");
                    xdd = "Normal";
                    txtReservaCedula.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaNombre.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaApellido.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaCorreo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaTelefono.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaDireccion.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtpFecha.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkJubilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTradicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkOriental.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkYoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkMeditacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkCabalgatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkBotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    CheckPiscinaAbierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    CheckPiscinaCerrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    CheckPiscinaBarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkHidromasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    checkSauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTraslados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHoraVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
            else
            {              
                xdd = "Maximized";
                
                    txtReservaCedula.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaNombre.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaApellido.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaCorreo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaTelefono.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtReservaDireccion.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtpFecha.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkJubilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));         
                    lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTradicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkOriental.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkYoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkMeditacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkCabalgatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkBotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CheckPiscinaAbierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));          
                    CheckPiscinaCerrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CheckPiscinaBarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkHidromasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkSauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    checkTraslados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblPrecio8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHora8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblHoraVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
        }
        private void Panel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Row<9)
            {

                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(24, 30, 54)), e.CellBounds);
            }
        }
    }
}
