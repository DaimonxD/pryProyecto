﻿using System;
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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola cola = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtC.Text);
            obj.Nombre = txtN.Text;
            obj.Tramite = txtT.Text;
            cola.Agregar(obj);
            cola.Recorrer(dgvCola);
            cola.Recorrer(lstCola);
            cola.Recorrer();
            txtT.Text = "";
            txtN.Text = "";
            txtC.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Primero != null)
            {
                lblC.Text = cola.Primero.Codigo.ToString();
                lblN.Text = cola.Primero.Nombre;
                lblT.Text = cola.Primero.Tramite;
                cola.Eliminar();
                cola.Recorrer(lstCola);
                cola.Recorrer(dgvCola);
                cola.Recorrer();
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
