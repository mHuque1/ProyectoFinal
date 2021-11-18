using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace Spa
{

    public partial class frmInicioGerente : Form
    {
        public static int contador = 0;

        public frmInicioGerente()
        {
            InitializeComponent();
        }
        private void tabla()
        {
            DataTable xd = Logica.capacidadfecha.OcupacionServiciosTop("Hoy");
            cartesianChart1.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 500);
            double[] valores = new double[5];
            string[] Servicios = new string[5];
            int i = 0;
            foreach (DataRow dr in xd.Rows)
            {
                valores[i] = double.Parse(dr["Porcentaje"].ToString());
                Servicios[i] = dr["Servicio"].ToString();
                i++;
            }

            cartesianChart1.Series = new SeriesCollection
            {
               new ColumnSeries
               {
                   Title = "ocupación",
                   Values = new ChartValues<double>(valores),
                   Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 165, 21, 80)),
                   Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199)),
                   MaxColumnWidth = 100
        }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Servicios",
                Labels = Servicios,
                LabelFormatter = value => value.ToString("N")
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.4,
                Y = 71,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Ideal",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Green
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.35,
                Y = 51,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Estable",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Yellow
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.3,
                Y = 31,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Deplorable",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Red
                }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = 70,
                        Stroke = Brushes.Green,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    },
                    new AxisSection
                    {
                        Value = 50,
                        Stroke = Brushes.Yellow,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    },
                     new AxisSection
                    {
                        Value = 30,
                        Stroke = Brushes.Red,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    }
                },
                Title = "Porcentaje %",
                LabelFormatter = value => value.ToString()
            });
            cartesianChart1.AxisX[0].Separator.Width = 150;
            cartesianChart1.AxisX[0].Separator.StrokeThickness = 0;
            cartesianChart1.AxisY[0].Separator.StrokeThickness = 0;
            //cartesianChart1.Series = piechartData;
        }
        private void tabla2(string rango)
        {
            DataTable xd = Logica.Reserva.NroClientes(rango);
            cartesianChart1.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 600);
            int[] valores = new int[xd.Rows.Count];
            string[] Fechas = new string[xd.Rows.Count];
            int i = 0;
            foreach (DataRow dr in xd.Rows)
            {
                valores[i] = Int32.Parse(dr["Clientes"].ToString());
                Fechas[i] = dr["Fecha"].ToString();
                i++;
            }
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Clientes",
                    Values = new ChartValues<int> (valores),
                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,165, 21, 80)),
                    PointGeometrySize = 15,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(128,165, 21, 80))
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Esta semana",
                Labels = Fechas,
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199))
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Nro Clientes",
                LabelFormatter = value => value.ToString("N0"),
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199))
            });
            cartesianChart2.AxisX[0].Separator.StrokeThickness = 0;
            cartesianChart2.AxisY[0].Separator.StrokeThickness = 0;
        }
        private void tablaPie()
        {
            DataTable xd = Logica.Reserva.ServiciosMasReservados("Hoy");
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection();
            foreach (DataRow dr in xd.Rows)
            {
                piechartData.Add(new PieSeries
                {

                    Title = dr["Servicio"].ToString(),
                    Values = new ChartValues<double> { Double.Parse(dr["Nro Reservas"].ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 40, 40, 40)),
                    Foreground = Brushes.White
                });
            }
            pieChart1.DefaultLegend.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199));
            pieChart1.Series = piechartData;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();
        }
        private void frmInicioGerente_Load(object sender, EventArgs e)
        {
            lblPersonasHora.Text = "" + Logica.Reservas.ContarClientesCurrentHora();
            PorcentajeReservasConfirmadas.Value = 0;
            PorcentajeServiciosHabilitados.Value = 0;
            PorcentajeReservasConfirmadas.Text = String.Format("{0:P}",0);
            PorcentajeServiciosHabilitados.Text = String.Format("{0:P}", 0);

            tablaPie();
            tabla();
            tabla2("Esta Semana");
            try
            {

            }
            catch (Exception) //exception division de 0
            {

            }
            DateTime hoy = DateTime.Today;
            //switch (hoy.ToString("dddd"))
            //{
            //    case "lunes":
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        lblNumeroClientes.Text= ""+Logica.logica.ClientesPorDia[0];
            //        break;
            //    case "martes":
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[1];
            //        break;
            //    case "miércoles":
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        Grafico.Series["ChartLinea"].MarkerStyle = MarkerStyle.Circle;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[2];
            //        break;
            //    case "jueves":
            //        Console.WriteLine(Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[3];
            //        break;
            //    case "viernes":
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[4];
            //        break;
            //    case "sábado":
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        Grafico.Series["ChartLinea"].MarkerStyle = MarkerStyle.Circle;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[5];
            //
            //        break;
            //    case "domingo":
            //        Grafico.Series["ChartLinea"].Points.AddXY("DOM", Logica.logica.ClientesPorDia[6]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("LUN", Logica.logica.ClientesPorDia[0]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MAR", Logica.logica.ClientesPorDia[1]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("MIE", Logica.logica.ClientesPorDia[2]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("JUE", Logica.logica.ClientesPorDia[3]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("VIE", Logica.logica.ClientesPorDia[4]);
            //        Grafico.Series["ChartLinea"].Points.AddXY("SAB", Logica.logica.ClientesPorDia[5]);
            //        Grafico.Series["ChartLinea"].YValueType = ChartValueType.Int32;
            //        lblNumeroClientes.Text = "" + Logica.logica.ClientesPorDia[6];
            //        break;
            //}

            lblNumeroClientes.Text = Convert.ToString(Logica.Reserva.ContarClientesHoy());
            lblReservasHoy.Text = Convert.ToString(Logica.Reservas.ContarReservasRealizadasHoy());
            lblIngresos.Text = String.Format("{0:C}", Logica.Reserva.IngresosEstaSemana());


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReservasConfirmadasTimer_Tick(object sender, EventArgs e)
        {
            

            while (PorcentajeReservasConfirmadas.Value < Logica.Reserva.GetPorcentajeConfirmados())
            {
                PorcentajeReservasConfirmadas.Value++;
                PorcentajeReservasConfirmadas.Text = String.Format("{0}%", PorcentajeReservasConfirmadas.Value);
                ReservasConfirmadasTimer.Stop();   
            }
            
            


        }

        private void ServiciosHablitadosTimer_Tick(object sender, EventArgs e)
        {
            while (PorcentajeServiciosHabilitados.Value < Logica.Servicio.GetPorcentajeServiciosHabilitados())
            {
                PorcentajeServiciosHabilitados.Value++;
                PorcentajeServiciosHabilitados.Text = String.Format("{0}%", PorcentajeServiciosHabilitados.Value);
                ServiciosHablitadosTimer.Stop();
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        //private void frmInicioGerente_Resize(object sender, EventArgs e)  
        //{
        //    contador++;
        //    if (contador > 2)
        //    {
        //        if (frmPantallaGerente.banderaResize == "Minimized")
        //        {
        //            Console.WriteLine("XDD: " + xdd);
        //            if (xdd == "Maximized")
        //                frmPantallaGerente.banderaResize = "Normal";
        //            if (xdd == "Normal")
        //                frmPantallaGerente.banderaResize = "Maximized";
        //        }
        //        if (frmPantallaGerente.banderaResize == "Maximized")
        //        {
        //            xdd = "Maximized";
        //            pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 30, this.Height / 2 - 20);
        //            pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
        //            pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos1.Location = new System.Drawing.Point(20, 0);
        //
        //            pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
        //            pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
        //            pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
        //            pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 30, this.Height / 2 - 20);
        //            pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
        //            progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 4));
        //            progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 9, pnlServicios.Height / 5);
        //            progresoAbajo.ProgressWidth = 6;
        //            progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
        //            lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
        //            lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 30, pnlServicios.Height / 2 - 10);
        //            lblSobre.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //
        //            pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 6, pnlDatos1.Width / 6 + 5);
        //            pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 17, pnlDatos1.Height / 8);
        //            lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 13, pnlDatos1.Height / 2 - 10);
        //            lblClientesHoy.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);
        //
        //            pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
        //            pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 17, pnlDatos2.Height / 8);
        //            lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2);
        //            lblSemana.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);
        //
        //            pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 6, pnlDatos3.Width / 6 + 5);
        //            pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 17, pnlDatos3.Height / 8);
        //            lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblReservasHoy.Location = new System.Drawing.Point(pnlDatos3.Width / 3 + 13, pnlDatos3.Height / 2 - 10);
        //            lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 7, pnlDatos3.Height - pnlDatos3.Height / 4);
        //
        //            pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
        //            pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 2 - 34, pnlDatos4.Height / 8);
        //            lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblServicioFavorito.Location = new System.Drawing.Point(20, pnlDatos4.Height / 2);
        //            lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);
        //
        //        }
        //        if (frmPantallaGerente.banderaResize == "Normal")
        //        {
        //            
        //            xdd = "Normal";
        //            pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
        //            pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
        //            pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos1.Location = new System.Drawing.Point(20, 0);
        //            pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
        //            pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
        //            pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
        //            pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
        //            pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
        //            progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 5));
        //            progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 12, pnlServicios.Height / 9);
        //            progresoAbajo.ProgressWidth = 20;
        //            progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
        //            lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
        //            lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 50, pnlServicios.Height / 2);
        //            lblSobre.Font = new System.Drawing.Font("Nirmala UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 5, pnlDatos1.Width / 5);
        //            pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos1.Height / 9);
        //            lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 34, pnlDatos1.Height / 2 - 10);
        //            lblClientesHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);
        //
        //            pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
        //            pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 30, pnlDatos2.Height / 9);
        //            lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2 - 10);
        //            lblSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);
        //
        //            pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 5, pnlDatos3.Width / 5);
        //            pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 30, pnlDatos3.Height / 10);
        //            lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblReservasHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos3.Height / 2 - 10);
        //            lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 6, pnlDatos3.Height - pnlDatos3.Height / 4);
        //
        //            pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
        //            pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 3, pnlDatos4.Height / 20);
        //            lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblServicioFavorito.Location = new System.Drawing.Point(15, pnlDatos4.Height / 2);
        //            lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);
        //
        //        }
        //    }
        //    else
        //    {
        //        if (f) {
        //            f = false;
        //            xdd = "Normal";
        //            pnlCapacidadHoy.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
        //            pnlCapacidadHoy.Location = new System.Drawing.Point(this.Width / 2, 0);
        //            pnlDatos1.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos1.Location = new System.Drawing.Point(20, 0);
        //            pnlDatos2.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos2.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, 0);
        //            pnlDatos3.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos3.Location = new System.Drawing.Point(20, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlDatos4.Size = new System.Drawing.Size((pnlCapacidadHoy.Width - 20) / 2 - 10, (pnlCapacidadHoy.Height - 15) / 2);
        //            pnlDatos4.Location = new System.Drawing.Point(pnlCapacidadHoy.Width / 2 + 25, pnlCapacidadHoy.Height / 2 + 8);
        //            pnlServicios.Size = new System.Drawing.Size(this.Width / 2 - 36, this.Height / 2 - 20);
        //            pnlServicios.Location = new System.Drawing.Point(20, this.Height / 2);
        //            pnlGrafica.Size = new System.Drawing.Size(this.Width / 2 - 20, this.Height / 2 - 20);
        //            pnlGrafica.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
        //            progresoAbajo.Size = new System.Drawing.Size(pnlServicios.Width / 2, pnlServicios.Height - (pnlServicios.Height / 5));
        //            progresoAbajo.Location = new System.Drawing.Point(pnlServicios.Width / 12, pnlServicios.Height / 9);
        //            progresoAbajo.ProgressWidth = 20;
        //            progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesConfirmados.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 8), pnlServicios.Height / 2 - (pnlServicios.Height / 4));
        //            lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblCantidadClientes.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4), pnlServicios.Height / 2);
        //            lblSobre.Location = new System.Drawing.Point(pnlServicios.Width / 2 + (pnlServicios.Width / 4) - 50, pnlServicios.Height / 2);
        //            lblSobre.Font = new System.Drawing.Font("Nirmala UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            pb1.Size = new System.Drawing.Size(pnlDatos1.Width / 5, pnlDatos1.Width / 5);
        //            pb1.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos1.Height / 9);
        //            lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblNumeroClientes.Location = new System.Drawing.Point(pnlDatos1.Width / 3 + 34, pnlDatos1.Height / 2 - 10);
        //            lblClientesHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblClientesHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 3, pnlDatos1.Height - pnlDatos1.Height / 4);
        //
        //            pb2.Size = new System.Drawing.Size(pnlDatos2.Width / 5, pnlDatos2.Width / 5);
        //            pb2.Location = new System.Drawing.Point(pnlDatos2.Width / 2 - 30, pnlDatos2.Height / 9);
        //            lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblIngresos.Location = new System.Drawing.Point(20, pnlDatos2.Height / 2 - 10);
        //            lblSemana.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblSemana.Location = new System.Drawing.Point(10, pnlDatos2.Height - pnlDatos2.Height / 4);
        //
        //            pb3.Size = new System.Drawing.Size(pnlDatos3.Width / 5, pnlDatos3.Width / 5);
        //            pb3.Location = new System.Drawing.Point(pnlDatos3.Width / 2 - 30, pnlDatos3.Height / 10);
        //            lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblReservasHoy.Location = new System.Drawing.Point(pnlDatos1.Width / 2 - 30, pnlDatos3.Height / 2 - 10);
        //            lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisReservas.Location = new System.Drawing.Point(pnlDatos3.Width / 6, pnlDatos3.Height - pnlDatos3.Height / 4);
        //
        //            pb4.Size = new System.Drawing.Size(pnlDatos4.Width / 3 - 10, pnlDatos4.Width / 3 - 10);
        //            pb4.Location = new System.Drawing.Point(pnlDatos4.Width / 3, pnlDatos4.Height / 20);
        //            lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblServicioFavorito.Location = new System.Drawing.Point(15, pnlDatos4.Height / 2);
        //            lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            lblGrisServicio.Location = new System.Drawing.Point(10, pnlDatos4.Height - pnlDatos4.Height / 4);
        //        }
        //        
        //    }
        //
        //}
    }
}
