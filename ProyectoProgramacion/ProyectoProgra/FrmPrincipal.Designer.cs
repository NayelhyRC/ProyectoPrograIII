namespace ProyectoProgra
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rbTabPlataforma = new System.Windows.Forms.RibbonTab();
            this.rbPanelEmpresa = new System.Windows.Forms.RibbonPanel();
            this.rbButtonEmpresa = new System.Windows.Forms.RibbonButton();
            this.rbPanelLocal = new System.Windows.Forms.RibbonPanel();
            this.rbBtnLocal = new System.Windows.Forms.RibbonButton();
            this.rbPanelDocumento = new System.Windows.Forms.RibbonPanel();
            this.rbBtnDocumento = new System.Windows.Forms.RibbonButton();
            this.rbPanelContratoPersonal = new System.Windows.Forms.RibbonPanel();
            this.rbBtnContratoPersonal = new System.Windows.Forms.RibbonButton();
            this.rbPanelPersonal = new System.Windows.Forms.RibbonPanel();
            this.rbBtnPersonal = new System.Windows.Forms.RibbonButton();
            this.rbnPanelUsuario = new System.Windows.Forms.RibbonPanel();
            this.rbBtnUsuario = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnPerfil = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.rbPanelMedioPago = new System.Windows.Forms.RibbonPanel();
            this.rbBtnMedioPago = new System.Windows.Forms.RibbonButton();
            this.rbPanelEntidad = new System.Windows.Forms.RibbonPanel();
            this.rbBtnEntidad = new System.Windows.Forms.RibbonButton();
            this.rbPanelSistemaPensiones = new System.Windows.Forms.RibbonPanel();
            this.rbBtnSistemaPensiones = new System.Windows.Forms.RibbonButton();
            this.rbPanelCuentaBancaria = new System.Windows.Forms.RibbonPanel();
            this.rbBtnCuenta = new System.Windows.Forms.RibbonButton();
            this.rbTabReportes = new System.Windows.Forms.RibbonTab();
            this.rbPanelReporteSist = new System.Windows.Forms.RibbonPanel();
            this.rbBtnReporteSist = new System.Windows.Forms.RibbonButton();
            this.rbLblReporteSistPersonal = new System.Windows.Forms.RibbonLabel();
            this.tabControl = new MdiTabControl.TabControl();
            this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.rbPanelReportesContratos = new System.Windows.Forms.RibbonPanel();
            this.rbBtnReporteContratos = new System.Windows.Forms.RibbonButton();
            this.lblReporteContato = new System.Windows.Forms.RibbonLabel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.Color.Green;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(902, 145);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rbTabPlataforma);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.rbTabReportes);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.ribbon1.TabSpacing = 4;
            this.ribbon1.Text = "Cinta de Opciones";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // rbTabPlataforma
            // 
            this.rbTabPlataforma.Name = "rbTabPlataforma";
            this.rbTabPlataforma.Panels.Add(this.rbPanelEmpresa);
            this.rbTabPlataforma.Panels.Add(this.rbPanelLocal);
            this.rbTabPlataforma.Panels.Add(this.rbPanelDocumento);
            this.rbTabPlataforma.Panels.Add(this.rbPanelContratoPersonal);
            this.rbTabPlataforma.Panels.Add(this.rbPanelPersonal);
            this.rbTabPlataforma.Panels.Add(this.rbnPanelUsuario);
            this.rbTabPlataforma.Panels.Add(this.ribbonPanel1);
            this.rbTabPlataforma.Text = "Plataforma";
            // 
            // rbPanelEmpresa
            // 
            this.rbPanelEmpresa.ButtonMoreVisible = false;
            this.rbPanelEmpresa.Items.Add(this.rbButtonEmpresa);
            this.rbPanelEmpresa.Name = "rbPanelEmpresa";
            this.rbPanelEmpresa.Text = "Empresas";
            // 
            // rbButtonEmpresa
            // 
            this.rbButtonEmpresa.Image = global::ProyectoProgra.Properties.Resources.empresa;
            this.rbButtonEmpresa.LargeImage = global::ProyectoProgra.Properties.Resources.empresa;
            this.rbButtonEmpresa.Name = "rbButtonEmpresa";
            this.rbButtonEmpresa.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonEmpresa.SmallImage")));
            this.rbButtonEmpresa.ToolTip = "Permite registrar empresas en el sistema,  asimismo permite listarlas de acuerdo," +
    " asimismo, listarlas de acuerdo a criterios de búsqueda. ";
            this.rbButtonEmpresa.ToolTipTitle = "Empresas";
            this.rbButtonEmpresa.Click += new System.EventHandler(this.rbButtonEmpresa_Click);
            // 
            // rbPanelLocal
            // 
            this.rbPanelLocal.ButtonMoreVisible = false;
            this.rbPanelLocal.Items.Add(this.rbBtnLocal);
            this.rbPanelLocal.Name = "rbPanelLocal";
            this.rbPanelLocal.Text = "Locales";
            // 
            // rbBtnLocal
            // 
            this.rbBtnLocal.Image = global::ProyectoProgra.Properties.Resources.local;
            this.rbBtnLocal.LargeImage = global::ProyectoProgra.Properties.Resources.local;
            this.rbBtnLocal.Name = "rbBtnLocal";
            this.rbBtnLocal.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnLocal.SmallImage")));
            this.rbBtnLocal.ToolTip = "Permite registrar locales en el sistema, además de listarlas, con la opción de li" +
    "star por ciertos criterios de búsqueda.";
            this.rbBtnLocal.ToolTipTitle = "Locales";
            this.rbBtnLocal.Click += new System.EventHandler(this.rbBtnLocal_Click);
            // 
            // rbPanelDocumento
            // 
            this.rbPanelDocumento.ButtonMoreVisible = false;
            this.rbPanelDocumento.Items.Add(this.rbBtnDocumento);
            this.rbPanelDocumento.Name = "rbPanelDocumento";
            this.rbPanelDocumento.Text = "Documento";
            // 
            // rbBtnDocumento
            // 
            this.rbBtnDocumento.Image = global::ProyectoProgra.Properties.Resources.documento;
            this.rbBtnDocumento.LargeImage = global::ProyectoProgra.Properties.Resources.documento;
            this.rbBtnDocumento.Name = "rbBtnDocumento";
            this.rbBtnDocumento.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnDocumento.SmallImage")));
            this.rbBtnDocumento.ToolTip = "Gestión de tipos de Documentos admitidos para  su posterior asignación al persona" +
    "l registrado.";
            this.rbBtnDocumento.ToolTipTitle = "Documento";
            this.rbBtnDocumento.Click += new System.EventHandler(this.rbBtnDocumento_Click);
            // 
            // rbPanelContratoPersonal
            // 
            this.rbPanelContratoPersonal.ButtonMoreVisible = false;
            this.rbPanelContratoPersonal.Items.Add(this.rbBtnContratoPersonal);
            this.rbPanelContratoPersonal.Name = "rbPanelContratoPersonal";
            this.rbPanelContratoPersonal.Text = "Contratos";
            // 
            // rbBtnContratoPersonal
            // 
            this.rbBtnContratoPersonal.Image = global::ProyectoProgra.Properties.Resources.localpersonal;
            this.rbBtnContratoPersonal.LargeImage = global::ProyectoProgra.Properties.Resources.localpersonal;
            this.rbBtnContratoPersonal.Name = "rbBtnContratoPersonal";
            this.rbBtnContratoPersonal.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnContratoPersonal.SmallImage")));
            this.rbBtnContratoPersonal.ToolTip = "Permite registrar contratos de personal, asimismo, permite listar  de acuerdo a l" +
    "a búsqueda de personal por número de documento.";
            this.rbBtnContratoPersonal.ToolTipTitle = "Contratos";
            this.rbBtnContratoPersonal.Click += new System.EventHandler(this.rbBtnContratoPersonal_Click);
            // 
            // rbPanelPersonal
            // 
            this.rbPanelPersonal.ButtonMoreVisible = false;
            this.rbPanelPersonal.Items.Add(this.rbBtnPersonal);
            this.rbPanelPersonal.Name = "rbPanelPersonal";
            this.rbPanelPersonal.Text = "Personal";
            // 
            // rbBtnPersonal
            // 
            this.rbBtnPersonal.Image = global::ProyectoProgra.Properties.Resources.personal;
            this.rbBtnPersonal.LargeImage = global::ProyectoProgra.Properties.Resources.personal;
            this.rbBtnPersonal.Name = "rbBtnPersonal";
            this.rbBtnPersonal.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnPersonal.SmallImage")));
            this.rbBtnPersonal.ToolTip = "Permite registrar al personal, asimismo, permite listarlos  de acuerdo a criterio" +
    "s de  búsqueda.";
            this.rbBtnPersonal.ToolTipTitle = "Personal";
            this.rbBtnPersonal.Click += new System.EventHandler(this.rbBtnPersonal_Click);
            // 
            // rbnPanelUsuario
            // 
            this.rbnPanelUsuario.ButtonMoreVisible = false;
            this.rbnPanelUsuario.Items.Add(this.rbBtnUsuario);
            this.rbnPanelUsuario.Name = "rbnPanelUsuario";
            this.rbnPanelUsuario.Text = "Usuarios";
            // 
            // rbBtnUsuario
            // 
            this.rbBtnUsuario.Image = global::ProyectoProgra.Properties.Resources.usuario;
            this.rbBtnUsuario.LargeImage = global::ProyectoProgra.Properties.Resources.usuario;
            this.rbBtnUsuario.Name = "rbBtnUsuario";
            this.rbBtnUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnUsuario.SmallImage")));
            this.rbBtnUsuario.ToolTip = "Permite registrar usuarios que accedan al sistema, asimismo, presenta un listado " +
    "de los mismos.";
            this.rbBtnUsuario.ToolTipTitle = "Usuarios";
            this.rbBtnUsuario.Click += new System.EventHandler(this.rbBtnUsuario_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.rbBtnPerfil);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Perfil";
            // 
            // rbBtnPerfil
            // 
            this.rbBtnPerfil.Image = global::ProyectoProgra.Properties.Resources.perfil;
            this.rbBtnPerfil.LargeImage = global::ProyectoProgra.Properties.Resources.perfil;
            this.rbBtnPerfil.Name = "rbBtnPerfil";
            this.rbBtnPerfil.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnPerfil.SmallImage")));
            this.rbBtnPerfil.ToolTip = "Permite registrar perfiles para asignarlos al tipo de usuario, asimismo, muestra " +
    "un listado de los mismos.";
            this.rbBtnPerfil.ToolTipTitle = "Perfil";
            this.rbBtnPerfil.Click += new System.EventHandler(this.rbBtnPerfil_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.rbPanelMedioPago);
            this.ribbonTab1.Panels.Add(this.rbPanelEntidad);
            this.ribbonTab1.Panels.Add(this.rbPanelSistemaPensiones);
            this.ribbonTab1.Panels.Add(this.rbPanelCuentaBancaria);
            this.ribbonTab1.Text = "Pagos";
            // 
            // rbPanelMedioPago
            // 
            this.rbPanelMedioPago.ButtonMoreEnabled = false;
            this.rbPanelMedioPago.ButtonMoreVisible = false;
            this.rbPanelMedioPago.Items.Add(this.rbBtnMedioPago);
            this.rbPanelMedioPago.Name = "rbPanelMedioPago";
            this.rbPanelMedioPago.Text = "Medio de Pago";
            // 
            // rbBtnMedioPago
            // 
            this.rbBtnMedioPago.Image = global::ProyectoProgra.Properties.Resources.mediopago;
            this.rbBtnMedioPago.LargeImage = global::ProyectoProgra.Properties.Resources.mediopago;
            this.rbBtnMedioPago.Name = "rbBtnMedioPago";
            this.rbBtnMedioPago.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnMedioPago.SmallImage")));
            this.rbBtnMedioPago.ToolTip = "Permite registrar los medios de pago con los que trabajará el sistema, asimismo, " +
    "presenta un listado de los mismos.";
            this.rbBtnMedioPago.ToolTipTitle = "Medio de Pago";
            this.rbBtnMedioPago.Click += new System.EventHandler(this.rbBtnMedioPago_Click);
            // 
            // rbPanelEntidad
            // 
            this.rbPanelEntidad.ButtonMoreEnabled = false;
            this.rbPanelEntidad.ButtonMoreVisible = false;
            this.rbPanelEntidad.Items.Add(this.rbBtnEntidad);
            this.rbPanelEntidad.Name = "rbPanelEntidad";
            this.rbPanelEntidad.Text = "Entidad Bancaria";
            // 
            // rbBtnEntidad
            // 
            this.rbBtnEntidad.Image = global::ProyectoProgra.Properties.Resources.entidad;
            this.rbBtnEntidad.LargeImage = global::ProyectoProgra.Properties.Resources.entidad;
            this.rbBtnEntidad.Name = "rbBtnEntidad";
            this.rbBtnEntidad.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnEntidad.SmallImage")));
            this.rbBtnEntidad.ToolTip = "Permite hacer el registro de entidades bancarias, así como listar las entidades y" +
    "a registradas y buscarlas de acuerdo a ciertos criterios.";
            this.rbBtnEntidad.ToolTipTitle = "Entidad Bancaria";
            this.rbBtnEntidad.Click += new System.EventHandler(this.rbBtnEntidad_Click);
            // 
            // rbPanelSistemaPensiones
            // 
            this.rbPanelSistemaPensiones.ButtonMoreEnabled = false;
            this.rbPanelSistemaPensiones.ButtonMoreVisible = false;
            this.rbPanelSistemaPensiones.Items.Add(this.rbBtnSistemaPensiones);
            this.rbPanelSistemaPensiones.Name = "rbPanelSistemaPensiones";
            this.rbPanelSistemaPensiones.Text = "Sistema de Pensiones";
            // 
            // rbBtnSistemaPensiones
            // 
            this.rbBtnSistemaPensiones.Image = global::ProyectoProgra.Properties.Resources.sistpensiones;
            this.rbBtnSistemaPensiones.LargeImage = global::ProyectoProgra.Properties.Resources.sistpensiones;
            this.rbBtnSistemaPensiones.Name = "rbBtnSistemaPensiones";
            this.rbBtnSistemaPensiones.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSistemaPensiones.SmallImage")));
            this.rbBtnSistemaPensiones.ToolTip = "Permite Registrar los sistemas de pensiones que soportará la empresa para su pres" +
    "onal.";
            this.rbBtnSistemaPensiones.ToolTipTitle = "Sistema de Pensiones";
            this.rbBtnSistemaPensiones.Click += new System.EventHandler(this.rbBtnSistemaPensiones_Click);
            // 
            // rbPanelCuentaBancaria
            // 
            this.rbPanelCuentaBancaria.ButtonMoreEnabled = false;
            this.rbPanelCuentaBancaria.ButtonMoreVisible = false;
            this.rbPanelCuentaBancaria.Items.Add(this.rbBtnCuenta);
            this.rbPanelCuentaBancaria.Name = "rbPanelCuentaBancaria";
            this.rbPanelCuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // rbBtnCuenta
            // 
            this.rbBtnCuenta.Image = global::ProyectoProgra.Properties.Resources.cuenta;
            this.rbBtnCuenta.LargeImage = global::ProyectoProgra.Properties.Resources.cuenta;
            this.rbBtnCuenta.Name = "rbBtnCuenta";
            this.rbBtnCuenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnCuenta.SmallImage")));
            this.rbBtnCuenta.ToolTip = "Permite registrar las cuentas bancarias con las que trabajará la empresa, asimism" +
    "o, las lista de acuedo a ciertos criterios de búsqueda.";
            this.rbBtnCuenta.ToolTipTitle = "Cuenta Bancaria";
            this.rbBtnCuenta.Click += new System.EventHandler(this.rbBtnCuenta_Click);
            // 
            // rbTabReportes
            // 
            this.rbTabReportes.Name = "rbTabReportes";
            this.rbTabReportes.Panels.Add(this.rbPanelReporteSist);
            this.rbTabReportes.Panels.Add(this.rbPanelReportesContratos);
            this.rbTabReportes.Text = "Reportes";
            // 
            // rbPanelReporteSist
            // 
            this.rbPanelReporteSist.ButtonMoreEnabled = false;
            this.rbPanelReporteSist.ButtonMoreVisible = false;
            this.rbPanelReporteSist.Items.Add(this.rbBtnReporteSist);
            this.rbPanelReporteSist.Items.Add(this.rbLblReporteSistPersonal);
            this.rbPanelReporteSist.Name = "rbPanelReporteSist";
            this.rbPanelReporteSist.Text = "Sistema de Pensiones";
            // 
            // rbBtnReporteSist
            // 
            this.rbBtnReporteSist.Image = global::ProyectoProgra.Properties.Resources.sistemaPReporte;
            this.rbBtnReporteSist.LargeImage = global::ProyectoProgra.Properties.Resources.sistemaPReporte;
            this.rbBtnReporteSist.Name = "rbBtnReporteSist";
            this.rbBtnReporteSist.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnReporteSist.SmallImage")));
            this.rbBtnReporteSist.Text = "Personal";
            this.rbBtnReporteSist.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.rbBtnReporteSist.ToolTip = "Lista el personal afiliado al sistema de pensiones elegido.";
            this.rbBtnReporteSist.ToolTipTitle = "Listado de Personal";
            this.rbBtnReporteSist.Click += new System.EventHandler(this.rbBtnReporteSist_Click);
            // 
            // rbLblReporteSistPersonal
            // 
            this.rbLblReporteSistPersonal.Name = "rbLblReporteSistPersonal";
            this.rbLblReporteSistPersonal.Text = "Listado de Personal";
            this.rbLblReporteSistPersonal.Click += new System.EventHandler(this.rbLblReporteSistPersonal_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.BackColor = System.Drawing.Color.White;
            this.tabControl.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControl.BorderColorDisabled = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 142);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(902, 312);
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabIndex = 1;
            // 
            // ribbonDescriptionMenuItem1
            // 
            this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.Image")));
            this.ribbonDescriptionMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.LargeImage")));
            this.ribbonDescriptionMenuItem1.Name = "ribbonDescriptionMenuItem1";
            this.ribbonDescriptionMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.SmallImage")));
            this.ribbonDescriptionMenuItem1.Text = "ribbonDescriptionMenuItem1";
            // 
            // rbPanelReportesContratos
            // 
            this.rbPanelReportesContratos.ButtonMoreEnabled = false;
            this.rbPanelReportesContratos.ButtonMoreVisible = false;
            this.rbPanelReportesContratos.Items.Add(this.rbBtnReporteContratos);
            this.rbPanelReportesContratos.Items.Add(this.lblReporteContato);
            this.rbPanelReportesContratos.Name = "rbPanelReportesContratos";
            this.rbPanelReportesContratos.Text = "Contratos";
            // 
            // rbBtnReporteContratos
            // 
            this.rbBtnReporteContratos.Image = global::ProyectoProgra.Properties.Resources.localpersonal;
            this.rbBtnReporteContratos.LargeImage = global::ProyectoProgra.Properties.Resources.localpersonal;
            this.rbBtnReporteContratos.Name = "rbBtnReporteContratos";
            this.rbBtnReporteContratos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnReporteContratos.SmallImage")));
            this.rbBtnReporteContratos.Click += new System.EventHandler(this.rbBtnReporteContratos_Click);
            // 
            // lblReporteContato
            // 
            this.lblReporteContato.Name = "lblReporteContato";
            this.lblReporteContato.Text = "Listado de Contratos";
            this.lblReporteContato.ToolTip = "Permite listar los contratos seleccionando 2 fechas como parámetro incial y final" +
    ".";
            this.lblReporteContato.ToolTipTitle = "Listado de Contratos";
            this.lblReporteContato.Click += new System.EventHandler(this.lblReporteContato_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmPrincipal";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.RibbonTab rbTabPlataforma;
        private System.Windows.Forms.RibbonPanel rbPanelEmpresa;
        private System.Windows.Forms.RibbonButton rbButtonEmpresa;
        private System.Windows.Forms.RibbonPanel rbPanelLocal;
        private System.Windows.Forms.RibbonButton rbBtnLocal;
        private System.Windows.Forms.RibbonPanel rbPanelDocumento;
        private System.Windows.Forms.RibbonButton rbBtnDocumento;
        private System.Windows.Forms.RibbonPanel rbPanelContratoPersonal;
        private System.Windows.Forms.RibbonButton rbBtnContratoPersonal;
        private System.Windows.Forms.RibbonPanel rbPanelPersonal;
        private System.Windows.Forms.RibbonButton rbBtnPersonal;
        private System.Windows.Forms.RibbonPanel rbnPanelUsuario;
        private System.Windows.Forms.RibbonButton rbBtnUsuario;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel rbPanelMedioPago;
        private System.Windows.Forms.RibbonButton rbBtnMedioPago;
        private System.Windows.Forms.RibbonPanel rbPanelEntidad;
        private System.Windows.Forms.RibbonButton rbBtnEntidad;
        private System.Windows.Forms.RibbonPanel rbPanelSistemaPensiones;
        private System.Windows.Forms.RibbonButton rbBtnSistemaPensiones;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rbBtnPerfil;
        private System.Windows.Forms.RibbonPanel rbPanelCuentaBancaria;
        private System.Windows.Forms.RibbonButton rbBtnCuenta;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private System.Windows.Forms.RibbonTab rbTabReportes;
        private System.Windows.Forms.RibbonPanel rbPanelReporteSist;
        private System.Windows.Forms.RibbonButton rbBtnReporteSist;
        private System.Windows.Forms.RibbonLabel rbLblReporteSistPersonal;
        private System.Windows.Forms.RibbonPanel rbPanelReportesContratos;
        private System.Windows.Forms.RibbonButton rbBtnReporteContratos;
        private System.Windows.Forms.RibbonLabel lblReporteContato;
    }
}