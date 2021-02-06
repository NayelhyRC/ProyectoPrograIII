using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Ventas
{
    public class MisFunciones
    {

        public static bool Buscar<T>(DataGridView tab, IEnumerable<T> data, string Condicion)
        {
            List<T> Listar = null;
            List<T> Resultados = null;
            if (Condicion.Length > 0)
            {
                foreach (var doc in data)
                {
                    PropertyInfo[] lst = typeof(T).GetProperties();
                    foreach (PropertyInfo op in lst)
                    {
                        if (op.GetValue(doc).Equals(Condicion) == true)
                        {
                            Listar.Add(doc);
                        }
                    }
                }
            }
            if (Listar.Count > 0)
            {
                Resultados = Listar.Distinct().ToList();
            }
            tab.DataSource = null;
            if (Resultados.Count > 0)
            {
                tab.AutoGenerateColumns = false;
                tab.DataSource = Resultados;
                return true;
            }
            return false;
        }
        public static void EnlazarDataGrid<T>(DataGridView dataGrid,
          IEnumerable<T> datos,
          string msje = "", string titulo = "")
        {

            dataGrid.DataSource = null;
            if (datos != null && datos.Count() > 0)
            {
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = datos;
            }
            else
            {
                if (string.IsNullOrEmpty(msje) == false)
                {
                    MessageBox.Show(msje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void EnlazarCombo<T>(ComboBox combo, IEnumerable<T> datos,
      string campoMostrar, string campoVinculado, string msje = "", string titulo = "")
        {

            combo.DataSource = null;
            if (datos != null && datos.Count() > 0)
            {
                combo.DisplayMember = campoMostrar;
                combo.ValueMember = campoVinculado;
                combo.DataSource = datos;
                combo.SelectedIndex = -1;
            }
            else
            {
                if (string.IsNullOrEmpty(msje) == false)
                {
                    MessageBox.Show(msje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static bool ValidarEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

    }

}
