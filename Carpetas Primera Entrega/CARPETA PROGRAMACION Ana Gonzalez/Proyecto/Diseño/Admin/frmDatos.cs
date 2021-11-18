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
    public partial class frmDatos : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        string b;
        Panel xd;
        //#############################################################################################

        public frmDatos(Panel a, String TipoUsuario)
        {
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {
                
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
        }
        
        //etc.
        //#############################################################################################
        private void frmDatos_Load(object sender, EventArgs e)
        {

            dgvCliente.DataSource = Logica.DatosClientes;
            DataGridViewButtonColumn servicioColumna = new DataGridViewButtonColumn();
            servicioColumna.Name = "Servicios";
            servicioColumna.Text = "Mostrar";
            servicioColumna.HeaderText = "Servicios";
            servicioColumna.UseColumnTextForButtonValue = true;
            int columnIndex = 6;
            if (dgvCliente.Columns["Servicios"] == null)
            {
                if(dgvCliente.Columns.Count != 0)
                {
                    dgvCliente.Columns.Insert(columnIndex, servicioColumna);
                }
                
            }

        }    
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvCliente.Columns["Servicios"].Index)
                {

                    DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();

                    frmServiciosCliente dou = new frmServiciosCliente(b);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }catch(ArgumentOutOfRangeException)
            {
                
            }
           
        }
        //#############################################################################################
    }
}
  
