namespace Spa
{
    partial class frmInicioGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioGerente));
            this.pnlDatos1 = new System.Windows.Forms.Panel();
            this.lblNumeroClientes = new System.Windows.Forms.Label();
            this.lblClientesHoy = new System.Windows.Forms.Label();
            this.pnlCapacidadHoy = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pnlDatos2 = new System.Windows.Forms.Panel();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.pnlDatos3 = new System.Windows.Forms.Panel();
            this.lblReservasHoy = new System.Windows.Forms.Label();
            this.lblGrisReservas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PorcentajeServiciosHabilitados = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PorcentajeReservasConfirmadas = new CircularProgressBar.CircularProgressBar();
            this.lblBarraCircular = new System.Windows.Forms.Label();
            this.ReservasConfirmadasTimer = new System.Windows.Forms.Timer(this.components);
            this.ServiciosHablitadosTimer = new System.Windows.Forms.Timer(this.components);
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDatos4 = new System.Windows.Forms.Panel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPersonasHora = new System.Windows.Forms.Label();
            this.pnlDatos1.SuspendLayout();
            this.pnlCapacidadHoy.SuspendLayout();
            this.pnlDatos2.SuspendLayout();
            this.pnlDatos3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDatos4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos1
            // 
            this.pnlDatos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos1.Controls.Add(this.pictureBox3);
            this.pnlDatos1.Controls.Add(this.lblNumeroClientes);
            this.pnlDatos1.Controls.Add(this.lblClientesHoy);
            this.pnlDatos1.Controls.Add(this.pb1);
            this.pnlDatos1.Location = new System.Drawing.Point(504, 0);
            this.pnlDatos1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos1.Name = "pnlDatos1";
            this.pnlDatos1.Size = new System.Drawing.Size(182, 89);
            this.pnlDatos1.TabIndex = 7;
            // 
            // lblNumeroClientes
            // 
            this.lblNumeroClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroClientes.AutoSize = true;
            this.lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroClientes.ForeColor = System.Drawing.Color.White;
            this.lblNumeroClientes.Location = new System.Drawing.Point(100, 43);
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
            this.lblClientesHoy.Location = new System.Drawing.Point(30, 15);
            this.lblClientesHoy.Name = "lblClientesHoy";
            this.lblClientesHoy.Size = new System.Drawing.Size(89, 20);
            this.lblClientesHoy.TabIndex = 12;
            this.lblClientesHoy.Text = "Clientes hoy";
            // 
            // pnlCapacidadHoy
            // 
            this.pnlCapacidadHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCapacidadHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlCapacidadHoy, 2);
            this.pnlCapacidadHoy.Controls.Add(this.cartesianChart1);
            this.pnlCapacidadHoy.Controls.Add(this.label7);
            this.pnlCapacidadHoy.Controls.Add(this.label8);
            this.pnlCapacidadHoy.Location = new System.Drawing.Point(504, 119);
            this.pnlCapacidadHoy.Margin = new System.Windows.Forms.Padding(15);
            this.pnlCapacidadHoy.Name = "pnlCapacidadHoy";
            this.pnlCapacidadHoy.Size = new System.Drawing.Size(486, 253);
            this.pnlCapacidadHoy.TabIndex = 8;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(0, 37);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(483, 216);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Capacidades diarias hoy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(69, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 0;
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
            this.pnlDatos2.Controls.Add(this.pictureBox4);
            this.pnlDatos2.Controls.Add(this.lblSemana);
            this.pnlDatos2.Controls.Add(this.lblIngresos);
            this.pnlDatos2.Controls.Add(this.pb2);
            this.pnlDatos2.Location = new System.Drawing.Point(716, 0);
            this.pnlDatos2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos2.Name = "pnlDatos2";
            this.pnlDatos2.Size = new System.Drawing.Size(274, 89);
            this.pnlDatos2.TabIndex = 8;
            // 
            // lblSemana
            // 
            this.lblSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSemana.Location = new System.Drawing.Point(56, 14);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(171, 17);
            this.lblSemana.TabIndex = 8;
            this.lblSemana.Text = "Ingresos de toda la semana";
            // 
            // lblIngresos
            // 
            this.lblIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.White;
            this.lblIngresos.Location = new System.Drawing.Point(86, 34);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(100, 48);
            this.lblIngresos.TabIndex = 10;
            this.lblIngresos.Text = "$4834";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDatos3
            // 
            this.pnlDatos3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos3.Controls.Add(this.pictureBox2);
            this.pnlDatos3.Controls.Add(this.pictureBox1);
            this.pnlDatos3.Controls.Add(this.lblReservasHoy);
            this.pnlDatos3.Controls.Add(this.lblGrisReservas);
            this.pnlDatos3.Location = new System.Drawing.Point(275, 0);
            this.pnlDatos3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos3.Name = "pnlDatos3";
            this.pnlDatos3.Size = new System.Drawing.Size(199, 89);
            this.pnlDatos3.TabIndex = 8;
            // 
            // lblReservasHoy
            // 
            this.lblReservasHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservasHoy.AutoSize = true;
            this.lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHoy.ForeColor = System.Drawing.Color.White;
            this.lblReservasHoy.Location = new System.Drawing.Point(106, 43);
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
            this.lblGrisReservas.Location = new System.Drawing.Point(2, 15);
            this.lblGrisReservas.Name = "lblGrisReservas";
            this.lblGrisReservas.Size = new System.Drawing.Size(166, 20);
            this.lblGrisReservas.TabIndex = 15;
            this.lblGrisReservas.Text = "Reservas realizadas hoy";
            this.lblGrisReservas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panel1.Location = new System.Drawing.Point(504, 402);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 206);
            this.panel1.TabIndex = 10;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart2.Location = new System.Drawing.Point(0, 36);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(489, 170);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.78607F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.09453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.14925F));
            this.tableLayoutPanel1.Controls.Add(this.pnlGrafica, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDatos1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCapacidadHoy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.82353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
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
            this.pnlGrafica.Location = new System.Drawing.Point(15, 119);
            this.pnlGrafica.Margin = new System.Windows.Forms.Padding(15);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(459, 253);
            this.pnlGrafica.TabIndex = 12;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Location = new System.Drawing.Point(3, 37);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(456, 216);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.PorcentajeServiciosHabilitados, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(275, 402);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.71717F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.28283F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 206);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // PorcentajeServiciosHabilitados
            // 
            this.PorcentajeServiciosHabilitados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PorcentajeServiciosHabilitados.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PorcentajeServiciosHabilitados.AnimationSpeed = 500;
            this.PorcentajeServiciosHabilitados.BackColor = System.Drawing.Color.Transparent;
            this.PorcentajeServiciosHabilitados.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.PorcentajeServiciosHabilitados.ForeColor = System.Drawing.Color.White;
            this.PorcentajeServiciosHabilitados.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.PorcentajeServiciosHabilitados.InnerMargin = 2;
            this.PorcentajeServiciosHabilitados.InnerWidth = -1;
            this.PorcentajeServiciosHabilitados.Location = new System.Drawing.Point(35, 61);
            this.PorcentajeServiciosHabilitados.Margin = new System.Windows.Forms.Padding(35, 17, 36, 17);
            this.PorcentajeServiciosHabilitados.MarqueeAnimationSpeed = 2000;
            this.PorcentajeServiciosHabilitados.Name = "PorcentajeServiciosHabilitados";
            this.PorcentajeServiciosHabilitados.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PorcentajeServiciosHabilitados.OuterMargin = -25;
            this.PorcentajeServiciosHabilitados.OuterWidth = 26;
            this.PorcentajeServiciosHabilitados.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PorcentajeServiciosHabilitados.ProgressWidth = 25;
            this.PorcentajeServiciosHabilitados.SecondaryFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PorcentajeServiciosHabilitados.Size = new System.Drawing.Size(128, 128);
            this.PorcentajeServiciosHabilitados.StartAngle = 270;
            this.PorcentajeServiciosHabilitados.SubscriptColor = System.Drawing.Color.White;
            this.PorcentajeServiciosHabilitados.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PorcentajeServiciosHabilitados.SubscriptText = "";
            this.PorcentajeServiciosHabilitados.SuperscriptColor = System.Drawing.Color.White;
            this.PorcentajeServiciosHabilitados.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PorcentajeServiciosHabilitados.SuperscriptText = "";
            this.PorcentajeServiciosHabilitados.TabIndex = 12;
            this.PorcentajeServiciosHabilitados.Text = "90%";
            this.PorcentajeServiciosHabilitados.TextMargin = new System.Windows.Forms.Padding(0);
            this.PorcentajeServiciosHabilitados.Value = 68;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Porcentaje Servicios habilitados";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.PorcentajeReservasConfirmadas, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblBarraCircular, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 402);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.47826F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.52174F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 206);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // PorcentajeReservasConfirmadas
            // 
            this.PorcentajeReservasConfirmadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PorcentajeReservasConfirmadas.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PorcentajeReservasConfirmadas.AnimationSpeed = 500;
            this.PorcentajeReservasConfirmadas.BackColor = System.Drawing.Color.Transparent;
            this.PorcentajeReservasConfirmadas.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.PorcentajeReservasConfirmadas.ForeColor = System.Drawing.Color.White;
            this.PorcentajeReservasConfirmadas.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.PorcentajeReservasConfirmadas.InnerMargin = 2;
            this.PorcentajeReservasConfirmadas.InnerWidth = -1;
            this.PorcentajeReservasConfirmadas.Location = new System.Drawing.Point(51, 63);
            this.PorcentajeReservasConfirmadas.MarqueeAnimationSpeed = 2000;
            this.PorcentajeReservasConfirmadas.Name = "PorcentajeReservasConfirmadas";
            this.PorcentajeReservasConfirmadas.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PorcentajeReservasConfirmadas.OuterMargin = -25;
            this.PorcentajeReservasConfirmadas.OuterWidth = 26;
            this.PorcentajeReservasConfirmadas.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PorcentajeReservasConfirmadas.ProgressWidth = 25;
            this.PorcentajeReservasConfirmadas.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.PorcentajeReservasConfirmadas.Size = new System.Drawing.Size(128, 128);
            this.PorcentajeReservasConfirmadas.StartAngle = 270;
            this.PorcentajeReservasConfirmadas.SubscriptColor = System.Drawing.Color.White;
            this.PorcentajeReservasConfirmadas.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PorcentajeReservasConfirmadas.SubscriptText = "";
            this.PorcentajeReservasConfirmadas.SuperscriptColor = System.Drawing.Color.White;
            this.PorcentajeReservasConfirmadas.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PorcentajeReservasConfirmadas.SuperscriptText = "";
            this.PorcentajeReservasConfirmadas.TabIndex = 12;
            this.PorcentajeReservasConfirmadas.Text = "68%";
            this.PorcentajeReservasConfirmadas.TextMargin = new System.Windows.Forms.Padding(0);
            this.PorcentajeReservasConfirmadas.Value = 68;
            // 
            // lblBarraCircular
            // 
            this.lblBarraCircular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBarraCircular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBarraCircular.ForeColor = System.Drawing.Color.White;
            this.lblBarraCircular.Location = new System.Drawing.Point(15, 0);
            this.lblBarraCircular.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblBarraCircular.Name = "lblBarraCircular";
            this.lblBarraCircular.Size = new System.Drawing.Size(215, 48);
            this.lblBarraCircular.TabIndex = 11;
            this.lblBarraCircular.Text = "Porcentaje reservas confirmadas";
            // 
            // ReservasConfirmadasTimer
            // 
            this.ReservasConfirmadasTimer.Enabled = true;
            this.ReservasConfirmadasTimer.Interval = 500;
            this.ReservasConfirmadasTimer.Tick += new System.EventHandler(this.ReservasConfirmadasTimer_Tick);
            // 
            // ServiciosHablitadosTimer
            // 
            this.ServiciosHablitadosTimer.Enabled = true;
            this.ServiciosHablitadosTimer.Interval = 400;
            this.ServiciosHablitadosTimer.Tick += new System.EventHandler(this.ServiciosHablitadosTimer_Tick);
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Interval = 1000;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::Spa.Properties.Resources.xdd;
            this.pictureBox4.Location = new System.Drawing.Point(230, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(38, 34);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(42, 48);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Spa.Properties.Resources.xdd;
            this.pictureBox3.Location = new System.Drawing.Point(122, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(60, 43);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(34, 39);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Spa.Properties.Resources._9999;
            this.pictureBox2.Location = new System.Drawing.Point(63, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Spa.Properties.Resources.xdd;
            this.pictureBox1.Location = new System.Drawing.Point(165, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDatos4
            // 
            this.pnlDatos4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlDatos4.Controls.Add(this.lblPersonasHora);
            this.pnlDatos4.Controls.Add(this.label3);
            this.pnlDatos4.Controls.Add(this.lblReloj);
            this.pnlDatos4.Location = new System.Drawing.Point(15, 0);
            this.pnlDatos4.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.pnlDatos4.Name = "pnlDatos4";
            this.pnlDatos4.Size = new System.Drawing.Size(230, 89);
            this.pnlDatos4.TabIndex = 9;
            // 
            // lblReloj
            // 
            this.lblReloj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReloj.ForeColor = System.Drawing.Color.White;
            this.lblReloj.Location = new System.Drawing.Point(74, 7);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(91, 30);
            this.lblReloj.TabIndex = 7;
            this.lblReloj.Text = "14:00:00";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(47, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "Personas reservadas \r\npara esta hora: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonasHora
            // 
            this.lblPersonasHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonasHora.AutoSize = true;
            this.lblPersonasHora.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonasHora.ForeColor = System.Drawing.Color.White;
            this.lblPersonasHora.Location = new System.Drawing.Point(165, 58);
            this.lblPersonasHora.Name = "lblPersonasHora";
            this.lblPersonasHora.Size = new System.Drawing.Size(28, 21);
            this.lblPersonasHora.TabIndex = 18;
            this.lblPersonasHora.Text = "15";
            this.lblPersonasHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInicioGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioGerente";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicioGerente_Load);
            this.pnlDatos1.ResumeLayout(false);
            this.pnlDatos1.PerformLayout();
            this.pnlCapacidadHoy.ResumeLayout(false);
            this.pnlCapacidadHoy.PerformLayout();
            this.pnlDatos2.ResumeLayout(false);
            this.pnlDatos2.PerformLayout();
            this.pnlDatos3.ResumeLayout(false);
            this.pnlDatos3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlGrafica.ResumeLayout(false);
            this.pnlGrafica.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDatos4.ResumeLayout(false);
            this.pnlDatos4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDatos1;
        private System.Windows.Forms.Panel pnlCapacidadHoy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Panel pnlDatos2;
        private System.Windows.Forms.Panel pnlDatos3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblSemana;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CircularProgressBar.CircularProgressBar PorcentajeServiciosHabilitados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CircularProgressBar.CircularProgressBar PorcentajeReservasConfirmadas;
        private System.Windows.Forms.Label lblBarraCircular;
        private System.Windows.Forms.Timer ReservasConfirmadasTimer;
        private System.Windows.Forms.Timer ServiciosHablitadosTimer;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Panel pnlDatos4;
        private System.Windows.Forms.Label lblPersonasHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReloj;
    }
}