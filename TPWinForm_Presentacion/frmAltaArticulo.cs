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
                cbxMarca.SelectedIndex = -1;

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                
                
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


            /* ArticuloNegocio negocio = new ArticuloNegocio();/*
            /* Articulo articulo = new Articulo();*/

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {


                if (validarAceptar())
                    
               
                return;

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

        private bool validarAceptar()
        {
            Filtros filtro = new Filtros();
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, Ingrese un codigo de Art.");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, Ingrese datos en Nombre.");
                return true;


            }
            if (!(filtro.soloLetras(txtNombre.Text)) && !(filtro.soloNumeros(txtNombre.Text)) )
            {
                MessageBox.Show("Solo se admiten Únicamente letras y números para Nombres");
                return true;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, Ingrese datos en Descripción.");
                return true;
            }
            if (!(filtro.soloLetras(txtDescripcion.Text)) && !(filtro.soloNumeros(txtDescripcion.Text)))
            {
                MessageBox.Show("Solo se admiten Únicamente letras y números para la Descripción");
                return true;
            }

         

            if (cbxMarca.SelectedIndex < 0 )
            {
               
            
                    MessageBox.Show("Se debe seleccionar una Marca");
                    return true;
                }
            /* if (!(filtro.soloNumeros(txtFiltroAvanzado.Text)))
             {
                 MessageBox.Show("Solo numeros para filtrar por un campo de Precios...");
                 return true;
             }*/

            if (cbxCategoria.SelectedIndex < 0)
            { 
                MessageBox.Show("Se debe seleccionar una Categoria");
                return true;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, Ingrese un Precio que contengan datos Numericos.");
                return true;

            }
            if (!(filtro.soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Solo se admiten datos Numericos para el Precio del Articulo");
                return true;
            }
            return false;
        }

            
        }


    }



