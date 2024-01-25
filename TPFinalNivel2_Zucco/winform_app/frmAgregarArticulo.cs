using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo artic = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                artic.Codigo = txtCodigo.Text;                
                artic.Nombre = txtModelo.Text;
                artic.Descripcion = txtDescripcion.Text;
                artic.Precio = decimal.Parse(txtPrecio.Text);
                artic.Marca = (Marca)cboMarca.SelectedItem;
                artic.Categoria = (Categoria)cboCategoria.SelectedItem;
                

                negocio.agregar(artic);
                MessageBox.Show("Artículo agregado exitosamente!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marca.listar();
                cboCategoria.DataSource = categoria.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
