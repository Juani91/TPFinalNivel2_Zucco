namespace winform_app
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaAvanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.panConsultaSimple = new System.Windows.Forms.Panel();
            this.btnFinConsultaSimple = new System.Windows.Forms.Button();
            this.panConsultaAvanzada = new System.Windows.Forms.Panel();
            this.btnFinConsultaAvanzada = new System.Windows.Forms.Button();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnConsultaAvanzada = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panConsultaSimple.SuspendLayout();
            this.panConsultaAvanzada.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 38);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(696, 288);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(726, 70);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(220, 220);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(6, 4);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(68, 17);
            this.lblConsultar.TabIndex = 3;
            this.lblConsultar.Text = "Consultar";
            this.lblConsultar.Visible = false;
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.articuloToolStripMenuItem.Text = "Artículo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 26);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 26);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 26);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaSimpleToolStripMenuItem,
            this.búsquedaAvanzadaToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.buscarToolStripMenuItem.Text = "Consulta";
            // 
            // consultaSimpleToolStripMenuItem
            // 
            this.consultaSimpleToolStripMenuItem.Name = "consultaSimpleToolStripMenuItem";
            this.consultaSimpleToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.consultaSimpleToolStripMenuItem.Text = "Consulta Simple";
            this.consultaSimpleToolStripMenuItem.Click += new System.EventHandler(this.consultaSimpleToolStripMenuItem_Click);
            // 
            // búsquedaAvanzadaToolStripMenuItem
            // 
            this.búsquedaAvanzadaToolStripMenuItem.Name = "búsquedaAvanzadaToolStripMenuItem";
            this.búsquedaAvanzadaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.búsquedaAvanzadaToolStripMenuItem.Text = "Consulta Avanzada";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(80, 3);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(335, 20);
            this.txtConsultar.TabIndex = 4;
            this.txtConsultar.Visible = false;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // panConsultaSimple
            // 
            this.panConsultaSimple.Controls.Add(this.btnFinConsultaSimple);
            this.panConsultaSimple.Controls.Add(this.lblConsultar);
            this.panConsultaSimple.Controls.Add(this.txtConsultar);
            this.panConsultaSimple.Location = new System.Drawing.Point(12, 332);
            this.panConsultaSimple.Name = "panConsultaSimple";
            this.panConsultaSimple.Size = new System.Drawing.Size(553, 36);
            this.panConsultaSimple.TabIndex = 5;
            this.panConsultaSimple.Visible = false;
            // 
            // btnFinConsultaSimple
            // 
            this.btnFinConsultaSimple.Location = new System.Drawing.Point(421, 1);
            this.btnFinConsultaSimple.Name = "btnFinConsultaSimple";
            this.btnFinConsultaSimple.Size = new System.Drawing.Size(106, 23);
            this.btnFinConsultaSimple.TabIndex = 5;
            this.btnFinConsultaSimple.Text = "Terminar Consulta";
            this.btnFinConsultaSimple.UseVisualStyleBackColor = true;
            this.btnFinConsultaSimple.Visible = false;
            this.btnFinConsultaSimple.Click += new System.EventHandler(this.btnFinConsultaSimple_Click);
            // 
            // panConsultaAvanzada
            // 
            this.panConsultaAvanzada.Controls.Add(this.btnFinConsultaAvanzada);
            this.panConsultaAvanzada.Controls.Add(this.cboCriterio);
            this.panConsultaAvanzada.Controls.Add(this.lblCriterio);
            this.panConsultaAvanzada.Controls.Add(this.lblConsulta);
            this.panConsultaAvanzada.Controls.Add(this.btnConsultaAvanzada);
            this.panConsultaAvanzada.Controls.Add(this.cboCampo);
            this.panConsultaAvanzada.Controls.Add(this.txtConsulta);
            this.panConsultaAvanzada.Controls.Add(this.lblCampo);
            this.panConsultaAvanzada.Location = new System.Drawing.Point(268, 70);
            this.panConsultaAvanzada.Name = "panConsultaAvanzada";
            this.panConsultaAvanzada.Size = new System.Drawing.Size(248, 171);
            this.panConsultaAvanzada.TabIndex = 6;
            // 
            // btnFinConsultaAvanzada
            // 
            this.btnFinConsultaAvanzada.Location = new System.Drawing.Point(117, 120);
            this.btnFinConsultaAvanzada.Name = "btnFinConsultaAvanzada";
            this.btnFinConsultaAvanzada.Size = new System.Drawing.Size(106, 23);
            this.btnFinConsultaAvanzada.TabIndex = 7;
            this.btnFinConsultaAvanzada.Text = "Terminar Consulta";
            this.btnFinConsultaAvanzada.UseVisualStyleBackColor = true;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(85, 45);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 6;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(32, 48);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(23, 81);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(48, 13);
            this.lblConsulta.TabIndex = 4;
            this.lblConsulta.Text = "Consulta";
            // 
            // btnConsultaAvanzada
            // 
            this.btnConsultaAvanzada.Location = new System.Drawing.Point(36, 120);
            this.btnConsultaAvanzada.Name = "btnConsultaAvanzada";
            this.btnConsultaAvanzada.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaAvanzada.TabIndex = 3;
            this.btnConsultaAvanzada.Text = "Consultar";
            this.btnConsultaAvanzada.UseVisualStyleBackColor = true;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(85, 12);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 2;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(85, 78);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(121, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(31, 15);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 339);
            this.Controls.Add(this.panConsultaAvanzada);
            this.Controls.Add(this.panConsultaSimple);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELECTRICMANIA";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panConsultaSimple.ResumeLayout(false);
            this.panConsultaSimple.PerformLayout();
            this.panConsultaAvanzada.ResumeLayout(false);
            this.panConsultaAvanzada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaAvanzadaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaSimpleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Panel panConsultaSimple;
        private System.Windows.Forms.Button btnFinConsultaSimple;
        private System.Windows.Forms.Panel panConsultaAvanzada;
        private System.Windows.Forms.Button btnFinConsultaAvanzada;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnConsultaAvanzada;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblCampo;
    }
}

