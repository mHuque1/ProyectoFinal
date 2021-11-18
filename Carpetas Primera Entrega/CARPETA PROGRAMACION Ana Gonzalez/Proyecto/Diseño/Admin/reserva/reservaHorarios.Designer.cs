namespace Diseño
{
    partial class reservaHorarios
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboxHoras = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GuardarHoras
            // 
            this.GuardarHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.GuardarHoras.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GuardarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.GuardarHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GuardarHoras.Location = new System.Drawing.Point(216, 12);
            this.GuardarHoras.Name = "GuardarHoras";
            this.GuardarHoras.Size = new System.Drawing.Size(150, 62);
            this.GuardarHoras.TabIndex = 3;
            this.GuardarHoras.Text = "Guardar horas";
            this.GuardarHoras.UseVisualStyleBackColor = false;
            this.GuardarHoras.Click += new System.EventHandler(this.GuardarHoras_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancelar.Location = new System.Drawing.Point(216, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 62);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cboxHoras
            // 
            this.cboxHoras.BackColor = System.Drawing.SystemColors.Menu;
            this.cboxHoras.Enabled = false;
            this.cboxHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxHoras.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxHoras.ForeColor = System.Drawing.Color.Black;
            this.cboxHoras.FormattingEnabled = true;
            this.cboxHoras.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00"});
            this.cboxHoras.Location = new System.Drawing.Point(12, 12);
            this.cboxHoras.Name = "cboxHoras";
            this.cboxHoras.Size = new System.Drawing.Size(198, 48);
            this.cboxHoras.TabIndex = 2;
            // 
            // reservaHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(375, 149);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GuardarHoras);
            this.Controls.Add(this.cboxHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservaHorarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reservaHorarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.reservaHorarios_Load);
            this.ResumeLayout(false);

        }



        #endregion
        public System.Windows.Forms.Button GuardarHoras;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboxHoras;
    }
}