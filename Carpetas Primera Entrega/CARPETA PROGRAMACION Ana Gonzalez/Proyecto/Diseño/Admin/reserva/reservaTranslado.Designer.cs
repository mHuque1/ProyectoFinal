namespace Diseño
{
    partial class reservaTranslado
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
            this.GuardarHoras = new System.Windows.Forms.Button();
            this.cboxHoras = new System.Windows.Forms.ComboBox();
            this.checkIda = new System.Windows.Forms.CheckBox();
            this.checkVuelta = new System.Windows.Forms.CheckBox();
            this.cbHorasVuelta = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblVuelta = new System.Windows.Forms.Label();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarHoras
            // 
            this.GuardarHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.GuardarHoras.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GuardarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GuardarHoras.Location = new System.Drawing.Point(12, 160);
            this.GuardarHoras.Name = "GuardarHoras";
            this.GuardarHoras.Size = new System.Drawing.Size(170, 73);
            this.GuardarHoras.TabIndex = 7;
            this.GuardarHoras.Text = "Guardar horas";
            this.GuardarHoras.UseVisualStyleBackColor = false;
            this.GuardarHoras.Click += new System.EventHandler(this.GuardarHoras_Click);
            // 
            // cboxHoras
            // 
            this.cboxHoras.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboxHoras.FormattingEnabled = true;
            this.cboxHoras.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00"});
            this.cboxHoras.Location = new System.Drawing.Point(173, 53);
            this.cboxHoras.MaxLength = 5;
            this.cboxHoras.Name = "cboxHoras";
            this.cboxHoras.Size = new System.Drawing.Size(163, 33);
            this.cboxHoras.TabIndex = 6;
            // 
            // checkIda
            // 
            this.checkIda.AutoSize = true;
            this.checkIda.Checked = true;
            this.checkIda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkIda.ForeColor = System.Drawing.Color.White;
            this.checkIda.Location = new System.Drawing.Point(162, 14);
            this.checkIda.Name = "checkIda";
            this.checkIda.Size = new System.Drawing.Size(54, 24);
            this.checkIda.TabIndex = 8;
            this.checkIda.Text = "Ida";
            this.checkIda.UseVisualStyleBackColor = true;
            this.checkIda.CheckedChanged += new System.EventHandler(this.checkIda_CheckedChanged);
            // 
            // checkVuelta
            // 
            this.checkVuelta.AutoSize = true;
            this.checkVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkVuelta.ForeColor = System.Drawing.Color.White;
            this.checkVuelta.Location = new System.Drawing.Point(256, 14);
            this.checkVuelta.Name = "checkVuelta";
            this.checkVuelta.Size = new System.Drawing.Size(80, 24);
            this.checkVuelta.TabIndex = 9;
            this.checkVuelta.Text = "Vuelta";
            this.checkVuelta.UseVisualStyleBackColor = true;
            this.checkVuelta.CheckedChanged += new System.EventHandler(this.checkVuelta_CheckedChanged);
            // 
            // cbHorasVuelta
            // 
            this.cbHorasVuelta.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbHorasVuelta.FormattingEnabled = true;
            this.cbHorasVuelta.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00"});
            this.cbHorasVuelta.Location = new System.Drawing.Point(173, 89);
            this.cbHorasVuelta.Name = "cbHorasVuelta";
            this.cbHorasVuelta.Size = new System.Drawing.Size(163, 33);
            this.cbHorasVuelta.Sorted = true;
            this.cbHorasVuelta.TabIndex = 11;
            this.cbHorasVuelta.Visible = false;            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSalida.Location = new System.Drawing.Point(8, 61);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(165, 25);
            this.lblSalida.TabIndex = 12;
            this.lblSalida.Text = "Hora de salida";
            // 
            // lblVuelta
            // 
            this.lblVuelta.AutoSize = true;
            this.lblVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVuelta.Location = new System.Drawing.Point(6, 97);
            this.lblVuelta.Name = "lblVuelta";
            this.lblVuelta.Size = new System.Drawing.Size(166, 25);
            this.lblVuelta.TabIndex = 13;
            this.lblVuelta.Text = "Hora de vuelta";
            this.lblVuelta.Visible = false;
            // 
            // pnlTabla
            // 
            this.pnlTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlTabla.Controls.Add(this.lblVuelta);
            this.pnlTabla.Controls.Add(this.lblSalida);
            this.pnlTabla.Controls.Add(this.cbHorasVuelta);
            this.pnlTabla.Controls.Add(this.checkVuelta);
            this.pnlTabla.Controls.Add(this.checkIda);
            this.pnlTabla.Controls.Add(this.cboxHoras);
            this.pnlTabla.Location = new System.Drawing.Point(12, 12);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(377, 142);
            this.pnlTabla.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancelar.Location = new System.Drawing.Point(219, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 73);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // reservaTranslado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(402, 247);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.GuardarHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservaTranslado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.reservaTranslado_Load);
            this.pnlTabla.ResumeLayout(false);
            this.pnlTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button GuardarHoras;
        private System.Windows.Forms.ComboBox cboxHoras;
        private System.Windows.Forms.CheckBox checkIda;
        private System.Windows.Forms.CheckBox checkVuelta;
        private System.Windows.Forms.ComboBox cbHorasVuelta;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblVuelta;
        private System.Windows.Forms.Panel pnlTabla;
        public System.Windows.Forms.Button btnCancelar;
    }
}