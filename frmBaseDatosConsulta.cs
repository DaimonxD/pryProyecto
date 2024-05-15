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
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos db = new clsBaseDatos();
            db.Listar(dgvLista, txtQuery.Text);
        }
    }
}
