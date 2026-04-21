using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEliminarPromocion : Form
    {
        private conexion con = new conexion();
        private string codigoPromocion;

        public FormEliminarPromocion(string codigo)
        {
            InitializeComponent();
            codigoPromocion = codigo;
            lblMensaje.Text = $"¿Estás seguro de que deseas eliminar la promoción:\n\n  «{codigo}»\n\nEsta acción no se puede deshacer.";
        }

        // ─── ELIMINAR ────────────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = "DELETE FROM PROMOCION WHERE COD_PROMOCION = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cod", codigoPromocion);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la promoción para eliminar.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar.\nAsegúrese de que no tenga dependencias activas (Viviendas).\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
