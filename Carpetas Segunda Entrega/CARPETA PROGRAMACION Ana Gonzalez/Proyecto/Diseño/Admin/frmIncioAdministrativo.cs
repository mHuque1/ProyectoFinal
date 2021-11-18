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

    public partial class frmInicioAdministrativo : Form
    {
        public static int contador = 0;

        public frmInicioAdministrativo()
        {
            InitializeComponent();
        }
        
        private void tabla2(string rango)
        {
            DataTable xd = Logica.Reserva.NroClientes(rango);
            cartesianChart2.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 600);
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
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,0, 126, 249)),
                    PointGeometrySize = 15,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(128,0, 126, 249))
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
            tablaPie();
            tabla2("Esta Semana");
            lblNumeroClientes.Text = Convert.ToString(Logica.Reserva.ContarClientesHoy());
            lblReservasHoy.Text = Convert.ToString(Logica.Reservas.ContarReservasRealizadasHoy());
        


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


      

    
    }
}
