using System;
using System.Windows.Forms;

namespace InmobilariaTopicos.UsersControl
{
    public partial class FormVerVivienda : Form
    {
        public FormVerVivienda(string nombre, string promocion, string estado,
                               string superficie, string precio,
                               string habitaciones, string banios,
                               string extras, string observaciones)
        {
            InitializeComponent();

            // Rellenar los campos de solo lectura
            lblNombreVal.Text = nombre;
            lblPromocionVal.Text = promocion;
            lblEstadoVal.Text = estado;
            lblSuperficieVal.Text = superficie;
            lblPrecioVal.Text = precio.Length > 0 ? "$" + decimal.Parse(precio).ToString("N0") : "—";
            lblHabitacionesVal.Text = habitaciones;
            lblBaniosVal.Text = banios;
            lblExtrasVal.Text = string.IsNullOrWhiteSpace(extras) ? "—" : extras;
            lblObservacionesVal.Text = string.IsNullOrWhiteSpace(observaciones) ? "Sin observaciones." : observaciones;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
