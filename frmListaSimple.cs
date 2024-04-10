using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryProyecto
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple lst = new clsListaSimple();
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(lst.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboxLista.Text);
                lst.Eliminar(x);
                lst.Recorrer(lstLista);
                lst.Recorrer(dgvLista);
                lst.Recorrer(cboxLista);
                lst.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void cboxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxLista .Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtC.Text);
            obj.Nombre = txtN.Text;
            obj.Tramite = txtT.Text;
            lst.Agregar(obj);
            lst.Recorrer(dgvLista);
            lst.Recorrer(lstLista);
            lst.Recorrer(cboxLista);
            lst.Recorrer();
            txtT.Text = "";
            txtN.Text = "";
            txtC.Text = "";
        }
    }
}
