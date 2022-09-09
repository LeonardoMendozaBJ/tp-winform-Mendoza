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
                pictureBoxArticulo.Load(listaArticulo[0].ImagenURL);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
            catch (Exception ex)
            {
                pictureBoxArticulo.Load("https://www.google.com/imgres?imgurl=https%3A%2F%2Fwpdirecto.com%2Fwp-content%2Fuploads%2F2017%2F08%2Falt-de-una-imagen.png&imgrefurl=https%3A%2F%2Fwpdirecto.com%2Fimagen-por-defecto-miniaturas%2F&tbnid=B6rQa8xwUHBKwM&vet=12ahUKEwjSzK7sqIj6AhW1uZUCHSiLDtIQMygEegUIARDHAQ..i&docid=X3wLzmG1bLpYvM&w=648&h=470&q=imagen%20por%20defecto&ved=2ahUKEwjSzK7sqIj6AhW1uZUCHSiLDtIQMygEegUIARDHAQ");
                throw ex;
            }
        }
    }
}