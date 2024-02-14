using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; 

                    lista.Add(aux);
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

        public void agegar(Marca nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                datos.setearParametro("Descripcion", nueva.Descripcion);
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

        public void modificar(Marca modificada)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @Descripcion where Id = @Id");                
                datos.setearParametro("Descripcion", modificada.Descripcion);
                datos.setearParametro("Id", modificada.Id);

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

        public void eliminar(int id)
        {

        }
    }
}
