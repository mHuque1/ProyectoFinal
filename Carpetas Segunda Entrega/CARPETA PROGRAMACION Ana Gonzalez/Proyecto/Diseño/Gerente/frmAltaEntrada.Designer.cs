namespace Spa
{
    partial class frmAltaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaEntrada));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtCosto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bfbtnAgregar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlModificar.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModificar
            // 
            this.pnlModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlModificar.Controls.Add(this.txtCosto);
            this.pnlModificar.Controls.Add(this.txtNombre);
            this.pnlModificar.Controls.Add(this.label5);
            this.pnlModificar.Controls.Add(this.bfbtnAgregar);
            this.pnlModificar.Controls.Add(this.label2);
            this.pnlModificar.Location = new System.Drawing.Point(0, 60);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(411, 226);
            this.pnlModificar.TabIndex = 8;
            this.pnlModificar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModificar_Paint);
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Controls.Add(this.lblServicio);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(423, 54);
            this.MenuTop.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.CorrectoSalirbtn1;
            this.btnSalir.Location = new System.Drawing.Point(380, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(3, 12);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(279, 31);
            this.lblServicio.TabIndex = 0;
            this.lblServicio.Text = "Añadir tipo de entrada";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCosto
            // 
            this.txtCosto.AcceptsReturn = false;
            this.txtCosto.AcceptsTab = false;
            this.txtCosto.AnimationSpeed = 200;
            this.txtCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtCosto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCosto.BackgroundImage")));
            this.txtCosto.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCosto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCosto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCosto.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCosto.BorderRadius = 1;
            this.txtCosto.BorderThickness = 1;
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.DefaultFont = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtCosto.DefaultText = "";
            this.txtCosto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.HideSelection = true;
            this.txtCosto.IconLeft = null;
            this.txtCosto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.IconPadding = 10;
            this.txtCosto.IconRight = null;
            this.txtCosto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Lines = new string[0];
            this.txtCosto.Location = new System.Drawing.Point(183, 79);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtCosto.MaxLength = 32767;
            this.txtCosto.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCosto.Modified = false;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCosto.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCosto.OnIdleState = stateProperties12;
            this.txtCosto.Padding = new System.Windows.Forms.Padding(3);
            this.txtCosto.PasswordChar = '\0';
            this.txtCosto.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCosto.PlaceholderText = "Ingrese el costo";
            this.txtCosto.ReadOnly = false;
            this.txtCosto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCosto.SelectedText = "";
            this.txtCosto.SelectionLength = 0;
            this.txtCosto.SelectionStart = 0;
            this.txtCosto.ShortcutsEnabled = false;
            this.txtCosto.Size = new System.Drawing.Size(214, 40);
            this.txtCosto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtCosto.TabIndex = 92;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCosto.TextMarginBottom = 0;
            this.txtCosto.TextMarginLeft = 3;
            this.txtCosto.TextMarginTop = 0;
            this.txtCosto.TextPlaceholder = "Ingrese el costo";
            this.txtCosto.UseSystemPasswordChar = false;
            this.txtCosto.WordWrap = true;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = false;
            this.txtNombre.AcceptsTab = false;
            this.txtNombre.AnimationSpeed = 200;
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre.BackgroundImage")));
            this.txtNombre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNombre.BorderRadius = 1;
            this.txtNombre.BorderThickness = 1;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultFont = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtNombre.DefaultText = "";
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.HideSelection = true;
            this.txtNombre.IconLeft = null;
            this.txtNombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.IconPadding = 10;
            this.txtNombre.IconRight = null;
            this.txtNombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(183, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombre.Modified = false;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombre.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombre.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombre.OnIdleState = stateProperties16;
            this.txtNombre.Padding = new System.Windows.Forms.Padding(3);
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtNombre.PlaceholderText = "Ingrese el nombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(214, 40);
            this.txtNombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNombre.TabIndex = 91;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TextMarginBottom = 0;
            this.txtNombre.TextMarginLeft = 3;
            this.txtNombre.TextMarginTop = 0;
            this.txtNombre.TextPlaceholder = "Ingrese el nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.WordWrap = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(87, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 95;
            this.label5.Text = "Costo: $ ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bfbtnAgregar
            // 
            this.bfbtnAgregar.AllowAnimations = true;
            this.bfbtnAgregar.AllowMouseEffects = true;
            this.bfbtnAgregar.AllowToggling = false;
            this.bfbtnAgregar.AnimationSpeed = 200;
            this.bfbtnAgregar.AutoGenerateColors = false;
            this.bfbtnAgregar.AutoRoundBorders = false;
            this.bfbtnAgregar.AutoSizeLeftIcon = true;
            this.bfbtnAgregar.AutoSizeRightIcon = true;
            this.bfbtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.bfbtnAgregar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfbtnAgregar.BackgroundImage")));
            this.bfbtnAgregar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAgregar.ButtonText = "Agregar";
            this.bfbtnAgregar.ButtonTextMarginLeft = 0;
            this.bfbtnAgregar.ColorContrastOnClick = 45;
            this.bfbtnAgregar.ColorContrastOnHover = 45;
            this.bfbtnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bfbtnAgregar.CustomizableEdges = borderEdges2;
            this.bfbtnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bfbtnAgregar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnAgregar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnAgregar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnAgregar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bfbtnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtnAgregar.ForeColor = System.Drawing.Color.White;
            this.bfbtnAgregar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbtnAgregar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnAgregar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bfbtnAgregar.IconMarginLeft = 11;
            this.bfbtnAgregar.IconPadding = 10;
            this.bfbtnAgregar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfbtnAgregar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnAgregar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bfbtnAgregar.IconSize = 25;
            this.bfbtnAgregar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bfbtnAgregar.IdleBorderRadius = 35;
            this.bfbtnAgregar.IdleBorderThickness = 2;
            this.bfbtnAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnAgregar.IdleIconLeftImage = null;
            this.bfbtnAgregar.IdleIconRightImage = null;
            this.bfbtnAgregar.IndicateFocus = false;
            this.bfbtnAgregar.Location = new System.Drawing.Point(103, 140);
            this.bfbtnAgregar.Name = "bfbtnAgregar";
            this.bfbtnAgregar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnAgregar.OnDisabledState.BorderRadius = 35;
            this.bfbtnAgregar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAgregar.OnDisabledState.BorderThickness = 2;
            this.bfbtnAgregar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnAgregar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnAgregar.OnDisabledState.IconLeftImage = null;
            this.bfbtnAgregar.OnDisabledState.IconRightImage = null;
            this.bfbtnAgregar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnAgregar.onHoverState.BorderRadius = 35;
            this.bfbtnAgregar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAgregar.onHoverState.BorderThickness = 2;
            this.bfbtnAgregar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnAgregar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAgregar.onHoverState.IconLeftImage = null;
            this.bfbtnAgregar.onHoverState.IconRightImage = null;
            this.bfbtnAgregar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bfbtnAgregar.OnIdleState.BorderRadius = 35;
            this.bfbtnAgregar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAgregar.OnIdleState.BorderThickness = 2;
            this.bfbtnAgregar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bfbtnAgregar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAgregar.OnIdleState.IconLeftImage = null;
            this.bfbtnAgregar.OnIdleState.IconRightImage = null;
            this.bfbtnAgregar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnAgregar.OnPressedState.BorderRadius = 35;
            this.bfbtnAgregar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAgregar.OnPressedState.BorderThickness = 2;
            this.bfbtnAgregar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnAgregar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAgregar.OnPressedState.IconLeftImage = null;
            this.bfbtnAgregar.OnPressedState.IconRightImage = null;
            this.bfbtnAgregar.Size = new System.Drawing.Size(201, 58);
            this.bfbtnAgregar.TabIndex = 93;
            this.bfbtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnAgregar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfbtnAgregar.TextMarginLeft = 0;
            this.bfbtnAgregar.TextPadding = new System.Windows.Forms.Padding(0);
            this.bfbtnAgregar.UseDefaultRadiusAndThickness = true;
            this.bfbtnAgregar.Click += new System.EventHandler(this.bfbtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nombre Entrada:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAltaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(423, 298);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.pnlModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEntrada";
            this.Text = "frmAltaEntrada";
            this.Load += new System.EventHandler(this.frmAltaEntrada_Load);
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblServicio;
        private Bunifu.UI.WinForms.BunifuTextBox txtCosto;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bfbtnAgregar;
        private System.Windows.Forms.Label label2;
    }
}