using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmLocalPersonal : Form
    {
        private LocalPersonal Actual;

        #region "Singleton"

        private static FrmLocalPersonal frm;

        private FrmLocalPersonal()
        {
            InitializeComponent();
        }

        public static FrmLocalPersonal Crear()
        {
            if (FrmLocalPersonal.frm == null)
            {
                FrmLocalPersonal.frm = new FrmLocalPersonal()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmLocalPersonal.frm.BringToFront();

            return FrmLocalPersonal.frm;
        }

        private void FrmLocalPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLocalPersonal.frm = null;
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.FormatoInicial();
            this.ActivarControles(true);
            this.Actual = null;
        }

        private void FrmLocalPersonal_Load(object sender, EventArgs e)
        {
            this.btnListar.PerformClick();
        }

        private void CargarDatos()
        {
            this.CargarLocales();
            this.CargarPersonal();
        }

        private void CargarPersonal()
        {
            RNPersonal rn = new RNPersonal();
            List<Personal> lista;
            try
            {
                lista = rn.Listar();
                MisFunciones.EnlazarCombo(this.cboPersonal, lista, "NumeroDocumento", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLocales()
        {
            RNLocal rn = new RNLocal();
            List<Local> lista;
            try
            {
                lista = rn.Listar();
                MisFunciones.EnlazarCombo(this.cboLocal, lista, "Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatoInicial()
        {
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNLocalPersonal rn;
            LocalPersonal localPer;

            if (this.ValidateChildren() == true)
            {
                this.AutoValidate = AutoValidate.Disable;
                this.errProviderMssg.Clear();
                localPer = this.CrearEntidad();
                rn = new RNLocalPersonal();
                try
                {
                    if (this.Actual == null)
                    {
                        this.RegistrarContrato(rn, localPer);
                    }
                    else
                    {
                        this.ModificarContrato(rn, localPer);
                    }
                    this.ActivarControles(false);
                    btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private void ModificarContrato(RNLocalPersonal rn, LocalPersonal localPer)
        {
            if (rn.Actualizar(localPer) == true)
            {
                MessageBox.Show("El contrato ha sido modificado con éxito.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El contrato no pudo ser modificado.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RegistrarContrato(RNLocalPersonal rn, LocalPersonal localPer)
        {
            if (rn.Registrar(localPer) == true)
            {
                MessageBox.Show("El contrato ha sido registrado con éxito.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El contrato no pudo ser registrado con éxito.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActivarControles(bool estado)
        {
            this.gbPersonal.Enabled = estado;
            this.gbListadoLocales.Enabled = !estado;
            if (estado == true)
            {
                this.cboPersonal.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private LocalPersonal CrearEntidad()
        {
            return new LocalPersonal
            {
                Personal = (Personal)this.cboPersonal.SelectedItem,
                Local = (Local)this.cboLocal.SelectedItem,
                Cargo = this.txtCargo.Text,
                Sueldo = (float)(this.nudSueldo.Value),
                CorreoEmpresarial = this.txtCorreoEmpresarial.Text,
                CelularEmpresarial = this.txtCelularEmpresarial.Text,
                Vigencia = this.chkVigente.Checked,
                FechaInicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                FechaFin = dtpFechaFin.Value.ToString("yyyy-MM-dd hh:mm:ss")
            };
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNLocalPersonal rn = new RNLocalPersonal();
            List<LocalPersonal> lista;

            try
            {
                this.txtBusqueda.Text = this.txtBusqueda.Text.Trim();
                lista = Filtrar(this.txtBusqueda.Text);
                MisFunciones.EnlazarDataGrid(this.dgvListado, lista, "No se encontraron contratos para listar.", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<LocalPersonal> Filtrar(string docBuscar)
        {
            List<LocalPersonal> lista;
            RNLocalPersonal rn = new RNLocalPersonal();

            lista = rn.Listar();
            if (string.IsNullOrEmpty(docBuscar) == true)
            {
                return lista;
            }
            else
            {
                var list = new List<LocalPersonal>();
                foreach (var item in lista)
                {
                    if (item.Personal.NumeroDocumento.Length >= docBuscar.Length
                            && item.Personal.NumeroDocumento.Substring(0, docBuscar.Length).Equals(docBuscar) == true)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(false);
            this.errProviderMssg.Clear();
        }

        private void LimpiarControles()
        {
            this.cboPersonal.SelectedIndex = -1;
            this.cboLocal.SelectedIndex = -1;
            this.txtCargo.Text = "";
            this.txtCelularEmpresarial.Text = "";
            this.txtCorreoEmpresarial.Text = "";
            this.nudSueldo.Value = this.nudSueldo.Minimum;
            this.dtpFechaInicio.Value = DateTime.Now;
            this.dtpFechaFin.Value = DateTime.Now;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (LocalPersonal)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNLocalPersonal rn = new RNLocalPersonal();

            try
            {
                this.Actual = rn.Buscar(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.cboPersonal.SelectedValue = Actual.Personal.Codigo;
                    this.cboLocal.SelectedValue = Actual.Local.Codigo;
                    this.txtCargo.Text = Actual.Cargo;
                    this.txtCelularEmpresarial.Text = this.Actual.CelularEmpresarial;
                    this.txtCorreoEmpresarial.Text = this.Actual.CorreoEmpresarial;
                    this.nudSueldo.Value = (decimal)(this.Actual.Sueldo);
                    this.chkVigente.Checked = this.Actual.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el contrato indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPersonal_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboPersonal.SelectedIndex == -1)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errProviderMssg.SetError(this.cboPersonal, "Debe seleccionar a un personal");
            }
            else
            {
                this.errProviderMssg.Clear();
            }
        }

        private void cboLocal_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboLocal.SelectedIndex == -1)
            {
                e.Cancel = true;
                this.errProviderMssg.SetError(this.cboLocal, "Debe seleccionar a un personal");
            }
            else
            {
                this.errProviderMssg.Clear();
            }
        }

        private void txtCargo_Validating(object sender, CancelEventArgs e)
        {
            this.txtCargo.Text = this.txtCargo.Text.Trim();
            if (this.txtCargo.Text.Length < 4)
            {
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                e.Cancel = true;
                this.errProviderMssg.SetError(this.txtCargo, "El cargo debe tener al menos 04 caracteres.");
            }
            else
            {
                this.errProviderMssg.SetError(this.txtCargo, "");
                this.errProviderMssg.Clear();
            }
        }

        private void txtCorreoEmpresarial_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCorreoEmpresarial.Text.Length > 0)
            {
                this.txtCorreoEmpresarial.Text = this.txtCorreoEmpresarial.Text.Trim();
                if (MisFunciones.ValidarEmail(this.txtCorreoEmpresarial.Text) == false)
                {
                    this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                    this.errProviderMssg.SetError(this.txtCorreoEmpresarial, "El email debe tener el formato ejemplo@mail.com");
                    e.Cancel = true;
                }
                else
                {
                    this.errProviderMssg.SetError(this.txtCorreoEmpresarial, "");
                    this.errProviderMssg.Clear();
                }
            }
        }

        private void txtCelularEmpresarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtpFechaInicio_Validating(object sender, CancelEventArgs e)
        {
                if (this.ValidarFechas() == false)
                {
                    this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                    e.Cancel = true;
                    this.errProviderMssg.SetError(this.dtpFechaInicio, "El contrato debe ser de al menos 90 días.");
                }
                else
                {
                    //this.errProviderMssg.SetError(this.dtpFechaInicio, "");
                    this.errProviderMssg.Clear();
                }
        }

        private bool ValidarFechas()
        {
            DateTime fechaI = DateTime.Parse(this.dtpFechaInicio.Value.ToString());
            DateTime fechaF = DateTime.Parse(this.dtpFechaFin.Value.ToString());

            var val = fechaF - fechaI;

            if (val.TotalDays >= 90)
            {
                return true;
            }

            return false;
        }

        private void txtCelularEmpresarial_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCelularEmpresarial.Text.Length > 0)
            {
                this.txtCelularEmpresarial.Text = this.txtCelularEmpresarial.Text.Trim();
                string sub = this.txtCelularEmpresarial.Text.Substring(0, 1);
                if (sub != "9")
                {
                    this.errProviderMssg.SetError(this.txtCelularEmpresarial, "Ingrese un número de celular correcto.");
                    e.Cancel = true;
                }
                else
                {
                    this.errProviderMssg.SetError(this.txtCelularEmpresarial, "");
                    this.errProviderMssg.Clear();
                }
            }
        }
        
    }
}
