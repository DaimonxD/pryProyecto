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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDatos db = new clsBaseDatos();
        String varSQL;

        private void btnSelect1_Click(object sender, EventArgs e) //Proyección Simple
        {
            varSQL = "select titulo " +
                "from libro " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnSelect2_Click(object sender, EventArgs e) //Proyección Multiatributo
        {
            varSQL = "select titulo, año " +
                "from libro " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnSelect3_Click(object sender, EventArgs e) //Juntar
        {
            varSQL = "select * " +
                "from libro, idioma " +
                "where libro.ididioma = idioma.ididioma " + 
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnWhere1_Click(object sender, EventArgs e) //Selección Simple
        {
            varSQL = "select * " +
                "from libro " +
                "where idautor = 2 " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnWhere2_Click(object sender, EventArgs e) //Selección Multiatributo
        {
            varSQL = "select * " +
                "from libro " +
                "where libro.ididioma = 3 AND libro.precio > 500 ";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnWhere3_Click(object sender, EventArgs e) //Selección por Convolución
        {
            varSQL = "select * " +
                "from libro " +
                "where ididioma in (select distinct ididioma from libro where ididioma < 5) " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnAlgebra1_Click(object sender, EventArgs e) //Unión
        {
            varSQL = "select * " + "from libro " + "where idautor = 2 " + "union " + 
                "select * " + "from libro " + "where idautor = 5 " + "union " + 
                "select * " + "from libro " + "where idautor = 3 " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnAlgebra2_Click(object sender, EventArgs e) //Intersección
        {
            varSQL = "SELECT * " +
                "FROM Libro " +
                "WHERE IdIdioma IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            db.Listar(dgvOperaciones, varSQL);
        }

        private void btnAlgebra3_Click(object sender, EventArgs e) //Diferencia
        {
            varSQL = "select * " +
                "from libro " +
                "where ididioma not in " +
                "(select distinct ididioma " +
                "from libro " +
                "where ididioma < 5) " +
                "order by 1 desc";
            db.Listar(dgvOperaciones, varSQL);
        }
    }
}
