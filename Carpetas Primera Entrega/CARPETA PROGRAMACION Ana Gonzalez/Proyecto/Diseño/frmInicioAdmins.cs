using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmInicioAdmin : Form
    {
        public frmInicioAdmin()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();

            this.Grafico.Series["ChartLinea"].Points.AddXY("LUN", 10);
            this.Grafico.Series["ChartLinea"].Points.AddXY("MAR", 20);
            this.Grafico.Series["ChartLinea"].Points.AddXY("MIE", 30);
            this.Grafico.Series["ChartLinea"].Points.AddXY("JUE", 40);
            this.Grafico.Series["ChartLinea"].Points.AddXY("VIE", 50);
            this.Grafico.Series["ChartLinea"].Points.AddXY("SAB", 40);
            this.Grafico.Series["ChartLinea"].Points.AddXY("DOM", 20);
        }

        
    }
}
