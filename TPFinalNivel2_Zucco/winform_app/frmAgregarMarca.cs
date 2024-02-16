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

        bool modificada = false;
        bool eliminada = false;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(bool situacion)
        {
            InitializeComponent();
            modificada = situacion;
            Text = "Modificar Marca";
            lblAgregarMarca.Text = "Modificar";
        }

        public frmAgregarMarca(bool situacion, bool eliminar)
        {
            InitializeComponent();
            modificada = situacion;
            eliminada = eliminar;
            Text = "Eliminar Marca";
            lblAgregarMarca.Text = "Eliminar";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.Id = int.Parse(dgvAgregarMarca.SelectedRows[0].Cells["Id"].Value.ToString());
                marca.Descripcion = txtAgregarMarca.Text;

                if(modificada == true && eliminada == true)
                {
                    negocio.eliminar(marca);
                    MessageBox.Show("¡Marca eliminada exitosamente!");
                }
                else if(modificada == true)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("¡Marca modificada exitosamente!");
                }
                else
                {
                    negocio.agegar(marca);
                    MessageBox.Show("¡Marca agregada exitosamente!");
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
            listaMarcas = negocio.listar();
            dgvAgregarMarca.DataSource = listaMarcas;
            ocultarColumnaId();
        }

        private void dgvAgregarMarca_SelectionChanged(object sender, EventArgs e)
        {
            Marca seleccionado = new Marca();
            try
            {
                if(modificada == true)
                {                    
                    seleccionado = (Marca)dgvAgregarMarca.CurrentRow.DataBoundItem;
                    txtAgregarMarca.Text = seleccionado.Descripcion.ToString();                    
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
            string filtro = txtConsultarMarca.Text;
            
            if(filtro != "")
                listaMarcasConsulta = listaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else           
                listaMarcasConsulta = listaMarcas;

            dgvAgregarMarca.DataSource = null;
            dgvAgregarMarca.DataSource = listaMarcasConsulta;
            ocultarColumnaId();
        }
    }
}
