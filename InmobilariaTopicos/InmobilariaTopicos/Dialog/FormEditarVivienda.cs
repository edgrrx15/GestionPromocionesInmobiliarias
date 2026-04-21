using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEditarVivienda : Form
    {
        private conexion con = new conexion();
        private int idVivienda;

        public FormEditarVivienda(int id)
        {
            InitializeComponent();
            this.idVivienda = id;
            this.Load += FormEditarVivienda_Load;
        }

        // ─── CARGAR DATOS AL ABRIR ────────────────────────────────────────────
        private void FormEditarVivienda_Load(object sender, EventArgs e)
        {
            CargarPromociones();
            CargarDatosVivienda();
        }

        private void CargarPromociones()
        {
            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "SELECT COD_PROMOCION, NOMBRE FROM PROMOCION";
                    SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbPromocion.DataSource = dt;
                    cbPromocion.DisplayMember = "NOMBRE";
                    cbPromocion.ValueMember = "COD_PROMOCION";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosVivienda()
        {
            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "SELECT * FROM VIVIENDA WHERE ID_VIVIENDA = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idVivienda);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0) return;
                    DataRow row = dt.Rows[0];

                    txtNombre.Text       = row["NOMBRE"]?.ToString() ?? "";
                    txtSuperficie.Text   = row["SUPERFICIE"].ToString();
                    txtHabitaciones.Text = row["NUM_HABITACIONES"].ToString();
                    txtBanios.Text       = row["NUM_BANIOS"].ToString();
                    txtPrecio.Text       = row["PRECIO"].ToString();
                    txtExtras.Text       = row["EXTRAS"]?.ToString() ?? "";
                    txtObservaciones.Text = row["OBSERVACIONES"]?.ToString() ?? "";

                    // Seleccionar la promoción actual
                    cbPromocion.SelectedValue = row["COD_PROMOCION"].ToString();

                    // Seleccionar el estado actual
                    string estadoActual = row["ESTADO"]?.ToString() ?? "Disponible";
                    cbEstado.SelectedItem = estadoActual;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de vivienda:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── GUARDAR EDICIÓN (UPDATE) ─────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cbPromocion.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtSuperficie.Text) ||
                string.IsNullOrWhiteSpace(txtHabitaciones.Text) ||
                string.IsNullOrWhiteSpace(txtBanios.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = @"UPDATE VIVIENDA SET
                        NOMBRE           = @nombre,
                        COD_PROMOCION    = @codPromocion,
                        SUPERFICIE       = @superficie,
                        NUM_HABITACIONES = @habitaciones,
                        NUM_BANIOS       = @banios,
                        PRECIO           = @precio,
                        ESTADO           = @estado,
                        EXTRAS           = @extras,
                        OBSERVACIONES    = @observaciones
                    WHERE ID_VIVIENDA = @id";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@codPromocion", cbPromocion.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@superficie", Convert.ToDouble(txtSuperficie.Text.Trim()));
                    cmd.Parameters.AddWithValue("@habitaciones", Convert.ToInt32(txtHabitaciones.Text.Trim()));
                    cmd.Parameters.AddWithValue("@banios", Convert.ToInt32(txtBanios.Text.Trim()));
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text.Trim()));
                    cmd.Parameters.AddWithValue("@estado", cbEstado.SelectedItem?.ToString() ?? "Disponible");
                    cmd.Parameters.AddWithValue("@extras", string.IsNullOrWhiteSpace(txtExtras.Text) ? (object)DBNull.Value : txtExtras.Text.Trim());
                    cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrWhiteSpace(txtObservaciones.Text) ? (object)DBNull.Value : txtObservaciones.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", idVivienda);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar vivienda:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── ELIMINAR (DELETE) ────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta vivienda? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "DELETE FROM VIVIENDA WHERE ID_VIVIENDA = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idVivienda);
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vivienda:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
