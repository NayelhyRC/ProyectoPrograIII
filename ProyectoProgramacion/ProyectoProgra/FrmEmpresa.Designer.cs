namespace ProyectoProgra
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Youtube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whatsapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.txtWhatsapp = new System.Windows.Forms.TextBox();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.lblRUC = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.lblInsta = new System.Windows.Forms.Label();
            this.lblYouTube = new System.Windows.Forms.Label();
            this.lblWhatsapp = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbListado.Controls.Add(this.label1);
            this.gbListado.Controls.Add(this.txtBusqueda);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnListar);
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListado.Location = new System.Drawing.Point(302, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(568, 380);
            this.gbListado.TabIndex = 1;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Empresas ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(70, 33);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(230, 21);
            this.txtBusqueda.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnModificar.IconSize = 21;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModificar.Location = new System.Drawing.Point(94, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListar.IconColor = System.Drawing.Color.Purple;
            this.btnListar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnListar.IconSize = 22;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListar.Location = new System.Drawing.Point(481, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "&Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.RazonSocial,
            this.RUC,
            this.Facebook,
            this.Instagram,
            this.Youtube,
            this.Whatsapp,
            this.Correo,
            this.Logo,
            this.Vigencia});
            this.dgvListado.Location = new System.Drawing.Point(16, 62);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(537, 274);
            this.dgvListado.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "RUC";
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            // 
            // Facebook
            // 
            this.Facebook.DataPropertyName = "Facebook";
            this.Facebook.HeaderText = "Facebook";
            this.Facebook.Name = "Facebook";
            this.Facebook.Visible = false;
            // 
            // Instagram
            // 
            this.Instagram.DataPropertyName = "Instagram";
            this.Instagram.HeaderText = "Instagram";
            this.Instagram.Name = "Instagram";
            this.Instagram.Visible = false;
            // 
            // Youtube
            // 
            this.Youtube.DataPropertyName = "YouTube";
            this.Youtube.HeaderText = "Youtube";
            this.Youtube.Name = "Youtube";
            this.Youtube.Visible = false;
            // 
            // Whatsapp
            // 
            this.Whatsapp.DataPropertyName = "Whatsapp";
            this.Whatsapp.HeaderText = "Whatsapp";
            this.Whatsapp.Name = "Whatsapp";
            this.Whatsapp.Visible = false;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Logo
            // 
            this.Logo.DataPropertyName = "Logo";
            this.Logo.HeaderText = "Logo";
            this.Logo.Name = "Logo";
            this.Logo.Visible = false;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "Vigencia";
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 22;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNuevo.Location = new System.Drawing.Point(16, 345);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbEmpresa.Controls.Add(this.btnCancelar);
            this.gbEmpresa.Controls.Add(this.btnAceptar);
            this.gbEmpresa.Controls.Add(this.txtRazonSocial);
            this.gbEmpresa.Controls.Add(this.chkVigente);
            this.gbEmpresa.Controls.Add(this.txtCorreo);
            this.gbEmpresa.Controls.Add(this.txtLogo);
            this.gbEmpresa.Controls.Add(this.txtInstagram);
            this.gbEmpresa.Controls.Add(this.txtWhatsapp);
            this.gbEmpresa.Controls.Add(this.txtYoutube);
            this.gbEmpresa.Controls.Add(this.lblRUC);
            this.gbEmpresa.Controls.Add(this.lblFacebook);
            this.gbEmpresa.Controls.Add(this.lblInsta);
            this.gbEmpresa.Controls.Add(this.lblYouTube);
            this.gbEmpresa.Controls.Add(this.lblWhatsapp);
            this.gbEmpresa.Controls.Add(this.lblCorreo);
            this.gbEmpresa.Controls.Add(this.lblLogo);
            this.gbEmpresa.Controls.Add(this.txtFacebook);
            this.gbEmpresa.Controls.Add(this.txtRUC);
            this.gbEmpresa.Controls.Add(this.lblRazonSocial);
            this.gbEmpresa.Enabled = false;
            this.gbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpresa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbEmpresa.Location = new System.Drawing.Point(12, 12);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(275, 368);
            this.gbEmpresa.TabIndex = 0;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Datos de la Empresa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Crimson;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 22;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(164, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 22;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(83, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AccessibleDescription = "";
            this.txtRazonSocial.AccessibleName = "";
            this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRazonSocial.Location = new System.Drawing.Point(128, 36);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(121, 21);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazonSocial_Validating);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVigente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chkVigente.Location = new System.Drawing.Point(20, 294);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(67, 19);
            this.chkVigente.TabIndex = 16;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorreo.Location = new System.Drawing.Point(128, 229);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 21);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // txtLogo
            // 
            this.txtLogo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLogo.Location = new System.Drawing.Point(128, 261);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(121, 21);
            this.txtLogo.TabIndex = 15;
            // 
            // txtInstagram
            // 
            this.txtInstagram.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInstagram.Location = new System.Drawing.Point(128, 130);
            this.txtInstagram.MaxLength = 100;
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(121, 21);
            this.txtInstagram.TabIndex = 7;
            // 
            // txtWhatsapp
            // 
            this.txtWhatsapp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWhatsapp.Location = new System.Drawing.Point(128, 198);
            this.txtWhatsapp.MaxLength = 9;
            this.txtWhatsapp.Name = "txtWhatsapp";
            this.txtWhatsapp.Size = new System.Drawing.Size(121, 21);
            this.txtWhatsapp.TabIndex = 11;
            this.txtWhatsapp.TextChanged += new System.EventHandler(this.txtWhatsapp_TextChanged);
            this.txtWhatsapp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // txtYoutube
            // 
            this.txtYoutube.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYoutube.Location = new System.Drawing.Point(128, 164);
            this.txtYoutube.MaxLength = 100;
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(121, 21);
            this.txtYoutube.TabIndex = 9;
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRUC.Location = new System.Drawing.Point(17, 71);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(42, 15);
            this.lblRUC.TabIndex = 2;
            this.lblRUC.Text = "&RUC : ";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFacebook.Location = new System.Drawing.Point(17, 101);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(67, 15);
            this.lblFacebook.TabIndex = 4;
            this.lblFacebook.Text = "&Facebook :";
            // 
            // lblInsta
            // 
            this.lblInsta.AutoSize = true;
            this.lblInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInsta.Location = new System.Drawing.Point(17, 133);
            this.lblInsta.Name = "lblInsta";
            this.lblInsta.Size = new System.Drawing.Size(71, 15);
            this.lblInsta.TabIndex = 6;
            this.lblInsta.Text = "&Instagram : ";
            // 
            // lblYouTube
            // 
            this.lblYouTube.AutoSize = true;
            this.lblYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouTube.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblYouTube.Location = new System.Drawing.Point(17, 167);
            this.lblYouTube.Name = "lblYouTube";
            this.lblYouTube.Size = new System.Drawing.Size(65, 15);
            this.lblYouTube.TabIndex = 8;
            this.lblYouTube.Text = "&YouTube : ";
            // 
            // lblWhatsapp
            // 
            this.lblWhatsapp.AutoSize = true;
            this.lblWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatsapp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblWhatsapp.Location = new System.Drawing.Point(17, 201);
            this.lblWhatsapp.Name = "lblWhatsapp";
            this.lblWhatsapp.Size = new System.Drawing.Size(71, 15);
            this.lblWhatsapp.TabIndex = 10;
            this.lblWhatsapp.Text = "&Whatsapp : ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCorreo.Location = new System.Drawing.Point(17, 232);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(50, 15);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "C&orreo :";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLogo.Location = new System.Drawing.Point(17, 261);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(44, 15);
            this.lblLogo.TabIndex = 14;
            this.lblLogo.Text = "Lo&go : ";
            // 
            // txtFacebook
            // 
            this.txtFacebook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFacebook.Location = new System.Drawing.Point(128, 98);
            this.txtFacebook.MaxLength = 100;
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(121, 21);
            this.txtFacebook.TabIndex = 5;
            // 
            // txtRUC
            // 
            this.txtRUC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRUC.Location = new System.Drawing.Point(128, 68);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(121, 21);
            this.txtRUC.TabIndex = 3;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtRUC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRUC_Validating);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRazonSocial.Location = new System.Drawing.Point(17, 39);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(86, 15);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razón &Social :";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Crimson;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 22;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.Location = new System.Drawing.Point(798, 398);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errMensaje
            // 
            this.errMensaje.ContainerControl = this;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 433);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpresa";
            this.Text = "FrmEmpresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.TextBox txtWhatsapp;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Label lblInsta;
        private System.Windows.Forms.Label lblYouTube;
        private System.Windows.Forms.Label lblWhatsapp;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label lblRazonSocial;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnListar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.ErrorProvider errMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Youtube;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vigencia;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
    }
}