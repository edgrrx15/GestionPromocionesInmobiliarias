using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEditarPromocion : Form
    {
        private conexion con = new conexion();
        private byte[] planoBytes = null;
        private string codigoOriginal;

        // idProm puede ser int o null
        public FormEditarPromocion(string codigo, string nombre, string poblacion, object idProm)
        {
            InitializeComponent();
            codigoOriginal = codigo;
            codigoInternoText.Text = codigo;
            codigoInternoText.ReadOnly = true;   // No se cambia la PK
            nombrePromoText.Text  = nombre;
            poblacionText.Text    = poblacion;

            // Cargar combo de promotoras
            CargarPromotoras();

            // Seleccionar la promotora actual
            if (idProm != null && cbPromotora.DataSource != null)
                cbPromotora.SelectedValue = idProm;
        }

        // ─── CARGAR PROMOTORAS ───────────────────────────────────────────────
        private void CargarPromotoras()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = "SELECT ID_PROMOTORA, NOMBRE FROM PROMOTORA ORDER BY NOMBRE";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbPromotora.DataSource    = dt;
                    cbPromotora.DisplayMember = "NOMBRE";
                    cbPromotora.ValueMember   = "ID_PROMOTORA";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promotoras:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SUBIR PLANO ─────────────────────────────────────────────────────
        private void btnSubirPlano_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen y PDF|*.jpg;*.jpeg;*.png;*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaPlano.Text = ofd.FileName;
                    planoBytes        = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        // ─── GUARDAR (UPDATE) ────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrePromoText.Text) ||
                string.IsNullOrWhiteSpace(poblacionText.Text)   ||
                cbPromotora.SelectedValue == null)
            {
                MessageBox.Show("Llene los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre    = nombrePromoText.Text.Trim();
            string poblacion = poblacionText.Text.Trim();
            int    idProm    = Convert.ToInt32(cbPromotora.SelectedValue);

            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"UPDATE PROMOCION SET
                        NOMBRE       = @nom,
                        POBLACION    = @pob,
                        ID_PROMOTORA = @idProm"
                        + (planoBytes != null ? ", PLANO_SITUACION = @plano" : "") + @"
                    WHERE COD_PROMOCION = @cod";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nom",   nombre);
                    cmd.Parameters.AddWithValue("@pob",   poblacion);
                    cmd.Parameters.AddWithValue("@idProm", idProm);
                    cmd.Parameters.AddWithValue("@cod",   codigoOriginal);

                    if (planoBytes != null)
                        cmd.Parameters.AddWithValue("@plano", planoBytes);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la promoción:\n" + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── CANCELAR ────────────────────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
