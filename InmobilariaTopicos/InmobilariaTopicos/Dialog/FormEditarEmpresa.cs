using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEditarEmpresa : Form
    {
        private conexion con = new conexion();
        private string idOriginal;

        public FormEditarEmpresa(string id, string nombre, string tipo,
                                  string telefono, string fax, string correo, string direccion)
        {
            InitializeComponent();
            idOriginal = id;
            idEmpresaEdicionText.Text = id;
            nombreEmpresaEdicionText.Text = nombre;
            tipoEmpresaEdicionText.Text = tipo;
            telefonoEdicionText.Text = telefono;
            faxEdicionText.Text = fax;
            correoEdicionText.Text = correo;
            descripcionEmpresaText.Text = direccion;
        }

        // ─── GUARDAR (UPDATE) ────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idEmpresaEdicionText.Text) ||
                string.IsNullOrWhiteSpace(nombreEmpresaEdicionText.Text) ||
                string.IsNullOrWhiteSpace(tipoEmpresaEdicionText.Text))
            {
                MessageBox.Show("ID, Nombre y Tipo son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    string sql = @"UPDATE EMPRESA SET
                        ID_EMPRESA  = @idNuevo,
                        NOMBRE      = @nombre,
                        TIPO        = @tipo,
                        TELEFONO    = @telefono,
                        FAX         = @fax,
                        CORREO      = @correo,
                        DIRECCION   = @direccion
                    WHERE ID_EMPRESA = @idOriginal";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@idNuevo", Convert.ToInt32(idEmpresaEdicionText.Text.Trim()));
                    cmd.Parameters.AddWithValue("@nombre", nombreEmpresaEdicionText.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipo", tipoEmpresaEdicionText.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", telefonoEdicionText.Text.Trim());
                    cmd.Parameters.AddWithValue("@fax", faxEdicionText.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", correoEdicionText.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", descripcionEmpresaText.Text.Trim());
                    cmd.Parameters.AddWithValue("@idOriginal", Convert.ToInt32(idOriginal));

                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empresa:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e) { }
    }
}
