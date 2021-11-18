namespace Diseño
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaGerente));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnPrecios = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnGrids = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnReservaCliente = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.pnlGerente = new System.Windows.Forms.Panel();
            this.PBoxUsuario = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblGerente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCargado = new System.Windows.Forms.Panel();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.iconoTitulo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.pnlGerente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBotones.Controls.Add(this.btnPrecios);
            this.panelBotones.Controls.Add(this.btnLogOut);
            this.panelBotones.Controls.Add(this.btnGrids);
            this.panelBotones.Controls.Add(this.btnModificarCliente);
            this.panelBotones.Controls.Add(this.btnReservaCliente);
            this.panelBotones.Controls.Add(this.BtnInicio);
            this.panelBotones.Controls.Add(this.pnlGerente);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(219, 619);
            this.panelBotones.TabIndex = 0;
            // 
            // btnPrecios
            // 
            this.btnPrecios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrecios.FlatAppearance.BorderSize = 0;
            this.btnPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecios.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnPrecios.Image = ((System.Drawing.Image)(resources.GetObject("btnPrecios.Image")));
            this.btnPrecios.Location = new System.Drawing.Point(0, 333);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnPrecios.Size = new System.Drawing.Size(219, 45);
            this.btnPrecios.TabIndex = 7;
            this.btnPrecios.Text = "Modificar precio";
            this.btnPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecios.UseVisualStyleBackColor = true;
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecios_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnLogOut.Image = global::Spa.Properties.Resources.logoLogOutGerente;
            this.btnLogOut.Location = new System.Drawing.Point(0, 574);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(219, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGrids
            // 
            this.btnGrids.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrids.FlatAppearance.BorderSize = 0;
            this.btnGrids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrids.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnGrids.Image = ((System.Drawing.Image)(resources.GetObject("btnGrids.Image")));
            this.btnGrids.Location = new System.Drawing.Point(0, 288);
            this.btnGrids.Name = "btnGrids";
            this.btnGrids.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnGrids.Size = new System.Drawing.Size(219, 45);
            this.btnGrids.TabIndex = 4;
            this.btnGrids.Text = "Datos";
            this.btnGrids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrids.UseVisualStyleBackColor = true;
            this.btnGrids.Click += new System.EventHandler(this.btnGrids_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarCliente.Image = global::Spa.Properties.Resources.ModificarLogoGerente;
            this.btnModificarCliente.Location = new System.Drawing.Point(0, 243);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarCliente.Size = new System.Drawing.Size(219, 45);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Datos";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnReservaCliente
            // 
            this.btnReservaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservaCliente.FlatAppearance.BorderSize = 0;
            this.btnReservaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservaCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnReservaCliente.Image = global::Spa.Properties.Resources.ReservaClienteLogoGerente;
            this.btnReservaCliente.Location = new System.Drawing.Point(0, 198);
            this.btnReservaCliente.Name = "btnReservaCliente";
            this.btnReservaCliente.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnReservaCliente.Size = new System.Drawing.Size(219, 45);
            this.btnReservaCliente.TabIndex = 2;
            this.btnReservaCliente.Text = "Reservar Cliente";
            this.btnReservaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservaCliente.UseVisualStyleBackColor = true;
            this.btnReservaCliente.Click += new System.EventHandler(this.btnReservaCliente_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.BtnInicio.Image = global::Spa.Properties.Resources.InicioLogoGerente;
            this.BtnInicio.Location = new System.Drawing.Point(0, 153);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(219, 45);
            this.BtnInicio.TabIndex = 1;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlGerente
            // 
            this.pnlGerente.Controls.Add(this.PBoxUsuario);
            this.pnlGerente.Controls.Add(this.lblBienvenida);
            this.pnlGerente.Controls.Add(this.lblGerente);
            this.pnlGerente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGerente.Location = new System.Drawing.Point(0, 0);
            this.pnlGerente.Name = "pnlGerente";
            this.pnlGerente.Size = new System.Drawing.Size(219, 153);
            this.pnlGerente.TabIndex = 0;
            // 
            // PBoxUsuario
            // 
            this.PBoxUsuario.Image = global::Spa.Properties.Resources.GerenteLogo;
            this.PBoxUsuario.Location = new System.Drawing.Point(74, 30);
            this.PBoxUsuario.Name = "PBoxUsuario";
            this.PBoxUsuario.Size = new System.Drawing.Size(70, 70);
            this.PBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxUsuario.TabIndex = 2;
            this.PBoxUsuario.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblBienvenida.Location = new System.Drawing.Point(56, 126);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(108, 12);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Bienvenido Gerente!";
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lblGerente.Location = new System.Drawing.Point(78, 106);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(63, 16);
            this.lblGerente.TabIndex = 1;
            this.lblGerente.Text = "Gerente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTitulo.Location = new System.Drawing.Point(271, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(90, 33);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Inicio";
            // 
            // pnlCargado
            // 
            this.pnlCargado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlCargado.Location = new System.Drawing.Point(219, 76);
            this.pnlCargado.Name = "pnlCargado";
            this.pnlCargado.Size = new System.Drawing.Size(937, 543);
            this.pnlCargado.TabIndex = 5;
            // 
            // timerAbrir
            // 
            this.timerAbrir.Interval = 40;
            this.timerAbrir.Tick += new System.EventHandler(this.timerAbrir_Tick);
            // 
            // iconoTitulo
            // 
            this.iconoTitulo.Image = global::Spa.Properties.Resources.InicioLogoGerente1;
            this.iconoTitulo.Location = new System.Drawing.Point(225, 12);
            this.iconoTitulo.Name = "iconoTitulo";
            this.iconoTitulo.Size = new System.Drawing.Size(40, 40);
            this.iconoTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoTitulo.TabIndex = 6;
            this.iconoTitulo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.exitLogoGerente;
            this.btnSalir.Location = new System.Drawing.Point(1116, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximizar.Image = global::Spa.Properties.Resources.MaximizeLogoGerente;
            this.btnMaximizar.Location = new System.Drawing.Point(1076, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimizar.Image = global::Spa.Properties.Resources.MinimizeLogoGerente;
            this.btnMinimizar.Location = new System.Drawing.Point(1036, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // frmPantallaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1156, 619);
            this.Controls.Add(this.iconoTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCargado);
            this.Controls.Add(this.panelBotones);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.frmPantallaGerente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proyecto_MouseDown);
            this.Resize += new System.EventHandler(this.frmPantallaGerente_Resize);
            this.panelBotones.ResumeLayout(false);
            this.pnlGerente.ResumeLayout(false);
            this.pnlGerente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel pnlGerente;
        private System.Windows.Forms.PictureBox PBoxUsuario;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnReservaCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCargado;
        private System.Windows.Forms.Button btnGrids;
        private System.Windows.Forms.Timer timerAbrir;
        private System.Windows.Forms.PictureBox iconoTitulo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPrecios;
    }
}

