namespace ProyectoProgra
{
    partial class FrmReporteSistemaPensiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboSistema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPDF = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSistema
            // 
            this.cboSistema.FormattingEnabled = true;
            this.cboSistema.Location = new System.Drawing.Point(69, 32);
            this.cboSistema.Name = "cboSistema";
            this.cboSistema.Size = new System.Drawing.Size(121, 21);
            this.cboSistema.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Buscar :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.btnCerrar.Location = new System.Drawing.Point(707, 450);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 23);
            this.btnCerrar.TabIndex = 40;
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
            this.btnListar.Location = new System.Drawing.Point(226, 32);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 23);
            this.btnListar.TabIndex = 39;
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
            this.cdNombre,
            this.cdCelular});
            this.dgvListado.Location = new System.Drawing.Point(15, 64);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(764, 380);
            this.dgvListado.TabIndex = 38;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "NombreCompleto";
            this.cdNombre.HeaderText = "Nombre de Personal";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            this.cdNombre.Width = 700;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "NumeroDocumento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.cdCelular.DefaultCellStyle = dataGridViewCellStyle2;
            this.cdCelular.HeaderText = "Número de Documento";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            this.cdCelular.Width = 400;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGenerarPDF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarPDF.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGenerarPDF.IconSize = 27;
            this.btnGenerarPDF.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGenerarPDF.Location = new System.Drawing.Point(659, 21);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(120, 37);
            this.btnGenerarPDF.TabIndex = 43;
            this.btnGenerarPDF.Text = "&Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // FrmReporteSistemaPensiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.cboSistema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListado);
            this.Name = "FrmReporteSistemaPensiones";
            this.Text = "Reporte de Sistema de Pensiones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteSistemaPensiones_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteSistemaPensiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSistema;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private FontAwesome.Sharp.IconButton btnGenerarPDF;
    }
}