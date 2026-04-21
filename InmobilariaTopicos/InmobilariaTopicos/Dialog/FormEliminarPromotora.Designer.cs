namespace InmobilariaTopicos.UsersControl
{
    partial class FormEliminarPromotora
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
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
            this.lblTitle.Size = new System.Drawing.Size(225, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Eliminar Promotora";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(25, 70);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(330, 80);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "¿Estás seguro de que deseas eliminar?";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.FillColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(210, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(50, 160);
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
            this.panelCentral.Controls.Add(this.btnEliminar);
            this.panelCentral.Controls.Add(this.btnCancelar);
            this.panelCentral.Controls.Add(this.lblMensaje);
            this.panelCentral.Controls.Add(this.lblTitle);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(10, 10);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(380, 230);
            this.panelCentral.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            this.guna2Elipse2.TargetControl = this.panelCentral;
            // 
            // FormEliminarPromotora
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminarPromotora";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMensaje;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
