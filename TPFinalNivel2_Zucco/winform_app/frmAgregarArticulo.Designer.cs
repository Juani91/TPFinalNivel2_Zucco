namespace winform_app
{
    partial class frmAgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArticulo));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(45, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(184, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(103, 110);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(184, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(43, 111);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(50, 72);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(103, 71);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(184, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 150);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(49, 189);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 149);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(184, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(103, 227);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(184, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(28, 228);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(197, 311);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(305, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(103, 266);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(184, 20);
            this.txtImagenUrl.TabIndex = 7;
            this.txtImagenUrl.TextChanged += new System.EventHandler(this.txtImagenUrl_TextChanged);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenUrl.Location = new System.Drawing.Point(61, 267);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(36, 17);
            this.lblImagenUrl.TabIndex = 16;
            this.lblImagenUrl.Text = "URL";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(293, 264);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(69, 23);
            this.btnAgregarImagen.TabIndex = 8;
            this.btnAgregarImagen.Text = "Examinar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(333, 24);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(222, 222);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 18;
            this.pbxArticulo.TabStop = false;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 352);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}