namespace Spa
{
    partial class frmPositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPositivo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.icono = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAceptar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconDelay = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.95794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.98088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25239F));
            this.tableLayoutPanel1.Controls.Add(this.icono, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMensaje, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.50746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.49254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.29851F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // icono
            // 
            this.icono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icono.Enabled = false;
            this.icono.Image = ((System.Drawing.Image)(resources.GetObject("icono.Image")));
            this.icono.Location = new System.Drawing.Point(75, 3);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(359, 189);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 0;
            this.icono.TabStop = false;
            this.icono.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMensaje, 3);
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(3, 195);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(517, 71);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje positivo aqui";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AllowAnimations = true;
            this.btnAceptar.AllowMouseEffects = true;
            this.btnAceptar.AllowToggling = false;
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AnimationSpeed = 200;
            this.btnAceptar.AutoGenerateColors = false;
            this.btnAceptar.AutoRoundBorders = false;
            this.btnAceptar.AutoSizeLeftIcon = true;
            this.btnAceptar.AutoSizeRightIcon = true;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.ButtonTextMarginLeft = 0;
            this.btnAceptar.ColorContrastOnClick = 45;
            this.btnAceptar.ColorContrastOnHover = 45;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAceptar.CustomizableEdges = borderEdges1;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAceptar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAceptar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAceptar.IconMarginLeft = 11;
            this.btnAceptar.IconPadding = 10;
            this.btnAceptar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAceptar.IconSize = 25;
            this.btnAceptar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.IdleBorderRadius = 35;
            this.btnAceptar.IdleBorderThickness = 2;
            this.btnAceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.IdleIconLeftImage = null;
            this.btnAceptar.IdleIconRightImage = null;
            this.btnAceptar.IndicateFocus = false;
            this.btnAceptar.Location = new System.Drawing.Point(102, 276);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAceptar.OnDisabledState.BorderRadius = 35;
            this.btnAceptar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnDisabledState.BorderThickness = 2;
            this.btnAceptar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAceptar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAceptar.OnDisabledState.IconLeftImage = null;
            this.btnAceptar.OnDisabledState.IconRightImage = null;
            this.btnAceptar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.onHoverState.BorderRadius = 35;
            this.btnAceptar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.onHoverState.BorderThickness = 2;
            this.btnAceptar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.onHoverState.IconLeftImage = null;
            this.btnAceptar.onHoverState.IconRightImage = null;
            this.btnAceptar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.OnIdleState.BorderRadius = 35;
            this.btnAceptar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnIdleState.BorderThickness = 2;
            this.btnAceptar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnIdleState.IconLeftImage = null;
            this.btnAceptar.OnIdleState.IconRightImage = null;
            this.btnAceptar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.OnPressedState.BorderRadius = 35;
            this.btnAceptar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnPressedState.BorderThickness = 2;
            this.btnAceptar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(61)))));
            this.btnAceptar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnPressedState.IconLeftImage = null;
            this.btnAceptar.OnPressedState.IconRightImage = null;
            this.btnAceptar.Size = new System.Drawing.Size(305, 49);
            this.btnAceptar.TabIndex = 137;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptar.TextMarginLeft = 0;
            this.btnAceptar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAceptar.UseDefaultRadiusAndThickness = true;
            // 
            // iconDelay
            // 
            this.iconDelay.Enabled = true;
            this.iconDelay.Interval = 2000;
            this.iconDelay.Tick += new System.EventHandler(this.iconDelay_Tick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 40;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // frmPositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPositivo";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPositivo";
            this.Load += new System.EventHandler(this.frmPositivo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Label lblMensaje;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAceptar;
        private System.Windows.Forms.Timer iconDelay;
        private System.Windows.Forms.Timer fadeIn;
    }
}