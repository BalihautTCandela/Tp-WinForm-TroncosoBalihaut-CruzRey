using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public String CodigoArt { get; set; }
        public String NombreArt { get; set; }
        public String DescripcionArt { get; set; }
        public Marca IdM { get; set; }
        public Categoria IdC { get; set; }
        public String ImagenArt  { get; set; }
        public Decimal PrecioArt { get; set; }





    }
}
