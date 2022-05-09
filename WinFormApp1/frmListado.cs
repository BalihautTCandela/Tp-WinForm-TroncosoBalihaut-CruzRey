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
            Cargar();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*frmAltaArticulo ventana = new frmAltaArticulo();
            ventana.ShowDialog();*/
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.listar();
                dgvListado.DataSource = ListaArticulos;
                ocultarColumnas();
                CargarImagen(ListaArticulos[0].ImagenArt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvListado.Columns["ImagenArt"].Visible = false;
            dgvListado.Columns["Id"].Visible = false;
        }
        private void toolAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo ventana = new frmAltaArticulo();
            ventana.ShowDialog();
            Cargar();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar ventana = new frmEliminar();
            ventana.ShowDialog();
            Cargar();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            frmBusqueda ventana = new frmBusqueda();
            ventana.ShowDialog();

            List<Articulo> ListadoNuevo = ventana.getListaFiltrada();

            dgvListado.DataSource = null;
            dgvListado.DataSource = ListadoNuevo;
            ocultarColumnas();
            //Cargar();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;
            Seleccionado = (Articulo)dgvListado.CurrentRow.DataBoundItem;
            frmAltaArticulo Modificar = new frmAltaArticulo(Seleccionado);
            Modificar.ShowDialog();
            Cargar();
        }
    }
}
