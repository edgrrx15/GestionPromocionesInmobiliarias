namespace InmobilariaTopicos.UsersControl
{
    partial class FormEditarEmpresa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components              = new System.ComponentModel.Container();
            this.lblTitle                = new System.Windows.Forms.Label();
            this.lblTipo                 = new System.Windows.Forms.Label();
            this.idEmpresaEdicionText    = new Guna.UI2.WinForms.Guna2TextBox();
            this.nombreEmpresaEdicionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.tipoEmpresaEdicionText  = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar              = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar             = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral            = new Guna.UI2.WinForms.Guna2Panel();
            this.label4                  = new System.Windows.Forms.Label();
            this.label3                  = new System.Windows.Forms.Label();
            this.label2                  = new System.Windows.Forms.Label();
            this.guna2Elipse1            = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2            = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.telefonoEdicionText     = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5                  = new System.Windows.Forms.Label();
            this.correoEdicionText       = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6                  = new System.Windows.Forms.Label();
            this.faxEdicionText          = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7                  = new System.Windows.Forms.Label();
            this.descripcionEmpresaText  = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.BackColor       = System.Drawing.Color.FromArgb(238, 243, 251);
            this.ClientSize      = new System.Drawing.Size(450, 432);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name            = "FormEditarEmpresa";
            this.Padding         = new System.Windows.Forms.Padding(10);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Editar Empresa";

            // panelCentral
            this.panelCentral.BackColor    = System.Drawing.Color.White;
            this.panelCentral.BorderRadius  = 15;
            this.panelCentral.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location     = new System.Drawing.Point(10, 10);
            this.panelCentral.Name         = "panelCentral";
            this.panelCentral.Size         = new System.Drawing.Size(430, 412);
            this.panelCentral.TabIndex     = 0;
            this.panelCentral.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.descripcionEmpresaText, this.correoEdicionText, this.label6,
                this.faxEdicionText, this.label7, this.telefonoEdicionText, this.label5,
                this.label4, this.label3, this.label2,
                this.btnGuardar, this.btnCancelar,
                this.tipoEmpresaEdicionText, this.lblTipo,
                this.nombreEmpresaEdicionText,
                this.idEmpresaEdicionText, this.lblTitle
            });

            // Titulo
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Text      = "Editar empresa";

            this.label2.AutoSize  = true;
            this.label2.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label2.Location  = new System.Drawing.Point(22, 63);
            this.label2.Name      = "label2";
            this.label2.Text      = "ID empresa";

            this.idEmpresaEdicionText.BorderRadius    = 10;
            this.idEmpresaEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.idEmpresaEdicionText.Location        = new System.Drawing.Point(25, 80);
            this.idEmpresaEdicionText.Name            = "idEmpresaEdicionText";
            this.idEmpresaEdicionText.PlaceholderText = "Codigo";
            this.idEmpresaEdicionText.Size            = new System.Drawing.Size(180, 36);

            this.label3.AutoSize  = true;
            this.label3.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label3.Location  = new System.Drawing.Point(217, 63);
            this.label3.Name      = "label3";
            this.label3.Text      = "Nombre";

            this.nombreEmpresaEdicionText.BorderRadius    = 10;
            this.nombreEmpresaEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.nombreEmpresaEdicionText.Location        = new System.Drawing.Point(220, 80);
            this.nombreEmpresaEdicionText.Name            = "nombreEmpresaEdicionText";
            this.nombreEmpresaEdicionText.PlaceholderText = "Nombre";
            this.nombreEmpresaEdicionText.Size            = new System.Drawing.Size(180, 36);

            this.lblTipo.AutoSize  = true;
            this.lblTipo.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblTipo.Location  = new System.Drawing.Point(25, 130);
            this.lblTipo.Name      = "lblTipo";
            this.lblTipo.Text      = "Tipo";

            this.tipoEmpresaEdicionText.BorderRadius    = 10;
            this.tipoEmpresaEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.tipoEmpresaEdicionText.Location        = new System.Drawing.Point(25, 150);
            this.tipoEmpresaEdicionText.Name            = "tipoEmpresaEdicionText";
            this.tipoEmpresaEdicionText.PlaceholderText = "Constructora";
            this.tipoEmpresaEdicionText.Size            = new System.Drawing.Size(180, 36);

            this.label5.AutoSize  = true;
            this.label5.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label5.Location  = new System.Drawing.Point(217, 130);
            this.label5.Name      = "label5";
            this.label5.Text      = "Telefono";

            this.telefonoEdicionText.BorderRadius    = 10;
            this.telefonoEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.telefonoEdicionText.Location        = new System.Drawing.Point(217, 150);
            this.telefonoEdicionText.Name            = "telefonoEdicionText";
            this.telefonoEdicionText.PlaceholderText = "664-000-0000";
            this.telefonoEdicionText.Size            = new System.Drawing.Size(180, 36);

            this.label7.AutoSize  = true;
            this.label7.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label7.Location  = new System.Drawing.Point(25, 194);
            this.label7.Name      = "label7";
            this.label7.Text      = "Fax";

            this.faxEdicionText.BorderRadius    = 10;
            this.faxEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.faxEdicionText.Location        = new System.Drawing.Point(25, 214);
            this.faxEdicionText.Name            = "faxEdicionText";
            this.faxEdicionText.PlaceholderText = "664-000-0001";
            this.faxEdicionText.Size            = new System.Drawing.Size(180, 36);
            this.faxEdicionText.TextChanged    += new System.EventHandler(this.guna2TextBox3_TextChanged);

            this.label6.AutoSize  = true;
            this.label6.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label6.Location  = new System.Drawing.Point(217, 194);
            this.label6.Name      = "label6";
            this.label6.Text      = "Correo";

            this.correoEdicionText.BorderRadius    = 10;
            this.correoEdicionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.correoEdicionText.Location        = new System.Drawing.Point(217, 214);
            this.correoEdicionText.Name            = "correoEdicionText";
            this.correoEdicionText.PlaceholderText = "contacto@empresa.com";
            this.correoEdicionText.Size            = new System.Drawing.Size(180, 36);

            this.label4.AutoSize  = true;
            this.label4.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.label4.Location  = new System.Drawing.Point(25, 258);
            this.label4.Name      = "label4";
            this.label4.Text      = "Direccion";

            this.descripcionEmpresaText.BorderRadius    = 10;
            this.descripcionEmpresaText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.descripcionEmpresaText.Location        = new System.Drawing.Point(28, 275);
            this.descripcionEmpresaText.Name            = "descripcionEmpresaText";
            this.descripcionEmpresaText.PlaceholderText = "Calle, numero, colonia, ciudad...";
            this.descripcionEmpresaText.Size            = new System.Drawing.Size(369, 61);

            this.guna2Elipse1.BorderRadius  = 18;
            this.guna2Elipse1.TargetControl = this;
            this.guna2Elipse2.BorderRadius  = 12;
            this.guna2Elipse2.TargetControl = this.panelCentral;

            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.FillColor    = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnGuardar.Font         = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor    = System.Drawing.Color.White;
            this.btnGuardar.Location     = new System.Drawing.Point(280, 347);
            this.btnGuardar.Name         = "btnGuardar";
            this.btnGuardar.Size         = new System.Drawing.Size(120, 40);
            this.btnGuardar.Text         = "Guardar";
            this.btnGuardar.Click       += new System.EventHandler(this.btnGuardar_Click);

            this.btnCancelar.BorderColor     = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.BorderRadius    = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor       = System.Drawing.Color.White;
            this.btnCancelar.Font            = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor       = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.Location        = new System.Drawing.Point(145, 347);
            this.btnCancelar.Name            = "btnCancelar";
            this.btnCancelar.Size            = new System.Drawing.Size(120, 40);
            this.btnCancelar.Text            = "Cancelar";
            this.btnCancelar.Click          += new System.EventHandler(this.btnCancelar_Click);

            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTipo;
        private Guna.UI2.WinForms.Guna2TextBox idEmpresaEdicionText;
        private Guna.UI2.WinForms.Guna2TextBox nombreEmpresaEdicionText;
        private Guna.UI2.WinForms.Guna2TextBox tipoEmpresaEdicionText;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel panelCentral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox telefonoEdicionText;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox correoEdicionText;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox faxEdicionText;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox descripcionEmpresaText;
    }
}
