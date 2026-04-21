namespace InmobilariaTopicos.UsersControl
{
    partial class FormEditarPromotora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.nombrePromoText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Editar Promotora";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblNombre.Location = new System.Drawing.Point(25, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 14);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre corporativo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(25, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(95, 17);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID de Sistema: ";
            // 
            // nombrePromoText
            // 
            this.nombrePromoText.BorderRadius = 10;
            this.nombrePromoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombrePromoText.DefaultText = "";
            this.nombrePromoText.Font = new System.Drawing.Font("SF Pro Display", 9F);
            this.nombrePromoText.Location = new System.Drawing.Point(25, 115);
            this.nombrePromoText.Name = "nombrePromoText";
            this.nombrePromoText.PlaceholderText = "Nombre";
            this.nombrePromoText.SelectedText = "";
            this.nombrePromoText.Size = new System.Drawing.Size(325, 36);
            this.nombrePromoText.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnGuardar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(230, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.btnCancelar.Location = new System.Drawing.Point(95, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.BorderRadius = 15;
            this.panelCentral.Controls.Add(this.btnGuardar);
            this.panelCentral.Controls.Add(this.btnCancelar);
            this.panelCentral.Controls.Add(this.lblNombre);
            this.panelCentral.Controls.Add(this.nombrePromoText);
            this.panelCentral.Controls.Add(this.lblId);
            this.panelCentral.Controls.Add(this.lblTitle);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(10, 10);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(380, 260);
            this.panelCentral.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            this.guna2Elipse2.TargetControl = this.panelCentral;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormEditarPromotora
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarPromotora";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2TextBox nombrePromoText;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
