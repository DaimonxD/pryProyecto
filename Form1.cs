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
    public partial class frmDeudaClientes : Form
    {
        public frmDeudaClientes()
        {
            InitializeComponent();
        }


        private clsCliente objCliente = new clsCliente();

        private void frmDeudaClientes_Load(object sender, EventArgs e)
        {
            objCliente.Codigo = 15;
            objCliente.Nombre = "Juan García";
            objCliente.Deuda = 0;

            lblCodigo.Text = objCliente.Codigo.ToString();
            lblNombre.Text = objCliente.Nombre;
            lblDeuda.Text = objCliente.Deuda.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text == "")
            {
                MessageBox.Show("Ingresá algo");
            }
            else
            {
                objCliente.Comprar(Convert.ToDecimal(txtImporte.Text));
                lblDeuda.Text = objCliente.Deuda.ToString();
                txtImporte.Clear();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text == "")
            {
                MessageBox.Show("Ingresá algo");
            }
            else
            {
                objCliente.Pagar(Convert.ToDecimal(txtImporte.Text));
                lblDeuda.Text = objCliente.Deuda.ToString();
                txtImporte.Clear();
            }
        }
    }
}
