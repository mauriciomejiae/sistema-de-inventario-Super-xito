namespace PracticaMauricioMejia
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.pbxLicencia = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblSistemaInventario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxDatosProducto = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTotalAcumulado = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.gbxListaProducto = new System.Windows.Forms.GroupBox();
            this.epvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTotalAcumulado = new System.Windows.Forms.TextBox();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.lblProductosRegistrados = new System.Windows.Forms.Label();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLicencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            this.gbxDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.gbxListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epvError)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelVertical.Controls.Add(this.txtLicencia);
            this.panelVertical.Controls.Add(this.pbxLicencia);
            this.panelVertical.Controls.Add(this.pbxLogo);
            this.panelVertical.Controls.Add(this.btnEliminar);
            this.panelVertical.Controls.Add(this.btnRegistrar);
            this.panelVertical.Controls.Add(this.btnConsultar);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 44);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(206, 496);
            this.panelVertical.TabIndex = 0;
            // 
            // txtLicencia
            // 
            this.txtLicencia.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicencia.Enabled = false;
            this.txtLicencia.Location = new System.Drawing.Point(3, 350);
            this.txtLicencia.Multiline = true;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(203, 103);
            this.txtLicencia.TabIndex = 6;
            this.txtLicencia.Visible = false;
            // 
            // pbxLicencia
            // 
            this.epvError.SetIconAlignment(this.pbxLicencia, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.pbxLicencia.Image = global::PracticaMauricioMejia.Properties.Resources.by_nc_nd;
            this.pbxLicencia.Location = new System.Drawing.Point(36, 459);
            this.pbxLicencia.Name = "pbxLicencia";
            this.pbxLicencia.Size = new System.Drawing.Size(110, 34);
            this.pbxLicencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLicencia.TabIndex = 5;
            this.pbxLicencia.TabStop = false;
            this.pbxLicencia.Tag = "";
            this.pbxLicencia.MouseLeave += new System.EventHandler(this.pbxLicencia_MouseLeave);
            this.pbxLicencia.MouseHover += new System.EventHandler(this.pbxLicencia_MouseHover);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::PracticaMauricioMejia.Properties.Resources.superexito_1;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(206, 59);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = global::PracticaMauricioMejia.Properties.Resources.icons8_multiplicar_24;
            this.btnEliminar.Location = new System.Drawing.Point(0, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(206, 49);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "   Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::PracticaMauricioMejia.Properties.Resources.icons8_producto_nuevo_24;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 137);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(206, 49);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "   Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Image = global::PracticaMauricioMejia.Properties.Resources.icons8_análisis_de_stock_24;
            this.btnConsultar.Location = new System.Drawing.Point(0, 198);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 49);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "   Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelHorizontal.Controls.Add(this.lblSalir);
            this.panelHorizontal.Controls.Add(this.lblSistemaInventario);
            this.panelHorizontal.Controls.Add(this.btnSalir);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(858, 44);
            this.panelHorizontal.TabIndex = 1;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(772, 15);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(33, 16);
            this.lblSalir.TabIndex = 14;
            this.lblSalir.Text = "&Salir";
            this.lblSalir.Visible = false;
            // 
            // lblSistemaInventario
            // 
            this.lblSistemaInventario.AutoSize = true;
            this.lblSistemaInventario.Font = new System.Drawing.Font("Code Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblSistemaInventario.Location = new System.Drawing.Point(21, 15);
            this.lblSistemaInventario.Name = "lblSistemaInventario";
            this.lblSistemaInventario.Size = new System.Drawing.Size(177, 16);
            this.lblSistemaInventario.TabIndex = 1;
            this.lblSistemaInventario.Text = "Sistema de inventario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::PracticaMauricioMejia.Properties.Resources.if_logout_48698;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(811, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 44);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // gbxDatosProducto
            // 
            this.gbxDatosProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbxDatosProducto.Controls.Add(this.lblCodigo);
            this.gbxDatosProducto.Controls.Add(this.txtPrecio);
            this.gbxDatosProducto.Controls.Add(this.label1);
            this.gbxDatosProducto.Controls.Add(this.lblTipo);
            this.gbxDatosProducto.Controls.Add(this.txtDescripcion);
            this.gbxDatosProducto.Controls.Add(this.cbxTipo);
            this.gbxDatosProducto.Controls.Add(this.lblDescripcion);
            this.gbxDatosProducto.Controls.Add(this.txtCodigo);
            this.gbxDatosProducto.Controls.Add(this.txtNombre);
            this.gbxDatosProducto.Controls.Add(this.lblNombre);
            this.gbxDatosProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDatosProducto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxDatosProducto.Location = new System.Drawing.Point(237, 84);
            this.gbxDatosProducto.Name = "gbxDatosProducto";
            this.gbxDatosProducto.Size = new System.Drawing.Size(597, 165);
            this.gbxDatosProducto.TabIndex = 2;
            this.gbxDatosProducto.TabStop = false;
            this.gbxDatosProducto.Text = "&Datos del producto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 16);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "&Código EAN:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(395, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(173, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "&Precio:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(356, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 16);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "&Tipo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(92, 92);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 56);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Electrodoméstico",
            "Electrónico",
            "Comestible",
            "Hogar"});
            this.cbxTipo.Location = new System.Drawing.Point(395, 30);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(173, 26);
            this.cbxTipo.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(10, 96);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 16);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "&Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(92, 27);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(230, 26);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCodigo_MouseDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(92, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "&Nombre:";
            // 
            // lblTotalAcumulado
            // 
            this.lblTotalAcumulado.AutoSize = true;
            this.lblTotalAcumulado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAcumulado.Location = new System.Drawing.Point(558, 503);
            this.lblTotalAcumulado.Name = "lblTotalAcumulado";
            this.lblTotalAcumulado.Size = new System.Drawing.Size(100, 16);
            this.lblTotalAcumulado.TabIndex = 3;
            this.lblTotalAcumulado.Text = "&Total acumulado:";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(6, 22);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.Size = new System.Drawing.Size(585, 197);
            this.dgvListaProductos.TabIndex = 3;
            // 
            // gbxListaProducto
            // 
            this.gbxListaProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbxListaProducto.Controls.Add(this.dgvListaProductos);
            this.gbxListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxListaProducto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxListaProducto.Location = new System.Drawing.Point(237, 267);
            this.gbxListaProducto.Name = "gbxListaProducto";
            this.gbxListaProducto.Size = new System.Drawing.Size(597, 225);
            this.gbxListaProducto.TabIndex = 13;
            this.gbxListaProducto.TabStop = false;
            this.gbxListaProducto.Text = "&Lista de productos:";
            // 
            // epvError
            // 
            this.epvError.ContainerControl = this;
            // 
            // txtTotalAcumulado
            // 
            this.txtTotalAcumulado.Enabled = false;
            this.txtTotalAcumulado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAcumulado.Location = new System.Drawing.Point(664, 501);
            this.txtTotalAcumulado.Name = "txtTotalAcumulado";
            this.txtTotalAcumulado.Size = new System.Drawing.Size(164, 23);
            this.txtTotalAcumulado.TabIndex = 4;
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Enabled = false;
            this.txtTotalRegistros.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRegistros.Location = new System.Drawing.Point(371, 500);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.Size = new System.Drawing.Size(164, 23);
            this.txtTotalRegistros.TabIndex = 15;
            // 
            // lblProductosRegistrados
            // 
            this.lblProductosRegistrados.AutoSize = true;
            this.lblProductosRegistrados.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosRegistrados.Location = new System.Drawing.Point(240, 503);
            this.lblProductosRegistrados.Name = "lblProductosRegistrados";
            this.lblProductosRegistrados.Size = new System.Drawing.Size(127, 16);
            this.lblProductosRegistrados.TabIndex = 14;
            this.lblProductosRegistrados.Text = "&Productos registrados:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(858, 540);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotalRegistros);
            this.Controls.Add(this.lblProductosRegistrados);
            this.Controls.Add(this.gbxListaProducto);
            this.Controls.Add(this.gbxDatosProducto);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.txtTotalAcumulado);
            this.Controls.Add(this.lblTotalAcumulado);
            this.MaximumSize = new System.Drawing.Size(874, 556);
            this.MinimumSize = new System.Drawing.Size(874, 556);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelVertical.ResumeLayout(false);
            this.panelVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLicencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            this.gbxDatosProducto.ResumeLayout(false);
            this.gbxDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.gbxListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSistemaInventario;
        private System.Windows.Forms.GroupBox gbxDatosProducto;
        private System.Windows.Forms.Label lblTotalAcumulado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.GroupBox gbxListaProducto;
        private System.Windows.Forms.ErrorProvider epvError;
        private System.Windows.Forms.TextBox txtTotalAcumulado;
        private System.Windows.Forms.TextBox txtTotalRegistros;
        private System.Windows.Forms.Label lblProductosRegistrados;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.PictureBox pbxLicencia;
        private System.Windows.Forms.TextBox txtLicencia;
    }
}