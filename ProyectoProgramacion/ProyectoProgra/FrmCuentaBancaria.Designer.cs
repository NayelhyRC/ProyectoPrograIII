namespace ProyectoProgra
{
    partial class FrmCuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentaBancaria));
            this.gbListadoCuentasBancaria = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.cboEntidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconAceptar = new FontAwesome.Sharp.IconButton();
            this.cboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.Repetir = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCodigoCCI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.errMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbListadoCuentasBancaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoCuentasBancaria
            // 
            this.gbListadoCuentasBancaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListadoCuentasBancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbListadoCuentasBancaria.Controls.Add(this.txtBusqueda);
            this.gbListadoCuentasBancaria.Controls.Add(this.lblBuscar);
            this.gbListadoCuentasBancaria.Controls.Add(this.dgvListado);
            this.gbListadoCuentasBancaria.Controls.Add(this.btnListar);
            this.gbListadoCuentasBancaria.Controls.Add(this.btnModificar);
            this.gbListadoCuentasBancaria.Controls.Add(this.btnNuevo);
            this.gbListadoCuentasBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoCuentasBancaria.Location = new System.Drawing.Point(358, 27);
            this.gbListadoCuentasBancaria.Name = "gbListadoCuentasBancaria";
            this.gbListadoCuentasBancaria.Size = new System.Drawing.Size(556, 365);
            this.gbListadoCuentasBancaria.TabIndex = 1;
            this.gbListadoCuentasBancaria.TabStop = false;
            this.gbListadoCuentasBancaria.Text = "Listado de Cuentas Bancarias";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(74, 36);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(122, 21);
            this.txtBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(11, 39);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(51, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(11, 68);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(534, 261);
            this.dgvListado.TabIndex = 3;
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
            this.btnListar.Location = new System.Drawing.Point(473, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "&Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(89, 336);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 5;
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
            this.btnNuevo.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 22;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNuevo.Location = new System.Drawing.Point(11, 336);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbCuenta
            // 
            this.gbCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbCuenta.Controls.Add(this.cboEmpresa);
            this.gbCuenta.Controls.Add(this.cboEntidad);
            this.gbCuenta.Controls.Add(this.label4);
            this.gbCuenta.Controls.Add(this.label1);
            this.gbCuenta.Controls.Add(this.btnCancelar);
            this.gbCuenta.Controls.Add(this.iconAceptar);
            this.gbCuenta.Controls.Add(this.cboTipoMoneda);
            this.gbCuenta.Controls.Add(this.chkVigente);
            this.gbCuenta.Controls.Add(this.txtNombre);
            this.gbCuenta.Controls.Add(this.lblFechaNacimiento);
            this.gbCuenta.Controls.Add(this.Repetir);
            this.gbCuenta.Controls.Add(this.txtNumeroCuenta);
            this.gbCuenta.Controls.Add(this.lblApellidos);
            this.gbCuenta.Controls.Add(this.txtCodigoCCI);
            this.gbCuenta.Controls.Add(this.label2);
            this.gbCuenta.Enabled = false;
            this.gbCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuenta.Location = new System.Drawing.Point(23, 27);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(320, 316);
            this.gbCuenta.TabIndex = 0;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Datos  de la Cuenta Bancaria";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Items.AddRange(new object[] {
            "Dolar",
            "Soles"});
            this.cboEmpresa.Location = new System.Drawing.Point(129, 65);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(164, 23);
            this.cboEmpresa.TabIndex = 3;
            // 
            // cboEntidad
            // 
            this.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidad.FormattingEnabled = true;
            this.cboEntidad.Items.AddRange(new object[] {
            "Dolar",
            "Soles"});
            this.cboEntidad.Location = new System.Drawing.Point(129, 34);
            this.cboEntidad.Name = "cboEntidad";
            this.cboEntidad.Size = new System.Drawing.Size(164, 23);
            this.cboEntidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "E&mpresa : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Entidad Bancaria: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Crimson;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 22;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(208, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconAceptar
            // 
            this.iconAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconAceptar.IconColor = System.Drawing.Color.ForestGreen;
            this.iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAceptar.IconSize = 22;
            this.iconAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconAceptar.Location = new System.Drawing.Point(127, 275);
            this.iconAceptar.Name = "iconAceptar";
            this.iconAceptar.Size = new System.Drawing.Size(75, 23);
            this.iconAceptar.TabIndex = 13;
            this.iconAceptar.Text = "&Aceptar";
            this.iconAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconAceptar.UseVisualStyleBackColor = true;
            this.iconAceptar.Click += new System.EventHandler(this.iconAceptar_Click);
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Items.AddRange(new object[] {
            "Dólar",
            "Sol",
            "Euro"});
            this.cboTipoMoneda.Location = new System.Drawing.Point(129, 206);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(164, 23);
            this.cboTipoMoneda.TabIndex = 11;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVigente.Location = new System.Drawing.Point(13, 245);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(67, 19);
            this.chkVigente.TabIndex = 12;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(129, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '*';
            this.txtNombre.Size = new System.Drawing.Size(164, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(14, 209);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(83, 15);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "&TipoMoneda :";
            // 
            // Repetir
            // 
            this.Repetir.AutoSize = true;
            this.Repetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repetir.Location = new System.Drawing.Point(14, 177);
            this.Repetir.Name = "Repetir";
            this.Repetir.Size = new System.Drawing.Size(58, 15);
            this.Repetir.TabIndex = 8;
            this.Repetir.Text = "N&ombre :";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(129, 138);
            this.txtNumeroCuenta.MaxLength = 24;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.PasswordChar = '*';
            this.txtNumeroCuenta.Size = new System.Drawing.Size(164, 21);
            this.txtNumeroCuenta.TabIndex = 7;
            this.txtNumeroCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroCuenta_Validating);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(14, 141);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(120, 15);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "N&úmero de Cuenta : ";
            // 
            // txtCodigoCCI
            // 
            this.txtCodigoCCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCCI.Location = new System.Drawing.Point(129, 103);
            this.txtCodigoCCI.MaxLength = 20;
            this.txtCodigoCCI.Name = "txtCodigoCCI";
            this.txtCodigoCCI.Size = new System.Drawing.Size(164, 21);
            this.txtCodigoCCI.TabIndex = 5;
            this.txtCodigoCCI.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoCCI_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC&I: ";
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
            this.btnCerrar.Location = new System.Drawing.Point(842, 398);
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
            // FrmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(926, 433);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListadoCuentasBancaria);
            this.Controls.Add(this.gbCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuentaBancaria";
            this.Text = "Cuenta Bancaria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCuentaBancaria_FormClosed);
            this.Load += new System.EventHandler(this.FrmCuentaBancaria_Load);
            this.gbListadoCuentasBancaria.ResumeLayout(false);
            this.gbListadoCuentasBancaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbCuenta.ResumeLayout(false);
            this.gbCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.GroupBox gbListadoCuentasBancaria;
        private System.Windows.Forms.DataGridView dgvListado;
        private FontAwesome.Sharp.IconButton btnListar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.GroupBox gbCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton iconAceptar;
        private System.Windows.Forms.ComboBox cboTipoMoneda;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label Repetir;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCodigoCCI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.ComboBox cboEntidad;
        private System.Windows.Forms.ErrorProvider errMensaje;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
    }
}