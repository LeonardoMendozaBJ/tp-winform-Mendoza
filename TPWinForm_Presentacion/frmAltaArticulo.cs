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
using Dominio;
using Negocio;
using System.Configuration;

namespace TPWinForm_Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {


            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marca.listar();
                cbxCategoria.DataSource = categoria.listar();

               

                cbxMarca.DataSource = marca.listar();
                cbxMarca.ValueMember = "IdMarca";
                cbxMarca.DisplayMember = "Descripcion";
                /*cbxMarca.SelectedIndex = -1;*/

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "Descripcion";
                /*cbxCategoria.SelectedIndex = -1;*/
                
                
                if (articulo != null)
                {
                    Text = "Modificar Articulo";
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                  /*if (articulo.Marca != null)*/
                        cbxMarca.SelectedValue = articulo.Marca.Idmarca;
                   /* if (articulo.Categoria != null) */
                        cbxCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                  
                    txtUrl.Text = articulo.ImagenURL;
                    cargarImagen(articulo.ImagenURL);
                    txtPrecio.Text = articulo.Precio.ToString();

                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {

           
            ArticuloNegocio negocio = new ArticuloNegocio();
           /* Articulo articulo = new Articulo();*/
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.ImagenURL = txtUrl.Text.Trim();
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("ARTICULO MODIFICADO CON EXITO!");
                }
                else
                {
                    negocio.agregar(articulo);

                    MessageBox.Show("ARTICULO AGREGADO CON EXITO!");
                }
                //Guardo imagen si la levantó localmente:
                if (archivo != null && !(txtUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
          
            finally { Close(); }

        }

        private void frmAltaArticulo_Leave(object sender, EventArgs e)
        {

        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxArticulo.Load("https://aramar.com/wp-content/uploads/2017/05/aramar-suministros-para-el-vidrio-cristal-sin-imagen-disponible.jpg");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

          
            }
        }
    }
}
