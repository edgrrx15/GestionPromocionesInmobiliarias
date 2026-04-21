using InmobilariaTopicos.Dialog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class Contratos : UserControl
    {
        private conexion con = new conexion();

        public Contratos()
        {
            InitializeComponent();
            this.Load += Contratos_Load;
        }

        // =====================================================================
        // CARGA INICIAL
        // =====================================================================
        private void Contratos_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            CargarPromociones();
            CargarHistorial();
            CargarContratoActivo();

            // Conectar eventos de botones
            guardarBoton.Click += guardarBoton_Click;
            editarContratoBoton.Click += editarContratoBoton_Click;
            eliminarContratoBoton.Click += eliminarContratoBoton_Click;
            buscarEmpresaText.KeyDown += buscarText_KeyDown;
        }

        // =====================================================================
        // CARGAR COMBOS
        // =====================================================================
        private void CargarEmpresas()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT ID_EMPRESA, NOMBRE FROM EMPRESA ORDER BY NOMBRE", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    empresaContratoCombo.DataSource = dt;
                    empresaContratoCombo.DisplayMember = "NOMBRE";
                    empresaContratoCombo.ValueMember = "ID_EMPRESA";
                    empresaContratoCombo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empresas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPromociones()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT COD_PROMOCION, NOMBRE FROM PROMOCION ORDER BY NOMBRE", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    promocionContratoCombo.DataSource = dt;
                    promocionContratoCombo.DisplayMember = "NOMBRE";
                    promocionContratoCombo.ValueMember = "COD_PROMOCION";
                    promocionContratoCombo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // CARGAR HISTORIAL (DataGridView)
        // =====================================================================
        public void CargarHistorial()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"
                SELECT
                    c.ID_CONTRATO   AS ID,
                    e.NOMBRE        AS Empresa,
                    p.NOMBRE        AS Promocion,
                    c.IMPORTE       AS Importe,
                    c.OBSERVACIONES AS Observaciones,
                    c.ID_EMPRESA,
                    c.COD_PROMOCION
                FROM CONTRATO c
                INNER JOIN EMPRESA  e ON c.ID_EMPRESA    = e.ID_EMPRESA
                INNER JOIN PROMOCION p ON c.COD_PROMOCION = p.COD_PROMOCION
                ORDER BY c.ID_CONTRATO DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    guna2DataGridView1.DataSource = null;

                    if (dt.Rows.Count == 0)
                    {
                        guna2DataGridView1.Visible = false;
                        return;
                    }

                    guna2DataGridView1.Visible = true;
                    guna2DataGridView1.DataSource = dt;
                }

                // =========================
                // CONFIGURACION GENERAL
                // =========================
                guna2DataGridView1.ReadOnly = true;
                guna2DataGridView1.AllowUserToAddRows = false;
                guna2DataGridView1.AllowUserToDeleteRows = false;
                guna2DataGridView1.AllowUserToResizeRows = false;
                guna2DataGridView1.AllowUserToResizeColumns = false;
                guna2DataGridView1.MultiSelect = false;
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.RowHeadersVisible = false;
                guna2DataGridView1.BorderStyle = BorderStyle.None;
                guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                guna2DataGridView1.EnableHeadersVisualStyles = false;
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.ScrollBars = ScrollBars.Vertical;
                guna2DataGridView1.ColumnHeadersHeight = 42;
                guna2DataGridView1.RowTemplate.Height = 38;

                // =========================
                // COLORES Y FUENTES
                // =========================
                guna2DataGridView1.BackgroundColor = Color.White;
                guna2DataGridView1.GridColor = Color.FromArgb(230, 230, 230);

                guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(95, 95, 95);
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("SF Pro Display", 9F, FontStyle.Bold);
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 12, 0);

                guna2DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(95, 95, 95);

                guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
                guna2DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
                guna2DataGridView1.DefaultCellStyle.Font = new Font("SF Pro Display", 9F, FontStyle.Regular);
                guna2DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                guna2DataGridView1.DefaultCellStyle.Padding = new Padding(12, 0, 12, 0);

                guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 221, 230);
                guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35);
                guna2DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 252);
                guna2DataGridView1.Cursor = Cursors.Hand;

                // =========================
                // COLUMNAS
                // =========================
                foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                    col.MinimumWidth = 50; // más compacto
                }

                // =========================
                // TITULOS
                // =========================
                if (guna2DataGridView1.Columns.Contains("ID"))
                    guna2DataGridView1.Columns["ID"].HeaderText = "ID";

                if (guna2DataGridView1.Columns.Contains("Empresa"))
                    guna2DataGridView1.Columns["Empresa"].HeaderText = "Empresa";

                if (guna2DataGridView1.Columns.Contains("Promocion"))
                    guna2DataGridView1.Columns["Promocion"].HeaderText = "Promoción";

                if (guna2DataGridView1.Columns.Contains("Importe"))
                    guna2DataGridView1.Columns["Importe"].HeaderText = "Importe";

                if (guna2DataGridView1.Columns.Contains("Observaciones"))
                    guna2DataGridView1.Columns["Observaciones"].HeaderText = "Observaciones";

                // =========================
                // OCULTAR COLUMNAS
                // =========================
                if (guna2DataGridView1.Columns.Contains("ID_EMPRESA"))
                    guna2DataGridView1.Columns["ID_EMPRESA"].Visible = false;

                if (guna2DataGridView1.Columns.Contains("COD_PROMOCION"))
                    guna2DataGridView1.Columns["COD_PROMOCION"].Visible = false;

                // =========================
                // FORMATO IMPORTE
                // =========================
                if (guna2DataGridView1.Columns.Contains("Importe"))
                    guna2DataGridView1.Columns["Importe"].DefaultCellStyle.Format = "C2";

                // =========================
                // DISTRIBUCION (CLAVE)
                // =========================
                if (guna2DataGridView1.Columns.Contains("ID"))
                    guna2DataGridView1.Columns["ID"].FillWeight = 40;

                if (guna2DataGridView1.Columns.Contains("Empresa"))
                    guna2DataGridView1.Columns["Empresa"].FillWeight = 90;

                if (guna2DataGridView1.Columns.Contains("Promocion"))
                    guna2DataGridView1.Columns["Promocion"].FillWeight = 90;

                if (guna2DataGridView1.Columns.Contains("Importe"))
                    guna2DataGridView1.Columns["Importe"].FillWeight = 70;

                if (guna2DataGridView1.Columns.Contains("Observaciones"))
                    guna2DataGridView1.Columns["Observaciones"].FillWeight = 120;

                // =========================
                guna2DataGridView1.ClearSelection();
                guna2DataGridView1.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideCol(string name)
        {
            if (guna2DataGridView1.Columns.Contains(name))
                guna2DataGridView1.Columns[name].Visible = false;
        }

        // =====================================================================
        // CARGAR CONTRATO ACTIVO (panel derecho)
        // =====================================================================
        private void CargarContratoActivo()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    // Toma el contrato más reciente
                    string sql = @" 
                        SELECT TOP 1
                            c.ID_CONTRATO,
                            e.NOMBRE  AS NombreEmpresa,
                            p.NOMBRE  AS NombrePromocion,
                            c.IMPORTE
                        FROM CONTRATO c
                        INNER JOIN EMPRESA   e ON c.ID_EMPRESA    = e.ID_EMPRESA
                        INNER JOIN PROMOCION p ON c.COD_PROMOCION = p.COD_PROMOCION
                        ORDER BY c.ID_CONTRATO DESC";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblidContrato.Text = dr["ID_CONTRATO"].ToString();
                        lblNombreEmpresa.Text = dr["NombreEmpresa"].ToString();
                        lblNombrePromo.Text = dr["NombrePromocion"].ToString();
                        lblImporteContrato.Text = $"${Convert.ToDecimal(dr["IMPORTE"]):N2}";
                    }
                    else
                    {
                        lblidContrato.Text = "—";
                        lblNombreEmpresa.Text = "—";
                        lblNombrePromo.Text = "—";
                        lblImporteContrato.Text = "$0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contrato activo:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // GUARDAR (INSERT)
        // =====================================================================
        private void guardarBoton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(nombreEmpresaText.Text) ||
                empresaContratoCombo.SelectedValue == null ||
                promocionContratoCombo.SelectedValue == null)
            {
                MessageBox.Show("Llena todos los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(nombreEmpresaText.Text.Trim(), out decimal importe))
            {
                MessageBox.Show("El importe debe ser un número válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idContrato = idEmpresaText.Text.Trim().ToUpper();
            int idEmpresa = Convert.ToInt32(empresaContratoCombo.SelectedValue);
            string codPromocion = promocionContratoCombo.SelectedValue.ToString();
            string observaciones = direccionEmpresaText.Text.Trim();

            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"INSERT INTO CONTRATO
                        (ID_CONTRATO, ID_EMPRESA, COD_PROMOCION, IMPORTE, OBSERVACIONES)
                        VALUES (@id, @idEmp, @codProm, @importe, @obs)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idContrato);
                    cmd.Parameters.AddWithValue("@idEmp", idEmpresa);
                    cmd.Parameters.AddWithValue("@codProm", codPromocion);
                    cmd.Parameters.AddWithValue("@importe", importe);
                    cmd.Parameters.AddWithValue("@obs", string.IsNullOrEmpty(observaciones)
                                                             ? (object)DBNull.Value : observaciones);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contrato registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarHistorial();
                CargarContratoActivo();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627 || sqlex.Number == 2601)
            {
                MessageBox.Show("Ya existe un contrato con ese ID.", "ID duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // EDITAR — abre FormEditarContrato
        // =====================================================================
        private void editarContratoBoton_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contrato del historial para editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = guna2DataGridView1.SelectedRows[0];

            string id = fila.Cells["ID"].Value?.ToString();
            decimal importe = Convert.ToDecimal(fila.Cells["Importe"].Value);
            int idEmpresa = Convert.ToInt32(fila.Cells["ID_EMPRESA"].Value);
            string codPromo = fila.Cells["COD_PROMOCION"].Value?.ToString();
            string obs = fila.Cells["Observaciones"].Value?.ToString();

            using (var modal = new FormEditarContrato(id, importe, idEmpresa, codPromo, obs))
            {
                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CargarHistorial();
                    CargarContratoActivo();
                }
            }
        }

        // =====================================================================
        // ELIMINAR — abre FormEliminarContrato
        // =====================================================================
        private void eliminarContratoBoton_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contrato del historial para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = guna2DataGridView1.SelectedRows[0]
                            .Cells["ID"].Value?.ToString();

            if (string.IsNullOrEmpty(id)) return;

            using (var modal = new FormEliminarContrato(id))
            {
                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LimpiarFormulario();
                    CargarHistorial();
                    CargarContratoActivo();
                }
            }
        }

        // =====================================================================
        // BUSCAR (Enter en textbox)
        // =====================================================================
        private void buscarText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string texto = buscarEmpresaText.Text.Trim();

            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"
                        SELECT
                            c.ID_CONTRATO   AS ID,
                            e.NOMBRE        AS Empresa,
                            p.NOMBRE        AS Promocion,
                            c.IMPORTE       AS Importe,
                            c.OBSERVACIONES AS Observaciones,
                            c.ID_EMPRESA,
                            c.COD_PROMOCION
                        FROM CONTRATO c
                        INNER JOIN EMPRESA   e ON c.ID_EMPRESA    = e.ID_EMPRESA
                        INNER JOIN PROMOCION p ON c.COD_PROMOCION = p.COD_PROMOCION
                        WHERE c.ID_CONTRATO LIKE @b
                           OR e.NOMBRE       LIKE @b
                           OR p.NOMBRE       LIKE @b
                        ORDER BY c.ID_CONTRATO DESC";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@b", "%" + texto + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    guna2DataGridView1.DataSource = null;
                    if (dt.Rows.Count > 0)
                        guna2DataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // LIMPIAR FORMULARIO
        // =====================================================================
        private void LimpiarFormulario()
        {
            idEmpresaText.Text = string.Empty;
            nombreEmpresaText.Text = string.Empty;
            direccionEmpresaText.Text = string.Empty;
            empresaContratoCombo.SelectedIndex = -1;
            promocionContratoCombo.SelectedIndex = -1;
        }

        private void label10_Click(object sender, EventArgs e) { }
    }
}
