using System;
using System.Collections.Generic;
using CapaDatos;
using Ventas;
using CapaNegocios;
using System.Windows.Forms;

namespace ProyectoProgra
{
    public partial class FrmContratosPorVencer : Form
    {
        public FrmContratosPorVencer()
        {
            InitializeComponent();
        }

        private List<LocalPersonal> listado;

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNLocalPersonal rn = new RNLocalPersonal();
            TimeSpan tiempo = this.dtpMesFin.Value - this.dtpMesInicio.Value;
            var aux = this.dtpMesFin.Value.Month - 1;

            string fechaInicio = dtpMesInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string fechaFin = dtpMesFin.Value.ToString("yyyy-MM-dd hh:mm:ss");
            //this.dtpMesInicio.Value, this.dtpMesFin.Value
            try
            {
                if (tiempo.TotalDays > 0)
                {
                    listado = rn.ListarPorMesVencimiento(fechaInicio, fechaFin);
                    if (listado.Count > 0)
                    {
                        MisFunciones.EnlazarDataGrid(dgvListado, listado, "No hay elementos que mostrar.", this.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar fechas correctas.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
