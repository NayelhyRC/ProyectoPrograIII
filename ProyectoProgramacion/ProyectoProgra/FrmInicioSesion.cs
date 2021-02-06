using CapaDatos;
using CapaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoProgra
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Fondo2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Usuario aux;
            RNUsuario iS = new RNUsuario();
            if(this.txtNombre != null && this.txtContraseña != null) 
            { 
                try
                {
                    aux = iS.InicioSesion(txtNombre.Text, txtContraseña.Text);
                    if (aux != null)
                    {
                        Hide();
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese datos correctos, por favor.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {

            txtContraseña.UseSystemPasswordChar = !chkMostrarContraseña.Checked;
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.txtNombre.Text = this.txtNombre.Text.Trim();

            if (this.txtNombre.Text == "")
            {
                e.Cancel = true;
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                this.errorProvider1.SetError(this.txtNombre, "Ingrese el Nombre de Usuario.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
