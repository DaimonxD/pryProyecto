﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryProyecto
{
    class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if(Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if(Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo ant = Primero;
                    clsNodo aux = Primero;
                    while(Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if(Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Ant = Primero;
                clsNodo Aux = Primero;
                while(Aux.Codigo != Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }
                Ant.Siguiente = Aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
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
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
