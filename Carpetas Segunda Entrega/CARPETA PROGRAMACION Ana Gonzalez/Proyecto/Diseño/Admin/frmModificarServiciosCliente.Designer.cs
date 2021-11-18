namespace Spa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.panelHoras = new System.Windows.Forms.Panel();
            this.btnBorrarReserva = new System.Windows.Forms.Button();
            this.btnCambiarFechaHora = new System.Windows.Forms.Button();
            this.cboxHoras = new System.Windows.Forms.ComboBox();
            this.btnMostrarDisponibilidad = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.panelHoras.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvServicios.ColumnHeadersHeight = 30;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvServicios.EnableHeadersVisualStyles = false;
            this.dgvServicios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServicios.Location = new System.Drawing.Point(12, 91);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvServicios.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvServicios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(737, 433);
            this.dgvServicios.TabIndex = 1;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            // 
            // panelHoras
            // 
            this.panelHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelHoras.Controls.Add(this.btnBorrarReserva);
            this.panelHoras.Controls.Add(this.btnCambiarFechaHora);
            this.panelHoras.Controls.Add(this.cboxHoras);
            this.panelHoras.Controls.Add(this.btnMostrarDisponibilidad);
            this.panelHoras.Enabled = false;
            this.panelHoras.Location = new System.Drawing.Point(761, 202);
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
            this.btnCambiarFechaHora.Text = "Modificar Hora";
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
            this.lblServicio.Location = new System.Drawing.Point(875, 145);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(111, 31);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "Servicio";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1114, 54);
            this.MenuTop.TabIndex = 7;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.CorrectoSalirbtn1;
            this.btnSalir.Location = new System.Drawing.Point(1071, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmModificarServiciosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1114, 590);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.panelHoras);
            this.Controls.Add(this.dgvServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarServiciosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios del Cliente";
            this.Load += new System.EventHandler(this.frmModificarServiciosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.panelHoras.ResumeLayout(false);
            this.MenuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Panel panelHoras;
        private System.Windows.Forms.ComboBox cboxHoras;
        private System.Windows.Forms.Button btnMostrarDisponibilidad;

        private System.Windows.Forms.Button btnCambiarFechaHora;
        public System.Windows.Forms.Button btnBorrarReserva;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
    }
}