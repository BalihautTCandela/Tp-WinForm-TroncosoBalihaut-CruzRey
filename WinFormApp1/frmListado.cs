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
    public partial class frmListado : Form
    {
        private List<Articulo> ListaArticulos;
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            { 
                ListaArticulos = negocio.listar();
                dgvListado.DataSource = ListaArticulos;
                dgvListado.Columns["ImagenArt"].Visible = false;
                CargarImagen(ListaArticulos[0].ImagenArt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Elegido = (Articulo)dgvListado.CurrentRow.DataBoundItem;
            CargarImagen(Elegido.ImagenArt);
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbArticulo.Load(Imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://www.agora-gallery.com/advice/wp-content/uploads/2015/10/image-placeholder.png");
            }


        }
    }
}
