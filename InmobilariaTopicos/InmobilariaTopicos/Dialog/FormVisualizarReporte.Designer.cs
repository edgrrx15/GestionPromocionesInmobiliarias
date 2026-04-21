namespace InmobilariaTopicos.UsersControl
{
    partial class FormVisualizarReporte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle hStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTop        = new System.Windows.Forms.Panel();
            this.lblTitulo       = new System.Windows.Forms.Label();
            this.lblSubtitulo    = new System.Windows.Forms.Label();
            this.btnGuardar      = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar       = new Guna.UI2.WinForms.Guna2Button();
            this.gridPrevia      = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottom     = new System.Windows.Forms.Panel();
            this.lblConteo       = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrevia)).BeginInit();
            this.SuspendLayout();

            // ── Form ─────────────────────────────────────────────────────────
            this.BackColor       = System.Drawing.Color.FromArgb(238, 243, 251);
            this.ClientSize      = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.gridPrevia);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize     = new System.Drawing.Size(900, 500);
            this.Name            = "FormVisualizarReporte";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Vista Previa — Reporte";
            this.WindowState     = System.Windows.Forms.FormWindowState.Maximized;

            // ── panelTop ─────────────────────────────────────────────────────
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblSubtitulo);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.btnGuardar);
            this.panelTop.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height   = 80;
            this.panelTop.Name     = "panelTop";
            this.panelTop.Padding  = new System.Windows.Forms.Padding(24, 12, 24, 12);

            // ── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Font      = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitulo.Location  = new System.Drawing.Point(22, 10);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Text      = "Vista Previa";

            // ── lblSubtitulo ─────────────────────────────────────────────────
            this.lblSubtitulo.AutoSize  = true;
            this.lblSubtitulo.Font      = new System.Drawing.Font("SF Pro Display", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitulo.Location  = new System.Drawing.Point(24, 48);
            this.lblSubtitulo.Name      = "lblSubtitulo";
            this.lblSubtitulo.Text      = "";

            // ── btnGuardar ───────────────────────────────────────────────────
            this.btnGuardar.Anchor     = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.Cursor     = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor  = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnGuardar.Font       = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor  = System.Drawing.Color.White;
            this.btnGuardar.Location   = new System.Drawing.Point(820, 20);
            this.btnGuardar.Name       = "btnGuardar";
            this.btnGuardar.Size       = new System.Drawing.Size(140, 40);
            this.btnGuardar.Text       = "Guardar PDF";
            this.btnGuardar.Click     += new System.EventHandler(this.btnGuardar_Click);

            // ── btnCerrar ────────────────────────────────────────────────────
            this.btnCerrar.Anchor         = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderColor    = System.Drawing.Color.FromArgb(200, 198, 240);
            this.btnCerrar.BorderRadius   = 10;
            this.btnCerrar.BorderThickness = 1;
            this.btnCerrar.Cursor         = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FillColor      = System.Drawing.Color.White;
            this.btnCerrar.Font           = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor      = System.Drawing.Color.FromArgb(100, 88, 255);
            this.btnCerrar.Location       = new System.Drawing.Point(970, 20);
            this.btnCerrar.Name           = "btnCerrar";
            this.btnCerrar.Size           = new System.Drawing.Size(52, 40);
            this.btnCerrar.Text           = "✕";
            this.btnCerrar.Click         += new System.EventHandler(this.btnCerrar_Click);

            // ── gridPrevia ───────────────────────────────────────────────────
            hStyle.BackColor  = System.Drawing.Color.FromArgb(100, 88, 255);
            hStyle.ForeColor  = System.Drawing.Color.White;
            hStyle.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            hStyle.WrapMode   = System.Windows.Forms.DataGridViewTriState.False;

            rStyle.BackColor        = System.Drawing.Color.White;
            rStyle.ForeColor        = System.Drawing.Color.FromArgb(35, 35, 35);
            rStyle.Font             = new System.Drawing.Font("Segoe UI", 9F);
            rStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            rStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);

            this.gridPrevia.AllowUserToAddRows    = false;
            this.gridPrevia.AllowUserToDeleteRows = false;
            this.gridPrevia.ReadOnly              = true;
            this.gridPrevia.MultiSelect           = false;
            this.gridPrevia.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrevia.RowHeadersVisible     = false;
            this.gridPrevia.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrevia.BackgroundColor       = System.Drawing.Color.FromArgb(238, 243, 251);
            this.gridPrevia.ColumnHeadersDefaultCellStyle = hStyle;
            this.gridPrevia.DefaultCellStyle      = rStyle;
            this.gridPrevia.ColumnHeadersHeight   = 40;
            this.gridPrevia.RowTemplate.Height    = 34;
            this.gridPrevia.GridColor             = System.Drawing.Color.FromArgb(220, 218, 248);
            this.gridPrevia.Dock                  = System.Windows.Forms.DockStyle.Fill;
            this.gridPrevia.Name                  = "gridPrevia";
            this.gridPrevia.Padding               = new System.Windows.Forms.Padding(0, 80, 0, 50);

            // ── panelBottom ──────────────────────────────────────────────────
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.lblConteo);
            this.panelBottom.Dock    = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height  = 44;
            this.panelBottom.Name    = "panelBottom";

            // ── lblConteo ────────────────────────────────────────────────────
            this.lblConteo.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblConteo.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblConteo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblConteo.Name      = "lblConteo";
            this.lblConteo.Padding   = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.lblConteo.Text      = "0 registros";
            this.lblConteo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrevia)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel  panelTop;
        private System.Windows.Forms.Label  lblTitulo;
        private System.Windows.Forms.Label  lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2DataGridView gridPrevia;
        private System.Windows.Forms.Panel  panelBottom;
        private System.Windows.Forms.Label  lblConteo;
    }
}
