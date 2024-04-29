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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
            rAs.Checked = true;
        }

        clsListaDoble lst = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rAs.Checked)
            {
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtC.Text);
                obj.Nombre = txtN.Text;
                obj.Tramite = txtT.Text;
                lst.Agregar(obj);
                lst.Recorrer(dgvListaDoble);
                lst.Recorrer(lstListaDoble);
                lst.Recorrer(cboxListaDoble);
                lst.Recorrer();
                txtT.Text = "";
                txtN.Text = "";
                txtC.Text = "";
            }
            if(rDes.Checked)
            {
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtC.Text);
                obj.Nombre = txtN.Text;
                obj.Tramite = txtT.Text;
                lst.Agregar(obj);
                lst.RecorrerDes(dgvListaDoble);
                lst.RecorrerDes(lstListaDoble);
                lst.RecorrerDes(cboxListaDoble);
                lst.RecorrerDes();
                txtT.Text = "";
                txtN.Text = "";
                txtC.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(rAs.Checked)
            {
                if (lst.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cboxListaDoble.Text);
                    lst.Eliminar(x);
                    lst.Recorrer(lstListaDoble);
                    lst.Recorrer(dgvListaDoble);
                    lst.Recorrer(cboxListaDoble);
                    lst.Recorrer();
                }
                else
                {
                    MessageBox.Show("La lista está vacía");
                }
                btnEliminar.Enabled = false;
            }
            if(rDes.Checked)
            {
                if (lst.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cboxListaDoble.Text);
                    lst.Eliminar(x);
                    lst.RecorrerDes(lstListaDoble);
                    lst.RecorrerDes(dgvListaDoble);
                    lst.RecorrerDes(cboxListaDoble);
                    lst.RecorrerDes();
                }
                else
                {
                    MessageBox.Show("La lista está vacía");
                }
                btnEliminar.Enabled = false;
            }

        }

        private void cboxListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxListaDoble.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

    }
}
