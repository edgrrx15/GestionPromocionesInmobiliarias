namespace InmobilariaTopicos.UsersControl
{
    partial class Viviendas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guardarBoton = new Guna.UI2.WinForms.Guna2Button();
            this.buscarEmpresaText = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelCardsVivienda = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subPromo = new System.Windows.Forms.Label();
            this.titlePromo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelCardsVivienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.guardarBoton);
            this.panelMain.Controls.Add(this.buscarEmpresaText);
            this.panelMain.Controls.Add(this.panelCardsVivienda);
            this.panelMain.Controls.Add(this.subPromo);
            this.panelMain.Controls.Add(this.titlePromo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 24, 24);
            this.panelMain.Size = new System.Drawing.Size(1157, 700);
            this.panelMain.TabIndex = 2;
            // 
            // guardarBoton
            // 
            this.guardarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardarBoton.BorderRadius = 10;
            this.guardarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBoton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.guardarBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.guardarBoton.ForeColor = System.Drawing.Color.White;
            this.guardarBoton.Image = global::InmobilariaTopicos.Properties.Resources.icons8_add_29__1_;
            this.guardarBoton.Location = new System.Drawing.Point(989, 6);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(141, 40);
            this.guardarBoton.TabIndex = 34;
            this.guardarBoton.Text = "Nueva vivienda";
            // 
            // buscarEmpresaText
            // 
            this.buscarEmpresaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarEmpresaText.BackColor = System.Drawing.Color.Transparent;
            this.buscarEmpresaText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.buscarEmpresaText.BorderRadius = 18;
            this.buscarEmpresaText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscarEmpresaText.DefaultText = "";
            this.buscarEmpresaText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarEmpresaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.buscarEmpresaText.IconLeft = global::InmobilariaTopicos.Properties.Resources.icons8_search_25;
            this.buscarEmpresaText.Location = new System.Drawing.Point(625, 6);
            this.buscarEmpresaText.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.buscarEmpresaText.Name = "buscarEmpresaText";
            this.buscarEmpresaText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.buscarEmpresaText.PlaceholderText = "Buscar una vivienda";
            this.buscarEmpresaText.SelectedText = "";
            this.buscarEmpresaText.Size = new System.Drawing.Size(345, 40);
            this.buscarEmpresaText.TabIndex = 24;
            // 
            // panelCardsVivienda
            // 
            this.panelCardsVivienda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCardsVivienda.AutoScroll = true;
            this.panelCardsVivienda.BackColor = System.Drawing.Color.Transparent;
            this.panelCardsVivienda.BorderRadius = 24;
            this.panelCardsVivienda.Controls.Add(this.flowPanel);
            this.panelCardsVivienda.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panelCardsVivienda.FillColor = System.Drawing.Color.Transparent;
            this.panelCardsVivienda.FillColor2 = System.Drawing.Color.Transparent;
            this.panelCardsVivienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(247)))), ((int)(((byte)(9)))));
            this.panelCardsVivienda.Location = new System.Drawing.Point(5, 68);
            this.panelCardsVivienda.Name = "panelCardsVivienda";
            this.panelCardsVivienda.ShadowDecoration.BorderRadius = 24;
            this.panelCardsVivienda.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.panelCardsVivienda.Size = new System.Drawing.Size(1125, 440);
            this.panelCardsVivienda.TabIndex = 16;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1125, 440);
            this.flowPanel.TabIndex = 0;
            // 
            // subPromo
            // 
            this.subPromo.AutoSize = true;
            this.subPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPromo.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.subPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subPromo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subPromo.Location = new System.Drawing.Point(0, 29);
            this.subPromo.Name = "subPromo";
            this.subPromo.Size = new System.Drawing.Size(172, 17);
            this.subPromo.TabIndex = 13;
            this.subPromo.Text = "Informacion de las viviendas";
            // 
            // titlePromo
            // 
            this.titlePromo.AutoSize = true;
            this.titlePromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePromo.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.titlePromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titlePromo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titlePromo.Location = new System.Drawing.Point(0, 0);
            this.titlePromo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.titlePromo.Name = "titlePromo";
            this.titlePromo.Size = new System.Drawing.Size(254, 29);
            this.titlePromo.TabIndex = 14;
            this.titlePromo.Text = "Catálogo de viviendas";
            // 
            // Viviendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Viviendas";
            this.Size = new System.Drawing.Size(1157, 700);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCardsVivienda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2TextBox buscarEmpresaText;
        private System.Windows.Forms.Label subPromo;
        private System.Windows.Forms.Label titlePromo;
        private Guna.UI2.WinForms.Guna2GradientPanel panelCardsVivienda;
        private Guna.UI2.WinForms.Guna2Button guardarBoton;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
