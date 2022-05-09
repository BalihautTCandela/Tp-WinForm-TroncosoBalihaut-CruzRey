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

namespace WinFormApp1
{
    public partial class frmBusqueda : Form
    {
        List<Articulo> listaFiltrada;
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> ListaArticulos;
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.listar();

            string codigo = txtCodigo.Text;

            try
            {
                if (codigo != "")
                {
                    listaFiltrada = ListaArticulos.FindAll(x => x.CodigoArt.ToUpper().Contains(codigo.ToUpper()));
                }
                else
                {
                    listaFiltrada = ListaArticulos;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            Close();

        }

        public List<Articulo> getListaFiltrada()
        {
            return listaFiltrada;
        }
    }
}
