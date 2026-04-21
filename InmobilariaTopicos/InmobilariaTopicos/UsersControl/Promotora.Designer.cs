namespace InmobilariaTopicos.UsersControl
{
    partial class Promotora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.BuscarPromotoraText = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelDatos = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.datagridViewPromos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.heroCard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nombrePromoText = new Guna.UI2.WinForms.Guna2TextBox();
            this.eliminarPromoBoton = new Guna.UI2.WinForms.Guna2Button();
            this.editarPromoBoton = new Guna.UI2.WinForms.Guna2Button();
            this.guardarBoton = new Guna.UI2.WinForms.Guna2Button();
            this.subPromo = new System.Windows.Forms.Label();
            this.titlePromo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPromos)).BeginInit();
            this.heroCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.BuscarPromotoraText);
            this.panelMain.Controls.Add(this.panelDatos);
            this.panelMain.Controls.Add(this.heroCard);
            this.panelMain.Controls.Add(this.subPromo);
            this.panelMain.Controls.Add(this.titlePromo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.panelMain.Size = new System.Drawing.Size(1125, 754);
            this.panelMain.TabIndex = 0;
            // 
            // BuscarPromotoraText
            // 
            this.BuscarPromotoraText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarPromotoraText.BackColor = System.Drawing.Color.Transparent;
            this.BuscarPromotoraText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.BuscarPromotoraText.BorderRadius = 18;
            this.BuscarPromotoraText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuscarPromotoraText.DefaultText = "";
            this.BuscarPromotoraText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPromotoraText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.BuscarPromotoraText.IconLeft = global::InmobilariaTopicos.Properties.Resources.icons8_search_25;
            this.BuscarPromotoraText.Location = new System.Drawing.Point(836, 6);
            this.BuscarPromotoraText.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.BuscarPromotoraText.Name = "BuscarPromotoraText";
            this.BuscarPromotoraText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BuscarPromotoraText.PlaceholderText = "Buscar promotora";
            this.BuscarPromotoraText.SelectedText = "";
            this.BuscarPromotoraText.Size = new System.Drawing.Size(273, 40);
            this.BuscarPromotoraText.TabIndex = 25;
            this.BuscarPromotoraText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscarPromotoraText_KeyDown);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelDatos.BorderRadius = 24;
            this.panelDatos.Controls.Add(this.datagridViewPromos);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelDatos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelDatos.Location = new System.Drawing.Point(563, 68);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Padding = new System.Windows.Forms.Padding(12, 12, 0, 12);
            this.panelDatos.Size = new System.Drawing.Size(547, 504);
            this.panelDatos.TabIndex = 16;
            // 
            // datagridViewPromos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagridViewPromos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridViewPromos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridViewPromos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPromos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridViewPromos.ColumnHeadersHeight = 40;
            this.datagridViewPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewPromos.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridViewPromos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.datagridViewPromos.Location = new System.Drawing.Point(19, 45);
            this.datagridViewPromos.Name = "datagridViewPromos";
            this.datagridViewPromos.ReadOnly = true;
            this.datagridViewPromos.RowHeadersVisible = false;
            this.datagridViewPromos.RowTemplate.Height = 40;
            this.datagridViewPromos.Size = new System.Drawing.Size(513, 444);
            this.datagridViewPromos.TabIndex = 18;
            this.datagridViewPromos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPromos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridViewPromos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridViewPromos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridViewPromos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridViewPromos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.datagridViewPromos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.datagridViewPromos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPromos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridViewPromos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPromos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.datagridViewPromos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewPromos.ThemeStyle.HeaderStyle.Height = 40;
            this.datagridViewPromos.ThemeStyle.ReadOnly = true;
            this.datagridViewPromos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPromos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPromos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPromos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.datagridViewPromos.ThemeStyle.RowsStyle.Height = 40;
            this.datagridViewPromos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.datagridViewPromos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Listado de promotoras";
            // 
            // heroCard
            // 
            this.heroCard.BackColor = System.Drawing.Color.Transparent;
            this.heroCard.BorderRadius = 24;
            this.heroCard.Controls.Add(this.lblTitle);
            this.heroCard.Controls.Add(this.nombrePromoText);
            this.heroCard.Controls.Add(this.eliminarPromoBoton);
            this.heroCard.Controls.Add(this.editarPromoBoton);
            this.heroCard.Controls.Add(this.guardarBoton);
            this.heroCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.Location = new System.Drawing.Point(0, 68);
            this.heroCard.Name = "heroCard";
            this.heroCard.Padding = new System.Windows.Forms.Padding(24);
            this.heroCard.Size = new System.Drawing.Size(536, 174);
            this.heroCard.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 16);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Nombre corporativo";
            // 
            // nombrePromoText
            // 
            this.nombrePromoText.BackColor = System.Drawing.Color.Transparent;
            this.nombrePromoText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.nombrePromoText.BorderRadius = 18;
            this.nombrePromoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombrePromoText.DefaultText = "";
            this.nombrePromoText.Font = new System.Drawing.Font("SF Pro Display", 9F);
            this.nombrePromoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nombrePromoText.Location = new System.Drawing.Point(27, 64);
            this.nombrePromoText.Name = "nombrePromoText";
            this.nombrePromoText.PlaceholderText = "Empresa Promotora SA de CV";
            this.nombrePromoText.SelectedText = "";
            this.nombrePromoText.Size = new System.Drawing.Size(481, 40);
            this.nombrePromoText.TabIndex = 4;
            // 
            // eliminarPromoBoton
            // 
            this.eliminarPromoBoton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.eliminarPromoBoton.BorderRadius = 10;
            this.eliminarPromoBoton.BorderThickness = 1;
            this.eliminarPromoBoton.FillColor = System.Drawing.Color.White;
            this.eliminarPromoBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.eliminarPromoBoton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.eliminarPromoBoton.Location = new System.Drawing.Point(236, 125);
            this.eliminarPromoBoton.Name = "eliminarPromoBoton";
            this.eliminarPromoBoton.Size = new System.Drawing.Size(86, 30);
            this.eliminarPromoBoton.TabIndex = 35;
            this.eliminarPromoBoton.Text = "Eliminar";
            this.eliminarPromoBoton.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // editarPromoBoton
            // 
            this.editarPromoBoton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.editarPromoBoton.BorderRadius = 10;
            this.editarPromoBoton.BorderThickness = 1;
            this.editarPromoBoton.FillColor = System.Drawing.Color.White;
            this.editarPromoBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.editarPromoBoton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.editarPromoBoton.Location = new System.Drawing.Point(330, 125);
            this.editarPromoBoton.Name = "editarPromoBoton";
            this.editarPromoBoton.Size = new System.Drawing.Size(86, 30);
            this.editarPromoBoton.TabIndex = 34;
            this.editarPromoBoton.Text = "Editar";
            this.editarPromoBoton.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // guardarBoton
            // 
            this.guardarBoton.BorderRadius = 10;
            this.guardarBoton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.guardarBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.guardarBoton.ForeColor = System.Drawing.Color.White;
            this.guardarBoton.Location = new System.Drawing.Point(422, 125);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(86, 30);
            this.guardarBoton.TabIndex = 33;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // subPromo
            // 
            this.subPromo.AutoSize = true;
            this.subPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPromo.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.subPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subPromo.Location = new System.Drawing.Point(0, 29);
            this.subPromo.Name = "subPromo";
            this.subPromo.Size = new System.Drawing.Size(259, 17);
            this.subPromo.TabIndex = 13;
            this.subPromo.Text = "Ingresa los nuevos datos de las promotoras";
            // 
            // titlePromo
            // 
            this.titlePromo.AutoSize = true;
            this.titlePromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePromo.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.titlePromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titlePromo.Location = new System.Drawing.Point(0, 0);
            this.titlePromo.Name = "titlePromo";
            this.titlePromo.Size = new System.Drawing.Size(236, 29);
            this.titlePromo.TabIndex = 14;
            this.titlePromo.Text = "Registrar Promotora";
            // 
            // Promotora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMain);
            this.Name = "Promotora";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.Size = new System.Drawing.Size(1125, 778);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPromos)).EndInit();
            this.heroCard.ResumeLayout(false);
            this.heroCard.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label titlePromo;
        private System.Windows.Forms.Label subPromo;
        private Guna.UI2.WinForms.Guna2GradientPanel heroCard;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox nombrePromoText;
        private Guna.UI2.WinForms.Guna2Button eliminarPromoBoton;
        private Guna.UI2.WinForms.Guna2Button editarPromoBoton;
        private Guna.UI2.WinForms.Guna2Button guardarBoton;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDatos;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewPromos;
        private Guna.UI2.WinForms.Guna2TextBox BuscarPromotoraText;
    }
}



