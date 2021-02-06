namespace ProyectoProgra
{
    partial class FrmLocalPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalPersonal));
            this.cboPersonal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSueldo = new System.Windows.Forms.NumericUpDown();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.txtCelularEmpresarial = new System.Windows.Forms.TextBox();
            this.txtCorreoEmpresarial = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.gbListadoLocales = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cdLocalNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDocumentoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.errProviderMssg = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).BeginInit();
            this.gbListadoLocales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMssg)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPersonal
            // 
            this.cboPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPersonal.FormattingEnabled = true;
            this.cboPersonal.Location = new System.Drawing.Point(138, 30);
            this.cboPersonal.Name = "cboPersonal";
            this.cboPersonal.Size = new System.Drawing.Size(153, 23);
            this.cboPersonal.TabIndex = 2;
            this.cboPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.cboPersonal_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "C&elular Empresarial:";
            // 
            // gbPersonal
            // 
            this.gbPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbPersonal.Controls.Add(this.dtpFechaFin);
            this.gbPersonal.Controls.Add(this.dtpFechaInicio);
            this.gbPersonal.Controls.Add(this.btnCancelar);
            this.gbPersonal.Controls.Add(this.btnAceptar);
            this.gbPersonal.Controls.Add(this.label6);
            this.gbPersonal.Controls.Add(this.label5);
            this.gbPersonal.Controls.Add(this.cboLocal);
            this.gbPersonal.Controls.Add(this.label4);
            this.gbPersonal.Controls.Add(this.label3);
            this.gbPersonal.Controls.Add(this.nudSueldo);
            this.gbPersonal.Controls.Add(this.cboPersonal);
            this.gbPersonal.Controls.Add(this.label1);
            this.gbPersonal.Controls.Add(this.chkVigente);
            this.gbPersonal.Controls.Add(this.txtCelularEmpresarial);
            this.gbPersonal.Controls.Add(this.txtCorreoEmpresarial);
            this.gbPersonal.Controls.Add(this.lblApellidos);
            this.gbPersonal.Controls.Add(this.txtCargo);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Controls.Add(this.lbl);
            this.gbPersonal.Enabled = false;
            this.gbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.Location = new System.Drawing.Point(12, 12);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(314, 393);
            this.gbPersonal.TabIndex = 0;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Datos de Contrato de Personal";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(137, 287);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(154, 21);
            this.dtpFechaFin.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(137, 250);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(154, 21);
            this.dtpFechaInicio.TabIndex = 14;
            this.dtpFechaInicio.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaInicio_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Crimson;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 22;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(206, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 0;
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
            this.btnAceptar.Location = new System.Drawing.Point(125, 354);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "&Fecha Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha &Inicio:";
            // 
            // cboLocal
            // 
            this.cboLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(137, 67);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(154, 23);
            this.cboLocal.TabIndex = 4;
            this.cboLocal.Validating += new System.ComponentModel.CancelEventHandler(this.cboLocal_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "L&ocal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "&Sueldo:";
            // 
            // nudSueldo
            // 
            this.nudSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSueldo.Location = new System.Drawing.Point(138, 142);
            this.nudSueldo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSueldo.Minimum = new decimal(new int[] {
            950,
            0,
            0,
            0});
            this.nudSueldo.Name = "nudSueldo";
            this.nudSueldo.Size = new System.Drawing.Size(153, 21);
            this.nudSueldo.TabIndex = 8;
            this.nudSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSueldo.Value = new decimal(new int[] {
            950,
            0,
            0,
            0});
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVigente.Location = new System.Drawing.Point(18, 324);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(67, 19);
            this.chkVigente.TabIndex = 17;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // txtCelularEmpresarial
            // 
            this.txtCelularEmpresarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularEmpresarial.Location = new System.Drawing.Point(137, 211);
            this.txtCelularEmpresarial.MaxLength = 9;
            this.txtCelularEmpresarial.Name = "txtCelularEmpresarial";
            this.txtCelularEmpresarial.Size = new System.Drawing.Size(154, 21);
            this.txtCelularEmpresarial.TabIndex = 12;
            this.txtCelularEmpresarial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelularEmpresarial_KeyPress);
            this.txtCelularEmpresarial.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelularEmpresarial_Validating);
            // 
            // txtCorreoEmpresarial
            // 
            this.txtCorreoEmpresarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoEmpresarial.Location = new System.Drawing.Point(137, 177);
            this.txtCorreoEmpresarial.Name = "txtCorreoEmpresarial";
            this.txtCorreoEmpresarial.Size = new System.Drawing.Size(154, 21);
            this.txtCorreoEmpresarial.TabIndex = 10;
            this.txtCorreoEmpresarial.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreoEmpresarial_Validating);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(15, 177);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(117, 15);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Co&rreo Empresarial:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(138, 104);
            this.txtCargo.MaxLength = 70;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(153, 21);
            this.txtCargo.TabIndex = 6;
            this.txtCargo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCargo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car&go:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(15, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(59, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "&Personal:";
            // 
            // gbListadoLocales
            // 
            this.gbListadoLocales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListadoLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbListadoLocales.Controls.Add(this.txtBusqueda);
            this.gbListadoLocales.Controls.Add(this.lblBusqueda);
            this.gbListadoLocales.Controls.Add(this.btnModificar);
            this.gbListadoLocales.Controls.Add(this.btnNuevo);
            this.gbListadoLocales.Controls.Add(this.btnListar);
            this.gbListadoLocales.Controls.Add(this.dgvListado);
            this.gbListadoLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoLocales.Location = new System.Drawing.Point(332, 12);
            this.gbListadoLocales.Name = "gbListadoLocales";
            this.gbListadoLocales.Size = new System.Drawing.Size(507, 393);
            this.gbListadoLocales.TabIndex = 1;
            this.gbListadoLocales.TabStop = false;
            this.gbListadoLocales.Text = "Listado de Contratos";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(222, 40);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(161, 21);
            this.txtBusqueda.TabIndex = 5;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(8, 43);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(208, 15);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Buscar por documento de personal : ";
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
            this.btnModificar.Location = new System.Drawing.Point(89, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.Olive;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 22;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNuevo.Location = new System.Drawing.Point(11, 354);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnListar.Location = new System.Drawing.Point(426, 39);
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
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdLocalNombre,
            this.cdPersonal,
            this.cdDocumentoPersonal,
            this.cdCorreo,
            this.cdCelular,
            this.cdFechaInicio,
            this.cdFechaFin,
            this.cdSueldo,
            this.cdCargo,
            this.cdVigencia});
            this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListado.Location = new System.Drawing.Point(11, 70);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(487, 275);
            this.dgvListado.TabIndex = 1;
            // 
            // cdLocalNombre
            // 
            this.cdLocalNombre.DataPropertyName = "NombreLocal";
            this.cdLocalNombre.HeaderText = "Local";
            this.cdLocalNombre.Name = "cdLocalNombre";
            this.cdLocalNombre.ReadOnly = true;
            this.cdLocalNombre.Width = 170;
            // 
            // cdPersonal
            // 
            this.cdPersonal.DataPropertyName = "NombrePersonal";
            this.cdPersonal.HeaderText = "Personal";
            this.cdPersonal.Name = "cdPersonal";
            this.cdPersonal.ReadOnly = true;
            this.cdPersonal.Width = 180;
            // 
            // cdDocumentoPersonal
            // 
            this.cdDocumentoPersonal.DataPropertyName = "DocumentoPersonal";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.NullValue = null;
            this.cdDocumentoPersonal.DefaultCellStyle = dataGridViewCellStyle1;
            this.cdDocumentoPersonal.HeaderText = "Nmro. Documento";
            this.cdDocumentoPersonal.Name = "cdDocumentoPersonal";
            this.cdDocumentoPersonal.ReadOnly = true;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "CorreoEmpresarial";
            this.cdCorreo.HeaderText = "Correo";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "CelularEmpresarial";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cdCelular.DefaultCellStyle = dataGridViewCellStyle2;
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            // 
            // cdFechaInicio
            // 
            this.cdFechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.cdFechaInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.cdFechaInicio.HeaderText = "Fecha de Inicio";
            this.cdFechaInicio.Name = "cdFechaInicio";
            this.cdFechaInicio.ReadOnly = true;
            // 
            // cdFechaFin
            // 
            this.cdFechaFin.DataPropertyName = "FechaFin";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.cdFechaFin.DefaultCellStyle = dataGridViewCellStyle4;
            this.cdFechaFin.HeaderText = "Fecha de Término";
            this.cdFechaFin.Name = "cdFechaFin";
            this.cdFechaFin.ReadOnly = true;
            // 
            // cdSueldo
            // 
            this.cdSueldo.DataPropertyName = "Sueldo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.cdSueldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.cdSueldo.HeaderText = "Sueldo";
            this.cdSueldo.Name = "cdSueldo";
            this.cdSueldo.ReadOnly = true;
            this.cdSueldo.Width = 80;
            // 
            // cdCargo
            // 
            this.cdCargo.DataPropertyName = "Cargo";
            this.cdCargo.HeaderText = "Cargo";
            this.cdCargo.Name = "cdCargo";
            this.cdCargo.ReadOnly = true;
            // 
            // cdVigencia
            // 
            this.cdVigencia.DataPropertyName = "Vigencia";
            this.cdVigencia.HeaderText = "Vigente";
            this.cdVigencia.Name = "cdVigencia";
            this.cdVigencia.ReadOnly = true;
            this.cdVigencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdVigencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cdVigencia.Width = 80;
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
            this.btnCerrar.Location = new System.Drawing.Point(767, 411);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errProviderMssg
            // 
            this.errProviderMssg.ContainerControl = this;
            // 
            // FrmLocalPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(851, 445);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.gbListadoLocales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocalPersonal";
            this.Text = "Contrato de Personal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLocalPersonal_FormClosed);
            this.Load += new System.EventHandler(this.FrmLocalPersonal_Load);
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).EndInit();
            this.gbListadoLocales.ResumeLayout(false);
            this.gbListadoLocales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMssg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.TextBox txtCelularEmpresarial;
        private System.Windows.Forms.TextBox txtCorreoEmpresarial;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gbListadoLocales;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnListar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdLocalNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDocumentoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigencia;
        private System.Windows.Forms.ErrorProvider errProviderMssg;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}