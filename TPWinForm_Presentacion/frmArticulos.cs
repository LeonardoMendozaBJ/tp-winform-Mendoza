using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Presentacion
{
    public partial class frmArticulos : Form
    {

        private List<Articulo> listaArticulo;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarART_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarGrilla();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarGrilla()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                dgvArticulo.Columns["Id"].Visible = false;
                pictureBoxArticulo.Load(listaArticulo[0].ImagenURL);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()+ "falla frilla " );
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
           Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
           cargarImagen(seleccionado.ImagenURL);
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxArticulo.Load("https://img.freepik.com/vector-gratis/pagina-error-404-distorsion_23-2148105404.jpg");
                
            }
        }

        private void pictureBoxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarART_Click(object sender, EventArgs e)
        {
           
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
              /*  frmAltaArticulo.Text = "Modificar Articulo";*/

                modificar.ShowDialog();  
                cargarGrilla();
            

        }
    }
}