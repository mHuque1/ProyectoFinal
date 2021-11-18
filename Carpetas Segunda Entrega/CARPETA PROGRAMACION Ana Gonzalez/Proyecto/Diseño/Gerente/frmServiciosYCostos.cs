using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmServiciosYCostos : Form
    {
        public frmServiciosYCostos()
        {
            InitializeComponent();
        }

        private void frmServiciosYCostos_Load(object sender, EventArgs e)
        {

            Logica.Servicio.mostrarTablaServicios(dgvServicios);
            Logica.Entrada.mostrarTablaEntradas(dgvEntradas);
            eliminar.DisplayIndex = 7;
            editar.DisplayIndex = 6;
            EntradaEditar.DisplayIndex = 3;

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                dgvServicios.FirstDisplayedScrollingRowIndex = dgvServicios.Rows[e.Value].Index;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void dgvServicios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrollBarServicios.Maximum = dgvServicios.RowCount;
            }
            catch (Exception)
            {

            }

        }

        private void dgvServicios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrollBarServicios.Maximum = dgvServicios.RowCount;
            }
            catch (Exception)
            {

            }
        }

        private void crollBarEntradas_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                dgvEntradas.FirstDisplayedScrollingRowIndex = dgvEntradas.Rows[e.Value].Index;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void dgvEntradas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrollBarEntradas.Maximum = dgvEntradas.RowCount;
            }
            catch (Exception)
            {

            }
        }

        private void dgvEntradas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrollBarEntradas.Maximum = dgvEntradas.RowCount;
            }
            catch (Exception)
            {

            }
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvServicios.Columns["editar"].Index)
            {
                DataGridViewRow row = dgvServicios.Rows[e.RowIndex];
                string servicio = row.Cells["Servicio"].Value.ToString();
                int costo = Int32.Parse(row.Cells["Costo"].Value.ToString());
                MessageBox.Show(servicio + " " + costo);
                frmmodificacionServicio dou = new frmmodificacionServicio(servicio);
                if (dou.ShowDialog() == DialogResult.OK)
                {
                    Logica.Servicio.mostrarTablaServicios(dgvServicios);
                    eliminar.DisplayIndex = 7;
                    editar.DisplayIndex = 6;
                }
            }
            if (e.ColumnIndex == dgvServicios.Columns["eliminar"].Index)
            {
                DataGridViewRow row = dgvServicios.Rows[e.RowIndex];
                string servicio = row.Cells["Servicio"].Value.ToString();
                int costo = Int32.Parse(row.Cells["Costo"].Value.ToString());
                MessageBox.Show(servicio + " " + costo);
                VerificadorPass passxd = new VerificadorPass();
                if (passxd.ShowDialog() == DialogResult.OK)
                {
                    frmBajaLogicaServicio dou = new frmBajaLogicaServicio(servicio);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        Logica.Servicio.mostrarTablaServicios(dgvServicios);
                        eliminar.DisplayIndex = 6;
                        editar.DisplayIndex = 5;
                    }
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Logica.Servicio.buscarServicio(txtBuscador.Text, dgvServicios);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text == string.Empty)
                Logica.Servicio.mostrarTablaServicios(dgvServicios);
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            frmAltaServicio xd = new frmAltaServicio();
            if (xd.ShowDialog() == DialogResult.OK)
            {
                Logica.Servicio.mostrarTablaServicios(dgvServicios);
                eliminar.DisplayIndex = 7;
                editar.DisplayIndex = 6;
            }
        }

        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaEntrada xd = new frmAltaEntrada();
            if (xd.ShowDialog() == DialogResult.OK)
            {
                Logica.Entrada.mostrarTablaEntradas(dgvEntradas);
                eliminar.DisplayIndex = 7;
                editar.DisplayIndex = 6;
            }
        }

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEntradas.Columns["EntradaEditar"].Index)
            {
                DataGridViewRow row = dgvEntradas.Rows[e.RowIndex];
                string servicio = row.Cells["Entrada"].Value.ToString();
                VerificadorPass passxd = new VerificadorPass();
                if (passxd.ShowDialog() == DialogResult.OK)
                {
                    frmModificacionEntrada dou = new frmModificacionEntrada(servicio);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        Logica.Entrada.mostrarTablaEntradas(dgvEntradas);
                    }
                }

            }
        }
    }
}
