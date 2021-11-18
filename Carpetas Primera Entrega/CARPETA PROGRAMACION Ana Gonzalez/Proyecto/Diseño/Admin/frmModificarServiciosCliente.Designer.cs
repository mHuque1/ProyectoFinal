namespace Diseño
{
    partial class frmModificarServiciosCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelHoras = new System.Windows.Forms.Panel();
            this.btnBorrarReserva = new System.Windows.Forms.Button();
            this.btnCambiarFechaHora = new System.Windows.Forms.Button();
            this.cboxHoras = new System.Windows.Forms.ComboBox();
            this.btnMostrarDisponibilidad = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.panelHoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicios.ColumnHeadersHeight = 30;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicios.EnableHeadersVisualStyles = false;
            this.dgvServicios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServicios.Location = new System.Drawing.Point(12, 33);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvServicios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServicios.Size = new System.Drawing.Size(533, 355);
            this.dgvServicios.TabIndex = 1;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            this.dgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCerrar.Location = new System.Drawing.Point(551, 316);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(347, 60);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // panelHoras
            // 
            this.panelHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHoras.Controls.Add(this.btnBorrarReserva);
            this.panelHoras.Controls.Add(this.btnCambiarFechaHora);
            this.panelHoras.Controls.Add(this.cboxHoras);
            this.panelHoras.Controls.Add(this.btnMostrarDisponibilidad);
            this.panelHoras.Enabled = false;
            this.panelHoras.Location = new System.Drawing.Point(551, 67);
            this.panelHoras.Name = "panelHoras";
            this.panelHoras.Size = new System.Drawing.Size(347, 207);
            this.panelHoras.TabIndex = 5;
            // 
            // btnBorrarReserva
            // 
            this.btnBorrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBorrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBorrarReserva.Location = new System.Drawing.Point(189, 122);
            this.btnBorrarReserva.Name = "btnBorrarReserva";
            this.btnBorrarReserva.Size = new System.Drawing.Size(124, 67);
            this.btnBorrarReserva.TabIndex = 7;
            this.btnBorrarReserva.Text = "Borrar servicio";
            this.btnBorrarReserva.UseVisualStyleBackColor = false;
            this.btnBorrarReserva.Click += new System.EventHandler(this.btnBorrarReserva_Click);
            // 
            // btnCambiarFechaHora
            // 
            this.btnCambiarFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCambiarFechaHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarFechaHora.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFechaHora.Location = new System.Drawing.Point(31, 122);
            this.btnCambiarFechaHora.Name = "btnCambiarFechaHora";
            this.btnCambiarFechaHora.Size = new System.Drawing.Size(152, 67);
            this.btnCambiarFechaHora.TabIndex = 3;
            this.btnCambiarFechaHora.Text = "Modificar Reserva";
            this.btnCambiarFechaHora.UseVisualStyleBackColor = false;
            this.btnCambiarFechaHora.Click += new System.EventHandler(this.btnCambiarFechaHora_Click);
            // 
            // cboxHoras
            // 
            this.cboxHoras.Enabled = false;
            this.cboxHoras.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboxHoras.FormattingEnabled = true;
            this.cboxHoras.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00"});
            this.cboxHoras.Location = new System.Drawing.Point(31, 36);
            this.cboxHoras.Name = "cboxHoras";
            this.cboxHoras.Size = new System.Drawing.Size(152, 33);
            this.cboxHoras.TabIndex = 2;
            // 
            // btnMostrarDisponibilidad
            // 
            this.btnMostrarDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMostrarDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarDisponibilidad.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDisponibilidad.Location = new System.Drawing.Point(189, 17);
            this.btnMostrarDisponibilidad.Name = "btnMostrarDisponibilidad";
            this.btnMostrarDisponibilidad.Size = new System.Drawing.Size(124, 72);
            this.btnMostrarDisponibilidad.TabIndex = 0;
            this.btnMostrarDisponibilidad.Text = "mostrar horas disponibles";
            this.btnMostrarDisponibilidad.UseVisualStyleBackColor = false;
            this.btnMostrarDisponibilidad.Click += new System.EventHandler(this.btnMostrarDisponibilidad_Click);
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(642, 33);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(111, 31);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "Servicio";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModificarServiciosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(928, 417);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.panelHoras);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarServiciosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios del Cliente";
            this.Load += new System.EventHandler(this.frmModificarServiciosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.panelHoras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvServicios;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelHoras;
        private System.Windows.Forms.ComboBox cboxHoras;
        private System.Windows.Forms.Button btnMostrarDisponibilidad;

        private System.Windows.Forms.Button btnCambiarFechaHora;
        public System.Windows.Forms.Button btnBorrarReserva;
        private System.Windows.Forms.Label lblServicio;
    }
}