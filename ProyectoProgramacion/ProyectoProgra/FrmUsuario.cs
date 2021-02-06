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
    public partial class FrmUsuario : Form
    {
        private Usuario Actual;

        #region "Singleton"

        private static FrmUsuario frm;

        private FrmUsuario()
        {
            InitializeComponent();
        }

        public static FrmUsuario Crear()
        {
            if (FrmUsuario.frm == null)
            {
                FrmUsuario.frm = new FrmUsuario()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmUsuario.frm.BringToFront();

            return FrmUsuario.frm;
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUsuario.frm = null;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbUsuario.Enabled = true;
            this.Actual = null;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }
       
        private void iconAceptar_Click(object sender, EventArgs e)
        {
            RNUsuario rn;
            Usuario us;
            BorrarMensajeError();
            //if (ValidarCampos())
            //{
            //    MessageBox.Show("Registro de Usuario Correctamente ");
            //}
            if (this.ValidateChildren() == true)
            {
                us = this.CrearEntidad();
                rn = new RNUsuario();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(us);
                        MessageBox.Show("Registrado", "");
                    }
                    else
                    {
                        rn.Actualizar(us);
                    }
                    this.ActivarControles(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Actual = null;
                rn = null;
            }
        }
        private void ActivarControles(bool estado)
        {
            this.gbUsuario.Enabled = estado;
            this.gbListadoUsuarios.Enabled = !estado;
            if (estado == true)
            {
                this.cboPersonal.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }
        private Usuario CrearEntidad()
        {
            Usuario aux = new Usuario
            {
                CodigoPersonal = (Personal)this.cboPersonal.SelectedItem,
                CodigoPerfil = (Perfil)this.cboPerfil.SelectedItem,
                Nombre = this.txtNombre.Text,
                Clave = this.txtClave.Text,
                Tipo = this.cboLocal.SelectedItem.ToString().Substring(1, 1),
                CodigoLocal = (Local)this.cboLocal.SelectedItem,
                Vigencia = this.chkVigente.Checked,
            };
            if (Actual != null)
            {
                aux.Codigo = Actual.Codigo;
            }
            return aux;
        }
        private bool Busqueda()
        {
            RNUsuario rn = new RNUsuario();
            List<Usuario> Listar = new List<Usuario>();
            if (this.txtBusqueda.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(Usuario).GetProperties();
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
                    MessageBox.Show("No se existe el Usuario", "Resultado Busqueda");
            }
            return false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            RNUsuario rn = new RNUsuario();

            try
            {
                if (!Busqueda()){
                    MisFunciones.EnlazarDataGrid(this.dgvListado, rn.Listar() , "No se encontraron Usuarios.", this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(false);
            this.errorProvider1.Clear();
        }

        private void LimpiarControles()
        {
            this.cboPersonal.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.txtClave.Text = "";
            this.txtRepetir.Text = "";
            this.cboTipo.SelectedIndex = -1;
            this.cboLocal.SelectedIndex = -1;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Usuario)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PresentarDatos()
        {
            RNUsuario rn = new RNUsuario();

            try
            {
                this.Actual = rn.Buscar(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.txtClave.Text = this.Actual.Clave;
                    this.cboPersonal.SelectedItem = this.Actual.CodigoPersonal;
                    this.cboPerfil.SelectedItem = this.Actual.CodigoPerfil;
                    this.cboLocal.SelectedItem = this.Actual.CodigoLocal;
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
        private void CargarCombox()
        {
            RNPersonal rn = new RNPersonal();
            RNLocal rl = new RNLocal();
            RNPerfil rp = new RNPerfil();
            MisFunciones.EnlazarCombo(this.cboPersonal, rn.ListarVigentes(), "NombreCompleto", "Codigo", "Error", "No hay Personal Registrado");
            MisFunciones.EnlazarCombo(this.cboLocal, rl.ListarVigentes(), "Nombre", "Codigo", "Error", "No hay Locales Registrado");
            MisFunciones.EnlazarCombo(this.cboPerfil, rp.ListarVigentes(), "Nombre", "Codigo", "Error", "No hay Perfil Registrado");
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarCombox();
            btnListar.PerformClick();
        }

        //Error Provider
        private bool ValidarCampos()
        {
            bool atr = true;
            if (txtNombre.Text == "")
            {
                atr = false;
                errorProvider1.SetError(txtNombre, "Ingresar Nombre");
            }

            if (txtClave.Text == "")
            {
                atr = false;
                errorProvider1.SetError(txtClave, "Ingresar Clave");
            }
            if (txtRepetir.Text == "")
            {
                atr = false;
                errorProvider1.SetError(txtRepetir, "Repetir Clave Por Favor");
            }

            return atr;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtClave, "");
            errorProvider1.SetError(txtRepetir, "");
        }

        private void txtRepetir_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetir.Text.Equals(txtClave.Text))
            {
                errorProvider1.SetError(txtRepetir, "Error");
            }
            else { 
                errorProvider1.Clear();
            }
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

        private void txtClave_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.txtClave.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errorProvider1.SetError(this.txtClave, "Ingrese una clave.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
