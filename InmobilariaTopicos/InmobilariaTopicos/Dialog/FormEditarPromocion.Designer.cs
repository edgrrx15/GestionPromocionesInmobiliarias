namespace InmobilariaTopicos.UsersControl
{
    partial class FormEditarPromocion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components         = new System.ComponentModel.Container();
            this.lblTitle           = new System.Windows.Forms.Label();
            this.lblCodigo          = new System.Windows.Forms.Label();
            this.codigoInternoText  = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre          = new System.Windows.Forms.Label();
            this.nombrePromoText    = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPoblacion       = new System.Windows.Forms.Label();
            this.poblacionText      = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPromotora       = new System.Windows.Forms.Label();
            this.cbPromotora        = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPlanoLabel      = new System.Windows.Forms.Label();
            this.txtRutaPlano       = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubirPlano      = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar         = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar        = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral       = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1       = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2       = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();

            // ── Form ────────────────────────────────────────────────────────────
            this.BackColor       = System.Drawing.Color.FromArgb(238, 243, 251);
            this.ClientSize      = new System.Drawing.Size(560, 460);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name            = "FormEditarPromocion";
            this.Padding         = new System.Windows.Forms.Padding(10);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Editar Promocion";

            // ── panelCentral ────────────────────────────────────────────────────
            this.panelCentral.BackColor    = System.Drawing.Color.White;
            this.panelCentral.BorderRadius = 15;
            this.panelCentral.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location     = new System.Drawing.Point(10, 10);
            this.panelCentral.Name         = "panelCentral";
            this.panelCentral.Size         = new System.Drawing.Size(540, 440);
            this.panelCentral.TabIndex     = 0;
            this.panelCentral.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle,
                this.lblCodigo,    this.codigoInternoText,
                this.lblNombre,    this.nombrePromoText,
                this.lblPoblacion, this.poblacionText,
                this.lblPromotora, this.cbPromotora,
                this.lblPlanoLabel, this.txtRutaPlano, this.btnSubirPlano,
                this.btnCancelar,  this.btnGuardar
            });

            // ── Titulo ──────────────────────────────────────────────────────────
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Text      = "Editar promocion";

            // ── Codigo | Nombre ─────────────────────────────────────────────────
            this.lblCodigo.AutoSize  = true;
            this.lblCodigo.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCodigo.Location  = new System.Drawing.Point(22, 68);
            this.lblCodigo.Name      = "lblCodigo";
            this.lblCodigo.Text      = "Código interno";

            this.codigoInternoText.BorderRadius    = 10;
            this.codigoInternoText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.codigoInternoText.ForeColor       = System.Drawing.Color.FromArgb(100, 116, 139);
            this.codigoInternoText.Location        = new System.Drawing.Point(25, 85);
            this.codigoInternoText.Name            = "codigoInternoText";
            this.codigoInternoText.PlaceholderText = "Ej. PRO-001";
            this.codigoInternoText.Size            = new System.Drawing.Size(225, 36);

            this.lblNombre.AutoSize  = true;
            this.lblNombre.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNombre.Location  = new System.Drawing.Point(268, 68);
            this.lblNombre.Name      = "lblNombre";
            this.lblNombre.Text      = "Nombre";

            this.nombrePromoText.BorderRadius    = 10;
            this.nombrePromoText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.nombrePromoText.ForeColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.nombrePromoText.Location        = new System.Drawing.Point(268, 85);
            this.nombrePromoText.Name            = "nombrePromoText";
            this.nombrePromoText.PlaceholderText = "Ej. Residencial Norte";
            this.nombrePromoText.Size            = new System.Drawing.Size(240, 36);

            // ── Poblacion | Promotora ───────────────────────────────────────────
            this.lblPoblacion.AutoSize  = true;
            this.lblPoblacion.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblPoblacion.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPoblacion.Location  = new System.Drawing.Point(22, 136);
            this.lblPoblacion.Name      = "lblPoblacion";
            this.lblPoblacion.Text      = "Poblacion";

            this.poblacionText.BorderRadius    = 10;
            this.poblacionText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.poblacionText.ForeColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.poblacionText.Location        = new System.Drawing.Point(25, 153);
            this.poblacionText.Name            = "poblacionText";
            this.poblacionText.PlaceholderText = "Ej. Tijuana";
            this.poblacionText.Size            = new System.Drawing.Size(225, 36);

            this.lblPromotora.AutoSize  = true;
            this.lblPromotora.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblPromotora.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPromotora.Location  = new System.Drawing.Point(268, 136);
            this.lblPromotora.Name      = "lblPromotora";
            this.lblPromotora.Text      = "Promotora";

            this.cbPromotora.BorderRadius  = 10;
            this.cbPromotora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPromotora.Font          = new System.Drawing.Font("SF Pro Display", 9F);
            this.cbPromotora.ForeColor     = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cbPromotora.Location      = new System.Drawing.Point(268, 153);
            this.cbPromotora.Name          = "cbPromotora";
            this.cbPromotora.Size          = new System.Drawing.Size(240, 36);

            // ── Plano ───────────────────────────────────────────────────────────
            this.lblPlanoLabel.AutoSize  = true;
            this.lblPlanoLabel.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblPlanoLabel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPlanoLabel.Location  = new System.Drawing.Point(22, 205);
            this.lblPlanoLabel.Name      = "lblPlanoLabel";
            this.lblPlanoLabel.Text      = "Plano / documento (opcional)";

            this.txtRutaPlano.BorderRadius    = 10;
            this.txtRutaPlano.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.txtRutaPlano.ForeColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtRutaPlano.Location        = new System.Drawing.Point(25, 222);
            this.txtRutaPlano.Name            = "txtRutaPlano";
            this.txtRutaPlano.PlaceholderText = "Ruta del archivo...";
            this.txtRutaPlano.ReadOnly        = true;
            this.txtRutaPlano.Size            = new System.Drawing.Size(340, 36);

            this.btnSubirPlano.BorderColor     = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnSubirPlano.BorderRadius    = 10;
            this.btnSubirPlano.BorderThickness = 1;
            this.btnSubirPlano.Cursor          = System.Windows.Forms.Cursors.Hand;
            this.btnSubirPlano.FillColor       = System.Drawing.Color.White;
            this.btnSubirPlano.Font            = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubirPlano.ForeColor       = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnSubirPlano.Location        = new System.Drawing.Point(374, 222);
            this.btnSubirPlano.Name            = "btnSubirPlano";
            this.btnSubirPlano.Size            = new System.Drawing.Size(134, 36);
            this.btnSubirPlano.Text            = "Subir archivo";
            this.btnSubirPlano.Click          += new System.EventHandler(this.btnSubirPlano_Click);

            // ── Botones ─────────────────────────────────────────────────────────
            this.btnCancelar.BorderColor     = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.BorderRadius    = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.Cursor          = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FillColor       = System.Drawing.Color.White;
            this.btnCancelar.Font            = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor       = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.Location        = new System.Drawing.Point(280, 372);
            this.btnCancelar.Name            = "btnCancelar";
            this.btnCancelar.Size            = new System.Drawing.Size(120, 40);
            this.btnCancelar.Text            = "Cancelar";
            this.btnCancelar.Click          += new System.EventHandler(this.btnCancelar_Click);

            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.Cursor       = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor    = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnGuardar.Font         = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor    = System.Drawing.Color.White;
            this.btnGuardar.Location     = new System.Drawing.Point(408, 372);
            this.btnGuardar.Name         = "btnGuardar";
            this.btnGuardar.Size         = new System.Drawing.Size(120, 40);
            this.btnGuardar.Text         = "Guardar";
            this.btnGuardar.Click       += new System.EventHandler(this.btnGuardar_Click);

            // ── Elipses para bordes redondeados ────────────────────────────────
            this.guna2Elipse1.BorderRadius  = 18;
            this.guna2Elipse1.TargetControl = this;
            this.guna2Elipse2.BorderRadius  = 12;
            this.guna2Elipse2.TargetControl = this.panelCentral;

            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCodigo;
        private Guna.UI2.WinForms.Guna2TextBox codigoInternoText;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox nombrePromoText;
        private System.Windows.Forms.Label lblPoblacion;
        private Guna.UI2.WinForms.Guna2TextBox poblacionText;
        private System.Windows.Forms.Label lblPromotora;
        private Guna.UI2.WinForms.Guna2ComboBox cbPromotora;
        private System.Windows.Forms.Label lblPlanoLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtRutaPlano;
        private Guna.UI2.WinForms.Guna2Button btnSubirPlano;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
