using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.Dialog
{
    public partial class FormEliminarEmpresa : Form
    {
        private conexion con = new conexion();
        private int idEmpresa;

        public FormEliminarEmpresa(int id)
        {
            InitializeComponent();
            idEmpresa = id;
            lblMensaje.Text = $"\u00bfEst\u00e1s seguro de que deseas eliminar\nla empresa con ID: {id}?\n\nEsta acci\u00f3n no se puede deshacer.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = "DELETE FROM EMPRESA WHERE ID_EMPRESA = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idEmpresa);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontr\u00f3 la empresa para eliminar.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar.\nAseg\u00farese de que no tenga contratos activos.\n\n" + ex.Message,
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
