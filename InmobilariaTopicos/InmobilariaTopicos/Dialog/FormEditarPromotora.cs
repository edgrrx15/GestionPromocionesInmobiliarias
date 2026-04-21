using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data; // Asumo que aquí está conexion

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEditarPromotora : Form
    {
        private conexion con = new conexion();
        private int idActual;

        public FormEditarPromotora(int id, string nombre)
        {
            InitializeComponent();
            this.idActual = id;
            this.nombrePromoText.Text = nombre;
            this.lblId.Text = "ID de Sistema: " + id.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrePromoText.Text))
            {
                MessageBox.Show("El nombre de la promotora es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreNuevo = nombrePromoText.Text.Trim();

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "UPDATE PROMOTORA SET NOMBRE = @nombre WHERE ID_PROMOTORA = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nombre", nombreNuevo);
                    cmd.Parameters.AddWithValue("@id", this.idActual);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la promotora o no se hicieron cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo una excepción al actualizar:\n" + ex.Message, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
