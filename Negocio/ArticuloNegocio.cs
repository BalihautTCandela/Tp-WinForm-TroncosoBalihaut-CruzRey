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
                comando.CommandText = "select Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria,ImagenUrl FROM ARTICULOS ";
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
                    aux.IdM = new Marca();
                    aux.IdM.IdMarca = (int)lector["IdMarca"];
                    aux.IdC = new Categoria();
                    aux.IdC.IdCategoria = (int)lector["IdCategoria"];
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

