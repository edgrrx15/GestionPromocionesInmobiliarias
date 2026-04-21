namespace InmobilariaTopicos.UsersControl
{
    partial class FormAgregarVivienda
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.cbPromocion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.txtSuperficie = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.txtHabitaciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBanios = new System.Windows.Forms.Label();
            this.txtBanios = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.txtExtras = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panelSep = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(27, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar vivienda";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 14);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNombre.Location = new System.Drawing.Point(28, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ej. Vivienda B-08";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(280, 40);
            this.txtNombre.TabIndex = 4;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPromocion.Location = new System.Drawing.Point(330, 88);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(66, 14);
            this.lblPromocion.TabIndex = 5;
            this.lblPromocion.Text = "Promoción";
            // 
            // cbPromocion
            // 
            this.cbPromocion.BackColor = System.Drawing.Color.Transparent;
            this.cbPromocion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cbPromocion.BorderRadius = 10;
            this.cbPromocion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPromocion.FocusedColor = System.Drawing.Color.Empty;
            this.cbPromocion.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPromocion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbPromocion.ItemHeight = 30;
            this.cbPromocion.Location = new System.Drawing.Point(330, 107);
            this.cbPromocion.Name = "cbPromocion";
            this.cbPromocion.Size = new System.Drawing.Size(280, 36);
            this.cbPromocion.TabIndex = 6;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperficie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSuperficie.Location = new System.Drawing.Point(28, 162);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(64, 14);
            this.lblSuperficie.TabIndex = 7;
            this.lblSuperficie.Text = "Superficie";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtSuperficie.BorderRadius = 10;
            this.txtSuperficie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuperficie.DefaultText = "";
            this.txtSuperficie.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperficie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSuperficie.Location = new System.Drawing.Point(28, 181);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.PlaceholderText = "Ej. 98";
            this.txtSuperficie.SelectedText = "";
            this.txtSuperficie.Size = new System.Drawing.Size(280, 40);
            this.txtSuperficie.TabIndex = 8;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHabitaciones.Location = new System.Drawing.Point(330, 162);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(81, 14);
            this.lblHabitaciones.TabIndex = 9;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtHabitaciones.BorderRadius = 10;
            this.txtHabitaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHabitaciones.DefaultText = "";
            this.txtHabitaciones.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtHabitaciones.Location = new System.Drawing.Point(330, 181);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.PlaceholderText = "Ej. 3";
            this.txtHabitaciones.SelectedText = "";
            this.txtHabitaciones.Size = new System.Drawing.Size(280, 40);
            this.txtHabitaciones.TabIndex = 10;
            // 
            // lblBanios
            // 
            this.lblBanios.AutoSize = true;
            this.lblBanios.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBanios.Location = new System.Drawing.Point(28, 236);
            this.lblBanios.Name = "lblBanios";
            this.lblBanios.Size = new System.Drawing.Size(42, 14);
            this.lblBanios.TabIndex = 11;
            this.lblBanios.Text = "Baños";
            // 
            // txtBanios
            // 
            this.txtBanios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtBanios.BorderRadius = 10;
            this.txtBanios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanios.DefaultText = "";
            this.txtBanios.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtBanios.Location = new System.Drawing.Point(28, 255);
            this.txtBanios.Name = "txtBanios";
            this.txtBanios.PlaceholderText = "Ej. 2";
            this.txtBanios.SelectedText = "";
            this.txtBanios.Size = new System.Drawing.Size(280, 40);
            this.txtBanios.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEstado.Location = new System.Drawing.Point(330, 236);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 14);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cbEstado.BorderRadius = 10;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cbEstado.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbEstado.ItemHeight = 30;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "Reservada",
            "Vendida",
            "Premium",
            "Nueva"});
            this.cbEstado.Location = new System.Drawing.Point(330, 255);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(280, 36);
            this.cbEstado.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPrecio.Location = new System.Drawing.Point(28, 310);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 14);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtPrecio.BorderRadius = 10;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPrecio.Location = new System.Drawing.Point(28, 329);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "Ej. 2140000";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(280, 40);
            this.txtPrecio.TabIndex = 16;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblExtras.Location = new System.Drawing.Point(330, 310);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(41, 14);
            this.lblExtras.TabIndex = 17;
            this.lblExtras.Text = "Extras";
            // 
            // txtExtras
            // 
            this.txtExtras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtExtras.BorderRadius = 10;
            this.txtExtras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtras.DefaultText = "";
            this.txtExtras.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtExtras.Location = new System.Drawing.Point(330, 329);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.PlaceholderText = "Ej. Jardín privado";
            this.txtExtras.SelectedText = "";
            this.txtExtras.Size = new System.Drawing.Size(280, 40);
            this.txtExtras.TabIndex = 18;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblObservaciones.Location = new System.Drawing.Point(28, 382);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(163, 14);
            this.lblObservaciones.TabIndex = 19;
            this.lblObservaciones.Text = "Descripción / observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtObservaciones.BorderRadius = 10;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.DefaultText = "";
            this.txtObservaciones.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtObservaciones.Location = new System.Drawing.Point(28, 401);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PlaceholderText = "Observaciones adicionales...";
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(582, 70);
            this.txtObservaciones.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnGuardar.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(465, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 40);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar vivienda";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnCancelar.Location = new System.Drawing.Point(369, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 40);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelSep
            // 
            this.panelSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panelSep.Location = new System.Drawing.Point(24, 72);
            this.panelSep.Name = "panelSep";
            this.panelSep.Size = new System.Drawing.Size(590, 1);
            this.panelSep.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormAgregarVivienda
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 570);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelSep);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.cbPromocion);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.lblBanios);
            this.Controls.Add(this.txtBanios);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.txtExtras);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarVivienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Vivienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSep;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblPromocion;
        private Guna.UI2.WinForms.Guna2ComboBox cbPromocion;
        private System.Windows.Forms.Label lblSuperficie;
        private Guna.UI2.WinForms.Guna2TextBox txtSuperficie;
        private System.Windows.Forms.Label lblHabitaciones;
        private Guna.UI2.WinForms.Guna2TextBox txtHabitaciones;
        private System.Windows.Forms.Label lblBanios;
        private Guna.UI2.WinForms.Guna2TextBox txtBanios;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cbEstado;
        private System.Windows.Forms.Label lblPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label lblExtras;
        private Guna.UI2.WinForms.Guna2TextBox txtExtras;
        private System.Windows.Forms.Label lblObservaciones;
        private Guna.UI2.WinForms.Guna2TextBox txtObservaciones;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
