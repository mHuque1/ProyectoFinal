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

namespace Diseño
{
    public partial class frmServiciosCliente : Form
    {
        string b;
        public frmServiciosCliente(string TipoUsuario)
        {
            InitializeComponent();
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {

                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
        }
        private void frmServiciosCliente_Load(object sender, EventArgs e)
        {
            
            dgvServicios.DataSource = Logica.ServiciosClientes;
            if (dgvServicios.Columns.Count > 0) {
                string buscar = "CI = '" + frmDatos.txtID + "'";
                DataRow[] foundRows = Logica.ServiciosClientes.Select(buscar);
                if (foundRows.Length <= 0) {
                    MessageBox.Show("No hay servicios registrados para este cliente");
                    this.Close();
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvServicios.DataSource;
                    bs.Filter = "CI = '" + frmDatos.txtID + "'";
                    dgvServicios.DataSource = bs;
                }
        }
            else
            {
                MessageBox.Show("No hay servicios registrados");
                this.Close();
            }
                
            
        }

       
    }
}
