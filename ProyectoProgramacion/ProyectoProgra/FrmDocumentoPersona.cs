using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventas;
using System.Reflection;
using System.Linq;

namespace ProyectoProgra
{
    public partial class FrmDocumentoPersona : Form
    {

        #region "Singleton"

        private static FrmDocumentoPersona frm;

        private FrmDocumentoPersona()
        {
            InitializeComponent();
        }

        public static FrmDocumentoPersona Crear()
        {
            if (FrmDocumentoPersona.frm == null)
            {
                FrmDocumentoPersona.frm = new FrmDocumentoPersona()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmDocumentoPersona.frm.BringToFront();

            return FrmDocumentoPersona.frm;
        }

        private void FrmDocumentoPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDocumentoPersona.frm = null;
        }

        #endregion

        DocumentoPersona Aux;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Aux = null;
        }

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtCodSunat.Text = "";
            this.cboTipo.SelectedIndex = -1;
            this.numCantidadMinima.Value = 0;
            this.numCantidadMaxima.Value = 0;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbDocumento.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombre.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
            this.errMensaje.Clear();
        }

        private bool Busqueda()
        {
            RNDocumentoPersona rn = new RNDocumentoPersona();
            List<DocumentoPersona> Listar = new List<DocumentoPersona>();
            if (this.txtBuscar.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(DocumentoPersona).GetProperties();
                    foreach (PropertyInfo op in lst)
                    {
                        if (op.GetValue(doc).ToString().Equals(txtBuscar.Text) == true)
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
                if (this.txtBuscar.Text.Length > 0)
                    MessageBox.Show("No se Existe Documento", "Resultado Busqueda");
            }
            return false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNDocumentoPersona rn = new RNDocumentoPersona();
            try
            {
                
                if (!Busqueda())
                {
                    MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron Documentos", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNDocumentoPersona rn;
            DocumentoPersona doc;

            if (this.ValidateChildren() == true)
            {
                doc = this.CrearEntidad();
                rn = new RNDocumentoPersona();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(doc);
                    }
                    else
                    {
                        rn.Actualizar(doc);
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
                    doc = null;
                    rn = null;
                }
            }
        }

        private DocumentoPersona CrearEntidad()
        {
            DocumentoPersona doc = new DocumentoPersona
            {
                Nombre = this.txtNombre.Text,
                CodigoSunat = this.txtCodSunat.Text,
                Tipo = this.cboTipo.SelectedItem.ToString(),
                CantidadMinima = (int)this.numCantidadMinima.Value,
                CantidadMaxima = (int)this.numCantidadMaxima.Value,
                Vigencia = this.chkVigente.Checked
            };
            if (this.Aux != null)
            {
                doc.Codigo = this.Aux.Codigo;
            }

            return doc;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (DocumentoPersona)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un documento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNDocumentoPersona rn = new RNDocumentoPersona();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtNombre.Text = this.Aux.Nombre;
                    this.txtCodSunat.Text = this.Aux.CodigoSunat;
                    this.cboTipo.SelectedValue = this.Aux.Tipo;
                    this.numCantidadMinima.Value = this.Aux.CantidadMinima;
                    this.numCantidadMaxima.Value = this.Aux.CantidadMaxima;
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

        private void FrmDocumentoPersonacs_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
            this.ActivarControles(false);
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtNombre.Text.Length<2)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtNombre, "El nombre debe tener al menos 2 caracteres.");
            }
            else
            {
                this.errMensaje.SetError(this.txtNombre, "");
                this.errMensaje.Clear();
            }
        }

        private void cboTipo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.cboTipo.SelectedIndex == -1)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.cboTipo, "Debe seleccionar  un tipo.");
            }
            else
            {
                this.errMensaje.SetError(this.cboTipo, "");
                this.errMensaje.Clear();
            }
        }
    }
}
