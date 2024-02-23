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
    public partial class frmAgregarMarca : Form
    {
        private List<Marca> listaMarcas;
        private List<Categoria> listaCategorias;

        bool modificada = false;
        bool eliminada = false; // ESTO HACE FALTA??? Creo que sí.. para trabajar con las funciones de manera global
        bool categoria = false;

        public frmAgregarMarca(bool modificar, bool eliminar, bool esCategoria)
        {
            InitializeComponent();

            modificada = modificar;
            eliminada = eliminar; // ESTO HACE FALTA???
            categoria = esCategoria;

            if(!esCategoria)
            {
                if (modificar)
                {
                    Text = "Modificar Marca";
                    lblAgregarMarca.Text = "Modificar";
                }
                else
                {
                    Text = "Eliminar Marca";
                    lblAgregarMarca.Text = "Eliminar";
                }
            }
            else
            {
                if (modificar)
                {
                    Text = "Modificar Categoría";
                    lblAgregarMarca.Text = "Modificar";
                }
                else
                {
                    Text = "Eliminar Categoría";
                    lblAgregarMarca.Text = "Eliminar";
                }
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocioMarca = new MarcaNegocio();

            Categoria category = new Categoria();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                if (!categoria)
                {
                    marca.Id = int.Parse(dgvAgregarMarca.SelectedRows[0].Cells["Id"].Value.ToString());
                    marca.Descripcion = txtAgregarMarca.Text;

                    if (modificada && eliminada)
                    {
                        negocioMarca.eliminar(marca);
                        MessageBox.Show("¡Marca eliminada exitosamente!");
                    }
                    else if (modificada)
                    {
                        negocioMarca.modificar(marca);
                        MessageBox.Show("¡Marca modificada exitosamente!");
                    }
                    else
                    {
                        negocioMarca.agegar(marca);
                        MessageBox.Show("¡Marca agregada exitosamente!");
                    }
                }
                else
                {
                    category.Id = int.Parse(dgvAgregarMarca.SelectedRows[0].Cells["Id"].Value.ToString());
                    category.Descripcion = txtAgregarMarca.Text;

                    if (modificada && eliminada)
                    {
                        negocioCategoria.eliminar(category);
                        MessageBox.Show("¡Marca eliminada exitosamente!");
                    }
                    else if (modificada)
                    {
                        negocioCategoria.modificar(category);
                        MessageBox.Show("¡Marca modificada exitosamente!");
                    }
                    else
                    {
                        negocioCategoria.agegar(category);
                        MessageBox.Show("¡Marca agregada exitosamente!");
                    }
                }

                Close();    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            CategoriaNegocio category = new CategoriaNegocio();

            if (!categoria)
            {
                listaMarcas = negocio.listar();
                dgvAgregarMarca.DataSource = listaMarcas;
            }
            else
            {
                listaCategorias = category.listar();
                dgvAgregarMarca.DataSource = listaCategorias;
            }            
            
            ocultarColumnaId();
        }

        private void dgvAgregarMarca_SelectionChanged(object sender, EventArgs e)
        {
            Marca marcaSelect = new Marca();
            Categoria catSelect = new Categoria();

            try
            {
                if(modificada || eliminada)
                {
                    if(!categoria)
                    {
                        if(dgvAgregarMarca.CurrentRow != null)
                        {
                            marcaSelect = (Marca)dgvAgregarMarca.CurrentRow.DataBoundItem;
                            txtAgregarMarca.Text = marcaSelect.Descripcion.ToString();
                        }
                        else
                        {
                            txtAgregarMarca.Text = "";
                        }
                    }
                    else
                    {
                        if (dgvAgregarMarca.CurrentRow != null)
                        {
                            catSelect = (Categoria)dgvAgregarMarca.CurrentRow.DataBoundItem;
                            txtAgregarMarca.Text = catSelect.Descripcion.ToString();
                        }
                        else
                        {
                            txtAgregarMarca.Text = "";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnaId()
        {
            dgvAgregarMarca.Columns["Id"].Visible = false;
        }

        private void txtConsultarMarca_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaMarcasConsulta;
            List<Categoria> listaCategoriaConsulta;

            string filtro = txtConsultarMarca.Text;

            if (!categoria)
            {
                if(filtro != "")
                    listaMarcasConsulta = listaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                else           
                    listaMarcasConsulta = listaMarcas;

                dgvAgregarMarca.DataSource = null;
                dgvAgregarMarca.DataSource = listaMarcasConsulta;
            }
            else
            {
                if (filtro != "")
                    listaCategoriaConsulta = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                else
                    listaCategoriaConsulta = listaCategorias;

                dgvAgregarMarca.DataSource = null;
                dgvAgregarMarca.DataSource = listaCategoriaConsulta;
            }

            ocultarColumnaId();
        }
    }
}
