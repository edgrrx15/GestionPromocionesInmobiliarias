namespace InmobilariaTopicos.Dialog
{
    partial class FormEditarContrato
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components          = new System.ComponentModel.Container();
            this.lblTitle            = new System.Windows.Forms.Label();
            this.lblIdContrato       = new System.Windows.Forms.Label();
            this.idContratoText      = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmpresa          = new System.Windows.Forms.Label();
            this.cbEmpresa           = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPromocion        = new System.Windows.Forms.Label();
            this.cbPromocion         = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblImporte          = new System.Windows.Forms.Label();
            this.importeText         = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblObservaciones    = new System.Windows.Forms.Label();
            this.observacionesText   = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar          = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar         = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral        = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1        = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2        = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();

            // ── Form ────────────────────────────────────────────────────────────
            this.BackColor       = System.Drawing.Color.FromArgb(238, 243, 251);
            this.ClientSize      = new System.Drawing.Size(560, 480);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name            = "FormEditarContrato";
            this.Padding         = new System.Windows.Forms.Padding(10);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Editar Contrato";

            // ── panelCentral ────────────────────────────────────────────────────
            this.panelCentral.BackColor    = System.Drawing.Color.White;
            this.panelCentral.BorderRadius = 15;
            this.panelCentral.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Name         = "panelCentral";
            this.panelCentral.TabIndex     = 0;
            this.panelCentral.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle,
                this.lblIdContrato, this.idContratoText,
                this.lblEmpresa,    this.cbEmpresa,
                this.lblPromocion,  this.cbPromocion,
                this.lblImporte,    this.importeText,
                this.lblObservaciones, this.observacionesText,
                this.btnCancelar,   this.btnGuardar
            });

            // ── Titulo ──────────────────────────────────────────────────────────
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Editar contrato";

            // ── ID Contrato ─────────────────────────────────────────────────────
            this.lblIdContrato.AutoSize  = true;
            this.lblIdContrato.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblIdContrato.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIdContrato.Location  = new System.Drawing.Point(22, 68);
            this.lblIdContrato.Name      = "lblIdContrato";
            this.lblIdContrato.Text      = "ID Contrato";

            this.idContratoText.BorderRadius    = 10;
            this.idContratoText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.idContratoText.ForeColor       = System.Drawing.Color.FromArgb(100, 116, 139);
            this.idContratoText.Location        = new System.Drawing.Point(25, 85);
            this.idContratoText.Name            = "idContratoText";
            this.idContratoText.PlaceholderText = "CON-001";
            this.idContratoText.ReadOnly        = true;
            this.idContratoText.Size            = new System.Drawing.Size(225, 36);

            // ── Importe ─────────────────────────────────────────────────────────
            this.lblImporte.AutoSize  = true;
            this.lblImporte.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblImporte.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblImporte.Location  = new System.Drawing.Point(268, 68);
            this.lblImporte.Name      = "lblImporte";
            this.lblImporte.Text      = "Importe ($)";

            this.importeText.BorderRadius    = 10;
            this.importeText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.importeText.ForeColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.importeText.Location        = new System.Drawing.Point(268, 85);
            this.importeText.Name            = "importeText";
            this.importeText.PlaceholderText = "Ej. 850000";
            this.importeText.Size            = new System.Drawing.Size(240, 36);

            // ── Empresa ─────────────────────────────────────────────────────────
            this.lblEmpresa.AutoSize  = true;
            this.lblEmpresa.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblEmpresa.Location  = new System.Drawing.Point(22, 136);
            this.lblEmpresa.Name      = "lblEmpresa";
            this.lblEmpresa.Text      = "Empresa";

            this.cbEmpresa.BorderRadius  = 10;
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Font          = new System.Drawing.Font("SF Pro Display", 9F);
            this.cbEmpresa.ForeColor     = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cbEmpresa.Location      = new System.Drawing.Point(25, 153);
            this.cbEmpresa.Name          = "cbEmpresa";
            this.cbEmpresa.Size          = new System.Drawing.Size(225, 36);

            // ── Promocion ───────────────────────────────────────────────────────
            this.lblPromocion.AutoSize  = true;
            this.lblPromocion.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblPromocion.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPromocion.Location  = new System.Drawing.Point(268, 136);
            this.lblPromocion.Name      = "lblPromocion";
            this.lblPromocion.Text      = "Promoci\u00f3n";

            this.cbPromocion.BorderRadius  = 10;
            this.cbPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPromocion.Font          = new System.Drawing.Font("SF Pro Display", 9F);
            this.cbPromocion.ForeColor     = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cbPromocion.Location      = new System.Drawing.Point(268, 153);
            this.cbPromocion.Name          = "cbPromocion";
            this.cbPromocion.Size          = new System.Drawing.Size(240, 36);

            // ── Observaciones ───────────────────────────────────────────────────
            this.lblObservaciones.AutoSize  = true;
            this.lblObservaciones.Font      = new System.Drawing.Font("SF Pro Display", 9F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblObservaciones.Location  = new System.Drawing.Point(22, 204);
            this.lblObservaciones.Name      = "lblObservaciones";
            this.lblObservaciones.Text      = "Observaciones";

            this.observacionesText.BorderRadius    = 10;
            this.observacionesText.Font            = new System.Drawing.Font("SF Pro Display", 9F);
            this.observacionesText.ForeColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.observacionesText.Location        = new System.Drawing.Point(25, 221);
            this.observacionesText.Multiline       = true;
            this.observacionesText.Name            = "observacionesText";
            this.observacionesText.PlaceholderText = "Detalles, alcance, fechas, notas...";
            this.observacionesText.Size            = new System.Drawing.Size(483, 90);

            // ── Botones ─────────────────────────────────────────────────────────
            this.btnCancelar.BorderColor     = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.BorderRadius    = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.Cursor          = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FillColor       = System.Drawing.Color.White;
            this.btnCancelar.Font            = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor       = System.Drawing.Color.FromArgb(234, 88, 47);
            this.btnCancelar.Location        = new System.Drawing.Point(288, 400);
            this.btnCancelar.Name            = "btnCancelar";
            this.btnCancelar.Size            = new System.Drawing.Size(120, 40);
            this.btnCancelar.Text            = "Cancelar";
            this.btnCancelar.Click          += new System.EventHandler(this.btnCancelar_Click);

            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.Cursor       = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor    = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnGuardar.Font         = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor    = System.Drawing.Color.White;
            this.btnGuardar.Location     = new System.Drawing.Point(416, 400);
            this.btnGuardar.Name         = "btnGuardar";
            this.btnGuardar.Size         = new System.Drawing.Size(120, 40);
            this.btnGuardar.Text         = "Guardar";
            this.btnGuardar.Click       += new System.EventHandler(this.btnGuardar_Click);

            // ── Elipses ─────────────────────────────────────────────────────────
            this.guna2Elipse1.BorderRadius  = 18;
            this.guna2Elipse1.TargetControl = this;
            this.guna2Elipse2.BorderRadius  = 12;
            this.guna2Elipse2.TargetControl = this.panelCentral;

            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdContrato;
        private Guna.UI2.WinForms.Guna2TextBox idContratoText;
        private System.Windows.Forms.Label lblEmpresa;
        private Guna.UI2.WinForms.Guna2ComboBox cbEmpresa;
        private System.Windows.Forms.Label lblPromocion;
        private Guna.UI2.WinForms.Guna2ComboBox cbPromocion;
        private System.Windows.Forms.Label lblImporte;
        private Guna.UI2.WinForms.Guna2TextBox importeText;
        private System.Windows.Forms.Label lblObservaciones;
        private Guna.UI2.WinForms.Guna2TextBox observacionesText;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
