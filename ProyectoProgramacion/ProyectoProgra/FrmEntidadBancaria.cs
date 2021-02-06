using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmEntidadBancaria : Form
    {

        #region "Singleton"

        private static FrmEntidadBancaria frm;

        private FrmEntidadBancaria()
        {
            InitializeComponent();
        }

        public static FrmEntidadBancaria Crear()
        {
            if (FrmEntidadBancaria.frm == null)
            {
                FrmEntidadBancaria.frm = new FrmEntidadBancaria()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmEntidadBancaria.frm.BringToFront();

            return FrmEntidadBancaria.frm;
        }

        private void FrmEntidadBancaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmEntidadBancaria.frm = null;
        }

        #endregion

        private EntidadBancaria Aux;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNEntidadBancaria rn;
            EntidadBancaria entidadBancaria;

            if (this.ValidateChildren() == true)
            {
                entidadBancaria = this.CrearEntidad();
                rn = new RNEntidadBancaria();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(entidadBancaria);
                    }
                    else
                    {
                        rn.Actualizar(entidadBancaria);
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
                    entidadBancaria = null;
                    rn = null;
                }
            }
        }

        private void ActivarControles(bool estado)
        {

            this.gbEntidadBancaria.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtRazonSocial.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private EntidadBancaria CrearEntidad()
        {
            EntidadBancaria ent = new EntidadBancaria
            {
                RazonSocial = this.txtRazonSocial.Text,
                Siglas = this.txtSiglas.Text,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                ent.Codigo = this.Aux.Codigo;
            }

            return ent;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
            this.txtRazonSocial.Text = "";
            this.txtSiglas.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (EntidadBancaria)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Entidad Bancaria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtRazonSocial.Text = this.Aux.RazonSocial;
                    this.txtSiglas.Text = this.Aux.Siglas;
                    this.chkVigente.Checked = this.Aux.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró la entidad indicada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<EntidadBancaria> Filtrar(string docBuscar)
        {
            List<EntidadBancaria> lista;
            RNEntidadBancaria rn = new RNEntidadBancaria();

            lista = rn.Listar();
            if (string.IsNullOrEmpty(docBuscar) == true)
            {
                return lista;
            }
            else
            {
                var list = new List<EntidadBancaria>();
                foreach (var item in lista)
                {
                    if (item.RazonSocial.Length >= docBuscar.Length
                            && item.RazonSocial.Substring(0, docBuscar.Length).Equals(docBuscar) == true)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {

            RNEntidadBancaria rn = new RNEntidadBancaria();
            List<EntidadBancaria> lista;
            try
            {
                this.txtBusqueda.Text = this.txtBusqueda.Text.Trim();
                lista = Filtrar(this.txtBusqueda.Text);
                MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron Entidades Bancarias", "Error");
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

        private void FrmEntidadBancaria_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
            this.ActivarControles(false);
        }

        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtRazonSocial.Text.Length > 0)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtRazonSocial, "Ingrese una Razón Social.");
            }
            else
            {
                this.errMensaje.SetError(this.txtRazonSocial, "");
                this.errMensaje.Clear();
            }
        }
        private void txtSiglas_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtRazonSocial.Text.Length > 0)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtRazonSocial, "Ingrese las siglas.");
            }
            else
            {
                this.errMensaje.SetError(this.txtRazonSocial, "");
                this.errMensaje.Clear();
            }
        }
    }
}
