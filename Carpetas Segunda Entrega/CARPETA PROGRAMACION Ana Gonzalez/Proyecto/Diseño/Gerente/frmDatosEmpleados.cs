using System;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmDatosEmpleados : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        string b;
        Panel xd;
        //#############################################################################################
        public frmDatosEmpleados(Panel a, String TipoUsuario)
        {
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {
                
                dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
        }    
        //etc.
        //#############################################################################################
        private void frmDatosClientes_Load(object sender, EventArgs e)
        {

            this.usuarioTableAdapter.Fill(this.testDataSet.usuario);

        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvEmpleados.Columns["editar"].Index)
                {
                    DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();
                    string cedula = row.Cells["cedulaDataGridViewTextBoxColumn"].Value.ToString();
                    frmModificacionEmpleado dou = new frmModificacionEmpleado(xd, b, Int32.Parse(cedula));
                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        this.usuarioTableAdapter.Fill(this.testDataSet.usuario);
                        dgvEmpleados.DataSource = null;
                        dgvEmpleados.DataSource = usuarioBindingSource;
                    }
                }
                else if (e.ColumnIndex == dgvEmpleados.Columns["eliminar"].Index)
                {
                    DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();
                    string cedula = row.Cells["cedulaDataGridViewTextBoxColumn"].Value.ToString();
                    if (MessageBox.Show("Estas seguro que quieres eliminar a este Empleado?", "Baja Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        VerificadorPass dou = new VerificadorPass();
                        if (dou.ShowDialog() == DialogResult.OK)
                        {
                            Logica.Usuarios.bajaUsuario(Int32.Parse(cedula));
                            MessageBox.Show("Empleado Eliminado");
                            this.usuarioTableAdapter.Fill(this.testDataSet.usuario);
                            dgvEmpleados.DataSource = null;
                            dgvEmpleados.DataSource = usuarioBindingSource;
                        }
                    }
                }  
            }
            catch(ArgumentOutOfRangeException)
            {
                
            }
           
        }


        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            frmdou dou = new frmdou();
            if (dou.ShowDialog() == DialogResult.OK)
            {
                this.usuarioTableAdapter.Fill(this.testDataSet.usuario);
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = usuarioBindingSource;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.FillWithFiltro(this.testDataSet.usuario, "%"+txtBuscador.Text+"%");
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = usuarioBindingSource;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text == string.Empty) {
                this.usuarioTableAdapter.Fill(this.testDataSet.usuario);
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = usuarioBindingSource;
            }
            
        }


        //#############################################################################################
    }
}
  
