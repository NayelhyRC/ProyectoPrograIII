using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventas;
using System.Linq;
using System.Reflection;
namespace ProyectoProgra
{
    public partial class FrmSistemaPensiones : Form
    {
        #region "Singleton"
        private static FrmSistemaPensiones frm;
        public FrmSistemaPensiones()
        {
            InitializeComponent();
        }

        public static FrmSistemaPensiones Crear()
        {
            if (FrmSistemaPensiones.frm == null)
            {
                FrmSistemaPensiones.frm = new FrmSistemaPensiones()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmSistemaPensiones.frm.BringToFront();

            return FrmSistemaPensiones.frm;
        }

        private void FrmSistemaPensiones_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmSistemaPensiones.frm = null;
        }

        #endregion

        private SistemaPensiones Aux;
        //private object gbSistemaPensiones;
        //private object gbListadoP;

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
            this.textNombre.Text = "";
            this.textSiglas.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }
        private void ActivarControles(bool estado)
        {
            this.groupBox1.Enabled = estado;
            this.gbListadoPe.Enabled = !estado;
            if (estado == true)
            {
                this.textNombre.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.errorProvider1.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNSistemaPensiones rn = new RNSistemaPensiones();
            try
            {
                if (!Busqueda())
                {
                    MisFunciones.EnlazarDataGrid(dgvListado, rn.Listar(), "No se Econtraron  Sistemas", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Busqueda()
        {
            RNSistemaPensiones rn = new RNSistemaPensiones();
            List<SistemaPensiones> Listar = new List<SistemaPensiones>();
            if (this.txtBusqueda.Text.Length > 0)
            {
                foreach (var doc in rn.Listar())
                {
                    PropertyInfo[] lst = typeof(SistemaPensiones
                        ).GetProperties();
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
                    MessageBox.Show("No se Existe el Sistema", "Resultado Busqueda");
            }
            return false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNSistemaPensiones sp;
            SistemaPensiones sistemaPensiones; ////////////////////7
            //BorrarMensajeError();
            //if (ValidarCampos())
            //{
            //    MessageBox.Show("Registro de Usuario Correctamente ");
            //}

            if (this.ValidateChildren() == true)
            {
                sistemaPensiones = this.CrearEntidad();
                sp = new RNSistemaPensiones();
                try
                {
                    if (this.Aux == null)
                    {
                        sp.Registrar(sistemaPensiones);
                        MessageBox.Show("Registrado", "Se registro Correctamente");
                    }
                    else
                    {
                        sp.Actualizar(sistemaPensiones);
                        MessageBox.Show("Modificado", "Se Modifico Correctamente");
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
                    sistemaPensiones = null;
                    sp = null;
                }
            }
        }
        private SistemaPensiones CrearEntidad()
        {
            SistemaPensiones sip = new SistemaPensiones
            {
                Nombre = this.textNombre.Text,
                Siglas = this.textSiglas.Text,
                Vigencia = this.chkVigente.Checked,
            };
            if (this.Aux != null)
            {
                sip.Codigo = this.Aux.Codigo;
            }

            return sip;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Aux = (SistemaPensiones)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PresentarDatos()
        {
            RNSistemaPensiones rn = new RNSistemaPensiones();

            try
            {
                this.Aux = rn.Buscar(this.Aux.Codigo);
                if (this.Aux != null)
                {
                    this.textNombre.Text = this.Aux.Nombre;
                    this.textSiglas.Text = this.Aux.Siglas;
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
        private void FrmSistemaPensiones_Load(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }
        //Error Provide
        //private bool ValidarCampos()
        //{
        //    bool atr = true;
        //    if (textNombre.Text == "")
        //    {
        //        atr = false;
        //        errorProvider1.SetError(textNombre, "Ingresar Nombre");
        //    }

        //    if (textSiglas.Text == "")
        //    {
        //        atr = false;
        //        errorProvider1.SetError(textSiglas, "Ingresar Clave");
        //    }
        //    return atr;
        //}
        //private void BorrarMensajeError()
        //{
        //    errorProvider1.SetError(textNombre, "");
        //    errorProvider1.SetError(textSiglas, "");
        //    //errorProvider1.SetError(txtRepetir, "");

        //}

        private void textNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textNombre.Text.Trim() == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errorProvider1.SetError(this.textNombre, "Ingrese un Nombre.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
