using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmLocal : Form
    {

        #region "Singleton"

        private static FrmLocal frm;

        public FrmLocal()
        {
            InitializeComponent();
        }

        public static FrmLocal Crear()
        {
            if (FrmLocal.frm == null)
            {
                FrmLocal.frm = new FrmLocal()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmLocal.frm.BringToFront();

            return FrmLocal.frm;
        }

        private void FrmLocal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLocal.frm = null;
        }

        #endregion

        private Local Aux;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNLocal rn;
            Local local;

            if (this.ValidateChildren() == true)
            {
                local = this.CrearEntidad();
                rn = new RNLocal();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(local);
                    }
                    else
                    {
                        rn.Actualizar(local);
                    }
                    this.ActivarControles(false);
                    this.btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    local = null;
                    rn = null;
                }
            }
        }

        private void ActivarControles(bool estado)
        {
            this.gbLocal.Enabled = estado;
            this.gbListadoLocales.Enabled = !estado;
            if (estado == true)
            {
                this.txtDireccion.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private Local CrearEntidad()
        {
            Local loc = new Local
            {
                Empresa = (Empresa)this.cboEmpresa.SelectedItem,
                Nombre = this.txtNombre.Text,
                Direccion = this.txtDireccion.Text,
                Telefono = this.txtTelefono.Text,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                loc.Codigo = this.Aux.Codigo;
            }

            return loc;
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
            this.Aux = null;
        }

        private void LimpiarControles()
        {
            this.cboEmpresa.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (Local)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Local", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNLocal rn = new RNLocal();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.cboEmpresa.SelectedIndex = this.Aux.Empresa.Codigo;
                    this.txtNombre.Text = this.Aux.Nombre;
                    this.txtDireccion.Text = this.Aux.Direccion;
                    this.txtTelefono.Text = this.Aux.Telefono;
                    this.chkVigente.Checked = this.Aux.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el local indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Local> Filtrar(string docBuscar)
        {
            List<Local> lista;
            RNLocal rn = new RNLocal();

            lista = rn.Listar();
            if (string.IsNullOrEmpty(docBuscar) == true)
            {
                return lista;
            }
            else
            {
                var list = new List<Local>();
                foreach (var item in lista)
                {
                    if (item.Nombre.Length >= docBuscar.Length
                            && item.Nombre.Substring(0, docBuscar.Length).Equals(docBuscar) == true)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            RNLocal rn = new RNLocal();
            List<Local> lista;
            try
            {
                this.txtBusqueda.Text = this.txtBusqueda.Text.Trim();
                lista = Filtrar(this.txtBusqueda.Text);
                MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron Locales", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLocal_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
            this.ActivarControles(false);
        }

        private void CargarDatos()
        {
            this.CargarEmpresa();
        }

        private void CargarEmpresa()
        {
            RNEmpresa rn = new RNEmpresa();
            try
            {
                MisFunciones.EnlazarCombo(this.cboEmpresa, rn.ListarVigentes(), "RazonSocial", "Codigo", "Error", "No hay Locales Registrados");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtNombre.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtNombre, "Ingrese un Nombre.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        private void txtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtDireccion.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtDireccion, "Ingrese una direccion.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
    }
}
