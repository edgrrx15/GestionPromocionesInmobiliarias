using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormAgregarVivienda : Form
    {
        private conexion con = new conexion();

        public FormAgregarVivienda()
        {
            InitializeComponent();
            this.Load += FormAgregarVivienda_Load;
        }

        private void FormAgregarVivienda_Load(object sender, EventArgs e)
        {
            CargarPromociones();
        }

        // ─── LLENAR COMBOBOX DE PROMOCIONES ─────────────────────────────────────
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
                    cbPromocion.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── GUARDAR (INSERT) ────────────────────────────────────────────────────
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
                    string sql = @"INSERT INTO VIVIENDA 
                        (NOMBRE, COD_PROMOCION, SUPERFICIE, NUM_HABITACIONES, NUM_BANIOS, 
                         PRECIO, ESTADO, EXTRAS, OBSERVACIONES, TERRAZA, JARDIN_PRIVADO, PISCINA, GARAJE)
                        VALUES 
                        (@nombre, @codPromocion, @superficie, @habitaciones, @banios,
                         @precio, @estado, @extras, @observaciones, 0, 0, 0, 0)";

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

                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar vivienda:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
