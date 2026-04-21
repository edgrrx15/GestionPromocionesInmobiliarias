using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.Dialog
{
    public partial class FormEditarContrato : Form
    {
        private conexion con = new conexion();
        private string idOriginal;

        public FormEditarContrato(string idContrato, decimal importe, int idEmpresa, string codPromocion, string observaciones)
        {
            InitializeComponent();
            idOriginal             = idContrato;
            idContratoText.Text    = idContrato;
            importeText.Text       = importe.ToString();
            observacionesText.Text = observaciones ?? "";

            CargarEmpresas();
            CargarPromociones();

            if (idEmpresa > 0)    cbEmpresa.SelectedValue  = idEmpresa;
            if (!string.IsNullOrEmpty(codPromocion)) cbPromocion.SelectedValue = codPromocion;
        }

        private void CargarEmpresas()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT ID_EMPRESA, NOMBRE FROM EMPRESA ORDER BY NOMBRE", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbEmpresa.DataSource    = dt;
                    cbEmpresa.DisplayMember = "NOMBRE";
                    cbEmpresa.ValueMember   = "ID_EMPRESA";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empresas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPromociones()
        {
            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT COD_PROMOCION, NOMBRE FROM PROMOCION ORDER BY NOMBRE", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbPromocion.DataSource    = dt;
                    cbPromocion.DisplayMember = "NOMBRE";
                    cbPromocion.ValueMember   = "COD_PROMOCION";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedValue == null || cbPromocion.SelectedValue == null ||
                string.IsNullOrWhiteSpace(importeText.Text))
            {
                MessageBox.Show("Llene todos los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(importeText.Text.Trim(), out decimal importe))
            {
                MessageBox.Show("El importe debe ser un n\u00famero v\u00e1lido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int    idEmpresa     = Convert.ToInt32(cbEmpresa.SelectedValue);
            string codPromocion  = cbPromocion.SelectedValue.ToString();
            string observaciones = observacionesText.Text.Trim();

            try
            {
                using (SqlConnection conn = con.conectar())
                {
                    string sql = @"UPDATE CONTRATO SET
                        IMPORTE       = @importe,
                        ID_EMPRESA    = @idEmpresa,
                        COD_PROMOCION = @codProm,
                        OBSERVACIONES = @obs
                    WHERE ID_CONTRATO = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@importe",   importe);
                    cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                    cmd.Parameters.AddWithValue("@codProm",   codPromocion);
                    cmd.Parameters.AddWithValue("@obs",       (object)observaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id",        idOriginal);

                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el contrato:\n" + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
