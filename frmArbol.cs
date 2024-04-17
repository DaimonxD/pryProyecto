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
    }
}
