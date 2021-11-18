using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diseño
{
   
    public partial class frmInicioGerente : Form
    {

        static string xdd="";
        public static int contador = 0;
        static bool f = false;
        
        public frmInicioGerente()
        {
            InitializeComponent();
            


        }

        
        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();
        }
        private void frmInicioGerente_Load(object sender, EventArgs e)
        {   
            try { 
                progresoAbajo.Value = Logica.contarClientesConfirmados() * 100 / Logica.DatosClientes.Rows.Count;
                progresoAbajo.Text = progresoAbajo.Value.ToString()+"%";
            } catch (Exception) //exception division de 0
            {
                progresoAbajo.Value = 0;
                progresoAbajo.Text = progresoAbajo.Value.ToString() + "%";
            }        

            lblClientesConfirmados.Text = "" + Logica.contarClientesConfirmados();
            lblCantidadClientes.Text = ""+Logica.DatosClientes.Rows.Count;
            DateTime hoy = DateTime.Today;
            switch (hoy.ToString("dddd"))
            {
                case "lunes":
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    lblNumeroClientes.Text= ""+Logica.ClientesPorDia[0];
                    break;
                case "martes":
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[1];
                    break;
                case "miércoles":
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    Grafico.Series["ChartLinea"].MarkerStyle = MarkerStyle.Circle;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[2];
                    break;
                case "jueves":
                    Console.WriteLine(Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[3];
                    break;
                case "viernes":
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[4];
                    break;
                case "sábado":
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    Grafico.Series["ChartLinea"].MarkerStyle = MarkerStyle.Circle;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[5];

                    break;
                case "domingo":
                    Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.ClientesPorDia[6]);
                    Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.ClientesPorDia[0]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.ClientesPorDia[1]);
                    Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.ClientesPorDia[2]);
                    Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.ClientesPorDia[3]);
                    Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.ClientesPorDia[4]);
                    Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.ClientesPorDia[5]);
                    Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
                    lblNumeroClientes.Text = "" + Logica.ClientesPorDia[6];
                    break;
            }

            chartCapacidades.Series["ChartLinea"].Points.AddXY("Masajes", Logica.calcularCapacidadDiaria("Masaje"));
            chartCapacidades.Series["ChartLinea"].Points.AddXY("Sauna", Logica.calcularCapacidadDiaria("Sauna"));
            chartCapacidades.Series["ChartLinea"].Points.AddXY("Piscina abierta", Logica.calcularCapacidadDiaria("Piscina abierta"));
            chartCapacidades.Series["ChartLinea"].Points.AddXY("Piscina cerrada", Logica.calcularCapacidadDiaria("Piscina cerrada"));
            chartCapacidades.Series["ChartLinea"].Points.AddXY("Hidromasaje", Logica.calcularCapacidadDiaria("Hidromasaje"));
            chartCapacidades.Series["ChartLinea"].Points.AddXY("Piscina barro", Logica.calcularCapacidadDiaria("Piscina barro"));
            chartCapacidades.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //chartCapacidades.ChartAreas[0].AxisY.Maximum = 100;

            lblServicioFavorito.Text = Logica.contarServiciosFavoritos();
            lblReservasHoy.Text = "" +Logica.DatosClientes.Rows.Count;
            lblIngresos.Text = "$"+Logica.calcularIngresos();
            if (frmPantallaGerente.banderaResize == "Maximized")
            {
                contador = 1;
                f = true;

            }
        }
        private void frmInicioGerente_Resize(object sender, EventArgs e)  
        {
            contador++;
            if (contador > 2)
            {
                if (frmPantallaGerente.banderaResize == "Minimized")
                {
                    Console.WriteLine("XDD: " + xdd);
                    if (xdd == "Maximized")
                        frmPantallaGerente.banderaResize = "Normal";
                    if (xdd == "Normal")
                        frmPantallaGerente.banderaResize = "Maximized";
                }
                if (frmPantallaGerente.banderaResize == "Maximized")
                {
                    xdd = "Maximized";
                    pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 30, this.Height / 2 - 20);
                    pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
                    pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos1.Location = new System.Drawing.Point(20, 0);

                    pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
                    pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
                    pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
                    pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
                    pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
                    pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 30, this.Height / 2 - 20);
                    pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
                    progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 4));
                    progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 9, pnlServicios.Height / 5);
                    progresoAbajo.ProgressWidth = 6;
                    progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
                    lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
                    lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 30, pnlServicios.Height / 2 - 10);
                    lblSobre.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 6, pnlDatos1.Width / 6 + 5);
                    pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 17, pnlDatos1.Height / 8);
                    lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 13, pnlDatos1.Height / 2 - 10);
                    lblClientesHoy.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);

                    pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
                    pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 17, pnlDatos2.Height / 8);
                    lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2);
                    lblSemana.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);

                    pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 6, pnlDatos3.Width / 6 + 5);
                    pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 17, pnlDatos3.Height / 8);
                    lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblReservasHoy.Location = new System.Drawing.Point(pnlDatos3.Width / 3 + 13, pnlDatos3.Height / 2 - 10);
                    lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 7, pnlDatos3.Height - pnlDatos3.Height / 4);

                    pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
                    pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 2 - 34, pnlDatos4.Height / 8);
                    lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblServicioFavorito.Location = new System.Drawing.Point(20, pnlDatos4.Height / 2);
                    lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);

                }
                if (frmPantallaGerente.banderaResize == "Normal")
                {
                    
                    xdd = "Normal";
                    pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
                    pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
                    pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos1.Location = new System.Drawing.Point(20, 0);
                    pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
                    pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
                    pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
                    pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
                    pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
                    pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
                    pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
                    progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 5));
                    progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 12, pnlServicios.Height / 9);
                    progresoAbajo.ProgressWidth = 20;
                    progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
                    lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
                    lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 50, pnlServicios.Height / 2);
                    lblSobre.Font = new System.Drawing.Font("Nirmala UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 5, pnlDatos1.Width / 5);
                    pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos1.Height / 9);
                    lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 34, pnlDatos1.Height / 2 - 10);
                    lblClientesHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);

                    pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
                    pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 30, pnlDatos2.Height / 9);
                    lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2 - 10);
                    lblSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);

                    pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 5, pnlDatos3.Width / 5);
                    pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 30, pnlDatos3.Height / 10);
                    lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblReservasHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos3.Height / 2 - 10);
                    lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 6, pnlDatos3.Height - pnlDatos3.Height / 4);

                    pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
                    pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 3, pnlDatos4.Height / 20);
                    lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblServicioFavorito.Location = new System.Drawing.Point(15, pnlDatos4.Height / 2);
                    lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);

                }
            }
            else
            {
                if (f) {
                    f = false;
                    xdd = "Normal";
                    pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
                    pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
                    pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos1.Location = new System.Drawing.Point(20, 0);
                    pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
                    pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
                    pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
                    pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
                    pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
                    pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
                    pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
                    pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
                    progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 5));
                    progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 12, pnlServicios.Height / 9);
                    progresoAbajo.ProgressWidth = 20;
                    progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
                    lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
                    lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 50, pnlServicios.Height / 2);
                    lblSobre.Font = new System.Drawing.Font("Nirmala UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 5, pnlDatos1.Width / 5);
                    pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos1.Height / 9);
                    lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 34, pnlDatos1.Height / 2 - 10);
                    lblClientesHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);

                    pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
                    pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 30, pnlDatos2.Height / 9);
                    lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2 - 10);
                    lblSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);

                    pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 5, pnlDatos3.Width / 5);
                    pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 30, pnlDatos3.Height / 10);
                    lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblReservasHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos3.Height / 2 - 10);
                    lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 6, pnlDatos3.Height - pnlDatos3.Height / 4);

                    pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
                    pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 3, pnlDatos4.Height / 20);
                    lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblServicioFavorito.Location = new System.Drawing.Point(15, pnlDatos4.Height / 2);
                    lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);
                }
                
            }

}
    }
}
