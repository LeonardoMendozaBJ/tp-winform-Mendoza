using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" select Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdCategoria, A.IdMarca, A.ImagenURL, M.Id, M.Descripcion, C.Id, C.Descripcion " +
                    "from ARTICULOS A left join MARCAS M on A.IdMarca = M.Id left join CATEGORIAS c on a.IdCategoria = C.Id ");
                datos.ejecutarLecura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!Convert.IsDBNull(datos.Lector["Precio"]))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenURL = (string)datos.Lector["ImagenURL"];

                    aux.categoria = new Categoria();
                    aux.categoria.IdCategoria = (int)datos.Lector["Id"];
                    aux.categoria.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.marca = new Marca();
                    aux.marca.Idmarca = (int)datos.Lector["Id"];
                    aux.marca.Descripcion = (string)datos.Lector["Descripcion"];


                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenURL, Precio) Values ('" + nuevo.Codigo + "' , '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "' , " + nuevo.marca.Idmarca + "," + nuevo.categoria.IdCategoria + ", '" + nuevo.ImagenURL + "' ," + nuevo.Precio + ")");
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {
                     throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void modificar(Articulo nuevo)
        {
        }
    }
}