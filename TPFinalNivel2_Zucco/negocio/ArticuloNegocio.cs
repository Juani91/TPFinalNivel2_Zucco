using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, M.Descripcion Marca, Nombre, A.Descripcion, Precio, C.Descripcion Categoria, ImagenUrl, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();

                    art.Id = (int)datos.Lector["Id"];
                    art.Codigo = (string)datos.Lector["Codigo"];                    
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    art.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        art.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    art.Marca = new Marca();
                    art.Marca.Id = (int)datos.Lector["IdMarca"];
                    art.Marca.Descripcion = (string)datos.Lector["Marca"];                    
                    art.Categoria = new Categoria();
                    art.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    art.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(art);
                }
                
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) values (@Codigo, @Nombre, @Descripcion, @Precio, @idMarca, @idCategoria, @ImagenUrl)");
                datos.setearParametro("Codigo", nuevo.Codigo);
                datos.setearParametro("Nombre", nuevo.Nombre);
                datos.setearParametro("Descripcion", nuevo.Descripcion);
                datos.setearParametro("Precio", nuevo.Precio);
                datos.setearParametro("IdMarca", nuevo.Marca.Id);
                datos.setearParametro("IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("ImagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificar(Articulo modificar)
        {

        }
    }
}
