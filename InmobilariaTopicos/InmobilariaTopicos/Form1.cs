using Guna.UI2.WinForms;
using InmobilariaTopicos.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobilariaTopicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardBoton.PerformClick();
        }

        private void ResaltarBoton(Guna2Button botonActivo)
        {
            foreach (Control ctrl in botonActivo.Parent.Controls)
            {
                if (ctrl is Guna2Button)
                {
                    ((Guna2Button)ctrl).FillColor = Color.Transparent;
                }
            }
            botonActivo.FillColor = Color.FromArgb(229, 239, 255);
        }

        private void CargarUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(uc);
            uc.BringToFront();
        }

        private void dashboardBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new InicioDashBoard());
        }

        private void promosBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Promciones());
        }

        private void viviendasBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Viviendas());
        }

        private void empresasBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Empresas());
        }

        private void contratosBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Contratos());
        }

        private void exportarBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Descargas());
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void promotorasBoton_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Guna2Button)sender);
            CargarUserControl(new Promotora());
        }
    }
}
