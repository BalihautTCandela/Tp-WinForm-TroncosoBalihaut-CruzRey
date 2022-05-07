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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.CodigoArt = txtnumeric.Text;
                nuevo.NombreArt = txtNombre.Text;
                nuevo.DescripcionArt = txtDescripcion.Text;

                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;

                negocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
;           }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
