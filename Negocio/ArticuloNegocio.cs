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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl FROM ARTICULOS AS A, MARCAS as M, CATEGORIAS as C WHERE A.IdMarca = M.Id and A.IdCategoria = C.Id";
                //comando.CommandText = "select A.Codigo,A.Nombre,A.Descripcion ,A.Precio,A.IdMarca, M.Descripcion Marca, A.IdCategoria,A.ImagenUrl FROM ARTICULOS as A, MARCAS as M WHERE A.IdMarca = M.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArt = (string)lector["Codigo"];
                    aux.NombreArt = (string)lector["Nombre"];
                    aux.DescripcionArt = (string)lector["Descripcion"];
                    aux.PrecioArt = (decimal)lector["Precio"];
                    aux.Marca = new Marca();
                    //aux.IdM.IdMarca = (int)lector["IdMarca"];
                    aux.Marca.DescripcionMarca = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    //aux.IdC.IdCategoria = (int)lector["IdCategoria"];
                    aux.Categoria.DescripcionCategoria = (string)lector["Categoria"];
                    aux.ImagenArt = (string)lector["ImagenUrl"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

