using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        bool eliminada = false;
        bool categoria = false;

        public frmAgregarMarca(bool modificar, bool eliminar, bool esCategoria)
        {
            InitializeComponent();

            modificada = modificar;
            eliminada = eliminar;
            categoria = esCategoria;

            if(!esCategoria)
            {
                if (modificar)
                {
                    Text = "Modificar Marca";
                    lblAgregarMarca.Text = "Modificar";
                }
                else if (eliminar)
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
                else if (eliminar)
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

        public void consultarData()
        {
                     
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocioMarca = new MarcaNegocio();

            Categoria category = new Categoria();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            frmArticulos formularioPrincipal = new frmArticulos();

            try
            {
                if (!categoria)
                {
                    marca.Id = int.Parse(dgvAgregarMarca.SelectedRows[0].Cells["Id"].Value.ToString());
                    marca.Descripcion = txtAgregarMarca.Text;

                    if (eliminada)
                    {

                        string buscar = txtAgregarMarca.Text;

                        bool existe = formularioPrincipal.consultarDataGridView(buscar); // VER POR QUÉ SIEMPRE DA FALSE! 

                        if (existe)
                        {
                            MessageBox.Show("¡No puedes eliminar una marca que está siendo utilizada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            DialogResult seleccion = MessageBox.Show("La categoría se eliminará permanentemente. ¿Está seguro de querer eliminarla?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (seleccion == DialogResult.Yes)
                            {
                                negocioMarca.eliminar(marca);
                                MessageBox.Show("¡Marca eliminada exitosamente!");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else if (modificada)
                    {
                        negocioMarca.modificar(marca);
                        MessageBox.Show("¡Marca modificada exitosamente!");
                    }
                    else
                    {
                        bool existe = false;

                        foreach (DataGridViewRow fila in dgvAgregarMarca.Rows)
                        {
                            DataGridViewCell celda = fila.Cells["Descripcion"];

                            if(celda.Value != null && celda.Value.ToString().ToUpper().Contains(txtAgregarMarca.Text.ToUpper()))
                            {
                                existe = true;
                            }
                        }                
                        if (existe)
                        {
                            DialogResult seleccion = MessageBox.Show("!Esta marca ya existe! ¿Desea agregarla igualmente?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(seleccion == DialogResult.Yes)
                            {
                                negocioMarca.agegar(marca);
                                MessageBox.Show("¡Marca agregada exitosamente!");
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            negocioMarca.agegar(marca);
                            MessageBox.Show("¡Marca agregada exitosamente!");
                        }
                    }
                }
                else
                {
                    category.Id = int.Parse(dgvAgregarMarca.SelectedRows[0].Cells["Id"].Value.ToString());
                    category.Descripcion = txtAgregarMarca.Text;

                    if (eliminada)
                    {
                        DialogResult seleccion = MessageBox.Show("La categoría se eliminará permanentemente. ¿Está seguro de querer eliminarla?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (seleccion == DialogResult.Yes)
                        {
                            negocioCategoria.eliminar(category);
                            MessageBox.Show("¡Categoría eliminada exitosamente!");
                        }
                        else
                        {
                            return;
                        }

                    }
                    else if (modificada)
                    {
                        negocioCategoria.modificar(category);
                        MessageBox.Show("¡Categoría modificada exitosamente!");
                    }
                    else
                    {
                        bool existe = false;

                        foreach (DataGridViewRow fila in dgvAgregarMarca.Rows)
                        {
                            DataGridViewCell celda = fila.Cells["Descripcion"];

                            if (celda.Value != null && celda.Value.ToString().ToUpper().Contains(txtAgregarMarca.Text.ToUpper()))
                            {
                                existe = true;
                            }
                        }
                        if (existe)
                        {
                            DialogResult seleccion = MessageBox.Show("!Esta categoría ya existe! ¿Desea agregarla igualmente?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (seleccion == DialogResult.Yes)
                            {
                                negocioCategoria.agegar(category);
                                MessageBox.Show("¡Categoría agregada exitosamente!");
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            negocioCategoria.agegar(category);
                            MessageBox.Show("¡Categoría agregada exitosamente!");
                        }
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
