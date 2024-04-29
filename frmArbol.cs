using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyecto
{
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
            inOrden.Checked = true;
        }

        clsArbol arbol = new clsArbol();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtC.Text);
            obj.Nombre = txtN.Text;
            obj.Tramite = txtT.Text;
            arbol.Agregar(obj);
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(tView);
            arbol.Recorrer(cboxT);
            txtT.Text = "";
            txtN.Text = "";
            txtC.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cboxT.Text);
                arbol.Eliminar(x);
                arbol.Recorrer(dgvTree);
                arbol.Recorrer(cboxT);
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void cboxT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxT.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {

        }
    }
}
