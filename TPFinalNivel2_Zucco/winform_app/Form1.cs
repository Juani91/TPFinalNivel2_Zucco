﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;        

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();

            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Modelo");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult seleccion = MessageBox.Show("¿De verdad deseas eliminar este artículo?", "!Eliminando artículo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(seleccion == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaConsulta;
            string filtro = txtConsultar.Text;

            if (filtro != "")
                listaConsulta = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaConsulta = listaArticulos;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaConsulta;
            ocultarColumnas();
        }
        
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eleccion = cboCampo.SelectedItem.ToString();

            if (eleccion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnConsultaAvanzada_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtConsultaAvanzada.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void consultaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarConsultaAvanzada();

            txtConsultar.Visible = true;
            lblConsultar.Visible = true;
            btnFinConsultaSimple.Visible = true;
            if (this.Size.Height == 378)
                this.Size = new System.Drawing.Size(this.Size.Width + 0, this.Size.Height + 25);

            panConsultaSimple.Visible = true;
        }

        private void btnFinConsultaSimple_Click(object sender, EventArgs e)
        {
            cerrarConsulta();
        }

        private void búsquedaAvanzadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarConsulta();

            lblConsultaAvanzada.Visible = true;
            lblCampo.Visible = true;
            lblCriterio.Visible = true;
            lblConsultaAv.Visible = true;            
            cboCampo.Visible = true;
            cboCriterio.Visible = true;
            txtConsultaAvanzada.Visible = true;
            btnConsultaAvanzada.Visible = true;
            btnFinConsultaAvanzada .Visible = true;

            if (this.Size.Height == 378)
                this.Size = new System.Drawing.Size(this.Size.Width + 0, this.Size.Height + 52);

            panConsultaAvanzada.Visible = true;
        }

        private void btnFinConsultaAvanzada_Click(object sender, EventArgs e)
        {
            cerrarConsultaAvanzada();
        }

        private void cerrarConsulta()
        {
            txtConsultar.Visible = false;
            lblConsultar.Visible = false;
            btnFinConsultaSimple.Visible = false;

            if(this.Size.Height != 378 && this.Size.Height != 430)
                this.Size = new System.Drawing.Size(this.Size.Width + 0, this.Size.Height - 25);

            txtConsultar.Text = "";
            panConsultaSimple.Visible = false;
        }

        private void cerrarConsultaAvanzada()
        {
            lblConsultaAvanzada.Visible = false;
            lblCampo.Visible = false;
            lblCriterio.Visible = false;
            lblConsultaAv.Visible = false;
            cboCampo.Visible = false;
            cboCriterio.Visible = false;
            txtConsultaAvanzada.Visible = false;
            btnConsultaAvanzada.Visible = false;
            btnFinConsultaAvanzada.Visible = false;

            if (this.Size.Height != 378 && this.Size.Height != 403)
                this.Size = new System.Drawing.Size(this.Size.Width + 0, this.Size.Height - 52);

            txtConsultaAvanzada.Text = "";
            panConsultaAvanzada.Visible = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca alta = new frmAgregarMarca();
            alta.ShowDialog();

            cargar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            bool situacion = true;

            frmAgregarMarca alta = new frmAgregarMarca(situacion);
            alta.ShowDialog();

            cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            bool situacion = true;
            bool eliminar = true;

            frmAgregarMarca alta = new frmAgregarMarca(situacion, eliminar);
            alta.ShowDialog();

            cargar();
        }
    }
}
