using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryProyecto
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if(Primero == null)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if(Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else if (Nuevo.Codigo > Ultimo.Codigo)
                {
                    Ultimo.Siguiente = Nuevo;
                    Nuevo.Anterior = Ultimo;
                    Ultimo = Nuevo;
                }
                else
                {
                    clsNodo Aux = Primero;
                    clsNodo Ant = Primero;
                    while(Aux.Codigo < Nuevo.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }

                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = Aux;
                    Aux.Siguiente = Nuevo;
                    Nuevo.Anterior = Ant;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if(Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else if(Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
                Primero.Anterior = null;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while(aux.Codigo < Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
                aux = aux.Siguiente;
                aux.Anterior = ant;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while(aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Anterior;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Lista.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
    }
}
