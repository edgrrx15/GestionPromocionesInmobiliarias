using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data; // Asumo que aquí está conexion

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormEliminarPromotora : Form
    {
        private conexion con = new conexion();
        private int idPromotora;

        public FormEliminarPromotora(int id)
        {
            InitializeComponent();
            idPromotora = id;
            lblMensaje.Text = $"¿Estás seguro de que deseas eliminar la promotora con ID: {id}?\n\nEsta acción no se puede deshacer.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection connection = con.conectar())
                {
                    string sql = "DELETE FROM PROMOTORA WHERE ID_PROMOTORA = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idPromotora);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la promotora para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                //lanzara este error cuando la promotora tenga asociada una promocion
                MessageBox.Show("Asegurate que no tenga una promocion asociada.\n\n" + ex.Message, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
