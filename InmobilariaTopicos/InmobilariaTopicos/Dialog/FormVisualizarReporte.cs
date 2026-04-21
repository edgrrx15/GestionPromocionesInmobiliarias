using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormVisualizarReporte : Form
    {
        private readonly DataTable _datos;
        private readonly string    _titulo;
        private readonly string    _fechaInicio;
        private readonly string    _fechaFin;

        public FormVisualizarReporte(DataTable datos, string titulo, string fechaInicio, string fechaFin)
        {
            InitializeComponent();
            _datos      = datos;
            _titulo     = titulo;
            _fechaInicio = fechaInicio;
            _fechaFin    = fechaFin;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // ── Encabezado ────────────────────────────────────────────────────
            lblTitulo.Text    = $"Vista Previa — {_titulo}";
            lblSubtitulo.Text = $"Periodo: {_fechaInicio}  —  {_fechaFin}";

            // ── Cargar datos en el grid ───────────────────────────────────────
            gridPrevia.DataSource = null;
            gridPrevia.DataSource = _datos;

            // Formato de columnas monetarias
            foreach (DataGridViewColumn col in gridPrevia.Columns)
            {
                string nombre = col.HeaderText.ToLower();
                if (nombre.Contains("importe") || nombre.Contains("precio"))
                    col.DefaultCellStyle.Format = "C2";

                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            gridPrevia.ClearSelection();

            // ── Conteo total ──────────────────────────────────────────────────
            lblConteo.Text = $"{_datos.Rows.Count} registros encontrados";
        }

        // ── Guardar como PDF ────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter   = "PDF files (*.pdf)|*.pdf";
                dlg.FileName = $"Reporte_{_titulo}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                dlg.Title    = "Guardar reporte PDF";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    Descargas.GenerarPDF(_datos, _titulo, dlg.FileName);
                    MessageBox.Show($"PDF guardado correctamente:\n{dlg.FileName}",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
