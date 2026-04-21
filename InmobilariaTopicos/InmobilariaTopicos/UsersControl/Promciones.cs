using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class Promciones : UserControl
    {
        // Almacena los bytes del plano seleccionado
        private byte[] planoBytes = null;

        public Promciones()
        {
            InitializeComponent();
            this.Load += Promciones_Load;
        }

        // =====================================================================
        // CARGA INICIAL
        // =====================================================================
        private void Promciones_Load(object sender, EventArgs e)
        {
            CargarPromotoras();
            CargarPromociones();
        }

        // =====================================================================
        // CARGAR COMBO DE PROMOTORAS
        // =====================================================================
        private void CargarPromotoras()
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection conn = con.conectar())
                {
                    // conectar() ya abre la conexión — NO llamar conn.Open() de nuevo
                    string sql = "SELECT ID_PROMOTORA, NOMBRE FROM PROMOTORA ORDER BY NOMBRE";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbPromotora.DataSource    = dt;
                    cbPromotora.DisplayMember = "NOMBRE";
                    cbPromotora.ValueMember   = "ID_PROMOTORA";
                    cbPromotora.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promotoras:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // CARGAR GRID DE PROMOCIONES
        // =====================================================================
        public void CargarPromociones()
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection conn = con.conectar())
                {
                    // conectar() ya abre la conexión — NO llamar conn.Open() de nuevo
                    string sql = @"
                SELECT
                    p.COD_PROMOCION   AS CODIGO_INTERNO,
                    p.NOMBRE,
                    p.POBLACION,
                    pr.NOMBRE         AS PROMOTORA,
                    p.PLANO_SITUACION,
                    p.ID_PROMOTORA
                FROM PROMOCION p
                INNER JOIN PROMOTORA pr ON p.ID_PROMOTORA = pr.ID_PROMOTORA
                ORDER BY p.COD_PROMOCION";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    datagridViewPromos.DataSource = null;

                    if (dt.Rows.Count == 0)
                    {
                        datagridViewPromos.Visible = false;
                        return;
                    }

                    datagridViewPromos.Visible    = true;
                    datagridViewPromos.DataSource = dt;
                }

                // =========================
                // CONFIGURACION GENERAL
                // =========================
                datagridViewPromos.ReadOnly = true;
                datagridViewPromos.AllowUserToAddRows = false;
                datagridViewPromos.AllowUserToDeleteRows = false;
                datagridViewPromos.AllowUserToResizeRows = false;
                datagridViewPromos.AllowUserToResizeColumns = false;
                datagridViewPromos.MultiSelect = false;
                datagridViewPromos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                datagridViewPromos.RowHeadersVisible = false;
                datagridViewPromos.BorderStyle = BorderStyle.None;
                datagridViewPromos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                datagridViewPromos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                datagridViewPromos.EnableHeadersVisualStyles = false;
                datagridViewPromos.ScrollBars = ScrollBars.Vertical;
                datagridViewPromos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridViewPromos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                datagridViewPromos.ColumnHeadersHeight = 42;
                datagridViewPromos.RowTemplate.Height = 38;
                datagridViewPromos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // =========================
                // COLORES Y FUENTES
                // =========================
                datagridViewPromos.BackgroundColor = Color.White;
                datagridViewPromos.GridColor = Color.FromArgb(230, 230, 230);
                datagridViewPromos.DefaultCellStyle.BackColor = Color.White;
                datagridViewPromos.DefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
                datagridViewPromos.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                datagridViewPromos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridViewPromos.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                datagridViewPromos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 250);
                datagridViewPromos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35);
                datagridViewPromos.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                datagridViewPromos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(95, 95, 95);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(95, 95, 95);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                datagridViewPromos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 252);
                datagridViewPromos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
                datagridViewPromos.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 250);
                datagridViewPromos.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35);

                // =========================
                // COLUMNAS
                // =========================
                foreach (DataGridViewColumn col in datagridViewPromos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                    col.MinimumWidth = 60;
                }

                // =========================
                // TITULOS
                // =========================
                if (datagridViewPromos.Columns.Contains("CODIGO_INTERNO"))
                    datagridViewPromos.Columns["CODIGO_INTERNO"].HeaderText = "Código";

                if (datagridViewPromos.Columns.Contains("NOMBRE"))
                    datagridViewPromos.Columns["NOMBRE"].HeaderText = "Nombre";

                if (datagridViewPromos.Columns.Contains("POBLACION"))
                    datagridViewPromos.Columns["POBLACION"].HeaderText = "Población";

                if (datagridViewPromos.Columns.Contains("PROMOTORA"))
                    datagridViewPromos.Columns["PROMOTORA"].HeaderText = "Promotora";

                // =========================
                // OCULTAR COLUMNAS
                // =========================
                if (datagridViewPromos.Columns.Contains("PLANO_SITUACION"))
                    datagridViewPromos.Columns["PLANO_SITUACION"].Visible = false;

                if (datagridViewPromos.Columns.Contains("ID_PROMOTORA"))
                    datagridViewPromos.Columns["ID_PROMOTORA"].Visible = false;

                // =========================
                // TAMAÑOS
                // =========================
                if (datagridViewPromos.Columns.Contains("CODIGO_INTERNO"))
                    datagridViewPromos.Columns["CODIGO_INTERNO"].FillWeight = 70;

                if (datagridViewPromos.Columns.Contains("NOMBRE"))
                    datagridViewPromos.Columns["NOMBRE"].FillWeight = 120;

                if (datagridViewPromos.Columns.Contains("POBLACION"))
                    datagridViewPromos.Columns["POBLACION"].FillWeight = 90;

                if (datagridViewPromos.Columns.Contains("PROMOTORA"))
                    datagridViewPromos.Columns["PROMOTORA"].FillWeight = 110;

                // =========================
                // ESPACIO VISUAL A LA DERECHA
                // =========================
                if (datagridViewPromos.Columns.Count > 0)
                {
                    DataGridViewColumn ultima = datagridViewPromos.Columns[datagridViewPromos.Columns.Count - 1];
                    ultima.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    ultima.Width = ultima.Width - 15;
                }

                // =========================
                // DETALLES EXTRA VISUALES
                // =========================
                datagridViewPromos.ClearSelection();
                datagridViewPromos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // =====================================================================
        // BOTÓN EXAMINAR (subir plano)
        // =====================================================================
        private void btnSubirPlano_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen y PDF|*.jpg;*.jpeg;*.png;*.pdf";
                ofd.Title = "Seleccionar Plano o Documento";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaPlano.Text = ofd.FileName;
                    planoBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        // =====================================================================
        // BOTÓN GUARDAR  (INSERT)
        // =====================================================================
        private void guardarBoton_Click(object sender, EventArgs e)
        {
            // ── Validación ──────────────────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(codigoInternoText.Text) ||
                string.IsNullOrWhiteSpace(nombrePromoText.Text) ||
                string.IsNullOrWhiteSpace(poblacionText.Text) ||
                cbPromotora.SelectedValue == null)
            {
                MessageBox.Show("Por favor llena todos los campos obligatorios.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = codigoInternoText.Text.Trim().ToUpper();
            string nombre = nombrePromoText.Text.Trim();
            string poblacion = poblacionText.Text.Trim();
            int idPromotora = Convert.ToInt32(cbPromotora.SelectedValue);

            try
            {
                conexion con = new conexion();
                using (SqlConnection conn = con.conectar())
                {
                    string query = "INSERT INTO PROMOCION (COD_PROMOCION, NOMBRE, POBLACION, ID_PROMOTORA, PLANO_SITUACION) " +
                                   "VALUES (@codigo, @nombre, @poblacion, @idPromotora, @plano)";

                    SqlCommand altas = new SqlCommand(query, conn);
                    altas.Parameters.AddWithValue("@codigo",      codigo);
                    altas.Parameters.AddWithValue("@nombre",      nombre);
                    altas.Parameters.AddWithValue("@poblacion",   poblacion);
                    altas.Parameters.AddWithValue("@idPromotora", idPromotora);

                    if (planoBytes != null)
                        altas.Parameters.AddWithValue("@plano", planoBytes);
                    else
                        altas.Parameters.AddWithValue("@plano", DBNull.Value);

                    altas.ExecuteNonQuery();
                }

                MessageBox.Show("Promoción registrada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarPromociones();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627 || sqlex.Number == 2601)
            {
                MessageBox.Show("Ya existe una promoción con ese Código Interno.",
                    "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // BOTÓN EDITAR  – abre el modal FormEditarPromocion
        // =====================================================================
        private void editarPromoBoton_Click(object sender, EventArgs e)
        {
            if (datagridViewPromos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promoción para editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = datagridViewPromos.SelectedRows[0];
            string codigo = fila.Cells["CODIGO_INTERNO"].Value?.ToString();
            string nombre = fila.Cells["NOMBRE"].Value?.ToString();
            string poblacion = fila.Cells["POBLACION"].Value?.ToString();
            object idProm = fila.Cells["ID_PROMOTORA"].Value;

            using (var modal = new FormEditarPromocion(codigo, nombre, poblacion, idProm))
            {
                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    CargarPromociones();
            }
        }

        // =====================================================================
        // BOTÓN ELIMINAR – abre el modal FormEliminarPromocion
        // =====================================================================
        private void eliminarPromoBoton_Click(object sender, EventArgs e)
        {
            if (datagridViewPromos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promoción para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Si esta promocion esta asociado con una vivienda no se podra eliminar, se tiene que eliminar primero la vivienda
            if(datagridViewPromos.SelectedRows[0].Cells["CODIGO_INTERNO"].Value != null)
            {
                string codigoPromo = datagridViewPromos.SelectedRows[0].Cells["CODIGO_INTERNO"].Value.ToString();
                conexion con = new conexion();
                using (SqlConnection conn = con.conectar())
                {
                    string sql = "SELECT COUNT(*) FROM VIVIENDA WHERE COD_PROMOCION = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cod", codigoPromo);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("No se puede eliminar esta promoción porque tiene viviendas asociadas.\nElimine primero las viviendas relacionadas.",
                            "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            string codigo = datagridViewPromos.SelectedRows[0]
                                .Cells["CODIGO_INTERNO"].Value?.ToString();

            if (string.IsNullOrEmpty(codigo)) return;

            using (var modal = new FormEliminarPromocion(codigo))
            {
                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LimpiarFormulario();
                    CargarPromociones();
                }
            }
        }

        // =====================================================================
        // LIMPIAR FORMULARIO
        // =====================================================================
        private void LimpiarFormulario()
        {
            codigoInternoText.Text = string.Empty;
            codigoInternoText.Enabled = true;
            nombrePromoText.Text = string.Empty;
            poblacionText.Text = string.Empty;
            cbPromotora.SelectedIndex = -1;
            txtRutaPlano.Text = string.Empty;
            planoBytes = null;
        }

        private void buscarPromoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string texto = buscarPromoText.Text.Trim();

            try
            {
                conexion con = new conexion();
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"
                        SELECT
                            p.COD_PROMOCION   AS CODIGO_INTERNO,
                            p.NOMBRE,
                            p.POBLACION,
                            pr.NOMBRE         AS PROMOTORA,
                            p.PLANO_SITUACION,
                            p.ID_PROMOTORA
                        FROM PROMOCION p
                        INNER JOIN PROMOTORA pr ON p.ID_PROMOTORA = pr.ID_PROMOTORA
                        WHERE p.COD_PROMOCION LIKE @busqueda
                           OR p.NOMBRE        LIKE @busqueda
                           OR p.POBLACION     LIKE @busqueda
                           OR pr.NOMBRE       LIKE @busqueda
                        ORDER BY p.COD_PROMOCION";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@busqueda", "%" + texto + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    datagridViewPromos.DataSource = null;
                    datagridViewPromos.Visible = dt.Rows.Count > 0;
                    if (dt.Rows.Count > 0)
                        datagridViewPromos.DataSource = dt;

                    //Si no hay resultados, se muestra un mensaje indicando que no se encontraron promociones
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron promociones que coincidan con la búsqueda.",
                            "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}