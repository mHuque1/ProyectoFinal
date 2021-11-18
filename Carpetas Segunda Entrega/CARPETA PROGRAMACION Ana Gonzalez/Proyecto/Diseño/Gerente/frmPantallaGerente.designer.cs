namespace Spa
{
    partial class frmPantallaGerente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaGerente));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.pnlCargador = new System.Windows.Forms.Panel();
            this.pnlCargado = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlBotones = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fotoUsuario = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatosClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.pnlCargador.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Controls.Add(this.btnMaximizar);
            this.MenuTop.Controls.Add(this.btnMinimizar);
            this.MenuTop.Controls.Add(this.lblTitulo);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1326, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1263, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1223, 14);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 10;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimizar.Image = global::Spa.Properties.Resources.MinimizeLogo2;
            this.btnMinimizar.Location = new System.Drawing.Point(1183, 14);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(81, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "INICIO";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // pnlCargador
            // 
            this.pnlCargador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.pnlCargador.Controls.Add(this.pnlCargado);
            this.AnimacionSidebarBack.SetDecoration(this.pnlCargador, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlCargador, BunifuAnimatorNS.DecorationType.None);
            this.pnlCargador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCargador.Location = new System.Drawing.Point(300, 80);
            this.pnlCargador.Name = "pnlCargador";
            this.pnlCargador.Padding = new System.Windows.Forms.Padding(0, 5, 25, 25);
            this.pnlCargador.Size = new System.Drawing.Size(1026, 682);
            this.pnlCargador.TabIndex = 2;
            // 
            // pnlCargado
            // 
            this.pnlCargado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AnimacionSidebarBack.SetDecoration(this.pnlCargado, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlCargado, BunifuAnimatorNS.DecorationType.None);
            this.pnlCargado.Location = new System.Drawing.Point(9, 6);
            this.pnlCargado.Name = "pnlCargado";
            this.pnlCargado.Size = new System.Drawing.Size(989, 638);
            this.pnlCargado.TabIndex = 1;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.pnlBotones;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBotones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotones.BackgroundImage")));
            this.pnlBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBotones.Controls.Add(this.panel1);
            this.pnlBotones.Controls.Add(this.btnEmpleados);
            this.pnlBotones.Controls.Add(this.btnReservarCliente);
            this.pnlBotones.Controls.Add(this.btnConfig);
            this.pnlBotones.Controls.Add(this.btnCerrarSesion);
            this.pnlBotones.Controls.Add(this.bunifuFlatButton7);
            this.pnlBotones.Controls.Add(this.btnDatosClientes);
            this.pnlBotones.Controls.Add(this.btnServicios);
            this.pnlBotones.Controls.Add(this.btnInicio);
            this.pnlBotones.Controls.Add(this.LineaSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.pnlBotones, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlBotones, BunifuAnimatorNS.DecorationType.None);
            this.pnlBotones.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.pnlBotones.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.pnlBotones.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.pnlBotones.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlBotones.Location = new System.Drawing.Point(12, 6);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Quality = 10;
            this.pnlBotones.Size = new System.Drawing.Size(270, 641);
            this.pnlBotones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fotoUsuario);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 62);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gerente";
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.AllowFocused = false;
            this.fotoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fotoUsuario.AutoSizeHeight = false;
            this.fotoUsuario.BorderRadius = 20;
            this.AnimacionSidebar.SetDecoration(this.fotoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.fotoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.fotoUsuario.Image = global::Spa.Properties.Resources.GerenteLogo1;
            this.fotoUsuario.IsCircle = true;
            this.fotoUsuario.Location = new System.Drawing.Point(3, 18);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(40, 40);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoUsuario.TabIndex = 0;
            this.fotoUsuario.TabStop = false;
            this.fotoUsuario.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.fotoUsuario.WaitOnLoad = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 0;
            this.btnEmpleados.ButtonText = "          EMPLEADOS";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Iconimage")));
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 50D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(7, 336);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(261, 51);
            this.btnEmpleados.TabIndex = 18;
            this.btnEmpleados.Text = "          EMPLEADOS";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.LightGray;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnReservarCliente
            // 
            this.btnReservarCliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnReservarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnReservarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservarCliente.BorderRadius = 0;
            this.btnReservarCliente.ButtonText = "          RESERVAR CLIENTE";
            this.btnReservarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnReservarCliente, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnReservarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnReservarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnReservarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnReservarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReservarCliente.Iconimage")));
            this.btnReservarCliente.Iconimage_right = null;
            this.btnReservarCliente.Iconimage_right_Selected = null;
            this.btnReservarCliente.Iconimage_Selected = null;
            this.btnReservarCliente.IconMarginLeft = 0;
            this.btnReservarCliente.IconMarginRight = 0;
            this.btnReservarCliente.IconRightVisible = true;
            this.btnReservarCliente.IconRightZoom = 0D;
            this.btnReservarCliente.IconVisible = true;
            this.btnReservarCliente.IconZoom = 50D;
            this.btnReservarCliente.IsTab = false;
            this.btnReservarCliente.Location = new System.Drawing.Point(9, 126);
            this.btnReservarCliente.Name = "btnReservarCliente";
            this.btnReservarCliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReservarCliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReservarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReservarCliente.selected = false;
            this.btnReservarCliente.Size = new System.Drawing.Size(261, 51);
            this.btnReservarCliente.TabIndex = 17;
            this.btnReservarCliente.Text = "          RESERVAR CLIENTE";
            this.btnReservarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservarCliente.Textcolor = System.Drawing.Color.LightGray;
            this.btnReservarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReservarCliente.Click += new System.EventHandler(this.btnReservarCliente_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Activecolor = System.Drawing.Color.Transparent;
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.BorderRadius = 0;
            this.btnConfig.ButtonText = "        CONFIGURACIÓN";
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnConfig, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnConfig, BunifuAnimatorNS.DecorationType.None);
            this.btnConfig.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfig.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfig.Iconimage")));
            this.btnConfig.Iconimage_right = null;
            this.btnConfig.Iconimage_right_Selected = null;
            this.btnConfig.Iconimage_Selected = null;
            this.btnConfig.IconMarginLeft = 0;
            this.btnConfig.IconMarginRight = 0;
            this.btnConfig.IconRightVisible = true;
            this.btnConfig.IconRightZoom = 0D;
            this.btnConfig.IconVisible = true;
            this.btnConfig.IconZoom = 50D;
            this.btnConfig.IsTab = false;
            this.btnConfig.Location = new System.Drawing.Point(9, 530);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfig.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfig.selected = false;
            this.btnConfig.Size = new System.Drawing.Size(261, 51);
            this.btnConfig.TabIndex = 16;
            this.btnConfig.Text = "        CONFIGURACIÓN";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Textcolor = System.Drawing.Color.LightGray;
            this.btnConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Activecolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.BorderRadius = 0;
            this.btnCerrarSesion.ButtonText = "      CERRAR SESIÓN";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Iconimage")));
            this.btnCerrarSesion.Iconimage_right = null;
            this.btnCerrarSesion.Iconimage_right_Selected = null;
            this.btnCerrarSesion.Iconimage_Selected = null;
            this.btnCerrarSesion.IconMarginLeft = 0;
            this.btnCerrarSesion.IconMarginRight = 0;
            this.btnCerrarSesion.IconRightVisible = true;
            this.btnCerrarSesion.IconRightZoom = 0D;
            this.btnCerrarSesion.IconVisible = true;
            this.btnCerrarSesion.IconZoom = 50D;
            this.btnCerrarSesion.IsTab = false;
            this.btnCerrarSesion.Location = new System.Drawing.Point(9, 587);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.selected = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(261, 51);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "      CERRAR SESIÓN";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Textcolor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "          GANANCIAS";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 50D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(9, 285);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(261, 51);
            this.bunifuFlatButton7.TabIndex = 14;
            this.bunifuFlatButton7.Text = "          GANANCIAS";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnDatosClientes
            // 
            this.btnDatosClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnDatosClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnDatosClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatosClientes.BorderRadius = 0;
            this.btnDatosClientes.ButtonText = "          CLIENTES";
            this.btnDatosClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnDatosClientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnDatosClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnDatosClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatosClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnDatosClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatosClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDatosClientes.Iconimage")));
            this.btnDatosClientes.Iconimage_right = null;
            this.btnDatosClientes.Iconimage_right_Selected = null;
            this.btnDatosClientes.Iconimage_Selected = null;
            this.btnDatosClientes.IconMarginLeft = 0;
            this.btnDatosClientes.IconMarginRight = 0;
            this.btnDatosClientes.IconRightVisible = true;
            this.btnDatosClientes.IconRightZoom = 0D;
            this.btnDatosClientes.IconVisible = true;
            this.btnDatosClientes.IconZoom = 50D;
            this.btnDatosClientes.IsTab = false;
            this.btnDatosClientes.Location = new System.Drawing.Point(9, 177);
            this.btnDatosClientes.Name = "btnDatosClientes";
            this.btnDatosClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDatosClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDatosClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatosClientes.selected = false;
            this.btnDatosClientes.Size = new System.Drawing.Size(261, 51);
            this.btnDatosClientes.TabIndex = 12;
            this.btnDatosClientes.Text = "          CLIENTES";
            this.btnDatosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosClientes.Textcolor = System.Drawing.Color.LightGray;
            this.btnDatosClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDatosClientes.Click += new System.EventHandler(this.btnDatosClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Activecolor = System.Drawing.Color.Transparent;
            this.btnServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicios.BorderRadius = 0;
            this.btnServicios.ButtonText = "          SERVICIOS Y COSTOS";
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnServicios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnServicios, BunifuAnimatorNS.DecorationType.None);
            this.btnServicios.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnServicios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnServicios.Iconimage")));
            this.btnServicios.Iconimage_right = null;
            this.btnServicios.Iconimage_right_Selected = null;
            this.btnServicios.Iconimage_Selected = null;
            this.btnServicios.IconMarginLeft = 0;
            this.btnServicios.IconMarginRight = 0;
            this.btnServicios.IconRightVisible = true;
            this.btnServicios.IconRightZoom = 0D;
            this.btnServicios.IconVisible = true;
            this.btnServicios.IconZoom = 50D;
            this.btnServicios.IsTab = false;
            this.btnServicios.Location = new System.Drawing.Point(9, 228);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicios.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnServicios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicios.selected = false;
            this.btnServicios.Size = new System.Drawing.Size(261, 51);
            this.btnServicios.TabIndex = 10;
            this.btnServicios.Text = "          SERVICIOS Y COSTOS";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Textcolor = System.Drawing.Color.LightGray;
            this.btnServicios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "          INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(9, 75);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(261, 51);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "          INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.LightGray;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation4;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.SidebarWrapper.Controls.Add(this.pnlBotones);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 682);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation3;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPantallaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1326, 762);
            this.Controls.Add(this.pnlCargador);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Gerente";
            this.Load += new System.EventHandler(this.frmGerente_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.pnlCargador.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel pnlCargador;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBotones;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton btnDatosClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicios;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
       // private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarSesion;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfig;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservarCliente;
        private System.Windows.Forms.Panel pnlCargado;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox fotoUsuario;
    }
}

