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

                negocio.agregar(artic);
                MessageBox.Show("Artículo agregado exitosamente!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
