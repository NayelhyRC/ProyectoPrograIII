namespace ProyectoProgra
{
    partial class FrmContratosPorVencer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtpMesInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpMesFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
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
            this.dgvListado.Location = new System.Drawing.Point(12, 52);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(858, 431);
            this.dgvListado.TabIndex = 60;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.NullValue = null;
            this.cdDocumentoPersonal.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.cdCelular.DefaultCellStyle = dataGridViewCellStyle7;
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            // 
            // cdFechaInicio
            // 
            this.cdFechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.cdFechaInicio.DefaultCellStyle = dataGridViewCellStyle8;
            this.cdFechaInicio.HeaderText = "Fecha de Inicio";
            this.cdFechaInicio.Name = "cdFechaInicio";
            this.cdFechaInicio.ReadOnly = true;
            // 
            // cdFechaFin
            // 
            this.cdFechaFin.DataPropertyName = "FechaFin";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.cdFechaFin.DefaultCellStyle = dataGridViewCellStyle9;
            this.cdFechaFin.HeaderText = "Fecha de Término";
            this.cdFechaFin.Name = "cdFechaFin";
            this.cdFechaFin.ReadOnly = true;
            // 
            // cdSueldo
            // 
            this.cdSueldo.DataPropertyName = "Sueldo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.cdSueldo.DefaultCellStyle = dataGridViewCellStyle10;
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
            // dtpMesInicio
            // 
            this.dtpMesInicio.CustomFormat = "yyyy-mm-dd hh:mm:ss";
            this.dtpMesInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMesInicio.Location = new System.Drawing.Point(72, 22);
            this.dtpMesInicio.Name = "dtpMesInicio";
            this.dtpMesInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpMesInicio.TabIndex = 59;
            // 
            // dtpMesFin
            // 
            this.dtpMesFin.CustomFormat = "yyyy-mm-dd hh:mm:ss";
            this.dtpMesFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMesFin.Location = new System.Drawing.Point(301, 21);
            this.dtpMesFin.Name = "dtpMesFin";
            this.dtpMesFin.Size = new System.Drawing.Size(104, 20);
            this.dtpMesFin.TabIndex = 58;
            // 
            // lblFechaI
            // 
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaI.Location = new System.Drawing.Point(9, 26);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(57, 15);
            this.lblFechaI.TabIndex = 55;
            this.lblFechaI.Text = "Fecha 1 :";
            this.lblFechaI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.btnCerrar.Location = new System.Drawing.Point(798, 494);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 23);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListar.IconColor = System.Drawing.Color.Purple;
            this.btnListar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnListar.IconSize = 22;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListar.Location = new System.Drawing.Point(425, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 23);
            this.btnListar.TabIndex = 53;
            this.btnListar.Text = "&Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha 2 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FrmContratosPorVencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.dtpMesInicio);
            this.Controls.Add(this.dtpMesFin);
            this.Controls.Add(this.lblFechaI);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Name = "FrmContratosPorVencer";
            this.Text = "Contratos por vencer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
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
        private System.Windows.Forms.DateTimePicker dtpMesInicio;
        private System.Windows.Forms.DateTimePicker dtpMesFin;
        private System.Windows.Forms.Label lblFechaI;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnListar;
        private System.Windows.Forms.Label label1;
    }
}