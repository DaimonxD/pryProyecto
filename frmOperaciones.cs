using System;
using System.Collections;
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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDatos db = new clsBaseDatos();
        String varSQL;

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cboxConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una consulta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            varSQL = ObtenerConsulta(cboxConsulta.SelectedIndex + 1);
            if (varSQL != null)
            {
                db.Listar(dgvConsulta, varSQL);
            }
        }

        private string ObtenerConsulta(int query)
        {
            switch (query)
            {
                case 1:
                    lblConsulta.Text = "Seleccionar todos los libros con sus autores y países";
                    return "SELECT l.titulo, " +
                        "(SELECT nombre FROM Autor WHERE idAutor = l.idAutor) AS autor, " +
                        "(SELECT nombre FROM Pais WHERE idPais = l.idPais) AS pais " +
                        "FROM Libro l";
                case 2:
                    lblConsulta.Text = "Seleccionar todos los libros publicados en Español";
                    return "SELECT l.titulo, " +
                        "(SELECT nombre FROM Idioma WHERE ididioma = l.idIdioma) AS idioma " +
                        "FROM Libro l " +
                        "WHERE l.idIdioma = (SELECT ididioma FROM Idioma WHERE nombre = 'Español');";
                case 3:
                    lblConsulta.Text = "Contar la cantidad total de libros por autor";
                    return "SELECT a.nombre, " +
                        "(SELECT COUNT(*) FROM Libro WHERE idAutor = a.idAutor) AS total libros " +
                        "FROM Autor a";
                case 4:
                    lblConsulta.Text = "Obtener los libros publicados después del año 1950";
                    return "SELECT titulo, val(año) AS año " +
                        "FROM Libro " +
                        "WHERE val(año) > 1950;";
                case 5:
                    lblConsulta.Text = "Obtener los autores que tienen libros en más de un idioma";
                    return "SELECT a.nombre " +
                        "FROM Autor AS a " +
                        "WHERE a.idAutor IN (" +
                        "SELECT l.idAutor " +
                        "FROM Libro AS l " +
                        "GROUP BY l.idAutor " +
                        "HAVING COUNT(l.idIdioma) > 1)";
                case 6:
                    lblConsulta.Text = "Seleccionar el libro más caro";
                    return "SELECT titulo, precio " +
                        "FROM Libro " +
                        "ORDER BY precio DESC";
                case 7:
                    lblConsulta.Text = "Seleccionar el libro más antiguo";
                    return "SELECT titulo, año " +
                        "FROM Libro " +
                        "ORDER BY año ASC";
                case 8:
                    lblConsulta.Text = "Calcular el precio promedio de los libros por idioma";
                    return "SELECT i.nombre, " +
                        "(SELECT AVG(l.precio) " +
                        "FROM Libro AS l " +
                        "WHERE l.idIdioma = i.ididioma) AS precio_promedio " +
                        "FROM Idioma AS i";
                case 9:
                    lblConsulta.Text = "Listar todos los países y la cantidad de libros que tienen";
                    return "SELECT p.nombre, " +
                        "COUNT(l.idLibro) AS total_libros " +
                        "FROM Pais p " +
                        "LEFT JOIN Libro l ON p.idPais = l.idPais " +
                        "GROUP BY p.nombre;";
                case 10:
                    lblConsulta.Text = "Encontrar todos los libros del autor Gabriel García Márquez";
                    return "SELECT l.titulo " +
                        "FROM Libro AS l " +
                        "WHERE l.idAutor " +
                        "IN (SELECT idAutor FROM Autor WHERE nombre = 'Gabriel García Márquez')";
                case 11:
                    lblConsulta.Text = "Obtener los autores con libros publicados en España";
                    return "SELECT DISTINCT a.nombre " +
                        "FROM Autor AS a " +
                        "WHERE a.idAutor " +
                        "IN (SELECT l.idAutor FROM Libro AS l WHERE l.idPais = (SELECT idPais FROM Pais WHERE nombre = 'España'))";
                case 12:
                    lblConsulta.Text = "Calcular el valor total del inventario de libros";
                    return "SELECT SUM(precio * cantidad) AS valor_total_inventario " +
                        "FROM Libro";
                case 13:
                    lblConsulta.Text = "Listar todos los idiomas y la cantidad de libros en cada idioma";
                    return "SELECT i.nombre, " +
                        "COUNT(l.idLibro) AS total_libros " +
                        "FROM Idioma i " +
                        "LEFT JOIN Libro l ON i.ididioma = l.idIdioma " +
                        "GROUP BY i.nombre";
                case 14:
                    lblConsulta.Text = "Encontrar los libros publicados en un rango de años entre 1700 y 1900";
                    return "SELECT titulo, val(año) AS año " +
                        "FROM Libro WHERE val(año) " +
                        "BETWEEN 1700 AND 1900";
                case 15:
                    lblConsulta.Text = "Listar todos los libros junto con el nombre de su autor y el idioma";
                    return "SELECT l.titulo, " +
                        "(SELECT nombre FROM Autor WHERE idAutor = l.idAutor) AS autor, " +
                        "(SELECT nombre FROM Idioma WHERE ididioma = l.idIdioma) AS idioma " +
                        "FROM Libro AS l";
                case 16:
                    lblConsulta.Text = "Seleccionar los libros que tienen una cantidad menor a 5 en inventario";
                    return "SELECT titulo, cantidad " +
                        "FROM Libro " +
                        "WHERE cantidad < 5;";
                case 17:
                    lblConsulta.Text = "Encontrar los autores que tienen más de 2 libros publicados";
                    return "SELECT nombre " +
                        "FROM Autor " +
                        "WHERE idAutor " +
                        "IN (SELECT idAutor FROM Libro GROUP BY idAutor HAVING COUNT(idLibro) > 2)";
                case 18:
                    lblConsulta.Text = "Obtener la cantidad total de libros disponibles por país";
                    return "SELECT p.nombre, " +
                        "SUM(l.cantidad) AS total_libros " +
                        "FROM Pais AS p, Libro AS l " +
                        "WHERE p.idPais = l.idPais " +
                        "GROUP BY p.nombre";
                case 19:
                    lblConsulta.Text = "Seleccionar los libros con un precio mayor al promedio de todos los libros";
                    return "SELECT titulo, precio " +
                        "FROM Libro " +
                        "WHERE precio > (SELECT AVG(precio) FROM Libro);";
                case 20:
                    lblConsulta.Text = "Seleccionar los libros con mayor cantidad de copias";
                    return "SELECT * " +
                        "FROM Libro " +
                        "WHERE cantidad > 5 " +
                        "ORDER BY cantidad DESC";
                default:
                    return null;
            }
        }
    }
}
