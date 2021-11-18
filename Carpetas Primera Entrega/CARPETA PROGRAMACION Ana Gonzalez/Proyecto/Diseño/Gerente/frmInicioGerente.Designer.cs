namespace Diseño
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.lblSobre = new System.Windows.Forms.Label();
            this.progresoAbajo = new CircularProgressBar.CircularProgressBar();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblBarraCircular = new System.Windows.Forms.Label();
            this.lblClientesConfirmados = new System.Windows.Forms.Label();
            this.pnlDatos1 = new System.Windows.Forms.Panel();
            this.lblNumeroClientes = new System.Windows.Forms.Label();
            this.lblClientesHoy = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pnlCapacidadHoy = new System.Windows.Forms.Panel();
            this.chartCapacidades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pnlDatos2 = new System.Windows.Forms.Panel();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pnlDatos3 = new System.Windows.Forms.Panel();
            this.lblReservasHoy = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.lblGrisReservas = new System.Windows.Forms.Label();
            this.pnlDatos4 = new System.Windows.Forms.Panel();
            this.lblServicioFavorito = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.lblGrisServicio = new System.Windows.Forms.Label();
            this.pnlServicios.SuspendLayout();
            this.pnlDatos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.pnlCapacidadHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapacidades)).BeginInit();
            this.pnlGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.pnlDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.pnlDatos3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.pnlDatos4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlServicios
            // 
            this.pnlServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlServicios.Controls.Add(this.lblSobre);
            this.pnlServicios.Controls.Add(this.progresoAbajo);
            this.pnlServicios.Controls.Add(this.lblCantidadClientes);
            this.pnlServicios.Controls.Add(this.lblBarraCircular);
            this.pnlServicios.Controls.Add(this.lblClientesConfirmados);
            this.pnlServicios.Location = new System.Drawing.Point(20, 269);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(433, 251);
            this.pnlServicios.TabIndex = 0;
            // 
            // lblSobre
            // 
            this.lblSobre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSobre.Location = new System.Drawing.Point(280, 138);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(29, 37);
            this.lblSobre.TabIndex = 9;
            this.lblSobre.Text = "/";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progresoAbajo
            // 
            this.progresoAbajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progresoAbajo.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progresoAbajo.AnimationFunction")));
            this.progresoAbajo.AnimationSpeed = 500;
            this.progresoAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.progresoAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresoAbajo.ForeColor = System.Drawing.Color.White;
            this.progresoAbajo.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.progresoAbajo.InnerMargin = 2;
            this.progresoAbajo.InnerWidth = -1;
            this.progresoAbajo.Location = new System.Drawing.Point(93, 72);
            this.progresoAbajo.MarqueeAnimationSpeed = 2000;
            this.progresoAbajo.Name = "progresoAbajo";
            this.progresoAbajo.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.progresoAbajo.OuterMargin = -25;
            this.progresoAbajo.OuterWidth = 26;
            this.progresoAbajo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.progresoAbajo.ProgressWidth = 6;
            this.progresoAbajo.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.progresoAbajo.Size = new System.Drawing.Size(142, 136);
            this.progresoAbajo.StartAngle = 270;
            this.progresoAbajo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresoAbajo.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresoAbajo.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progresoAbajo.SubscriptText = "";
            this.progresoAbajo.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresoAbajo.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progresoAbajo.SuperscriptText = "";
            this.progresoAbajo.TabIndex = 7;
            this.progresoAbajo.Text = "68%";
            this.progresoAbajo.TextMargin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.progresoAbajo.Value = 68;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblCantidadClientes.Location = new System.Drawing.Point(305, 144);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(61, 30);
            this.lblCantidadClientes.TabIndex = 8;
            this.lblCantidadClientes.Text = "1000\r\n";
            this.lblCantidadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarraCircular
            // 
            this.lblBarraCircular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBarraCircular.AutoSize = true;
            this.lblBarraCircular.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.lblBarraCircular.ForeColor = System.Drawing.Color.White;
            this.lblBarraCircular.Location = new System.Drawing.Point(3, 8);
            this.lblBarraCircular.Name = "lblBarraCircular";
            this.lblBarraCircular.Size = new System.Drawing.Size(283, 25);
            this.lblBarraCircular.TabIndex = 5;
            this.lblBarraCircular.Text = "Clientes con reserva confirmada";
            // 
            // lblClientesConfirmados
            // 
            this.lblClientesConfirmados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientesConfirmados.AutoSize = true;
            this.lblClientesConfirmados.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesConfirmados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblClientesConfirmados.Location = new System.Drawing.Point(251, 90);
            this.lblClientesConfirmados.Name = "lblClientesConfirmados";
            this.lblClientesConfirmados.Size = new System.Drawing.Size(115, 54);
            this.lblClientesConfirmados.TabIndex = 6;
            this.lblClientesConfirmados.Text = "1000\r\n";
            // 
            // pnlDatos1
            // 
            this.pnlDatos1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDatos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlDatos1.Controls.Add(this.lblNumeroClientes);
            this.pnlDatos1.Controls.Add(this.lblClientesHoy);
            this.pnlDatos1.Controls.Add(this.pb1);
            this.pnlDatos1.Location = new System.Drawing.Point(20, 0);
            this.pnlDatos1.Name = "pnlDatos1";
            this.pnlDatos1.Size = new System.Drawing.Size(209, 118);
            this.pnlDatos1.TabIndex = 7;
            // 
            // lblNumeroClientes
            // 
            this.lblNumeroClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroClientes.AutoSize = true;
            this.lblNumeroClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroClientes.ForeColor = System.Drawing.Color.White;
            this.lblNumeroClientes.Location = new System.Drawing.Point(83, 54);
            this.lblNumeroClientes.Name = "lblNumeroClientes";
            this.lblNumeroClientes.Size = new System.Drawing.Size(47, 34);
            this.lblNumeroClientes.TabIndex = 13;
            this.lblNumeroClientes.Text = "15";
            this.lblNumeroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientesHoy
            // 
            this.lblClientesHoy.AutoSize = true;
            this.lblClientesHoy.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblClientesHoy.Location = new System.Drawing.Point(70, 88);
            this.lblClientesHoy.Name = "lblClientesHoy";
            this.lblClientesHoy.Size = new System.Drawing.Size(78, 17);
            this.lblClientesHoy.TabIndex = 12;
            this.lblClientesHoy.Text = "Clientes hoy";
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(89, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(34, 39);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            // 
            // pnlCapacidadHoy
            // 
            this.pnlCapacidadHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCapacidadHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlCapacidadHoy.Controls.Add(this.chartCapacidades);
            this.pnlCapacidadHoy.Controls.Add(this.label7);
            this.pnlCapacidadHoy.Controls.Add(this.label8);
            this.pnlCapacidadHoy.Location = new System.Drawing.Point(471, 0);
            this.pnlCapacidadHoy.Name = "pnlCapacidadHoy";
            this.pnlCapacidadHoy.Size = new System.Drawing.Size(448, 251);
            this.pnlCapacidadHoy.TabIndex = 8;
            // 
            // chartCapacidades
            // 
            this.chartCapacidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCapacidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.chartCapacidades.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCapacidades.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCapacidades.Legends.Add(legend1);
            this.chartCapacidades.Location = new System.Drawing.Point(0, 29);
            this.chartCapacidades.Name = "chartCapacidades";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            series1.Font = new System.Drawing.Font("Corbel", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "ChartLinea";
            this.chartCapacidades.Series.Add(series1);
            this.chartCapacidades.Size = new System.Drawing.Size(448, 222);
            this.chartCapacidades.TabIndex = 17;
            this.chartCapacidades.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 25);
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
            // pnlGrafica
            // 
            this.pnlGrafica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlGrafica.Controls.Add(this.Grafico);
            this.pnlGrafica.Controls.Add(this.label12);
            this.pnlGrafica.Controls.Add(this.label13);
            this.pnlGrafica.Location = new System.Drawing.Point(471, 269);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(448, 251);
            this.pnlGrafica.TabIndex = 10;
            // 
            // Grafico
            // 
            this.Grafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Grafico.BorderlineWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.Grafico.Legends.Add(legend2);
            this.Grafico.Location = new System.Drawing.Point(0, 58);
            this.Grafico.Name = "Grafico";
            series2.BorderWidth = 8;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            series2.EmptyPointStyle.BorderColor = System.Drawing.Color.Black;
            series2.EmptyPointStyle.BorderWidth = 3;
            series2.EmptyPointStyle.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            series2.MarkerSize = 10;
            series2.Name = "ChartLinea";
            this.Grafico.Series.Add(series2);
            this.Grafico.Size = new System.Drawing.Size(448, 193);
            this.Grafico.TabIndex = 1;
            this.Grafico.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(34, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Esta Semana";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Clientes";
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // pnlDatos2
            // 
            this.pnlDatos2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDatos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlDatos2.Controls.Add(this.lblSemana);
            this.pnlDatos2.Controls.Add(this.lblIngresos);
            this.pnlDatos2.Controls.Add(this.pb2);
            this.pnlDatos2.Location = new System.Drawing.Point(244, 0);
            this.pnlDatos2.Name = "pnlDatos2";
            this.pnlDatos2.Size = new System.Drawing.Size(209, 118);
            this.pnlDatos2.TabIndex = 8;
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSemana.Location = new System.Drawing.Point(20, 88);
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
            this.lblIngresos.Location = new System.Drawing.Point(55, 51);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(100, 48);
            this.lblIngresos.TabIndex = 10;
            this.lblIngresos.Text = "$4834";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(86, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(34, 39);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // pnlDatos3
            // 
            this.pnlDatos3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDatos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlDatos3.Controls.Add(this.lblReservasHoy);
            this.pnlDatos3.Controls.Add(this.pb3);
            this.pnlDatos3.Controls.Add(this.lblGrisReservas);
            this.pnlDatos3.Location = new System.Drawing.Point(20, 133);
            this.pnlDatos3.Name = "pnlDatos3";
            this.pnlDatos3.Size = new System.Drawing.Size(209, 118);
            this.pnlDatos3.TabIndex = 8;
            // 
            // lblReservasHoy
            // 
            this.lblReservasHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservasHoy.AutoSize = true;
            this.lblReservasHoy.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasHoy.ForeColor = System.Drawing.Color.White;
            this.lblReservasHoy.Location = new System.Drawing.Point(83, 54);
            this.lblReservasHoy.Name = "lblReservasHoy";
            this.lblReservasHoy.Size = new System.Drawing.Size(47, 34);
            this.lblReservasHoy.TabIndex = 16;
            this.lblReservasHoy.Text = "15";
            this.lblReservasHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(89, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(34, 39);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 14;
            this.pb3.TabStop = false;
            // 
            // lblGrisReservas
            // 
            this.lblGrisReservas.AutoSize = true;
            this.lblGrisReservas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrisReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblGrisReservas.Location = new System.Drawing.Point(30, 88);
            this.lblGrisReservas.Name = "lblGrisReservas";
            this.lblGrisReservas.Size = new System.Drawing.Size(149, 17);
            this.lblGrisReservas.TabIndex = 15;
            this.lblGrisReservas.Text = "Reservas realizadas hoy";
            // 
            // pnlDatos4
            // 
            this.pnlDatos4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDatos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pnlDatos4.Controls.Add(this.lblServicioFavorito);
            this.pnlDatos4.Controls.Add(this.pb4);
            this.pnlDatos4.Controls.Add(this.lblGrisServicio);
            this.pnlDatos4.Location = new System.Drawing.Point(244, 133);
            this.pnlDatos4.Name = "pnlDatos4";
            this.pnlDatos4.Size = new System.Drawing.Size(209, 118);
            this.pnlDatos4.TabIndex = 9;
            // 
            // lblServicioFavorito
            // 
            this.lblServicioFavorito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicioFavorito.AutoSize = true;
            this.lblServicioFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioFavorito.ForeColor = System.Drawing.Color.White;
            this.lblServicioFavorito.Location = new System.Drawing.Point(18, 66);
            this.lblServicioFavorito.Name = "lblServicioFavorito";
            this.lblServicioFavorito.Size = new System.Drawing.Size(176, 27);
            this.lblServicioFavorito.TabIndex = 19;
            this.lblServicioFavorito.Text = "Servicio Favorito";
            this.lblServicioFavorito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(73, 12);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(69, 60);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 17;
            this.pb4.TabStop = false;
            // 
            // lblGrisServicio
            // 
            this.lblGrisServicio.AutoSize = true;
            this.lblGrisServicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrisServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblGrisServicio.Location = new System.Drawing.Point(9, 93);
            this.lblGrisServicio.Name = "lblGrisServicio";
            this.lblGrisServicio.Size = new System.Drawing.Size(185, 17);
            this.lblGrisServicio.TabIndex = 18;
            this.lblGrisServicio.Text = "Servicio favorito de la semana";
            // 
            // frmInicioGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(937, 543);
            this.Controls.Add(this.pnlDatos4);
            this.Controls.Add(this.pnlDatos3);
            this.Controls.Add(this.pnlDatos2);
            this.Controls.Add(this.pnlGrafica);
            this.Controls.Add(this.pnlCapacidadHoy);
            this.Controls.Add(this.pnlDatos1);
            this.Controls.Add(this.pnlServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioGerente";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicioGerente_Load);
            this.Resize += new System.EventHandler(this.frmInicioGerente_Resize);
            this.pnlServicios.ResumeLayout(false);
            this.pnlServicios.PerformLayout();
            this.pnlDatos1.ResumeLayout(false);
            this.pnlDatos1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.pnlCapacidadHoy.ResumeLayout(false);
            this.pnlCapacidadHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapacidades)).EndInit();
            this.pnlGrafica.ResumeLayout(false);
            this.pnlGrafica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.pnlDatos2.ResumeLayout(false);
            this.pnlDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.pnlDatos3.ResumeLayout(false);
            this.pnlDatos3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.pnlDatos4.ResumeLayout(false);
            this.pnlDatos4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlServicios;
        private System.Windows.Forms.Panel pnlDatos1;
        private System.Windows.Forms.Panel pnlCapacidadHoy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacidades;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblClientesConfirmados;
        private CircularProgressBar.CircularProgressBar progresoAbajo;
        private System.Windows.Forms.Label lblBarraCircular;
        private System.Windows.Forms.Panel pnlDatos2;
        private System.Windows.Forms.Panel pnlDatos3;
        private System.Windows.Forms.Panel pnlDatos4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblNumeroClientes;
        private System.Windows.Forms.Label lblClientesHoy;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblReservasHoy;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label lblGrisReservas;
        private System.Windows.Forms.Label lblServicioFavorito;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Label lblGrisServicio;
        private System.Windows.Forms.Label lblSobre;
    }
}