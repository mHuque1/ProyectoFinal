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

namespace Diseño
{
    public partial class frmModificacionCliente : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        Panel xd;
        string b ="";
        int x;
        string cedula;
        //#############################################################################################

        //botones etc.
        //#############################################################################################
        public frmModificacionCliente(Panel a, string TipoUsuario)
        {

            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {
                this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
        }
        private void frmModificacionCliente_Load(object sender, EventArgs e)
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
                if (dgvCliente.Columns.Count != 0)
                {
                    dgvCliente.Columns.Insert(columnIndex, servicioColumna);
                }

            }
        }      
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try{
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                x = e.RowIndex;
                txtID = row.Cells[1].Value.ToString();
                if (row.Cells["CI"].Value.ToString() != "" && e.ColumnIndex != dgvCliente.Columns["Servicios"].Index)
                {
                    txtCedula.Text = row.Cells["CI"].Value.ToString();
                    cedula = row.Cells["CI"].Value.ToString();
                    txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                    txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                    txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                    txtDireccion.Text = row.Cells["Dirección"].Value.ToString();
                    txtAPagar.Text = row.Cells["Total a pagar"].Value.ToString();

                }
                else if (e.ColumnIndex == dgvCliente.Columns["Servicios"].Index && row.Cells["CI"].Value.ToString() != "")
                {
                    string cedula = row.Cells["CI"].Value.ToString();
                    frmModificarServiciosCliente dou = new frmModificarServiciosCliente(b);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        string buscar = "CI = '" + frmModificacionCliente.txtID + "'";
                        DataRow[] foundRows = Logica.ServiciosClientes.Select(buscar);
                        if (foundRows.Length <= 0)
                        {
                            foreach (DataRow dr in Logica.DatosClientes.Rows)
                            {

                                if (dr["CI"].ToString() == cedula)
                                { dr["Total a pagar"] = "0"; break; }
                            }
                                    frmCorrecto xd = new frmCorrecto("Desea Borrar los\ndatos del cliente?", 3);
                            if (xd.ShowDialog() == DialogResult.OK)
                            {
                                Logica.borrarCliente(txtID);
                            }
                        }
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            { 
                foreach (DataRow dr2 in Logica.ServiciosClientes.Rows)
                {
                    foreach (DataRow dr in Logica.DatosClientes.Rows)
                    {
                        if (dr["CI"].ToString() == cedula)
                        {
                            if (dr2["CI"].ToString() == cedula)
                            {
                                cedula = txtCedula.Text;
                                dr2["CI"] = txtCedula.Text;
                                dr["CI"] = txtCedula.Text;
                                dr["Nombre"] = txtNombre.Text;
                                dr["Apellido"] = txtApellido.Text;
                                dr["Correo"] = txtCorreo.Text;
                                dr["Telefono"] = txtTelefono.Text;
                                dr["Dirección"] = txtDireccion.Text;
                                dr["Total a pagar"] = txtAPagar.Text;
                            }
                        }
                    }
                }
                frmCorrecto dou = new frmCorrecto("Cliente modificado \ncorrectamente", 1);
                if (dou.ShowDialog() == DialogResult.OK)
                {
                }

            }
            catch (System.ArgumentOutOfRangeException d) { }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //#############################################################################################
    }
}
