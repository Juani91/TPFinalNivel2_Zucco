using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using System.Data.SqlClient;

namespace winform_app
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog imagen = null;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }       

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarAgregarArticulo()
        {
            if(txtCodigo.Text == "" || txtDescripcion.Text == "" || txtModelo.Text == "" || txtPrecio.Text == "" || cboMarca.SelectedIndex == -1 || cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Quedan campos sin completar.");
                return true;
            }

            if(txtImagenUrl.Text == "")
            {
                DialogResult seleccion = MessageBox.Show("Desea dejar sin imágen al Artículo por el momento?", "Artículo sin imagen", MessageBoxButtons.YesNo);
                if (seleccion == DialogResult.No)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Articulo artic = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(validarAgregarArticulo())
                {
                    return;
                }

                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtModelo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagenUrl.Text;                

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("!Artículo modificado exitosamente!");                    
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("!Artículo agregado exitosamente!");
                }

                if(imagen != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(imagen.FileName, ConfigurationManager.AppSettings["articulos-app"] + imagen.SafeFileName);
                }

                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Puede que el contenido del campo descripción sea demasiado extenso. Evite exceder los 150 caracteres.");
            }
            catch (FormatException)
            {
                MessageBox.Show("El campo precio contiene caracteres erróneos.");
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
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtModelo.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg;|jpeg|*.jpeg";
            

            if(imagen.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = imagen.FileName;
                cargarImagen(imagen.FileName);
            }

            
        }
    }
}
