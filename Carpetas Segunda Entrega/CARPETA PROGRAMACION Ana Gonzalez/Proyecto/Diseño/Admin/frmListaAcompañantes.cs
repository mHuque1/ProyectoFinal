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
    public partial class frmListaAcompañantes : Form
    {
        string Fecha;
        int CI = 0;
        string b = "";
        public frmListaAcompañantes(string fecha,int ci,string tipoUsuario)
        {
            b = tipoUsuario;
            Fecha = fecha;
            CI = ci;
            InitializeComponent();
            if(b=="Admin")
            {
                   MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                   dgvAcompañantes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                   dgvAcompañantes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            acompañantes.CargarAcompañantes(dgvAcompañantes,fecha,ci);
            eliminar.DisplayIndex = 8;
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void frmListaAcompañantes_Load(object sender, EventArgs e)
        {

        }

        private void dgvAcompañantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAcompañantes.Columns["eliminar"].Index)
            {
                DataGridViewRow row = dgvAcompañantes.Rows[e.RowIndex];
                acompañantes.BajaAcompañante(CI,Int32.Parse(row.Cells["CI"].Value.ToString()),Fecha);
                acompañantes.CargarAcompañantes(dgvAcompañantes, Fecha, CI);

            }
        }
    }
}
