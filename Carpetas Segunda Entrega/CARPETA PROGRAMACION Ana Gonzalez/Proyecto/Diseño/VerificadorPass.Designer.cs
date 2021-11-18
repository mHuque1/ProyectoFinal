namespace Spa
{
    partial class VerificadorPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificadorPass));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bfbtnVerificar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.MenuTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(371, 54);
            this.MenuTop.TabIndex = 7;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.CorrectoSalirbtn1;
            this.btnSalir.Location = new System.Drawing.Point(328, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.bfbtnVerificar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 356);
            this.panel1.TabIndex = 8;
            // 
            // bfbtnVerificar
            // 
            this.bfbtnVerificar.AllowAnimations = true;
            this.bfbtnVerificar.AllowMouseEffects = true;
            this.bfbtnVerificar.AllowToggling = false;
            this.bfbtnVerificar.AnimationSpeed = 200;
            this.bfbtnVerificar.AutoGenerateColors = false;
            this.bfbtnVerificar.AutoRoundBorders = false;
            this.bfbtnVerificar.AutoSizeLeftIcon = true;
            this.bfbtnVerificar.AutoSizeRightIcon = true;
            this.bfbtnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.bfbtnVerificar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnVerificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfbtnVerificar.BackgroundImage")));
            this.bfbtnVerificar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnVerificar.ButtonText = "Verificar";
            this.bfbtnVerificar.ButtonTextMarginLeft = 0;
            this.bfbtnVerificar.ColorContrastOnClick = 45;
            this.bfbtnVerificar.ColorContrastOnHover = 45;
            this.bfbtnVerificar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bfbtnVerificar.CustomizableEdges = borderEdges1;
            this.bfbtnVerificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bfbtnVerificar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnVerificar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnVerificar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnVerificar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bfbtnVerificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtnVerificar.ForeColor = System.Drawing.Color.White;
            this.bfbtnVerificar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbtnVerificar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnVerificar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bfbtnVerificar.IconMarginLeft = 11;
            this.bfbtnVerificar.IconPadding = 10;
            this.bfbtnVerificar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfbtnVerificar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnVerificar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bfbtnVerificar.IconSize = 25;
            this.bfbtnVerificar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bfbtnVerificar.IdleBorderRadius = 35;
            this.bfbtnVerificar.IdleBorderThickness = 2;
            this.bfbtnVerificar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnVerificar.IdleIconLeftImage = null;
            this.bfbtnVerificar.IdleIconRightImage = null;
            this.bfbtnVerificar.IndicateFocus = false;
            this.bfbtnVerificar.Location = new System.Drawing.Point(90, 268);
            this.bfbtnVerificar.Name = "bfbtnVerificar";
            this.bfbtnVerificar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnVerificar.OnDisabledState.BorderRadius = 35;
            this.bfbtnVerificar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnVerificar.OnDisabledState.BorderThickness = 2;
            this.bfbtnVerificar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnVerificar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnVerificar.OnDisabledState.IconLeftImage = null;
            this.bfbtnVerificar.OnDisabledState.IconRightImage = null;
            this.bfbtnVerificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnVerificar.onHoverState.BorderRadius = 35;
            this.bfbtnVerificar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnVerificar.onHoverState.BorderThickness = 2;
            this.bfbtnVerificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnVerificar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bfbtnVerificar.onHoverState.IconLeftImage = null;
            this.bfbtnVerificar.onHoverState.IconRightImage = null;
            this.bfbtnVerificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bfbtnVerificar.OnIdleState.BorderRadius = 35;
            this.bfbtnVerificar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnVerificar.OnIdleState.BorderThickness = 2;
            this.bfbtnVerificar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnVerificar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bfbtnVerificar.OnIdleState.IconLeftImage = null;
            this.bfbtnVerificar.OnIdleState.IconRightImage = null;
            this.bfbtnVerificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnVerificar.OnPressedState.BorderRadius = 35;
            this.bfbtnVerificar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnVerificar.OnPressedState.BorderThickness = 2;
            this.bfbtnVerificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnVerificar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bfbtnVerificar.OnPressedState.IconLeftImage = null;
            this.bfbtnVerificar.OnPressedState.IconRightImage = null;
            this.bfbtnVerificar.Size = new System.Drawing.Size(169, 58);
            this.bfbtnVerificar.TabIndex = 75;
            this.bfbtnVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnVerificar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfbtnVerificar.TextMarginLeft = 0;
            this.bfbtnVerificar.TextPadding = new System.Windows.Forms.Padding(0);
            this.bfbtnVerificar.UseDefaultRadiusAndThickness = true;
            this.bfbtnVerificar.Click += new System.EventHandler(this.bfbtnVerificar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(44, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ingrese su contraseña para continuar";
            // 
            // txtPass
            // 
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.AnimationSpeed = 200;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.White;
            this.txtPass.BorderColorIdle = System.Drawing.Color.White;
            this.txtPass.BorderRadius = 1;
            this.txtPass.BorderThickness = 1;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPass.DefaultText = "";
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = null;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(48, 201);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPass.Modified = false;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnIdleState = stateProperties4;
            this.txtPass.Padding = new System.Windows.Forms.Padding(3);
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPass.PlaceholderText = "Ingrese la contraseña";
            this.txtPass.ReadOnly = false;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(251, 51);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPass.TabIndex = 73;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginBottom = 0;
            this.txtPass.TextMarginLeft = 3;
            this.txtPass.TextMarginTop = 0;
            this.txtPass.TextPlaceholder = "Ingrese la contraseña";
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.WordWrap = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(65, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 60);
            this.label8.TabIndex = 72;
            this.label8.Text = "Esta acción requiere que ingrese \r\nsu contraseña \r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(79, 26);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(187, 45);
            this.bunifuLabel2.TabIndex = 71;
            this.bunifuLabel2.Text = "Hola Usuario!";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VerificadorPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerificadorPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.VerificadorPass_Load);
            this.MenuTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuTextBox txtPass;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bfbtnVerificar;
    }
}