namespace Spa
{
    partial class frmInicioAdministrativo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioAdministrativo));
            this.pnlDatos1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNumeroClientes = new System.Windows.Forms.Label();
            this.lblClientesHoy = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pnlDatos2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblReservasHoy = new System.Windows.Forms.Label();
            this.lblGrisReservas = new System.Windows.Forms.Label();
            this.pnlDatos4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label12 = new System.Windows.Forms.Label();
            this.ReservasConfirmadasTimer = new System.Windows.Forms.Timer(this.components);
            this.ServiciosHablitadosTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDatos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.pnlDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos1
            // 
            this.pnlDatos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos1.Controls.Add(this.pictureBox2);
            this.pnlDatos1.Controls.Add(this.lblGrisReservas);
            this.pnlDatos1.Controls.Add(this.lblReservasHoy);
            this.pnlDatos1.Location = new System.Drawing.Point(422, 0);
            this.pnlDatos1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos1.Name = "pnlDatos1";
            this.pnlDatos1.Size = new System.Drawing.Size(264, 178);
            this.pnlDatos1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Spa.Properties.Resources.xdd;
            this.pictureBox3.Location = new System.Drawing.Point(182, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // lblNumeroClientes
            // 
            this.lblNumeroClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroClientes.AutoSize = true;
            this.lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroClientes.ForeColor = System.Drawing.Color.White;
            this.lblNumeroClientes.Location = new System.Drawing.Point(160, 78);
            this.lblNumeroClientes.Name = "lblNumeroClientes";
            this.lblNumeroClientes.Size = new System.Drawing.Size(47, 34);
            this.lblNumeroClientes.TabIndex = 13;
            this.lblNumeroClientes.Text = "15";
            this.lblNumeroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientesHoy
            // 
            this.lblClientesHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientesHoy.AutoSize = true;
            this.lblClientesHoy.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.lblClientesHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblClientesHoy.Location = new System.Drawing.Point(90, 50);
            this.lblClientesHoy.Name = "lblClientesHoy";
            this.lblClientesHoy.Size = new System.Drawing.Size(89, 20);
            this.lblClientesHoy.TabIndex = 12;
            this.lblClientesHoy.Text = "Clientes hoy";
            // 
            // pb1
            // 
            this.pb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(120, 78);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(34, 39);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // pnlDatos2
            // 
            this.pnlDatos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos2.Controls.Add(this.pictureBox3);
            this.pnlDatos2.Controls.Add(this.lblClientesHoy);
            this.pnlDatos2.Controls.Add(this.lblNumeroClientes);
            this.pnlDatos2.Controls.Add(this.pb1);
            this.pnlDatos2.Location = new System.Drawing.Point(716, 0);
            this.pnlDatos2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos2.Name = "pnlDatos2";
            this.pnlDatos2.Size = new System.Drawing.Size(274, 178);
            this.pnlDatos2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Spa.Properties.Resources._9999;
            this.pictureBox2.Location = new System.Drawing.Point(101, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblReservasHoy
            // 
            this.lblReservasHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservasHoy.AutoSize = true;
            this.lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHoy.ForeColor = System.Drawing.Color.White;
            this.lblReservasHoy.Location = new System.Drawing.Point(144, 82);
            this.lblReservasHoy.Name = "lblReservasHoy";
            this.lblReservasHoy.Size = new System.Drawing.Size(47, 34);
            this.lblReservasHoy.TabIndex = 16;
            this.lblReservasHoy.Text = "15";
            this.lblReservasHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrisReservas
            // 
            this.lblGrisReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrisReservas.AutoSize = true;
            this.lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrisReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblGrisReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGrisReservas.Location = new System.Drawing.Point(40, 54);
            this.lblGrisReservas.Name = "lblGrisReservas";
            this.lblGrisReservas.Size = new System.Drawing.Size(166, 20);
            this.lblGrisReservas.TabIndex = 15;
            this.lblGrisReservas.Text = "Reservas realizadas hoy";
            this.lblGrisReservas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDatos4
            // 
            this.pnlDatos4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos4.Location = new System.Drawing.Point(15, 0);
            this.pnlDatos4.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos4.Name = "pnlDatos4";
            this.pnlDatos4.Size = new System.Drawing.Size(186, 178);
            this.pnlDatos4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.cartesianChart2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(422, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 400);
            this.panel1.TabIndex = 10;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart2.Location = new System.Drawing.Point(0, 36);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(571, 364);
            this.cartesianChart2.TabIndex = 7;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 30);
            this.label13.TabIndex = 15;
            this.label13.Text = "Clientes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.17928F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlGrafica, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.13965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.86035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 623);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnlGrafica
            // 
            this.pnlGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlGrafica, 2);
            this.pnlGrafica.Controls.Add(this.pieChart1);
            this.pnlGrafica.Controls.Add(this.label12);
            this.pnlGrafica.Location = new System.Drawing.Point(15, 208);
            this.pnlGrafica.Margin = new System.Windows.Forms.Padding(15);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(377, 400);
            this.pnlGrafica.TabIndex = 12;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Location = new System.Drawing.Point(3, 37);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(374, 363);
            this.pieChart1.TabIndex = 17;
            this.pieChart1.Text = "pieChart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 30);
            this.label12.TabIndex = 16;
            this.label12.Text = "Top servicios";
            // 
            // ReservasConfirmadasTimer
            // 
            this.ReservasConfirmadasTimer.Enabled = true;
            this.ReservasConfirmadasTimer.Interval = 500;
            // 
            // ServiciosHablitadosTimer
            // 
            this.ServiciosHablitadosTimer.Enabled = true;
            this.ServiciosHablitadosTimer.Interval = 400;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 178);
            this.panel2.TabIndex = 10;
            // 
            // frmInicioAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioAdministrativo";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicioGerente_Load);
            this.pnlDatos1.ResumeLayout(false);
            this.pnlDatos1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.pnlDatos2.ResumeLayout(false);
            this.pnlDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlGrafica.ResumeLayout(false);
            this.pnlGrafica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDatos1;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Panel pnlDatos2;
        private System.Windows.Forms.Panel pnlDatos4;
        private System.Windows.Forms.Label lblNumeroClientes;
        private System.Windows.Forms.Label lblClientesHoy;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblReservasHoy;
        private System.Windows.Forms.Label lblGrisReservas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.Timer ReservasConfirmadasTimer;
        private System.Windows.Forms.Timer ServiciosHablitadosTimer;
        private System.Windows.Forms.Panel panel2;
    }
}