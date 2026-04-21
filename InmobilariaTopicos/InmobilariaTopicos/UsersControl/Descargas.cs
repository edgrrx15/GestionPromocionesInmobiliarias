using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using topicos_autosbd.Data;
using PdfFont = iTextSharp.text.Font;

namespace InmobilariaTopicos.UsersControl
{
    public partial class Descargas : UserControl
    {
        private conexion con = new conexion();

        // ── Colores del proyecto (morado principal) ────────────────────────────
        private static readonly BaseColor ColorHeader = new BaseColor(100, 88, 255);
        private static readonly BaseColor ColorHeaderText = BaseColor.WHITE;
        private static readonly BaseColor ColorRowAlt = new BaseColor(238, 243, 251);
        private static readonly BaseColor ColorRowNorm = BaseColor.WHITE;
        private static readonly BaseColor ColorFooter = new BaseColor(64, 64, 64);

        public Descargas()
        {
            InitializeComponent();
            this.Load += Descargas_Load;
        }

        // =====================================================================
        // CARGA INICIAL
        // =====================================================================
        private void Descargas_Load(object sender, EventArgs e)
        {
            // Tipos de reporte disponibles
            comboTipoReporteCombo.Items.AddRange(new object[]
            {
                "Promotoras",
                "Promociones",
                "Viviendas",
                "Empresas",
                "Contratos"
            });
            comboTipoReporteCombo.SelectedIndex = 0;
            comboTipoReporteCombo.SelectedIndexChanged += comboTipo_Changed;

            // Fechas por defecto: año en curso
            fechaInicial.Value = new DateTime(DateTime.Today.Year, 1, 1);
            fechaFinal.Value = DateTime.Today;

            ActualizarResumen();
        }

        // =====================================================================
        // EVENTO: cambia tipo de reporte → actualiza filtro secundario
        // =====================================================================
        private void comboTipo_Changed(object sender, EventArgs e)
        {
            tipoPromocionCombo.Items.Clear();
            tipoPromocionCombo.Items.Add("Todos");

            string tipo = comboTipoReporteCombo.SelectedItem?.ToString() ?? "";

            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = null;
                    string display = "NOMBRE";

                    switch (tipo)
                    {
                        case "Promociones":
                        case "Viviendas":
                            sql = "SELECT COD_PROMOCION AS ID, NOMBRE FROM PROMOCION ORDER BY NOMBRE";
                            display = "NOMBRE";
                            label1.Text = "Filtrar por Promocion";
                            break;
                        case "Contratos":
                            sql = "SELECT ID_EMPRESA AS ID, NOMBRE FROM EMPRESA ORDER BY NOMBRE";
                            display = "NOMBRE";
                            label1.Text = "Filtrar por Empresa";
                            break;
                        default:
                            label1.Text = "Filtro adicional";
                            tipoPromocionCombo.SelectedIndex = 0;
                            ActualizarResumen();
                            return;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                        tipoPromocionCombo.Items.Add(row[display].ToString());
                }
            }
            catch { /* Si falla el filtro, se ignora */ }

            tipoPromocionCombo.SelectedIndex = 0;
            ActualizarResumen();
        }

        // =====================================================================
        // ACTUALIZAR PANEL RESUMEN (derecha)
        // =====================================================================
        private void ActualizarResumen()
        {
            string tipo = comboTipoReporteCombo.SelectedItem?.ToString() ?? "—";
            string fi = fechaInicial.Value.ToString("dd/MM/yyyy");
            string ff = fechaFinal.Value.ToString("dd/MM/yyyy");

            lblTipoValor.Text = tipo;
            lblRangoValor.Text = $"{fi} — {ff}";
            lblFormatoValor.Text = "PDF";

            // Contar registros con los filtros actuales
            int count = 0;
            try
            {
                DataTable dt = ObtenerDatos();
                count = dt?.Rows.Count ?? 0;
            }
            catch { }

            lblResultados.Text = count.ToString();
        }

        // =====================================================================
        // OBTENER DATOS SEGÚN FILTROS
        // =====================================================================
        private DataTable ObtenerDatos()
        {
            string tipo = comboTipoReporteCombo.SelectedItem?.ToString() ?? "";
            string filtro = tipoPromocionCombo.SelectedItem?.ToString();
            bool todos = string.IsNullOrEmpty(filtro) || filtro == "Todos";

            string sql = "";

            switch (tipo)
            {
                case "Promotoras":
                    sql = "SELECT ID_PROMOTORA AS [ID], NOMBRE AS [Nombre] " +
                          "FROM PROMOTORA ORDER BY NOMBRE";
                    break;

                case "Promociones":
                    sql = todos
                        ? @"SELECT p.COD_PROMOCION AS [Codigo], p.NOMBRE AS [Nombre],
                                   p.POBLACION AS [Poblacion], pr.NOMBRE AS [Promotora]
                            FROM PROMOCION p
                            INNER JOIN PROMOTORA pr ON p.ID_PROMOTORA = pr.ID_PROMOTORA
                            ORDER BY p.NOMBRE"
                        : $@"SELECT p.COD_PROMOCION AS [Codigo], p.NOMBRE AS [Nombre],
                                    p.POBLACION AS [Poblacion], pr.NOMBRE AS [Promotora]
                             FROM PROMOCION p
                             INNER JOIN PROMOTORA pr ON p.ID_PROMOTORA = pr.ID_PROMOTORA
                             WHERE p.NOMBRE = '{filtro.Replace("'", "''")}'
                             ORDER BY p.NOMBRE";
                    break;

                case "Viviendas":
                    sql = todos
                        ? @"SELECT v.ID_VIVIENDA AS [ID], v.NOMBRE AS [Nombre],
                                   v.SUPERFICIE AS [Superficie m2], v.NUM_HABITACIONES AS [Habitaciones],
                                   v.NUM_BANIOS AS [Banos], v.PRECIO AS [Precio],
                                   v.ESTADO AS [Estado], p.NOMBRE AS [Promocion]
                            FROM VIVIENDA v
                            INNER JOIN PROMOCION p ON v.COD_PROMOCION = p.COD_PROMOCION
                            ORDER BY p.NOMBRE, v.NOMBRE"
                        : $@"SELECT v.ID_VIVIENDA AS [ID], v.NOMBRE AS [Nombre],
                                    v.SUPERFICIE AS [Superficie m2], v.NUM_HABITACIONES AS [Habitaciones],
                                    v.NUM_BANIOS AS [Banos], v.PRECIO AS [Precio],
                                    v.ESTADO AS [Estado], p.NOMBRE AS [Promocion]
                             FROM VIVIENDA v
                             INNER JOIN PROMOCION p ON v.COD_PROMOCION = p.COD_PROMOCION
                             WHERE p.NOMBRE = '{filtro.Replace("'", "''")}'
                             ORDER BY v.NOMBRE";
                    break;

                case "Empresas":
                    sql = @"SELECT ID_EMPRESA AS [ID], NOMBRE AS [Nombre], TIPO AS [Tipo],
                                   TELEFONO AS [Telefono], FAX AS [Fax],
                                   CORREO AS [Correo], DIRECCION AS [Direccion]
                            FROM EMPRESA ORDER BY NOMBRE";
                    break;

                case "Contratos":
                    sql = todos
                        ? @"SELECT c.ID_CONTRATO AS [ID], e.NOMBRE AS [Empresa],
                                   p.NOMBRE AS [Promocion], c.IMPORTE AS [Importe],
                                   c.OBSERVACIONES AS [Observaciones]
                            FROM CONTRATO c
                            INNER JOIN EMPRESA e   ON c.ID_EMPRESA    = e.ID_EMPRESA
                            INNER JOIN PROMOCION p ON c.COD_PROMOCION = p.COD_PROMOCION
                            ORDER BY c.ID_CONTRATO"
                        : $@"SELECT c.ID_CONTRATO AS [ID], e.NOMBRE AS [Empresa],
                                    p.NOMBRE AS [Promocion], c.IMPORTE AS [Importe],
                                    c.OBSERVACIONES AS [Observaciones]
                             FROM CONTRATO c
                             INNER JOIN EMPRESA e   ON c.ID_EMPRESA    = e.ID_EMPRESA
                             INNER JOIN PROMOCION p ON c.COD_PROMOCION = p.COD_PROMOCION
                             WHERE e.NOMBRE = '{filtro.Replace("'", "''")}'
                             ORDER BY c.ID_CONTRATO";
                    break;

                default:
                    return new DataTable();
            }

            using (SqlConnection conn = con.conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =====================================================================
        // GENERAR PDF → GUARDAR EN DISCO
        // =====================================================================
        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            if (comboTipoReporteCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un tipo de reporte.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = comboTipoReporteCombo.SelectedItem.ToString();

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                dlg.FileName = $"Reporte_{tipo}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                dlg.Title = "Guardar reporte PDF";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    DataTable dt = ObtenerDatos();
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos que exportar con los filtros actuales.", "Sin datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    GenerarPDF(dt, tipo, dlg.FileName);

                    MessageBox.Show($"Reporte guardado correctamente:\n{dlg.FileName}",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =====================================================================
        // VISTA PREVIA → abre FormVisualizarReporte
        // =====================================================================
        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (comboTipoReporteCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un tipo de reporte.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = ObtenerDatos();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos que mostrar con los filtros actuales.", "Sin datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string tipo = comboTipoReporteCombo.SelectedItem.ToString();
                string fi = fechaInicial.Value.ToString("dd/MM/yyyy");
                string ff = fechaFinal.Value.ToString("dd/MM/yyyy");

                using (var form = new FormVisualizarReporte(dt, tipo, fi, ff))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la vista previa:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // LIMPIAR FILTROS
        // =====================================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboTipoReporteCombo.SelectedIndex = 0;
            tipoPromocionCombo.SelectedIndex = 0;
            fechaInicial.Value = new DateTime(DateTime.Today.Year, 1, 1);
            fechaFinal.Value = DateTime.Today;
            ActualizarResumen();
        }

        // =====================================================================
        // GENERADOR PDF con iTextSharp
        // =====================================================================
        internal static void GenerarPDF(DataTable dt, string titulo, string rutaArchivo)
        {
            // ── Colores ──────────────────────────────────────────────────────
            BaseColor colorHeader = new BaseColor(100, 88, 255);
            BaseColor colorAlt = new BaseColor(242, 240, 255);
            BaseColor colorBorder = new BaseColor(200, 198, 240);

            // ── Documento ────────────────────────────────────────────────────
            Document doc = new Document(PageSize.A4.Rotate(), 28, 28, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            writer.PageEvent = new PdfPageEvents(titulo);
            doc.Open();

            // ── Fuentes ──────────────────────────────────────────────────────
            PdfFont fTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, new BaseColor(15, 23, 42));
            PdfFont fSub = FontFactory.GetFont(FontFactory.HELVETICA, 10, new BaseColor(80, 80, 80));
            PdfFont fColHead = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);
            PdfFont fCell = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, new BaseColor(35, 35, 35));
            PdfFont fTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, new BaseColor(100, 88, 255));

            // ── Encabezado ────────────────────────────────────────────────────
            Paragraph pTitulo = new Paragraph("FlowGestion", fTitle) { SpacingAfter = 2 };
            Paragraph pSub = new Paragraph($"REPORTE DE {titulo.ToUpper()}    |    Generado: {DateTime.Now:dd/MM/yyyy HH:mm}", fSub) { SpacingAfter = 16 };
            doc.Add(pTitulo);
            doc.Add(pSub);

            // ── Tabla ─────────────────────────────────────────────────────────
            PdfPTable table = new PdfPTable(dt.Columns.Count)
            {
                WidthPercentage = 100,
                SpacingBefore = 4,
                HorizontalAlignment = Element.ALIGN_LEFT
            };

            // Anchos proporcionales automáticos
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++) widths[i] = 1f;
            table.SetWidths(widths);

            // ── Fila de encabezados de columna ────────────────────────────────
            foreach (DataColumn col in dt.Columns)
            {
                PdfPCell header = new PdfPCell(new Phrase(col.ColumnName, fColHead))
                {
                    BackgroundColor = colorHeader,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Padding = 8,
                    Border = PdfPCell.NO_BORDER,
                    BorderWidthBottom = 0.5f,
                    BorderColorBottom = new BaseColor(80, 70, 200)
                };
                table.AddCell(header);
            }

            // ── Filas de datos ────────────────────────────────────────────────
            bool alt = false;
            decimal grandTotal = 0m;
            int colImporte = -1;
            for (int c = 0; c < dt.Columns.Count; c++)
                if (dt.Columns[c].ColumnName.ToLower().Contains("importe") ||
                    dt.Columns[c].ColumnName.ToLower().Contains("precio"))
                    colImporte = c;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                BaseColor bg = alt ? colorAlt : BaseColor.WHITE;
                alt = !alt;

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    string val = dt.Rows[r][c]?.ToString() ?? "";

                    // Formatear columnas monetarias
                    bool esMonto = (c == colImporte);
                    if (esMonto && decimal.TryParse(val, out decimal m))
                    {
                        grandTotal += m;
                        val = m.ToString("C2");
                    }

                    PdfPCell cell = new PdfPCell(new Phrase(val, fCell))
                    {
                        BackgroundColor = bg,
                        Padding = 6,
                        Border = PdfPCell.NO_BORDER,
                        BorderWidthBottom = 0.3f,
                        BorderColorBottom = colorBorder,
                        HorizontalAlignment = esMonto
                            ? Element.ALIGN_RIGHT
                            : Element.ALIGN_LEFT
                    };
                    table.AddCell(cell);
                }
            }

            doc.Add(table);

            // ── Fila de totales ───────────────────────────────────────────────
            Paragraph pTotal = new Paragraph(
                $"Total de registros: {dt.Rows.Count}" +
                (colImporte >= 0 ? $"          Total importe: {grandTotal:C2}" : ""),
                fTotal)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingBefore = 8
            };
            doc.Add(pTotal);

            doc.Close();
        }
    }

    // =========================================================================
    // PAGE EVENTS — encabezado y pie de pagina en cada hoja
    // =========================================================================
    internal class PdfPageEvents : PdfPageEventHelper
    {
        private readonly string _titulo;
        private PdfFont _fFooter = FontFactory.GetFont(FontFactory.HELVETICA, 7.5f, new BaseColor(130, 130, 130));

        public PdfPageEvents(string titulo) { _titulo = titulo; }

        public override void OnEndPage(PdfWriter writer, Document doc)
        {
            PdfContentByte cb = writer.DirectContent;

            // Línea superior de pie de página
            cb.SetLineWidth(0.5f);
            cb.SetColorStroke(new BaseColor(200, 198, 240));
            cb.MoveTo(doc.Left, doc.Bottom - 6);
            cb.LineTo(doc.Right, doc.Bottom - 6);
            cb.Stroke();

            // Texto del pie
            string footer = $"FlowGestion  —  Reporte: {_titulo}  —  Pagina {writer.PageNumber}  —  {DateTime.Now:dd/MM/yyyy}";
            ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER,
                new Phrase(footer, _fFooter),
                (doc.Left + doc.Right) / 2, doc.Bottom - 16, 0);
        }
    }
}
