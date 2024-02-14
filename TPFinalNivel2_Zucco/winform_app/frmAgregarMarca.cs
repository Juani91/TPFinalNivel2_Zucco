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
        bool modificada = false;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(bool marca)
        {
            InitializeComponent();
            modificada = marca;
            Text = "Modificar Marca";
            lblAgregarMarca.Text = "Modificar";
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

                if(modificada ==  false)
                {
                    negocio.agegar(marca);
                    MessageBox.Show("¡Marca agregada exitosamente!");
                }
                else
                {
                    negocio.modificar(marca);
                    MessageBox.Show("¡Marca modificada exitosamente!");
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
            dgvAgregarMarca.DataSource = negocio.listar();
            dgvAgregarMarca.Columns["Id"].Visible = false;
        }

        private void dgvAgregarMarca_SelectionChanged(object sender, EventArgs e)
        {
            if(modificada == true)
            {
                if(dgvAgregarMarca.SelectedRows.Count > 0)
                {               
                    string marca = dgvAgregarMarca.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                    txtAgregarMarca.Text = marca;
                }
                else
                {
                    txtAgregarMarca.Clear();
                }
            }
        }
    }
}
