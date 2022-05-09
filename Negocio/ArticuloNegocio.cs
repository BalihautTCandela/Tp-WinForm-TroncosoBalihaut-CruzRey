using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, Precio, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl FROM ARTICULOS AS A, MARCAS as M, CATEGORIAS as C WHERE IdMarca = M.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArt = (string)datos.Lector["Codigo"];
                    aux.NombreArt = (string)datos.Lector["Nombre"];
                    aux.DescripcionArt = (string)datos.Lector["Descripcion"];
                    aux.PrecioArt = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenArt = (string)datos.Lector["ImagenUrl"];

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

        public void agregar(Articulo nuevoArt)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl) VALUES ('" + nuevoArt.CodigoArt + "', '" + nuevoArt.NombreArt + "', '" + nuevoArt.DescripcionArt + "', @IdMarca, @IdCategoria," + nuevoArt.PrecioArt + ", '" + nuevoArt.ImagenArt + "' )");
                datos.setearParametro("@IdMarca",nuevoArt.Marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevoArt.Categoria.IdCategoria);
               /// datos.setearParametro("@ImagenUrl", nuevoArt.ImagenArt);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

