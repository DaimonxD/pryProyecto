using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;

namespace pryProyecto
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador;

        private string cadena = "provider=microsoft.jet.oledb.4.0;data source=Libreria.mdb";
        private string cadena2 = "provider=microsoft.ace.oledb.12.0;data source=Libreria.mdb";

        public void Listar(DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");

                dgv.DataSource = null;
                dgv.DataSource = DS.Tables["Autor"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }


        public void Listar(DataGridView dgv, string Query)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Query;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Tables");

                dgv.DataSource = null;
                dgv.DataSource = DS.Tables["Tables"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
}
