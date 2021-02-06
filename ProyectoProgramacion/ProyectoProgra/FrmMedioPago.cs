using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmMedioPago : Form
    {
        #region "Singleton"

        private static FrmMedioPago frm;

        private FrmMedioPago()
        {
            InitializeComponent();
        }

        public static FrmMedioPago Crear()
        {
            if (FrmMedioPago.frm == null)
            {
                FrmMedioPago.frm = new FrmMedioPago()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmMedioPago.frm.BringToFront();

            return FrmMedioPago.frm;
        }

        private void FrmMedioPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedioPago.frm = null;
        }

        #endregion

        private MedioPago Aux;
        private void ActivarControles(bool estado)
        {
            this.gbPago.Enabled = estado;
            this.gbListadoPagos.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombre.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private MedioPago CrearEntidad()
        {
            MedioPago pg = new MedioPago
            {


                Nombre = this.txtNombre.Text,
                CodigoSunat = this.txtCodigoSunat.Text,

                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                pg.Codigo = this.Aux.Codigo;
            }

            return pg;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNMedioPago pg;
            MedioPago pago;

            if (this.ValidateChildren() == true)
            {
                pago = this.CrearEntidad();
                pg = new RNMedioPago();
                try
                {
                    if (this.Aux == null)
                    {
                        pg.Registrar(pago);
                    }
                    else
                    {
                        pg.Actualizar(pago);
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
                    pago = null;
                    pg = null;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.errorProvider1.Clear();
        }

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtCodigoSunat.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Aux = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (MedioPago)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNMedioPago rn = new RNMedioPago();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtNombre.Text = this.Aux.Nombre;
                    this.txtCodigoSunat.Text = this.Aux.CodigoSunat;
                    this.chkVigente.Checked = this.Aux.Vigencia;
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
        private List<MedioPago> Filtrar(string docBuscar)
        {
            List<MedioPago> lista;
            RNMedioPago rn = new RNMedioPago();

            lista = rn.Listar();
            if (string.IsNullOrEmpty(docBuscar) == true)
            {
                return lista;
            }
            else
            {
                var list = new List<MedioPago>();
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
            RNMedioPago rn = new RNMedioPago();
            List<MedioPago> lista;
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
        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
            this.ActivarControles(false);
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtNombre.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errorProvider1.SetError(this.txtNombre, "Ingrese un Nombre.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtCodigoSunat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtCodigoSunat.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errorProvider1.SetError(this.txtCodigoSunat, "Ingrese un Nombre.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
