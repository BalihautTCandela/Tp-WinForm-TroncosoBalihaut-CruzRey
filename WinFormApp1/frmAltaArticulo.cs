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

                negocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
;           }
        }
    }
}
