using System;
using System.Collections.Generic;
using CapaDatos;
using CapaNegocios;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmCuentaBancaria : Form
    {

        #region "Singleton"

        private static FrmCuentaBancaria frm;

        private FrmCuentaBancaria()
        {
            InitializeComponent();
        }

        public static FrmCuentaBancaria Crear()
        {
            if (FrmCuentaBancaria.frm == null)
            {
                FrmCuentaBancaria.frm = new FrmCuentaBancaria()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmCuentaBancaria.frm.BringToFront();

            return FrmCuentaBancaria.frm;
        }

        private void FrmCuentaBancaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCuentaBancaria.frm = null;
        }

        #endregion

        private CuentaBancaria Aux;

        private void ActivarControles(bool estado)
        {
            this.gbCuenta.Enabled = estado;
            this.gbListadoCuentasBancaria.Enabled = !estado;
            if (estado == true)
            {
                this.cboEntidad.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private CuentaBancaria CrearEntidad()
        {
            CuentaBancaria cb = new CuentaBancaria
            {
                CodigoEmpresa = (Empresa)this.cboEmpresa.SelectedItem,
                CodigoEntidadBancaria = (EntidadBancaria)this.cboEntidad.SelectedItem,
                CCI = this.txtCodigoCCI.Text,
                NumeroCuenta = this.txtNumeroCuenta.Text,
                TipoMoneda = (Char)this.cboTipoMoneda.SelectedItem,
                NombreP = this.txtNombre.Text,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                cb.Codigo = this.Aux.Codigo;
            }

            return cb;
        }

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            RNCuentaBancaria rn;
            CuentaBancaria cuenta;

            if (this.ValidateChildren() == true)
            {
                cuenta = this.CrearEntidad();
                rn = new RNCuentaBancaria();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(cuenta);
                    }
                    else
                    {
                        rn.Actualizar(cuenta);
                    }
                    this.ActivarControles(false);
                    this.btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.errMensaje.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.CargarCombos();
            this.Aux = null;
        }

        private void CargarCombos()
        {
            this.CargarComboEntidad();
            this.CargarComboEmpresa();
        }

        private void CargarComboEmpresa()
        {
            RNEmpresa rn = new RNEmpresa();
            List<Empresa> lista;
            try
            {
                lista = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboEmpresa, lista, "RazonSocial", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarComboEntidad()
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();
            List<EntidadBancaria> lista;
            try
            {
                lista = rn.Listar();
                MisFunciones.EnlazarCombo(this.cboEmpresa, lista, "RazonSocial", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PresentarDatos()
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.cboEmpresa.SelectedValue = this.Aux.CodigoEmpresa.Codigo;
                    this.cboEntidad.SelectedValue = Aux.CodigoEntidadBancaria.Codigo;
                    this.txtCodigoCCI.Text = this.Aux.CCI;
                    this.txtNumeroCuenta.Text = this.Aux.NumeroCuenta;
                    this.cboTipoMoneda.SelectedItem = this.Aux.NumeroCuenta;
                    this.txtNombre.Text = this.Aux.NombreP;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el personal indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControles()
        {
            this.cboEmpresa.SelectedIndex = -1;
            this.cboEntidad.SelectedIndex = -1;
            this.txtCodigoCCI.Text = "";
            this.txtNumeroCuenta.Text = "";
            this.cboTipoMoneda.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (CuentaBancaria)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool Busqueda()
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();
            List<CuentaBancaria> Listar = new List<CuentaBancaria>();
            if (this.txtBusqueda.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(CuentaBancaria).GetProperties();
                    foreach (PropertyInfo op in lst)
                    {
                        if (op.GetValue(doc).ToString().Equals(txtBusqueda.Text) == true)
                        {
                            Listar.Add(doc);
                        }
                    }
                }
            }
            if (Listar.Count > 0)
            {
                MisFunciones.EnlazarDataGrid(dgvListado, Listar.Distinct().ToList(), "", "");
                return true;
            }
            else
            {
                if (this.txtBusqueda.Text.Length > 0)
                    MessageBox.Show("No se existe Cuentas", "Resultado Busqueda");
            }
            return false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();

            try
            {
                if (!Busqueda())
                {
                    MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se econtraron Cuentas Bancarias para listar", this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCuentaBancaria_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void txtCodigoCCI_Validating(object sender, CancelEventArgs e)
        {
            this.txtCodigoCCI.Text = this.txtCodigoCCI.Text.Trim();
            if (this.txtCodigoCCI.Text == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtCodigoCCI, "Ingrese un CCI.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        private void txtNumeroCuenta_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtNumeroCuenta.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtNumeroCuenta, "Ingrese un número de cuenta.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.txtNombre.Text = this.txtNombre.Text.Trim();
            if (this.txtNombre.Text == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtNombre, "Ingrese un nombre.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        
    }
}
