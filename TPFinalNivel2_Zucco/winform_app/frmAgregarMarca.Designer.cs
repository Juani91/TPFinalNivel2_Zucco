﻿namespace winform_app
{
    partial class frmAgregarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarMarca));
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.dgvAgregarMarca = new System.Windows.Forms.DataGridView();
            this.txtAgregarMarca = new System.Windows.Forms.TextBox();
            this.txtConsultarMarca = new System.Windows.Forms.TextBox();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.lblConsultarMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.Location = new System.Drawing.Point(203, 174);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMarca.TabIndex = 3;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // dgvAgregarMarca
            // 
            this.dgvAgregarMarca.AllowUserToResizeColumns = false;
            this.dgvAgregarMarca.AllowUserToResizeRows = false;
            this.dgvAgregarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgregarMarca.Location = new System.Drawing.Point(31, 61);
            this.dgvAgregarMarca.MultiSelect = false;
            this.dgvAgregarMarca.Name = "dgvAgregarMarca";
            this.dgvAgregarMarca.RowHeadersVisible = false;
            this.dgvAgregarMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregarMarca.Size = new System.Drawing.Size(149, 218);
            this.dgvAgregarMarca.TabIndex = 0;
            this.dgvAgregarMarca.TabStop = false;
            this.dgvAgregarMarca.SelectionChanged += new System.EventHandler(this.dgvAgregarMarca_SelectionChanged);
            // 
            // txtAgregarMarca
            // 
            this.txtAgregarMarca.Location = new System.Drawing.Point(202, 135);
            this.txtAgregarMarca.Name = "txtAgregarMarca";
            this.txtAgregarMarca.Size = new System.Drawing.Size(168, 20);
            this.txtAgregarMarca.TabIndex = 2;
            // 
            // txtConsultarMarca
            // 
            this.txtConsultarMarca.Location = new System.Drawing.Point(157, 22);
            this.txtConsultarMarca.Name = "txtConsultarMarca";
            this.txtConsultarMarca.Size = new System.Drawing.Size(168, 20);
            this.txtConsultarMarca.TabIndex = 1;
            this.txtConsultarMarca.TextChanged += new System.EventHandler(this.txtConsultarMarca_TextChanged);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(295, 174);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 4;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarca.Location = new System.Drawing.Point(257, 102);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(59, 17);
            this.lblAgregarMarca.TabIndex = 0;
            this.lblAgregarMarca.Text = "Agregar";
            // 
            // lblConsultarMarca
            // 
            this.lblConsultarMarca.AutoSize = true;
            this.lblConsultarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarMarca.Location = new System.Drawing.Point(83, 23);
            this.lblConsultarMarca.Name = "lblConsultarMarca";
            this.lblConsultarMarca.Size = new System.Drawing.Size(68, 17);
            this.lblConsultarMarca.TabIndex = 0;
            this.lblConsultarMarca.Text = "Consultar";
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 292);
            this.Controls.Add(this.lblConsultarMarca);
            this.Controls.Add(this.lblAgregarMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.txtConsultarMarca);
            this.Controls.Add(this.txtAgregarMarca);
            this.Controls.Add(this.dgvAgregarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Marca";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.DataGridView dgvAgregarMarca;
        private System.Windows.Forms.TextBox txtAgregarMarca;
        private System.Windows.Forms.TextBox txtConsultarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.Label lblConsultarMarca;
    }
}