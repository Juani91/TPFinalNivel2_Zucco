using dominio;
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

        private void consultaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            txtConsultar.Visible = true;
            lblConsultar.Visible = true;
            btnFinConsultaSimple.Visible = true;
            if (this.Size.Height == 378)
                this.Size = new System.Drawing.Size(this.Size.Width +0, this.Size.Height +25);

            panConsultaSimple.Visible = true;
        }

        private void btnFinConsultaSimple_Click(object sender, EventArgs e)
        {
            txtConsultar.Visible = false;
            lblConsultar.Visible = false;
            btnFinConsultaSimple.Visible = false;            
            this.Size = new System.Drawing.Size(this.Size.Width + 0, this.Size.Height - 25);
            txtConsultar.Text = "";

            panConsultaSimple.Visible = false;
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cboCampo.SelectedItem.ToString();

            if( seleccion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
