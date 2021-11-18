namespace Spa
{
    partial class frmModificacionTotalAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionTotalAPagar));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtCosto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnModificarPrecio = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlModificar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModificar
            // 
            this.pnlModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlModificar.Controls.Add(this.tableLayoutPanel1);
            this.pnlModificar.Location = new System.Drawing.Point(11, 60);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(378, 269);
            this.pnlModificar.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTexto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCosto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarPrecio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.69962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.745247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.03463F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.40693F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 263);
            this.tableLayoutPanel1.TabIndex = 78;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(3, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(371, 86);
            this.lblTexto.TabIndex = 75;
            this.lblTexto.Text = "Esta intentado modificar el restante\r\na pagar:\r\n\r\n";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCosto
            // 
            this.txtCosto.AcceptsReturn = false;
            this.txtCosto.AcceptsTab = false;
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCosto.AnimationSpeed = 200;
            this.txtCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCosto.BackColor = System.Drawing.Color.Transparent;
            this.txtCosto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCosto.BackgroundImage")));
            this.txtCosto.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txtCosto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCosto.BorderColorHover = System.Drawing.Color.White;
            this.txtCosto.BorderColorIdle = System.Drawing.Color.White;
            this.txtCosto.BorderRadius = 1;
            this.txtCosto.BorderThickness = 1;
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.DefaultFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.DefaultText = "";
            this.txtCosto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.HideSelection = true;
            this.txtCosto.IconLeft = null;
            this.txtCosto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.IconPadding = 10;
            this.txtCosto.IconRight = null;
            this.txtCosto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Lines = new string[0];
            this.txtCosto.Location = new System.Drawing.Point(50, 112);
            this.txtCosto.MaxLength = 32767;
            this.txtCosto.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCosto.Modified = false;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCosto.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnIdleState = stateProperties4;
            this.txtCosto.Padding = new System.Windows.Forms.Padding(3);
            this.txtCosto.PasswordChar = '\0';
            this.txtCosto.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCosto.PlaceholderText = "Ingrese un restante";
            this.txtCosto.ReadOnly = false;
            this.txtCosto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCosto.SelectedText = "";
            this.txtCosto.SelectionLength = 0;
            this.txtCosto.SelectionStart = 0;
            this.txtCosto.ShortcutsEnabled = false;
            this.txtCosto.Size = new System.Drawing.Size(277, 78);
            this.txtCosto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCosto.TabIndex = 76;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCosto.TextMarginBottom = 0;
            this.txtCosto.TextMarginLeft = 3;
            this.txtCosto.TextMarginTop = 0;
            this.txtCosto.TextPlaceholder = "Ingrese un restante";
            this.txtCosto.UseSystemPasswordChar = false;
            this.txtCosto.WordWrap = true;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // btnModificarPrecio
            // 
            this.btnModificarPrecio.AllowAnimations = true;
            this.btnModificarPrecio.AllowMouseEffects = true;
            this.btnModificarPrecio.AllowToggling = false;
            this.btnModificarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModificarPrecio.AnimationSpeed = 200;
            this.btnModificarPrecio.AutoGenerateColors = false;
            this.btnModificarPrecio.AutoRoundBorders = false;
            this.btnModificarPrecio.AutoSizeLeftIcon = true;
            this.btnModificarPrecio.AutoSizeRightIcon = true;
            this.btnModificarPrecio.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarPrecio.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarPrecio.BackgroundImage")));
            this.btnModificarPrecio.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarPrecio.ButtonText = "Modificar restante";
            this.btnModificarPrecio.ButtonTextMarginLeft = 0;
            this.btnModificarPrecio.ColorContrastOnClick = 45;
            this.btnModificarPrecio.ColorContrastOnHover = 45;
            this.btnModificarPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnModificarPrecio.CustomizableEdges = borderEdges1;
            this.btnModificarPrecio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarPrecio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarPrecio.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificarPrecio.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificarPrecio.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnModificarPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrecio.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPrecio.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarPrecio.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificarPrecio.IconMarginLeft = 11;
            this.btnModificarPrecio.IconPadding = 10;
            this.btnModificarPrecio.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPrecio.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarPrecio.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificarPrecio.IconSize = 25;
            this.btnModificarPrecio.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.IdleBorderRadius = 35;
            this.btnModificarPrecio.IdleBorderThickness = 2;
            this.btnModificarPrecio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.IdleIconLeftImage = null;
            this.btnModificarPrecio.IdleIconRightImage = null;
            this.btnModificarPrecio.IndicateFocus = false;
            this.btnModificarPrecio.Location = new System.Drawing.Point(38, 196);
            this.btnModificarPrecio.Name = "btnModificarPrecio";
            this.btnModificarPrecio.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarPrecio.OnDisabledState.BorderRadius = 35;
            this.btnModificarPrecio.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarPrecio.OnDisabledState.BorderThickness = 2;
            this.btnModificarPrecio.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificarPrecio.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificarPrecio.OnDisabledState.IconLeftImage = null;
            this.btnModificarPrecio.OnDisabledState.IconRightImage = null;
            this.btnModificarPrecio.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.onHoverState.BorderRadius = 35;
            this.btnModificarPrecio.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarPrecio.onHoverState.BorderThickness = 2;
            this.btnModificarPrecio.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrecio.onHoverState.IconLeftImage = null;
            this.btnModificarPrecio.onHoverState.IconRightImage = null;
            this.btnModificarPrecio.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.OnIdleState.BorderRadius = 35;
            this.btnModificarPrecio.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarPrecio.OnIdleState.BorderThickness = 2;
            this.btnModificarPrecio.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrecio.OnIdleState.IconLeftImage = null;
            this.btnModificarPrecio.OnIdleState.IconRightImage = null;
            this.btnModificarPrecio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.OnPressedState.BorderRadius = 35;
            this.btnModificarPrecio.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarPrecio.OnPressedState.BorderThickness = 2;
            this.btnModificarPrecio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarPrecio.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrecio.OnPressedState.IconLeftImage = null;
            this.btnModificarPrecio.OnPressedState.IconRightImage = null;
            this.btnModificarPrecio.Size = new System.Drawing.Size(301, 64);
            this.btnModificarPrecio.TabIndex = 13;
            this.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarPrecio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarPrecio.TextMarginLeft = 0;
            this.btnModificarPrecio.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificarPrecio.UseDefaultRadiusAndThickness = true;
            this.btnModificarPrecio.Click += new System.EventHandler(this.btnModificarPrecio_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 86);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(371, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "Ingrese un nuevo restante a pagar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(3, 12);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(208, 31);
            this.lblServicio.TabIndex = 0;
            this.lblServicio.Text = "Modificar Precio";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Controls.Add(this.lblServicio);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(401, 54);
            this.MenuTop.TabIndex = 6;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.CorrectoSalirbtn1;
            this.btnSalir.Location = new System.Drawing.Point(358, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmModificacionTotalAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(401, 341);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.pnlModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificacionTotalAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificacionCliente";
            this.Load += new System.EventHandler(this.frmModificacionPrecioServicio_Load);
            this.pnlModificar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModificarPrecio;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuTextBox txtCosto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}