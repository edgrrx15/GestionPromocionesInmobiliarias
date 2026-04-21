using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InmobilariaTopicos.UsersControl
{
    public partial class ViviendaCard : UserControl
    {
        public int IdVivienda { get; set; }
        public event EventHandler EditarClicked; // Evento para editar, se suscribe desde Viviendas.cs
        public event EventHandler VerFichaClicked; // Evento para ver ficha, se suscribe desde Viviendas.cs

        public ViviendaCard()
        {
            InitializeComponent();
        }

        public void CargarDatos(int id, string nombre, string promocion, string superficie, string habitaciones, string banios, string extras, string precio, string estado)
        {
            IdVivienda = id;
            lblNombre.Text = nombre;
            lblPromocion.Text = promocion;
            
            lblSuperficieValor.Text = superficie;
            lblHabitacionesValor.Text = habitaciones;
            lblBaniosValor.Text = banios;
            lblExtrasValor.Text = extras;
            
            lblPrecio.Text = decimal.TryParse(precio, out decimal p) ? p.ToString("C0") : "$" + precio;

            lblEstado.Text = estado;
            if (estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase))
            {
                lblEstado.ForeColor = Color.FromArgb(16, 185, 129); // Green
                lblEstado.BackColor = Color.FromArgb(209, 250, 229);
            }
            else if (estado.Equals("Reservada", StringComparison.OrdinalIgnoreCase))
            {
                lblEstado.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                lblEstado.BackColor = Color.FromArgb(219, 234, 254);
            }
            else if (estado.Equals("Premium", StringComparison.OrdinalIgnoreCase))
            {
                lblEstado.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                lblEstado.BackColor = Color.FromArgb(254, 243, 199);
            }
            else
            {
                lblEstado.ForeColor = Color.DimGray;
                lblEstado.BackColor = Color.Gainsboro;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            VerFichaClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
