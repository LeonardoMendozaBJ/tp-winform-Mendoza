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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
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



               /* cboMarca.DataSource = marca.listar();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "marca";
                cboMarca.SelectedIndex = -1;

                cboCategoria.DataSource = categoria.listar();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "categoria";
                cboCategoria.SelectedIndex = -1;
                
                
                if (articulo != null)
                {
                    Text = "Modificar Articulo";
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    if (articulo.marca != null)
                        cboMarca.SelectedValue = articulo.marca.marca;
                    if (articulo.categoria != null)
                        cboCategoria.SelectedValue = articulo.categoria.categoria;

                }
               */

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
            Articulo articulo = new Articulo();
            try
            {
               /* if (articulo == null) */
                   

                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = rtbDescripcion.Text.Trim();
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.ImagenURL = txtUrl.Text.Trim();
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());

               /* if (articulo.Codigo != "")
                    negocio.modificar(articulo);

                else*/
                negocio.agregar(articulo);

                MessageBox.Show("operación realizada con exito!");
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally { Close(); }

        }

    }
}
