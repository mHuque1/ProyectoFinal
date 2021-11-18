using Diseño.Messages;
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

namespace Diseño.Gerente
{
    public partial class frmModificacionPrecio : Form
    {
        //Declaraciones
        //#############################################################################################
        int x;
        //#############################################################################################
        public frmModificacionPrecio()
        {
            InitializeComponent();
        }
        
        //Botones
        //#############################################################################################
        private void frmModificacionPrecio_Load(object sender, EventArgs e)
        {
            if (Logica.precios.Columns.Count <= 0)
            {
                Logica.precios.Columns.Add("Servicio", typeof(string));
                Logica.precios.Columns.Add("Precio", typeof(string));
                Logica.precios.Rows.Add("Entrada Estandar", "150");
                Logica.precios.Rows.Add("Entrada Turistas", "100");
                Logica.precios.Rows.Add("Entrada Jubilados", "80");
                Logica.precios.Rows.Add("Masaje Tradicional", "600");
                Logica.precios.Rows.Add("Masaje Oriental", "700");
                Logica.precios.Rows.Add("Yoga/Pilates", "800");
                Logica.precios.Rows.Add("Meditacion", "500");
                Logica.precios.Rows.Add("Alquiler de bicicletas", "100");
                Logica.precios.Rows.Add("Cabalgatas", "500");
                Logica.precios.Rows.Add("Paseo bote", "400");
                Logica.precios.Rows.Add("Traslados", "350");
            }
            dgvPrecios.DataSource = Logica.precios;
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvPrecios.Rows[x];

                if (txtPrecio.Text == row.Cells["Precio"].Value.ToString()) {
                    
                }
                else {
                    foreach (DataRow dr in Logica.precios.Rows)
                    {
                        if (dr["Servicio"].ToString() == lblServicio.Text)
                        {
                            dr["Precio"] = txtPrecio.Text;
                            break;
                        }
                    }
                    frmCorrecto dou = new frmCorrecto("Precio modificado \ncorrectamente", 1);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            } catch (System.ArgumentOutOfRangeException ) { }               
        }     
        private void dgvPrecios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblServicio.Location = new System.Drawing.Point(11, 126);
            try {
                DataGridViewRow row = this.dgvPrecios.Rows[e.RowIndex];
                x = e.RowIndex;
                lblServicio.Text = row.Cells["Servicio"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            } catch(System.ArgumentOutOfRangeException f) { }
            
            
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
            }
        }
        //#############################################################################################
    }
}
