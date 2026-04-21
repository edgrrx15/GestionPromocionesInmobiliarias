using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using topicos_autosbd.Data; 

namespace InmobilariaTopicos.UsersControl
{
    public partial class Promotora : UserControl
    {
        private conexion con = new conexion();

        public Promotora()
        {
            InitializeComponent();
            this.Load += Promotora_Load;
        }

        private void Promotora_Load(object sender, EventArgs e)
        {
            CargarPromotoras();
        }

        private void CargarPromotoras()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = con.conectar())
                {
                    string sql = "SELECT * FROM PROMOTORA";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

                datagridViewPromos.DataSource = null;

                if (dt.Rows.Count == 0)
                {
                    datagridViewPromos.Visible = false;
                    return;
                }
                
                datagridViewPromos.Visible = true;
                datagridViewPromos.DataSource = dt;

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

                // Para que entren todas las columnas
                datagridViewPromos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridViewPromos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // Alturas
                datagridViewPromos.ColumnHeadersHeight = 42;
                datagridViewPromos.RowTemplate.Height = 38;

                // =========================
                // COLORES Y FUENTES
                // =========================
                datagridViewPromos.BackgroundColor = Color.White;
                datagridViewPromos.GridColor = Color.FromArgb(230, 230, 230);

                datagridViewPromos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(95, 95, 95);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Font = new Font("SF Pro Display", 9F, FontStyle.Bold);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                datagridViewPromos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                datagridViewPromos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(95, 95, 95);

                datagridViewPromos.DefaultCellStyle.BackColor = Color.White;
                datagridViewPromos.DefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
                datagridViewPromos.DefaultCellStyle.Font = new Font("SF Pro Display", 9F, FontStyle.Regular);
                datagridViewPromos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridViewPromos.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                datagridViewPromos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 221, 230);
                datagridViewPromos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35);
                datagridViewPromos.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                datagridViewPromos.Cursor = Cursors.Hand;

                // Filas alternadas suaves
                datagridViewPromos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 252);

                // =========================
                // CONFIGURAR COLUMNAS
                // =========================
                foreach (DataGridViewColumn col in datagridViewPromos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                    col.MinimumWidth = 60;
                }

                // =========================
                // TITULOS DE COLUMNAS
                // =========================
                if (datagridViewPromos.Columns.Contains("ID_PROMOTORA"))
                    datagridViewPromos.Columns["ID_PROMOTORA"].HeaderText = "ID";

                if (datagridViewPromos.Columns.Contains("NOMBRE"))
                    datagridViewPromos.Columns["NOMBRE"].HeaderText = "Nombre";

                // Si luego agregas más campos en PROMOTORA, aquí los renombras

                // =========================
                // ANCHOS RELATIVOS
                // =========================
                if (datagridViewPromos.Columns.Contains("ID_PROMOTORA"))
                    datagridViewPromos.Columns["ID_PROMOTORA"].FillWeight = 45;

                if (datagridViewPromos.Columns.Contains("NOMBRE"))
                    datagridViewPromos.Columns["NOMBRE"].FillWeight = 120;

                // =========================
                // ESPACIO VISUAL A LA DERECHA
                // =========================
                if (datagridViewPromos.Columns.Count > 0)
                {
                    datagridViewPromos.Columns[datagridViewPromos.Columns.Count - 1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.None;

                    datagridViewPromos.Columns[datagridViewPromos.Columns.Count - 1].Width =
                        datagridViewPromos.Columns[datagridViewPromos.Columns.Count - 1].Width - 15;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener promotoras:\n" + ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrePromoText.Text))
            {
                MessageBox.Show("El nombre de la promotora es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = nombrePromoText.Text.Trim();

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "INSERT INTO PROMOTORA (NOMBRE) VALUES (@nombre)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    
                    int result = cmd.ExecuteNonQuery();
                    
                    if (result > 0)
                    {
                        MessageBox.Show("Promotora guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nombrePromoText.Clear();
                        CargarPromotoras();
                    }
                    else
                    {
                        MessageBox.Show("No se insertaron filas, pero no hubo excepción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción al guardar:\n" + ex.Message, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datagridViewPromos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promotora para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idActual = Convert.ToInt32(datagridViewPromos.SelectedRows[0].Cells["ID_PROMOTORA"].Value);
            string nombreActual = datagridViewPromos.SelectedRows[0].Cells["NOMBRE"].Value.ToString();

            using (var modal = new FormEditarPromotora(idActual, nombreActual))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    CargarPromotoras();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (datagridViewPromos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promotora para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            int id = Convert.ToInt32(datagridViewPromos.SelectedRows[0].Cells["ID_PROMOTORA"].Value);

            using (var modal = new FormEliminarPromotora(id))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    CargarPromotoras();
                }
            }
        }

        private void BuscarPromotoraText_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscara en la tabla
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter

                //valida que el campo no este vacio
                if (string.IsNullOrWhiteSpace(BuscarPromotoraText.Text))
                {
                    CargarPromotoras();
                    return;
                }
                try
                {
                    conexion con = new conexion();
                    SqlConnection connection = con.conectar();
                    string query = "SELECT * FROM PROMOTORA WHERE NOMBRE LIKE @filtro OR ID_PROMOTORA LIKE @filtro";
                    SqlDataAdapter consulta = new SqlDataAdapter(query, connection);

                    consulta.SelectCommand.Parameters.AddWithValue("@filtro", "%" + BuscarPromotoraText.Text.Trim() + "%");


                    DataTable dt = new DataTable();
                    consulta.Fill(dt);
                    datagridViewPromos.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron promotoras que coincidan con la búsqueda." + BuscarPromotoraText.Text, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar promotoras:\n" + ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
