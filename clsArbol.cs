using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyecto
{
    internal class clsArbol
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if(Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while(Aux != null)
                {
                    NodoPadre = Aux;
                    if(Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if(Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            inOrdenAsc(Lista, Raiz);
        }

        private void inOrdenAsc(ComboBox lst, clsNodo r)
        {
            if(r.Izquierdo != null)
            {
                inOrdenAsc(lst, r.Izquierdo);
            }
            lst.Items.Add(r.Codigo);
            if(r.Derecho != null)
            {
                inOrdenAsc(lst, r.Derecho);
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            inOrdenAsc(grilla, Raiz);
        }

        private void inOrdenAsc(DataGridView dgv, clsNodo r)
        {
            if (r.Izquierdo != null) inOrdenAsc(dgv, r.Izquierdo);
            dgv.Rows.Add(r.Codigo, r.Nombre, r.Tramite);
            if (r.Derecho != null) inOrdenAsc(dgv, r.Derecho);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo r, TreeNode nodo)
        {
            TreeNode NodoPadre = new TreeNode(r.Codigo.ToString());
            nodo.Nodes.Add(NodoPadre);
            if(r.Izquierdo != null)
            {
                PreOrden(r.Izquierdo, NodoPadre);
            }
            if(r.Derecho != null)
            {
                PreOrden(r.Derecho, NodoPadre);
            }
        }
    }
}
