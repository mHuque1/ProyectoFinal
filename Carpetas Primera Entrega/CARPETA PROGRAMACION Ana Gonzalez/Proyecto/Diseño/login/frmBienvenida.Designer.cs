namespace Diseño
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fotoSpa = new System.Windows.Forms.PictureBox();
            this.lblNombreSpa = new System.Windows.Forms.Label();
            this.FotoOpaca = new System.Windows.Forms.PictureBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoOpaca)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.fotoSpa);
            this.panel1.Controls.Add(this.lblNombreSpa);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 78);
            this.panel1.TabIndex = 0;
            // 
            // fotoSpa
            // 
            this.fotoSpa.Image = ((System.Drawing.Image)(resources.GetObject("fotoSpa.Image")));
            this.fotoSpa.Location = new System.Drawing.Point(3, 3);
            this.fotoSpa.Name = "fotoSpa";
            this.fotoSpa.Size = new System.Drawing.Size(72, 72);
            this.fotoSpa.TabIndex = 3;
            this.fotoSpa.TabStop = false;
            // 
            // lblNombreSpa
            // 
            this.lblNombreSpa.AutoSize = true;
            this.lblNombreSpa.Font = new System.Drawing.Font("Goudy Old Style", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNombreSpa.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreSpa.Location = new System.Drawing.Point(81, 24);
            this.lblNombreSpa.Name = "lblNombreSpa";
            this.lblNombreSpa.Size = new System.Drawing.Size(220, 32);
            this.lblNombreSpa.TabIndex = 2;
            this.lblNombreSpa.Text = "Spa Termal Onsen";
            // 
            // FotoOpaca
            // 
            this.FotoOpaca.Image = ((System.Drawing.Image)(resources.GetObject("FotoOpaca.Image")));
            this.FotoOpaca.Location = new System.Drawing.Point(381, 76);
            this.FotoOpaca.Name = "FotoOpaca";
            this.FotoOpaca.Size = new System.Drawing.Size(300, 306);
            this.FotoOpaca.TabIndex = 1;
            this.FotoOpaca.TabStop = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTipoUsuario.Location = new System.Drawing.Point(168, 193);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(103, 29);
            this.lblTipoUsuario.TabIndex = 3;
            this.lblTipoUsuario.Text = "Usuario";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblBienvenido.Location = new System.Drawing.Point(75, 109);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(311, 61);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido!";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // barraProgreso
            // 
            this.barraProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.barraProgreso.Location = new System.Drawing.Point(42, 244);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(376, 39);
            this.barraProgreso.TabIndex = 5;
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(679, 377);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FotoOpaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoOpaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreSpa;
        private System.Windows.Forms.PictureBox FotoOpaca;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox fotoSpa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar barraProgreso;
    }
}