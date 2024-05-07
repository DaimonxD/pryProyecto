using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            arbol.Equilibrar();
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(tView);
            arbol.Recorrer(cboxT);

            if(inOrden.Checked == true)
            {
                arbol.RecorrerAsc();
            }
            if(Descendente.Checked == true)
            {
                arbol.RecorrerDes();
            }
            if(preOrden.Checked == true)
            {
                arbol.RecorrerPreOrden();
            }
            if(postOrden.Checked == true)
            {
                arbol.RecorrerPostOrden();
            }
        }

        private void inOrdenA_CheckedChanged(object sender, EventArgs e)
        {
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(cboxT);
            arbol.Recorrer(tView);
            arbol.RecorrerAsc();
        }

        private void Descendente_CheckedChanged(object sender, EventArgs e)
        {
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(cboxT);
            arbol.Recorrer(tView);
            arbol.RecorrerDes();
        }

        private void preOrden_CheckedChanged(object sender, EventArgs e)
        {
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(cboxT);
            arbol.Recorrer(tView);
            arbol.RecorrerPreOrden();
        }

        private void postOrden_CheckedChanged(object sender, EventArgs e)
        {
            arbol.Recorrer(dgvTree);
            arbol.Recorrer(cboxT);
            arbol.Recorrer(tView);
            arbol.RecorrerPostOrden();
        }
    }
}
