using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using topicos_autosbd.Data;

namespace InmobilariaTopicos.UsersControl
{
    public partial class Viviendas : UserControl
    {
        private conexion con = new conexion();

        public Viviendas()
        {
            InitializeComponent();
            this.Load += Viviendas_Load;
        }

        private void Viviendas_Load(object sender, EventArgs e)
        {
            CargarViviendas();
            // Búsqueda en tiempo real
            buscarEmpresaText.TextChanged += (s, ev) => CargarViviendas(buscarEmpresaText.Text.Trim());
            // Botón agregar
            guardarBoton.Click += guardarBoton_Click;
        }

        // ─── LEER / RENDERIZAR TARJETAS ──────────────────────────────────────────
        public void CargarViviendas(string filtro = "")
        {
            flowPanel.Controls.Clear();

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    // Consulta con JOIN para obtener el nombre de la promoción y filtro por nombre, promoción o estado
                    // el V. es un alias para la tabla VIVIENDA y P. para PROMOCION, lo que hace el código más legible, no hace ninguna funcion pero ayuda a entender que tabla se esta utilizando en cada campo
                    string sql = @"

                        SELECT V.ID_VIVIENDA, V.NOMBRE, P.NOMBRE AS PROMOCION,
                               V.SUPERFICIE, V.NUM_HABITACIONES, V.NUM_BANIOS,
                               V.EXTRAS, V.PRECIO, V.ESTADO, V.OBSERVACIONES
                        FROM VIVIENDA V
                        INNER JOIN PROMOCION P ON V.COD_PROMOCION = P.COD_PROMOCION
                        WHERE V.NOMBRE LIKE @filtro
                           OR P.NOMBRE LIKE @filtro
                           OR V.ESTADO LIKE @filtro";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["ID_VIVIENDA"]);
                        string nombre = row["NOMBRE"]?.ToString() ?? "Sin nombre";
                        string promocion = row["PROMOCION"]?.ToString() ?? "";
                        string superficie = row["SUPERFICIE"].ToString() + " m²";
                        string habitaciones = row["NUM_HABITACIONES"].ToString();
                        string banios = row["NUM_BANIOS"].ToString();
                        string extras = row["EXTRAS"]?.ToString() ?? "—";
                        string precio = row["PRECIO"].ToString();
                        string estado = row["ESTADO"]? .ToString() ?? "Disponible";
                        string observaciones = row["OBSERVACIONES"]?.ToString() ?? "Ninguna";

                        ViviendaCard card = new ViviendaCard();
                        card.CargarDatos(id, nombre, promocion, superficie, habitaciones, banios, extras, precio, estado);

                        // Asignar eventos de los botones de la tarjeta
                        card.EditarClicked += (s, e) =>
                        {
                            using (var modal = new FormEditarVivienda(id))
                            {
                                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    CargarViviendas(buscarEmpresaText.Text.Trim());
                            }
                        };

                        card.VerFichaClicked += (s, e) =>
                        {
                            using (var modal = new FormVerVivienda(nombre, promocion, estado, superficie, precio, habitaciones, banios, extras, observaciones))
                            {
                                modal.ShowDialog();
                            }
                        };

                        flowPanel.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar viviendas:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── BOTÓN AGREGAR VIVIENDA ───────────────────────────────────────────────
        private void guardarBoton_Click(object sender, EventArgs e)
        {
            using (var modal = new FormAgregarVivienda())
            {
                if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    CargarViviendas();
            }
        }
    }
}
