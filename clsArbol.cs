using System;
using System.Collections.Generic;
using System.IO;
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
            if (r != null)
            {   
                if (r.Izquierdo != null) inOrdenAsc(lst, r.Izquierdo);
                lst.Items.Add(r.Codigo);
                if(r.Derecho != null) inOrdenAsc(lst, r.Derecho);
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            inOrdenAsc(grilla, Raiz);
        }

        private void inOrdenAsc(DataGridView dgv, clsNodo r)
        {
            if(r != null)
            {
                if (r.Izquierdo != null) inOrdenAsc(dgv, r.Izquierdo);
                dgv.Rows.Add(r.Codigo, r.Nombre, r.Tramite);
                if (r.Derecho != null) inOrdenAsc(dgv, r.Derecho);
            }
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
            if (r != null)
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

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while(Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if(Raiz != null)
            {
                if(NodoPadre.Izquierdo != null)
                {
                    GrabarVectorInOrden(NodoPadre.Izquierdo);
                }
                Vector[i] = NodoPadre;
                i = i + 1;
                if(NodoPadre.Derecho != null)
                {
                    GrabarVectorInOrden(NodoPadre.Derecho);
                }
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if(ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if(NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if(NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i++;
            }
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        public void RecorrerAsc()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrdenAscendente.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de Espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            Ascendente(Raiz, AD);
            AD.Close();
        }

        private void Ascendente(clsNodo Raiz, StreamWriter Writer)
        {
            if (Raiz != null)
            {
                Ascendente(Raiz.Izquierdo, Writer);
                Writer.Write($"{Raiz.Codigo};{Raiz.Nombre};{Raiz.Tramite}\n");
                Ascendente(Raiz.Derecho, Writer);
            }
        }

        public void RecorrerDes()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrdenDescendente.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de Espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            Descendente(Raiz, AD);
            AD.Close();
        }

        private void Descendente(clsNodo Raiz, StreamWriter Writer)
        {
            if (Raiz != null)
            {
                Descendente(Raiz.Derecho, Writer);
                Writer.Write($"{Raiz.Codigo};{Raiz.Nombre};{Raiz.Tramite}\n");
                Descendente(Raiz.Izquierdo, Writer);
            }
        }

        public void RecorrerPreOrden()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPreOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de Espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            PreOrden(Raiz, AD);
            AD.Close();
        }

        private void PreOrden(clsNodo Raiz, StreamWriter Writer)
        {
            if (Raiz != null)
            {
                Writer.Write($"{Raiz.Codigo};{Raiz.Nombre};{Raiz.Tramite}\n");
                PreOrden(Raiz.Izquierdo, Writer);
                PreOrden(Raiz.Derecho, Writer);
            }
        }

        public void RecorrerPostOrden()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPostOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PostOrden(Raiz, AD);
            AD.Close();
        }

        private void PostOrden(clsNodo Raiz, StreamWriter Writer)
        {
            if (Raiz != null)
            {
                PostOrden(Raiz.Izquierdo, Writer);
                PostOrden(Raiz.Derecho, Writer);
                Writer.Write($"{Raiz.Codigo};{Raiz.Nombre};{Raiz.Tramite}\n");
            }
        }
    }
}
