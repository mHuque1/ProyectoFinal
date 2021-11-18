namespace Diseño
{
    partial class frmPantallaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaAdmin));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnReservaCliente = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBoxUsuario = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCargado = new System.Windows.Forms.Panel();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.iconoTitulo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBotones.Controls.Add(this.btnLogOut);
            this.panelBotones.Controls.Add(this.btnDatos);
            this.panelBotones.Controls.Add(this.btnModificarCliente);
            this.panelBotones.Controls.Add(this.btnReservaCliente);
            this.panelBotones.Controls.Add(this.BtnInicio);
            this.panelBotones.Controls.Add(this.panel2);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(219, 619);
            this.panelBotones.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.Image = global::Spa.Properties.Resources.logoLogOutCliente;
            this.btnLogOut.Location = new System.Drawing.Point(0, 574);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(219, 45);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnDatos.Image")));
            this.btnDatos.Location = new System.Drawing.Point(0, 288);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDatos.Size = new System.Drawing.Size(219, 45);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = "Datos";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCliente.Image")));
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
            this.btnReservaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReservaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnReservaCliente.Image")));
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
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
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
            // panel2
            // 
            this.panel2.Controls.Add(this.PBoxUsuario);
            this.panel2.Controls.Add(this.lblBienvenida);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 153);
            this.panel2.TabIndex = 0;
            // 
            // PBoxUsuario
            // 
            this.PBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PBoxUsuario.Image")));
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
            this.lblBienvenida.Size = new System.Drawing.Size(107, 12);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Bienvenido Usuario!";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUsuario.Location = new System.Drawing.Point(78, 106);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTitulo.Location = new System.Drawing.Point(271, 27);
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
            this.iconoTitulo.Image = global::Spa.Properties.Resources.InicioLogo2;
            this.iconoTitulo.Location = new System.Drawing.Point(225, 20);
            this.iconoTitulo.Name = "iconoTitulo";
            this.iconoTitulo.Size = new System.Drawing.Size(40, 40);
            this.iconoTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoTitulo.TabIndex = 7;
            this.iconoTitulo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
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
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
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
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1036, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // frmPantallaAdmin
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
            this.Name = "frmPantallaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.frmPantalla_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proyecto_MouseDown);
            this.Resize += new System.EventHandler(this.frmPantallaAdmin_Resize);
            this.panelBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PBoxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnReservaCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCargado;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Timer timerAbrir;
        private System.Windows.Forms.PictureBox iconoTitulo;
        private System.Windows.Forms.Button btnLogOut;
    }
}

