using System;
using System.Windows.Forms;

//original
namespace ProyectoProgra
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void rbButtonEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = (FrmEmpresa)Application.OpenForms["FrmEmpresa"];

            if (frm == null)
            {
                frm = FrmEmpresa.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnLocal_Click(object sender, EventArgs e)
        {
            FrmLocal frm = (FrmLocal)Application.OpenForms["FrmLocal"];

            if (frm == null)
            {
                frm = FrmLocal.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnDocumento_Click(object sender, EventArgs e)
        {
            FrmDocumentoPersona frm = (FrmDocumentoPersona)Application.OpenForms["FrmDocumentoPersona"];

            if (frm == null)
            {
                frm = FrmDocumentoPersona.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal frm = (FrmPersonal)Application.OpenForms["FrmPersonal"];

            if (frm == null)
            {
                frm = FrmPersonal.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = (FrmUsuario)Application.OpenForms["FrmUsuario"];

            if (frm == null)
            {
                frm = FrmUsuario.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnContratoPersonal_Click(object sender, EventArgs e)
        {
            FrmLocalPersonal frm = (FrmLocalPersonal)Application.OpenForms["FrmLocalPersonal"];

            if (frm == null)
            {
                frm = FrmLocalPersonal.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rbBtnPensiones_Click(object sender, EventArgs e)
        {
            FrmSistemaPensiones frm = (FrmSistemaPensiones)Application.OpenForms["FrmSistemaPensiones"];

            if (frm == null)
            {
                frm = FrmSistemaPensiones.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnMedioPago_Click(object sender, EventArgs e)
        {
            FrmMedioPago frm = (FrmMedioPago)Application.OpenForms["FrmMedioPago"];

            if (frm == null)
            {
                frm = FrmMedioPago.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnEntidad_Click(object sender, EventArgs e)
        {
            FrmEntidadBancaria frm = (FrmEntidadBancaria)Application.OpenForms["FrmEntidadBancaria"];

            if (frm == null)
            {
                frm = FrmEntidadBancaria.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnSistemaPensiones_Click(object sender, EventArgs e)
        {
            FrmSistemaPensiones frm = (FrmSistemaPensiones)Application.OpenForms["FrmSistemaPensiones"];

            if (frm == null)
            {
                frm = new FrmSistemaPensiones();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnCuenta_Click(object sender, EventArgs e)
        {
            FrmCuentaBancaria frm = (FrmCuentaBancaria)Application.OpenForms["FrmCuentaBancaria"];

            if (frm == null)
            {
                frm = FrmCuentaBancaria.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = (FrmPerfil)Application.OpenForms["FrmPerfil"];

            if (frm == null)
            {
                frm = FrmPerfil.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbBtnReporteSist_Click(object sender, EventArgs e)
        {
            FrmReporteSistemaPensiones frm = (FrmReporteSistemaPensiones)Application.OpenForms["FrmReporteSistemaPensiones"];

            if (frm == null)
            {
                frm = FrmReporteSistemaPensiones.Crear();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmBienvenido frm = (FrmBienvenido)Application.OpenForms["FrmBienvenido"];

            if (frm == null)
            {
                frm = new FrmBienvenido();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void rbLblReporteSistPersonal_Click(object sender, EventArgs e)
        {
            this.rbBtnReporteSist.PerformClick();
        }

        private void rbBtnReporteContratos_Click(object sender, EventArgs e)
        {
            FrmContratosPorVencer frm = (FrmContratosPorVencer)Application.OpenForms["FrmContratosPorVencer"];

            if (frm == null)
            {
                frm = new FrmContratosPorVencer();
                tabControl.TabPages.Add(frm);
            }
            else
            {
                tabControl.TabPages[frm].Select();
            }
        }

        private void lblReporteContato_Click(object sender, EventArgs e)
        {
            this.rbBtnReporteContratos.PerformClick();
        }
    }
}
