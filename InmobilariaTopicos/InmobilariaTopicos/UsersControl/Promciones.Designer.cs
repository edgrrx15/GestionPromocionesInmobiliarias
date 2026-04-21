namespace InmobilariaTopicos.UsersControl
{
    partial class Promciones
    {
        /// <summary> 
        /// Variable del diseÃ±ador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estÃ©n usando.
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

        #region CÃ³digo generado por el DiseÃ±ador de componentes

        /// <summary> 
        /// MÃ©todo necesario para admitir el DiseÃ±ador. No se puede modificar
        /// el contenido de este mÃ©todo con el editor de cÃ³digo.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.buscarPromoText = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelDatos = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.datagridViewPromos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.heroCard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.eliminarPromoBoton = new Guna.UI2.WinForms.Guna2Button();
            this.editarPromoBoton = new Guna.UI2.WinForms.Guna2Button();
            this.guardarBoton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRutaPlano = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubirPlano = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPromotora = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poblacionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPortafolioTitle = new System.Windows.Forms.Label();
            this.codigoInternoText = new Guna.UI2.WinForms.Guna2TextBox();
            this.nombrePromoText = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panelMain.Controls.Add(this.buscarPromoText);
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
            // buscarPromoText
            // 
            this.buscarPromoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarPromoText.BackColor = System.Drawing.Color.Transparent;
            this.buscarPromoText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.buscarPromoText.BorderRadius = 18;
            this.buscarPromoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscarPromoText.DefaultText = "";
            this.buscarPromoText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPromoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.buscarPromoText.IconLeft = global::InmobilariaTopicos.Properties.Resources.icons8_search_25;
            this.buscarPromoText.Location = new System.Drawing.Point(837, 6);
            this.buscarPromoText.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.buscarPromoText.Name = "buscarPromoText";
            this.buscarPromoText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.buscarPromoText.PlaceholderText = "Buscar promocion deseada...";
            this.buscarPromoText.SelectedText = "";
            this.buscarPromoText.Size = new System.Drawing.Size(273, 40);
            this.buscarPromoText.TabIndex = 24;
            this.buscarPromoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscarPromoText_KeyDown);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelDatos.BorderRadius = 24;
            this.panelDatos.Controls.Add(this.datagridViewPromos);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panelDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelDatos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panelDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelDatos.Location = new System.Drawing.Point(563, 68);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Padding = new System.Windows.Forms.Padding(12, 12, 0, 12);
            this.panelDatos.ShadowDecoration.BorderRadius = 24;
            this.panelDatos.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPromos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridViewPromos.ColumnHeadersHeight = 4;
            this.datagridViewPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewPromos.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridViewPromos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.datagridViewPromos.Location = new System.Drawing.Point(19, 45);
            this.datagridViewPromos.Name = "datagridViewPromos";
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
            this.datagridViewPromos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPromos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.datagridViewPromos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewPromos.ThemeStyle.HeaderStyle.Height = 4;
            this.datagridViewPromos.ThemeStyle.ReadOnly = false;
            this.datagridViewPromos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPromos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPromos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Listado de promociones";
            // 
            // heroCard
            // 
            this.heroCard.BackColor = System.Drawing.Color.Transparent;
            this.heroCard.BorderRadius = 24;
            this.heroCard.Controls.Add(this.eliminarPromoBoton);
            this.heroCard.Controls.Add(this.editarPromoBoton);
            this.heroCard.Controls.Add(this.guardarBoton);
            this.heroCard.Controls.Add(this.label4);
            this.heroCard.Controls.Add(this.txtRutaPlano);
            this.heroCard.Controls.Add(this.btnSubirPlano);
            this.heroCard.Controls.Add(this.label3);
            this.heroCard.Controls.Add(this.cbPromotora);
            this.heroCard.Controls.Add(this.label2);
            this.heroCard.Controls.Add(this.poblacionText);
            this.heroCard.Controls.Add(this.label1);
            this.heroCard.Controls.Add(this.lblPortafolioTitle);
            this.heroCard.Controls.Add(this.codigoInternoText);
            this.heroCard.Controls.Add(this.nombrePromoText);
            this.heroCard.CustomBorderColor = System.Drawing.Color.Transparent;
            this.heroCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.heroCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.heroCard.Location = new System.Drawing.Point(0, 68);
            this.heroCard.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.heroCard.Name = "heroCard";
            this.heroCard.Padding = new System.Windows.Forms.Padding(24);
            this.heroCard.ShadowDecoration.BorderRadius = 24;
            this.heroCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.heroCard.Size = new System.Drawing.Size(536, 387);
            this.heroCard.TabIndex = 15;
            // 
            // eliminarPromoBoton
            // 
            this.eliminarPromoBoton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.eliminarPromoBoton.BorderRadius = 10;
            this.eliminarPromoBoton.BorderThickness = 1;
            this.eliminarPromoBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarPromoBoton.FillColor = System.Drawing.Color.White;
            this.eliminarPromoBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.eliminarPromoBoton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(47)))));
            this.eliminarPromoBoton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.eliminarPromoBoton.Image = global::InmobilariaTopicos.Properties.Resources.icons8_delete_28;
            this.eliminarPromoBoton.Location = new System.Drawing.Point(236, 332);
            this.eliminarPromoBoton.Name = "eliminarPromoBoton";
            this.eliminarPromoBoton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eliminarPromoBoton.Size = new System.Drawing.Size(86, 30);
            this.eliminarPromoBoton.TabIndex = 35;
            this.eliminarPromoBoton.Text = "Eliminar";
            this.eliminarPromoBoton.Click += new System.EventHandler(this.eliminarPromoBoton_Click);
            // 
            // editarPromoBoton
            // 
            this.editarPromoBoton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.editarPromoBoton.BorderRadius = 10;
            this.editarPromoBoton.BorderThickness = 1;
            this.editarPromoBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarPromoBoton.FillColor = System.Drawing.Color.White;
            this.editarPromoBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.editarPromoBoton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.editarPromoBoton.Image = global::InmobilariaTopicos.Properties.Resources.icons8_edit_48;
            this.editarPromoBoton.Location = new System.Drawing.Point(330, 332);
            this.editarPromoBoton.Name = "editarPromoBoton";
            this.editarPromoBoton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.editarPromoBoton.Size = new System.Drawing.Size(86, 30);
            this.editarPromoBoton.TabIndex = 34;
            this.editarPromoBoton.Text = "Editar";
            this.editarPromoBoton.Click += new System.EventHandler(this.editarPromoBoton_Click);
            // 
            // guardarBoton
            // 
            this.guardarBoton.BorderRadius = 10;
            this.guardarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBoton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.guardarBoton.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.guardarBoton.ForeColor = System.Drawing.Color.White;
            this.guardarBoton.Location = new System.Drawing.Point(422, 332);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(86, 30);
            this.guardarBoton.TabIndex = 33;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Plano";
            // 
            // txtRutaPlano
            // 
            this.txtRutaPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRutaPlano.BackColor = System.Drawing.Color.Transparent;
            this.txtRutaPlano.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.txtRutaPlano.BorderRadius = 18;
            this.txtRutaPlano.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRutaPlano.DefaultText = "";
            this.txtRutaPlano.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaPlano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtRutaPlano.Location = new System.Drawing.Point(27, 273);
            this.txtRutaPlano.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.txtRutaPlano.Name = "txtRutaPlano";
            this.txtRutaPlano.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRutaPlano.PlaceholderText = "Ruta del archivo seleccionado...";
            this.txtRutaPlano.ReadOnly = true;
            this.txtRutaPlano.SelectedText = "";
            this.txtRutaPlano.Size = new System.Drawing.Size(335, 40);
            this.txtRutaPlano.TabIndex = 22;
            // 
            // btnSubirPlano
            // 
            this.btnSubirPlano.BorderRadius = 10;
            this.btnSubirPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirPlano.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSubirPlano.Font = new System.Drawing.Font("SF Pro Display", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSubirPlano.ForeColor = System.Drawing.Color.White;
            this.btnSubirPlano.Location = new System.Drawing.Point(368, 273);
            this.btnSubirPlano.Name = "btnSubirPlano";
            this.btnSubirPlano.Size = new System.Drawing.Size(140, 40);
            this.btnSubirPlano.TabIndex = 24;
            this.btnSubirPlano.Text = "Examinar...";
            this.btnSubirPlano.Click += new System.EventHandler(this.btnSubirPlano_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(24, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Promotora Encargada";
            // 
            // cbPromotora
            // 
            this.cbPromotora.BackColor = System.Drawing.Color.Transparent;
            this.cbPromotora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.cbPromotora.BorderRadius = 18;
            this.cbPromotora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPromotora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPromotora.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPromotora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPromotora.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.cbPromotora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPromotora.ItemHeight = 30;
            this.cbPromotora.Location = new System.Drawing.Point(27, 206);
            this.cbPromotora.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.cbPromotora.Name = "cbPromotora";
            this.cbPromotora.Size = new System.Drawing.Size(481, 36);
            this.cbPromotora.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Poblacion";
            // 
            // poblacionText
            // 
            this.poblacionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poblacionText.BackColor = System.Drawing.Color.Transparent;
            this.poblacionText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.poblacionText.BorderRadius = 18;
            this.poblacionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poblacionText.DefaultText = "";
            this.poblacionText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.poblacionText.Location = new System.Drawing.Point(27, 135);
            this.poblacionText.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.poblacionText.Name = "poblacionText";
            this.poblacionText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.poblacionText.PlaceholderText = "PR-001";
            this.poblacionText.SelectedText = "";
            this.poblacionText.Size = new System.Drawing.Size(481, 40);
            this.poblacionText.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // lblPortafolioTitle
            // 
            this.lblPortafolioTitle.AutoSize = true;
            this.lblPortafolioTitle.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblPortafolioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPortafolioTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPortafolioTitle.Location = new System.Drawing.Point(24, 45);
            this.lblPortafolioTitle.Name = "lblPortafolioTitle";
            this.lblPortafolioTitle.Size = new System.Drawing.Size(89, 16);
            this.lblPortafolioTitle.TabIndex = 16;
            this.lblPortafolioTitle.Text = "Codigo Interno";
            // 
            // codigoInternoText
            // 
            this.codigoInternoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoInternoText.BackColor = System.Drawing.Color.Transparent;
            this.codigoInternoText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.codigoInternoText.BorderRadius = 18;
            this.codigoInternoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codigoInternoText.DefaultText = "";
            this.codigoInternoText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoInternoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.codigoInternoText.Location = new System.Drawing.Point(27, 64);
            this.codigoInternoText.Margin = new System.Windows.Forms.Padding(3, 3, 16, 12);
            this.codigoInternoText.Name = "codigoInternoText";
            this.codigoInternoText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.codigoInternoText.PlaceholderText = "PR-001";
            this.codigoInternoText.SelectedText = "";
            this.codigoInternoText.Size = new System.Drawing.Size(248, 40);
            this.codigoInternoText.TabIndex = 5;
            // 
            // nombrePromoText
            // 
            this.nombrePromoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombrePromoText.BackColor = System.Drawing.Color.Transparent;
            this.nombrePromoText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.nombrePromoText.BorderRadius = 18;
            this.nombrePromoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombrePromoText.DefaultText = "";
            this.nombrePromoText.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePromoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nombrePromoText.Location = new System.Drawing.Point(294, 64);
            this.nombrePromoText.Name = "nombrePromoText";
            this.nombrePromoText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nombrePromoText.PlaceholderText = "Residencial Vista del Norte";
            this.nombrePromoText.SelectedText = "";
            this.nombrePromoText.Size = new System.Drawing.Size(214, 40);
            this.nombrePromoText.TabIndex = 4;
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
            this.subPromo.Size = new System.Drawing.Size(268, 17);
            this.subPromo.TabIndex = 13;
            this.subPromo.Text = "Ingresa los nuevos datos de las promociones";
            // 
            // titlePromo
            // 
            this.titlePromo.AutoSize = true;
            this.titlePromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePromo.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold);
            this.titlePromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titlePromo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titlePromo.Location = new System.Drawing.Point(0, 0);
            this.titlePromo.Name = "titlePromo";
            this.titlePromo.Size = new System.Drawing.Size(238, 29);
            this.titlePromo.TabIndex = 14;
            this.titlePromo.Text = "Registrar Promocion";
            // 
            // Promciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMain);
            this.Name = "Promciones";
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

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label subPromo;
        private System.Windows.Forms.Label titlePromo;
        private Guna.UI2.WinForms.Guna2GradientPanel heroCard;
        private Guna.UI2.WinForms.Guna2TextBox codigoInternoText;
        private Guna.UI2.WinForms.Guna2TextBox nombrePromoText;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbPromotora;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox poblacionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPortafolioTitle;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtRutaPlano;
        private Guna.UI2.WinForms.Guna2Button btnSubirPlano;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDatos;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewPromos;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox buscarPromoText;
        private Guna.UI2.WinForms.Guna2Button eliminarPromoBoton;
        private Guna.UI2.WinForms.Guna2Button editarPromoBoton;
        private Guna.UI2.WinForms.Guna2Button guardarBoton;
    }
}



