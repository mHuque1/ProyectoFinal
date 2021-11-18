using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmBajaLogicaServicio : Form
    {
        string Servicio;
        public frmBajaLogicaServicio(string servicio)
        {
            Servicio = servicio;
            InitializeComponent();
        }

        private void frmBajaLogicaServicio_Load(object sender, EventArgs e)
        {
            dpHasta.MinDate = dpDesde.Value.AddDays(1);
            dpHasta.Value = dpHasta.MinDate;
        }

        private void bfbtnVerificar_Click(object sender, EventArgs e)
        {
            if(!cbIndefinido.Checked) {
                Logica.Servicio.habilitarDesabilitarServicio(Servicio, true, dpDesde.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                Logica.Servicio.habilitarDesabilitarServicio(Servicio, false, dpHasta.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                MessageBox.Show("xd");
                Logica.Servicio.habilitarDesabilitarServicio(Servicio, true, DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"));
                Logica.Servicio.habilitarDesabilitarServicio(Servicio, false, DateTime.Today.AddYears(100).ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        private void dpDesde_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDateTime(dpDesde.Value.ToString("yyyy-MM-dd HH:mm:ss")) >= Convert.ToDateTime(dpHasta.MinDate.ToString("yyyy-MM-dd HH:mm:ss")))
            {
                dpHasta.MinDate = dpDesde.Value.AddDays(1);
                dpHasta.Value = dpHasta.MinDate;
            }

        }

        private void cbIndefinido_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(cbIndefinido.Checked)
            {
                dpDesde.Enabled = false;
                dpHasta.Enabled = false;
            }
            else
            {
                dpDesde.Enabled = true;
                dpHasta.Enabled = true;
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }
    }
}
