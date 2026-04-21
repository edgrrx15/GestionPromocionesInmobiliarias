using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.Dialog
{
    public partial class FormEliminarContrato : Form
    {
        private conexion con = new conexion();
        private string idContrato;

        public FormEliminarContrato(string id)
        {
            InitializeComponent();
            idContrato = id;
            lblMensaje.Text = $"\u00bfEst\u00e1s seguro de que deseas eliminar\nel contrato \u00ab{id}\u00bb?\n\nEsta acci\u00f3n no se puede deshacer.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = "DELETE FROM CONTRATO WHERE ID_CONTRATO = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idContrato);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontr\u00f3 el contrato para eliminar.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar el contrato.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
