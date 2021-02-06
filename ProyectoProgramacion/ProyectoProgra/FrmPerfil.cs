using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;
using Ventas;

namespace ProyectoProgra
{
    public partial class FrmPerfil : Form
    {

        #region "Singleton"

        private static FrmPerfil frm;

        private FrmPerfil()
        {
            InitializeComponent();
        }

        public static FrmPerfil Crear()
        {
            if (FrmPerfil.frm == null)
            {
                FrmPerfil.frm = new FrmPerfil()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmPerfil.frm.BringToFront();

            return FrmPerfil.frm;
        }

        private void FrmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPerfil.frm = null;
        }

        #endregion

        private Perfil Aux;

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
            this.txtDescripcion.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbPerfil.Enabled = estado;
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
            LimpiarControles();
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
                    MessageBox.Show("No se Existe Perfil", "Resultado Busqueda");
            }
            return false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            RNPerfil rn = new RNPerfil();

            try
            {
                if (!Busqueda())
                {
                    MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron Perfiles", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNPerfil rn;
            Perfil pl;

            if (this.ValidateChildren() == true)
            {
                pl = this.CrearEntidad();
                rn = new RNPerfil();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(pl);
                        MessageBox.Show("Registro Exitoso", "Se Registro de forma Exitosa");
                    }
                    else
                    {
                        rn.Actualizar(pl);
                        MessageBox.Show("Modificacion Exitosa", "Se Modifico de forma Exitosa");
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
                    pl = null;
                    rn = null;
                    LimpiarControles();
                }
            }
        }

        private Perfil CrearEntidad()
        {
            Perfil aux2 = new Perfil
            {
                Nombre = this.txtNombre.Text,
                Descripcion = this.txtDescripcion.Text,
                Vigencia = this.chkVigente.Checked
            };
            if (this.Aux != null)
            {
                aux2.Codigo = this.Aux.Codigo;
            }

            return aux2;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (Perfil)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNPerfil rn = new RNPerfil
                ();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtNombre.Text = this.Aux.Nombre;
                    this.txtDescripcion.Text = this.Aux.Descripcion;
                    this.chkVigente.Checked = this.Aux.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el perfil", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
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
                this.errMensaje.SetError(this.txtNombre, "Ingrese un Nombre.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtDescripcion.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtDescripcion, "Ingrese un Nombre.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
    }
}
