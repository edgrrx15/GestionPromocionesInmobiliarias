using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using topicos_autosbd.Data;
using System.Data.SqlClient;
using InmobilariaTopicos.Dialog;


namespace InmobilariaTopicos.UsersControl
{
    public partial class Empresas : UserControl
    {
        public Empresas()
        {
            InitializeComponent();
            this.Load += Empresas_Load;
        }

        private void nombrePromoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void heroCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagridViewPromos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guardarEmpresaBoton_Click(object sender, EventArgs e)
        {
            //Validar si esta no esta vacio los 6 campos

            if (string.IsNullOrWhiteSpace(nombreEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(idEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(tipoEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(telefonoEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(faxText.Text) ||
                string.IsNullOrWhiteSpace(correoEmpresaText.Text) ||
                string.IsNullOrWhiteSpace(direccionEmpresaText.Text))
            {
                MessageBox.Show("Por favor llena todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // se abre la conexion a la base de datos
                conexion con = new conexion();
                SqlConnection connection = con.conectar();

                string query = "INSERT INTO EMPRESA (ID_EMPRESA, NOMBRE, TIPO, TELEFONO, FAX, CORREO, DIRECCION) " +
                               "VALUES (@idEmpresa, @nombreEmpresa, @tipoEmpresa, @telefonoEmpresa, @fax, @correoEmpresa, @direccionEmpresa)";

                SqlCommand altas = new SqlCommand(query, connection);

                altas.Parameters.AddWithValue("@idEmpresa", idEmpresaText.Text.Trim());
                altas.Parameters.AddWithValue("@nombreEmpresa", nombreEmpresaText.Text.Trim());
                altas.Parameters.AddWithValue("@tipoEmpresa", tipoEmpresaText.Text.Trim());
                altas.Parameters.AddWithValue("@telefonoEmpresa", telefonoEmpresaText.Text.Trim());
                altas.Parameters.AddWithValue("@fax", faxText.Text.Trim());
                altas.Parameters.AddWithValue("@correoEmpresa", correoEmpresaText.Text.Trim());
                altas.Parameters.AddWithValue("@direccionEmpresa", direccionEmpresaText.Text.Trim());
                altas.ExecuteNonQuery(); // Ejecutar la consulta para insertar la nueva empresa
                MessageBox.Show("Empresa guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarListaEmpresa(); // Actualizar la lista de empresas después de insertar una nueva

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la empresa:\n" + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarDatos()
        {
            idEmpresaText.Clear();
            nombreEmpresaText.Clear();
            tipoEmpresaText.Clear();
            telefonoEmpresaText.Clear();
            faxText.Clear();
            correoEmpresaText.Clear();
            direccionEmpresaText.Clear();
        }

        public void MostrarListaEmpresa()
        {
            try
            {
                conexion con = new conexion();
                SqlConnection conexion = con.conectar();

                string query = "SELECT * FROM EMPRESA";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();

                dataGridView1.DataSource = null;

                if (dt.Rows.Count == 0)
                {
                    dataGridView1.Visible = false;
                    return;
                }

                dataGridView1.Visible = true;
                dataGridView1.DataSource = dt;

                // =========================
                // CONFIGURACION GENERAL
                // =========================
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ScrollBars = ScrollBars.Vertical;

                // Para que entren todas las columnas
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // Alturas
                dataGridView1.ColumnHeadersHeight = 42;
                dataGridView1.RowTemplate.Height = 38;

                // =========================
                // COLORES Y FUENTES
                // =========================
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.GridColor = Color.FromArgb(230, 230, 230);

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(95, 95, 95);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("SF Pro Display", 9F, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(95, 95, 95);

                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView1.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 250);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35);
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Filas alternadas suaves
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 252);

                // =========================
                // CONFIGURAR COLUMNAS
                // =========================
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                    col.MinimumWidth = 60;
                }

                // =========================
                // TITULOS DE COLUMNAS
                // =========================
                if (dataGridView1.Columns.Contains("ID_EMPRESA"))
                    dataGridView1.Columns["ID_EMPRESA"].HeaderText = "ID";

                if (dataGridView1.Columns.Contains("NOMBRE"))
                    dataGridView1.Columns["NOMBRE"].HeaderText = "Nombre";

                if (dataGridView1.Columns.Contains("TIPO"))
                    dataGridView1.Columns["TIPO"].HeaderText = "Tipo";

                if (dataGridView1.Columns.Contains("DIRECCION"))
                    dataGridView1.Columns["DIRECCION"].HeaderText = "Dirección";

                if (dataGridView1.Columns.Contains("TELEFONO"))
                    dataGridView1.Columns["TELEFONO"].HeaderText = "Teléfono";

                if (dataGridView1.Columns.Contains("FAX"))
                    dataGridView1.Columns["FAX"].HeaderText = "Fax";

                if (dataGridView1.Columns.Contains("EMAIL"))
                    dataGridView1.Columns["EMAIL"].HeaderText = "Correo";

                // =========================
                // ANCHOS RELATIVOS
                // AQUI SE CONTROLA QUE DIRECCION
                // NO OCUPE DEMASIADO
                // =========================
                if (dataGridView1.Columns.Contains("ID_EMPRESA"))
                    dataGridView1.Columns["ID_EMPRESA"].FillWeight = 45;

                if (dataGridView1.Columns.Contains("NOMBRE"))
                    dataGridView1.Columns["NOMBRE"].FillWeight = 70;

                if (dataGridView1.Columns.Contains("TIPO"))
                    dataGridView1.Columns["TIPO"].FillWeight = 70;

                if (dataGridView1.Columns.Contains("DIRECCION"))
                    dataGridView1.Columns["DIRECCION"].FillWeight = 80;

                if (dataGridView1.Columns.Contains("TELEFONO"))
                    dataGridView1.Columns["TELEFONO"].FillWeight = 75;

                if (dataGridView1.Columns.Contains("FAX"))
                    dataGridView1.Columns["FAX"].FillWeight = 60;

                if (dataGridView1.Columns.Contains("EMAIL"))
                    dataGridView1.Columns["EMAIL"].FillWeight = 10;

                // =========================
                // ESPACIO VISUAL A LA DERECHA
                // =========================
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width =
                        dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width - 15;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void editarEmpresaBoton_Click(object sender, EventArgs e)
        {
            //Mostrara el modal y bajara la opacidad de todo lo que esta detras del modal y desactivara los botones y campos de texto que estan detras del modal

            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una empresa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idActual = dataGridView1.SelectedRows[0].Cells["ID_EMPRESA"].Value.ToString();
            string nombreActual = dataGridView1.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
            string tipoActual = dataGridView1.SelectedRows[0].Cells["TIPO"].Value.ToString();
            string telefonoActual = dataGridView1.SelectedRows[0].Cells["TELEFONO"].Value.ToString();
            string faxActual = dataGridView1.SelectedRows[0].Cells["FAX"].Value.ToString();
            string correoActual = dataGridView1.SelectedRows[0].Cells["CORREO"].Value.ToString();
            string direccionActual = dataGridView1.SelectedRows[0].Cells["DIRECCION"].Value.ToString();

            using (var modal = new FormEditarEmpresa(idActual, nombreActual, tipoActual, telefonoActual, faxActual, correoActual, direccionActual))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    // Recargar la lista de empresas después de editar
                    MostrarListaEmpresa();
                }
            }
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            MostrarListaEmpresa();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void eliminarEmpresaBoton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una empresa para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpresa = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_EMPRESA"].Value);

            using (var modal = new FormEliminarEmpresa(idEmpresa))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    // Recargar la lista de empresas después de eliminar
                    MostrarListaEmpresa();
                }
            }
        }
    }
}