using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Ventas;
using System.Reflection;
using System.Linq;

namespace ProyectoProgra
{
    public partial class FrmEmpresa : Form
    {

        #region "Singleton"

        private static FrmEmpresa frm;

        private FrmEmpresa()
        {
            InitializeComponent();
        }

        public static FrmEmpresa Crear()
        {
            if (FrmEmpresa.frm == null)
            {
                FrmEmpresa.frm = new FrmEmpresa()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmEmpresa.frm.BringToFront();

            return FrmEmpresa.frm;
        }

        private void FrmEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmEmpresa.frm = null;
        }

        #endregion

        private Empresa Aux;

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
            this.txtRazonSocial.Text = "";
            this.txtRUC.Text = "";
            this.txtFacebook.Text = "";
            this.txtInstagram.Text = "";
            this.txtLogo.Text = "";
            this.txtWhatsapp.Text = "";
            this.txtCorreo.Text = "";
            this.txtYoutube.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbEmpresa.Enabled = estado;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            LimpiarControles();
            this.errMensaje.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNEmpresa rn = new RNEmpresa();

            try
            {
                if (!Busqueda())
                {
                    MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se econtraron empresas para listar.", this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Busqueda()
        {
            RNEmpresa rn = new RNEmpresa();
            List<Empresa> Listar = new List<Empresa>();
            if (this.txtBusqueda.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(Empresa).GetProperties();
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
                    MessageBox.Show("No se existe Empresa", "Resultado Busqueda");
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNEmpresa rn;
            Empresa empresa;

            if (this.ValidateChildren() == true)
            {
                empresa = this.CrearEntidad();
                rn = new RNEmpresa();
                try
                {
                    if (this.Aux == null)
                    {
                        rn.Registrar(empresa);
                    }
                    else
                    {
                        rn.Actualizar(empresa);
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
                    empresa = null;
                    rn = null;
                }
            }
        }

        private Empresa CrearEntidad()
        {
            Empresa emp = new Empresa
            {
                RazonSocial = this.txtRazonSocial.Text,
                RUC = this.txtRUC.Text,
                Facebook = this.txtFacebook.Text,
                Instagram = this.txtInstagram.Text,
                YouTube = this.txtYoutube.Text,
                Whatsapp = this.txtWhatsapp.Text,
                Correo = this.txtCorreo.Text,
                Logo = this.txtLogo.Text,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                emp.Codigo = this.Aux.Codigo;
            }

            return emp;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (Empresa)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Empresa.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNEmpresa rn = new RNEmpresa();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.txtRazonSocial.Text = this.Aux.RazonSocial;
                    this.txtRUC.Text = this.Aux.RUC;
                    this.txtFacebook.Text = this.Aux.Facebook;
                    this.txtInstagram.Text = this.Aux.Instagram;
                    this.txtLogo.Text = this.Aux.Logo;
                    this.txtWhatsapp.Text = this.Aux.Whatsapp;
                    this.txtCorreo.Text = this.Aux.Correo;
                    this.txtYoutube.Text = this.Aux.YouTube;
                    this.chkVigente.Checked = this.Aux.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el personal indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRazonSocial.Text))
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

        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtRUC.Text.Length < 11)
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errMensaje.SetError(this.txtRUC, "El RUC debe contener 11 dígitos.");
            }
            else
            {
                this.errMensaje.Clear();
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCorreo.Text!="")
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
       
        private void txtWhatsapp_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtWhatsapp.Text, "  ^ [0-9]"))
            {
                this.txtWhatsapp.Text = "";
            }
        }
    }
}
