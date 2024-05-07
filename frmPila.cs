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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtC.Text);
            obj.Nombre = txtN.Text;
            obj.Tramite = txtT.Text;
            pila.Agregar(obj);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            pila.Recorrer();
            txtT.Text = "";
            txtN.Text = "";
            txtC.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                lblC.Text = pila.Primero.Codigo.ToString();
                lblN.Text = pila.Primero.Nombre;
                lblT.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(lstPila);
                pila.Recorrer(dgvPila);
                pila.Recorrer();
            }
            else
            {
                lblC.Text = "";
                lblT.Text = "";
                lblN.Text = "";
            }
        }

    }

}
