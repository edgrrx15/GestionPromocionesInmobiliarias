namespace InmobilariaTopicos.UsersControl
{
    partial class Descargas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titlePromo = new System.Windows.Forms.Label();
            this.subPromo = new System.Windows.Forms.Label();
            this.heroCard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVistaPrevia = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarPDF = new Guna.UI2.WinForms.Guna2Button();
            this.tipoPromocionCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaInicial = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboTipoReporteCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPortafolioTitle = new System.Windows.Forms.Label();
            this.panelResumen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblResultadosLabel = new System.Windows.Forms.Label();
            this.lblTipoValor = new System.Windows.Forms.Label();
            this.lblTipoLabel = new System.Windows.Forms.Label();
            this.lblFormatoValor = new System.Windows.Forms.Label();
            this.lblFormatoLabel = new System.Windows.Forms.Label();
            this.lblRangoValor = new System.Windows.Forms.Label();
            this.lblRangoLabel = new System.Windows.Forms.Label();
            this.lblResumenTitle = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.heroCard.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePromo
            // 
            this.titlePromo.AutoSize = true;
            this.titlePromo.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.titlePromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titlePromo.Location = new System.Drawing.Point(-5, 0);
            this.titlePromo.Name = "titlePromo";
            this.titlePromo.Size = new System.Drawing.Size(239, 29);
            this.titlePromo.TabIndex = 14;
            this.titlePromo.Text = "Centro de descargas";
            // 
            // subPromo
            // 
            this.subPromo.AutoSize = true;
            this.subPromo.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.subPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subPromo.Location = new System.Drawing.Point(0, 29);
            this.subPromo.Name = "subPromo";
            this.subPromo.Size = new System.Drawing.Size(218, 17);
            this.subPromo.TabIndex = 13;
            this.subPromo.Text = "Exportar informacion en formato PDF";
            // 
            // heroCard
            // 
            this.heroCard.BackColor = System.Drawing.Color.Transparent;
            this.heroCard.BorderRadius = 24;
            this.heroCard.Controls.Add(this.btnLimpiar);
            this.heroCard.Controls.Add(this.btnVistaPrevia);
            this.heroCard.Controls.Add(this.btnGuardarPDF);
            this.heroCard.Controls.Add(this.tipoPromocionCombo);
            this.heroCard.Controls.Add(this.label1);
            this.heroCard.Controls.Add(this.fechaFinal);
            this.heroCard.Controls.Add(this.label3);
            this.heroCard.Controls.Add(this.fechaInicial);
            this.heroCard.Controls.Add(this.comboTipoReporteCombo);
            this.heroCard.Controls.Add(this.label2);
            this.heroCard.Controls.Add(this.lblPortafolioTitle);
            this.heroCard.CustomBorderColor = System.Drawing.Color.Transparent;
            this.heroCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(247)))), ((int)(((byte)(9)))));
            this.heroCard.Location = new System.Drawing.Point(0, 68);
            this.heroCard.Margin = new System.Windows.Forms.Padding(0, 3, 24, 24);
            this.heroCard.Name = "heroCard";
            this.heroCard.Padding = new System.Windows.Forms.Padding(24);
            this.heroCard.ShadowDecoration.BorderRadius = 24;
            this.heroCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.heroCard.Size = new System.Drawing.Size(536, 285);
            this.heroCard.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.BorderThickness = 1;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FillColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Location = new System.Drawing.Point(27, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 36);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnVistaPrevia.BorderRadius = 10;
            this.btnVistaPrevia.BorderThickness = 1;
            this.btnVistaPrevia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaPrevia.FillColor = System.Drawing.Color.White;
            this.btnVistaPrevia.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnVistaPrevia.Location = new System.Drawing.Point(265, 220);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(118, 36);
            this.btnVistaPrevia.TabIndex = 40;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.BorderRadius = 10;
            this.btnGuardarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnGuardarPDF.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPDF.Location = new System.Drawing.Point(390, 220);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(118, 36);
            this.btnGuardarPDF.TabIndex = 2;
            this.btnGuardarPDF.Text = "Generar PDF";
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // tipoPromocionCombo
            // 
            this.tipoPromocionCombo.BackColor = System.Drawing.Color.Transparent;
            this.tipoPromocionCombo.BorderRadius = 18;
            this.tipoPromocionCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipoPromocionCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipoPromocionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPromocionCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipoPromocionCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipoPromocionCombo.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.tipoPromocionCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tipoPromocionCombo.ItemHeight = 30;
            this.tipoPromocionCombo.Location = new System.Drawing.Point(276, 48);
            this.tipoPromocionCombo.Name = "tipoPromocionCombo";
            this.tipoPromocionCombo.Size = new System.Drawing.Size(230, 36);
            this.tipoPromocionCombo.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filtro adicional";
            // 
            // fechaFinal
            // 
            this.fechaFinal.BorderRadius = 18;
            this.fechaFinal.Checked = true;
            this.fechaFinal.FillColor = System.Drawing.Color.White;
            this.fechaFinal.Font = new System.Drawing.Font("SF Pro Display", 9F);
            this.fechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(276, 118);
            this.fechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(232, 40);
            this.fechaFinal.TabIndex = 34;
            this.fechaFinal.Value = new System.DateTime(2026, 4, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(273, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha final";
            // 
            // fechaInicial
            // 
            this.fechaInicial.BorderRadius = 18;
            this.fechaInicial.Checked = true;
            this.fechaInicial.FillColor = System.Drawing.Color.White;
            this.fechaInicial.Font = new System.Drawing.Font("SF Pro Display", 9F);
            this.fechaInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.fechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicial.Location = new System.Drawing.Point(27, 118);
            this.fechaInicial.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaInicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(230, 40);
            this.fechaInicial.TabIndex = 32;
            this.fechaInicial.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // comboTipoReporteCombo
            // 
            this.comboTipoReporteCombo.BackColor = System.Drawing.Color.Transparent;
            this.comboTipoReporteCombo.BorderRadius = 18;
            this.comboTipoReporteCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboTipoReporteCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipoReporteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoReporteCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTipoReporteCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTipoReporteCombo.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.comboTipoReporteCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTipoReporteCombo.ItemHeight = 30;
            this.comboTipoReporteCombo.Location = new System.Drawing.Point(27, 48);
            this.comboTipoReporteCombo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.comboTipoReporteCombo.Name = "comboTipoReporteCombo";
            this.comboTipoReporteCombo.Size = new System.Drawing.Size(230, 36);
            this.comboTipoReporteCombo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha inicial";
            // 
            // lblPortafolioTitle
            // 
            this.lblPortafolioTitle.AutoSize = true;
            this.lblPortafolioTitle.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblPortafolioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPortafolioTitle.Location = new System.Drawing.Point(24, 30);
            this.lblPortafolioTitle.Name = "lblPortafolioTitle";
            this.lblPortafolioTitle.Size = new System.Drawing.Size(92, 16);
            this.lblPortafolioTitle.TabIndex = 16;
            this.lblPortafolioTitle.Text = "Tipo de reporte";
            // 
            // panelResumen
            // 
            this.panelResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResumen.BackColor = System.Drawing.Color.Transparent;
            this.panelResumen.BorderRadius = 24;
            this.panelResumen.Controls.Add(this.lblResultados);
            this.panelResumen.Controls.Add(this.lblResultadosLabel);
            this.panelResumen.Controls.Add(this.lblTipoValor);
            this.panelResumen.Controls.Add(this.lblTipoLabel);
            this.panelResumen.Controls.Add(this.lblFormatoValor);
            this.panelResumen.Controls.Add(this.lblFormatoLabel);
            this.panelResumen.Controls.Add(this.lblRangoValor);
            this.panelResumen.Controls.Add(this.lblRangoLabel);
            this.panelResumen.Controls.Add(this.lblResumenTitle);
            this.panelResumen.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panelResumen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelResumen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(247)))), ((int)(((byte)(9)))));
            this.panelResumen.Location = new System.Drawing.Point(562, 68);
            this.panelResumen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Padding = new System.Windows.Forms.Padding(12);
            this.panelResumen.ShadowDecoration.BorderRadius = 24;
            this.panelResumen.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.panelResumen.Size = new System.Drawing.Size(536, 285);
            this.panelResumen.TabIndex = 16;
            // 
            // lblResultados
            // 
            this.lblResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultados.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblResultados.Location = new System.Drawing.Point(280, 140);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(240, 16);
            this.lblResultados.TabIndex = 47;
            this.lblResultados.Text = "0";
            this.lblResultados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultadosLabel
            // 
            this.lblResultadosLabel.AutoSize = true;
            this.lblResultadosLabel.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblResultadosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResultadosLabel.Location = new System.Drawing.Point(16, 140);
            this.lblResultadosLabel.Name = "lblResultadosLabel";
            this.lblResultadosLabel.Size = new System.Drawing.Size(132, 16);
            this.lblResultadosLabel.TabIndex = 46;
            this.lblResultadosLabel.Text = "Registros encontrados";
            // 
            // lblTipoValor
            // 
            this.lblTipoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoValor.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoValor.Location = new System.Drawing.Point(280, 110);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(240, 16);
            this.lblTipoValor.TabIndex = 45;
            this.lblTipoValor.Text = "—";
            this.lblTipoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoLabel
            // 
            this.lblTipoLabel.AutoSize = true;
            this.lblTipoLabel.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblTipoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoLabel.Location = new System.Drawing.Point(16, 110);
            this.lblTipoLabel.Name = "lblTipoLabel";
            this.lblTipoLabel.Size = new System.Drawing.Size(92, 16);
            this.lblTipoLabel.TabIndex = 44;
            this.lblTipoLabel.Text = "Tipo de reporte";
            // 
            // lblFormatoValor
            // 
            this.lblFormatoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormatoValor.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFormatoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormatoValor.Location = new System.Drawing.Point(280, 80);
            this.lblFormatoValor.Name = "lblFormatoValor";
            this.lblFormatoValor.Size = new System.Drawing.Size(240, 16);
            this.lblFormatoValor.TabIndex = 43;
            this.lblFormatoValor.Text = "PDF";
            this.lblFormatoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFormatoLabel
            // 
            this.lblFormatoLabel.AutoSize = true;
            this.lblFormatoLabel.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblFormatoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormatoLabel.Location = new System.Drawing.Point(16, 80);
            this.lblFormatoLabel.Name = "lblFormatoLabel";
            this.lblFormatoLabel.Size = new System.Drawing.Size(53, 16);
            this.lblFormatoLabel.TabIndex = 42;
            this.lblFormatoLabel.Text = "Formato";
            // 
            // lblRangoValor
            // 
            this.lblRangoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRangoValor.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRangoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRangoValor.Location = new System.Drawing.Point(280, 50);
            this.lblRangoValor.Name = "lblRangoValor";
            this.lblRangoValor.Size = new System.Drawing.Size(240, 16);
            this.lblRangoValor.TabIndex = 41;
            this.lblRangoValor.Text = "—";
            this.lblRangoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRangoLabel
            // 
            this.lblRangoLabel.AutoSize = true;
            this.lblRangoLabel.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblRangoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRangoLabel.Location = new System.Drawing.Point(16, 50);
            this.lblRangoLabel.Name = "lblRangoLabel";
            this.lblRangoLabel.Size = new System.Drawing.Size(101, 16);
            this.lblRangoLabel.TabIndex = 40;
            this.lblRangoLabel.Text = "Rango de fechas";
            // 
            // lblResumenTitle
            // 
            this.lblResumenTitle.AutoSize = true;
            this.lblResumenTitle.Font = new System.Drawing.Font("SF Pro Display", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblResumenTitle.Location = new System.Drawing.Point(15, 12);
            this.lblResumenTitle.Name = "lblResumenTitle";
            this.lblResumenTitle.Size = new System.Drawing.Size(244, 23);
            this.lblResumenTitle.TabIndex = 17;
            this.lblResumenTitle.Text = "Configuracion de descarga";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.panelResumen);
            this.panelMain.Controls.Add(this.heroCard);
            this.panelMain.Controls.Add(this.subPromo);
            this.panelMain.Controls.Add(this.titlePromo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 24, 12);
            this.panelMain.Size = new System.Drawing.Size(1125, 902);
            this.panelMain.TabIndex = 3;
            // 
            // Descargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Descargas";
            this.Size = new System.Drawing.Size(1125, 902);
            this.heroCard.ResumeLayout(false);
            this.heroCard.PerformLayout();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label   titlePromo;
        private System.Windows.Forms.Label   subPromo;
        private Guna.UI2.WinForms.Guna2GradientPanel heroCard;
        private Guna.UI2.WinForms.Guna2ComboBox tipoPromocionCombo;
        private System.Windows.Forms.Label   label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaFinal;
        private System.Windows.Forms.Label   label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaInicial;
        private Guna.UI2.WinForms.Guna2ComboBox comboTipoReporteCombo;
        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.Label   lblPortafolioTitle;
        private Guna.UI2.WinForms.Guna2Button btnGuardarPDF;
        private Guna.UI2.WinForms.Guna2Button btnVistaPrevia;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2GradientPanel panelResumen;
        private System.Windows.Forms.Label   lblResumenTitle;
        private System.Windows.Forms.Label   lblRangoLabel;
        private System.Windows.Forms.Label   lblRangoValor;
        private System.Windows.Forms.Label   lblFormatoLabel;
        private System.Windows.Forms.Label   lblFormatoValor;
        private System.Windows.Forms.Label   lblTipoLabel;
        private System.Windows.Forms.Label   lblTipoValor;
        private System.Windows.Forms.Label   lblResultadosLabel;
        private System.Windows.Forms.Label   lblResultados;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}
