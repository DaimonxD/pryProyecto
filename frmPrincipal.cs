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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple simple = new frmListaSimple();
            simple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble doble = new frmListaDoble();
            doble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol arbol = new frmArbol();
            arbol.ShowDialog();
        }

        private void opreacionesConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosOperaciones db1 = new frmBaseDatosOperaciones();
            db1.ShowDialog();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsulta db2 = new frmBaseDatosConsulta();
            db2.ShowDialog();
        }

        private void repasoDeOpreacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Proximamente
        }

        private void datosDelDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDev dev = new frmDev();
            dev.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
