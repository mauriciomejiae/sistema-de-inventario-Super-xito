namespace PracticaMauricioMejia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.tsmOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNombreApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlanteamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxIngresar = new System.Windows.Forms.PictureBox();
            this.menuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(58, 297);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(225, 44);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpciones});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(356, 24);
            this.menuOpciones.TabIndex = 2;
            this.menuOpciones.Text = "menuOpciones";
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAutor,
            this.tsmNombreApp,
            this.tsmPlanteamiento,
            this.tsmSalir});
            this.tsmOpciones.Image = global::PracticaMauricioMejia.Properties.Resources.if_category_48654;
            this.tsmOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(85, 20);
            this.tsmOpciones.Text = "Opciones";
            // 
            // tsmAutor
            // 
            this.tsmAutor.Image = global::PracticaMauricioMejia.Properties.Resources.if_hire_me_48687;
            this.tsmAutor.Name = "tsmAutor";
            this.tsmAutor.Size = new System.Drawing.Size(151, 22);
            this.tsmAutor.Text = "Autor";
            this.tsmAutor.Click += new System.EventHandler(this.tsmAutor_Click);
            // 
            // tsmNombreApp
            // 
            this.tsmNombreApp.Image = global::PracticaMauricioMejia.Properties.Resources.if_special_offer_48729;
            this.tsmNombreApp.Name = "tsmNombreApp";
            this.tsmNombreApp.Size = new System.Drawing.Size(151, 22);
            this.tsmNombreApp.Text = "Nombre App";
            this.tsmNombreApp.Click += new System.EventHandler(this.tsmNombreApp_Click);
            // 
            // tsmPlanteamiento
            // 
            this.tsmPlanteamiento.Image = global::PracticaMauricioMejia.Properties.Resources.if_cv_48667;
            this.tsmPlanteamiento.Name = "tsmPlanteamiento";
            this.tsmPlanteamiento.Size = new System.Drawing.Size(151, 22);
            this.tsmPlanteamiento.Text = "Planteamiento";
            this.tsmPlanteamiento.Click += new System.EventHandler(this.tsmPlanteamiento_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Image = global::PracticaMauricioMejia.Properties.Resources.if_logout_48698;
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(151, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(55, 242);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(112, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "&Ingrese la contraseña:";
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Font = new System.Drawing.Font("Code Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblNombreApp.Location = new System.Drawing.Point(69, 132);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(210, 20);
            this.lblNombreApp.TabIndex = 6;
            this.lblNombreApp.Text = "Sistema de inventario";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AcceptsTab = true;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(58, 258);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(225, 35);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.WordWrap = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::PracticaMauricioMejia.Properties.Resources.superexito_1;
            this.pbxLogo.Location = new System.Drawing.Point(35, 24);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(281, 119);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // pbxIngresar
            // 
            this.pbxIngresar.Image = global::PracticaMauricioMejia.Properties.Resources.icons8_Access_64;
            this.pbxIngresar.Location = new System.Drawing.Point(132, 175);
            this.pbxIngresar.Name = "pbxIngresar";
            this.pbxIngresar.Size = new System.Drawing.Size(64, 64);
            this.pbxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIngresar.TabIndex = 4;
            this.pbxIngresar.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(356, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblNombreApp);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbxIngresar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.menuOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmAutor;
        private System.Windows.Forms.ToolStripMenuItem tsmNombreApp;
        private System.Windows.Forms.ToolStripMenuItem tsmPlanteamiento;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox pbxIngresar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}

