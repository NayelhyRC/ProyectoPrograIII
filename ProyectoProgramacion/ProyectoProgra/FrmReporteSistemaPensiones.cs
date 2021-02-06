using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

using Ventas;
using CapaNegocios;
using CapaDatos;
using System.Windows.Forms;

namespace ProyectoProgra
{
    public partial class FrmReporteSistemaPensiones : Form
    {
        
        #region "Singleton"

        private static FrmReporteSistemaPensiones frm;

        private FrmReporteSistemaPensiones()
        {
            InitializeComponent();
        }

        public static FrmReporteSistemaPensiones Crear()
        {
            if (FrmReporteSistemaPensiones.frm == null)
            {
                FrmReporteSistemaPensiones.frm = new FrmReporteSistemaPensiones()
                {
                    WindowState = FormWindowState.Maximized
                };
            }
            FrmReporteSistemaPensiones.frm.BringToFront();

            return FrmReporteSistemaPensiones.frm;
        }

        private void FrmReporteSistemaPensiones_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmReporteSistemaPensiones.frm = null;
        }

        #endregion

        List<Personal> listado;

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNPersonal rn = new RNPersonal();
            
            try
            {
                if( this.cboSistema.SelectedIndex != -1)
                {
                    listado = rn.ListarPorSistemaPensiones((int)this.cboSistema.SelectedValue);
                    if (listado.Count > 0)
                    {
                        this.btnGenerarPDF.Enabled = true;
                        MisFunciones.EnlazarDataGrid(dgvListado, listado, "No hay elementos que mostrar.", this.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un sistema de pensiones.", this.Text, 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReporteSistemaPensiones_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.btnGenerarPDF.Enabled = false;
        }

        private void CargarDatos()
        {
            this.CargarSistemas();
        }

        private void CargarSistemas()
        {
            RNSistemaPensiones rn = new RNSistemaPensiones();
            List<SistemaPensiones> lista;
            try
            {
                lista = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboSistema, lista, "Siglas", "Codigo");
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

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            RNPersonal rn = new RNPersonal();
            RNSistemaPensiones ln = new RNSistemaPensiones();

            var cod = (int)this.cboSistema.SelectedValue;
            var p = (SistemaPensiones)this.cboSistema.SelectedItem;
            CrearPdf(rn.ListarPorSistemaPensiones(cod),p.Siglas);
        }

        private void CrearPdf(List<Personal> Lista,string sp)
        {
            //crear pdf y tipo de hoja 
            PdfWriter pdfw = new PdfWriter("C:/Users/WHINERY/Desktop/Reporte.pdf"); //cambiar la direccion para que se genere en el escritorio
            PdfDocument pdf = new PdfDocument(pdfw);
            Document doc = new Document(pdf, PageSize.A4);
            //margins del pdf xd
            //para A4
            doc.SetMargins(150, 70, 50, 150);
            //la tabla se posiciona segun los margenes de la hoja
            //Fuentes para letras
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont font2 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            //titulo, logo , hora
            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/WHINERY/Documents/Visual Studio 2019/Projects/ProyectoProgramacionF/ProyectoProgramacion/icons/documento.png")).SetWidth(50); //cambiar la direccion de la img
            var plogo = new Paragraph("").Add(logo);

            var titulo = new Paragraph("Reporte de Sistema de Pensiones");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(25);
            
            var subtitulo = new Paragraph("Sistema Pesnsiones:"+sp+" ");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(25);

            var fecha = DateTime.Now.ToString("dd-MM-yyyy");
            var hora = DateTime.Now.ToString("hh:mm:ss");
            var Fecha = new Paragraph("Fecha:" + fecha + "\nHora:" + hora);
            Fecha.SetFontSize(15);


            // Columnas de las tablas
            string[] colums = { "Personal", "Número Documento" };
            float[] tam = { 4, 4};
            Table tab = new Table(UnitValue.CreatePercentArray(tam));
            //Agregar  encabezado tabla
            foreach (string colm in colums)
            {
                tab.AddHeaderCell(new Paragraph(colm).SetFont(font2));
            }
            //Llenado de Tabla
            foreach (var m in Lista)
            {
                tab.AddCell(new Cell().Add(new Paragraph(m.NombreCompleto)));
                tab.AddCell(new Cell().Add(new Paragraph(m.NumeroDocumento)));
            }
            //agregar tabla a pdf
            doc.Add(tab);

            // agregacion del titulo, logo, hora a pdf
            int numero = pdf.GetNumberOfPages();

            for (int i = 1; i <= numero; i++)
            {
                PdfPage pag = pdf.GetPage(i);
                float y = (pdf.GetPage(i).GetPageSize().GetTop() - 15);

                doc.ShowTextAligned(plogo, 60, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 295, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(subtitulo, 190, y - 80, i, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(Fecha, 515, y - 45, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Pagina{0} de {1}", i, numero)), pdf.GetPage(i).GetPageSize().GetWidth() / 2, pdf.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            //cerrar pdf
            doc.Close();

        }
    }
}
