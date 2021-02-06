using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Ventas;
using System.Linq;
using System.Reflection;

namespace ProyectoProgra
{
    public partial class FrmPersonal : Form
    {

        #region "Singleton"

        private static FrmPersonal frm;

        private FrmPersonal()
        {
            InitializeComponent();
        }

        public static FrmPersonal Crear()
        {
            if (FrmPersonal.frm == null)
            {
                FrmPersonal.frm = new FrmPersonal()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmPersonal.frm.BringToFront();

            return FrmPersonal.frm;
        }

        private void FrmPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPersonal.frm = null;
        }

        #endregion

        private Personal Aux;

        private void ActivarControles(bool estado)
        {
            this.gbEntidad.Enabled = estado;
            this.gbListadoPersonal.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombres.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNPersonal rn;
            Personal personal;

            if (this.ValidateChildren() == true)
            {
                personal = this.CrearEntidad();
                rn = new RNPersonal();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(personal);
                    }
                    else
                    {
                        rn.Actualizar(personal);
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
                    personal = null;
                    rn = null;
                }
            }
        }

        private Personal CrearEntidad()
        {
            Personal per = new Personal
            {
                NumeroDocumento = this.txtDNI.Text,
                Nombre = this.txtNombres.Text,
                ApellidoPaterno = this.txtApellidoPaterno.Text,
                ApellidoMaterno = this.txtApellidoMaterno.Text,
                Direccion = this.txtDireccion.Text,
                Telefono = this.txtTelefono.Text,
                Celular = this.txtCelular.Text,
                Correo = this.txtCorreo.Text,
                CodigoSistemaPensiones = (SistemaPensiones)this.cboSistemaPensiones.SelectedItem,
                CodigoDocumentoPersona = (DocumentoPersona)this.cboDocumentoPersona.SelectedItem,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                per.Codigo = this.Aux.Codigo;
            }

            return per;
        }



        private void PresentarDatos()
        {
            RNPersonal rn = new RNPersonal();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtDNI.Text = this.Aux.NumeroDocumento;
                    this.txtNombres.Text = this.Aux.Nombre;
                    this.txtApellidoPaterno.Text = this.Aux.ApellidoPaterno;
                    this.txtApellidoMaterno.Text = this.Aux.ApellidoMaterno;
                    this.txtDireccion.Text = this.Aux.Direccion;
                    this.txtTelefono.Text = this.Aux.Telefono;
                    this.txtCelular.Text = this.Aux.Celular;
                    this.txtCorreo.Text = this.Aux.Correo;
                    this.cboSistemaPensiones.SelectedValue = this.Aux.CodigoSistemaPensiones.Siglas;
                    this.cboDocumentoPersona.SelectedValue = this.Aux.CodigoDocumentoPersona.Nombre;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            LimpiarControles();
            this.errMensaje.Clear();
        }
        private bool Busqueda()
        {
            RNPersonal rn = new RNPersonal();
            List<Personal> Listar = new List<Personal>();
            if (this.txtBusqueda.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(Personal).GetProperties();
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
                    MessageBox.Show("No se Existe Personal", "Resultado Busqueda");
            }
            return false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            RNPersonal rn = new RNPersonal();
            try
            {
                if(!Busqueda())
                MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron Empresas", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (Personal)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un personal", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Aux = null;
        }


        private void LimpiarControles()
        {

            this.txtDNI.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidoPaterno.Text = "";
            this.txtApellidoMaterno.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCelular.Text = "";
            this.txtCorreo.Text = "";
            this.cboSistemaPensiones.SelectedIndex = -1;
            this.cboDocumentoPersona.SelectedIndex = -1;


        }
        private void CargarCombos()
        {
            RNDocumentoPersona DP = new RNDocumentoPersona();
            RNSistemaPensiones SP = new RNSistemaPensiones();
            RNEmpresa rn = new RNEmpresa();
            try
            {
                MisFunciones.EnlazarCombo(cboDocumentoPersona, DP.ListarVigentes(), "Nombre", "Codigo", "Error", "No hay Personal Registrado");
                MisFunciones.EnlazarCombo(cboSistemaPensiones, SP.ListarVigentes(), "Siglas", "Codigo", "Error", "No hay Personal Registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            btnListar.PerformClick();
        }
        //error
        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtDNI.Text.Trim()=="")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtDNI, "Ingrese una DNI.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtNombres.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtNombres, "Ingrese un Nombre.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtApellidoPaterno.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtApellidoPaterno, "Ingrese el apellido paterno.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtApellidoMaterno.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtApellidoMaterno, "Ingrese un apellido Materno.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtDireccion.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtDireccion, "Ingrese una Direccion.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtTelefono.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtTelefono, "Ingrese un telefono.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtTelefono.Text, "  ^ [0-9]"))
            {
                this.txtTelefono.Text = "";
            }
        }
        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtTelefono.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtCelular, "Ingrese un telefono.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }
        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtCelular.Text, "  ^ [0-9]"))
            {
                this.txtCelular.Text = "";
            }
        }
        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCorreo.Text != "")
            {
                this.txtCorreo.Text = this.txtCorreo.Text.Trim();
                if (MisFunciones.ValidarEmail(this.txtCorreo.Text) == false)
                {
                    this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                    this.errMensaje.SetError(this.txtCorreo, "El email debe tener el formato ejemplo@mail.com");
                    e.Cancel = true;
                }
                else
                {
                    this.errMensaje.Clear();
                }
            }
        }
    }
}

