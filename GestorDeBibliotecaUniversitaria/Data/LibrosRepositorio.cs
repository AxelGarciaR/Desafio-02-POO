using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using Microsoft.Data.SqlClient;

namespace GestorDeBibliotecaUniversitaria.Data
{
    internal class LibrosRepositorio
    {

        private readonly string _stringConnect;

        public LibrosRepositorio(string stringConnect)
        {
            _stringConnect = stringConnect;
        }

        public List<Libro> obtenerLibros(){
            
            var libros = new List<Libro>();

            using (var connection = new SqlConnection(_stringConnect)){

                string query = "Select ISBN, autorLibro, tituloLibro, editorialLibro, generoLibro from tbLibro";

                using (var command = new SqlCommand(query, connection)) {
                    
                    connection.Open();

                    using (var reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                            Libro libro = new Libro();

                            libro.ISBN = reader["ISBN"].ToString();
                            libro.AutorLibro = reader["autorLibro"].ToString();
                            libro.TituloLibro = reader["tituloLibro"].ToString();
                            libro.EditorialLibro = reader["editorialLibro"].ToString();
                            libro.GeneroLibro = reader["generoLibro"].ToString();

                            libros.Add(libro);

                        }

                    }

                }

            }

            return libros;
        }

        public void insertarLibro(Libro libro) {

            using (var connection = new SqlConnection(_stringConnect)) {

                string query = "Insert into tbLibro (ISBN, autorLibro, tituloLibro, editorialLibro, generoLibro) values (@Isbn, @Autorlibro, @TituloLibro, @EditorialLibro, @GeneroLibro);";

                using (var command = new SqlCommand(query, connection)) {

                    command.Parameters.Add(new SqlParameter("@Isbn", System.Data.SqlDbType.NVarChar) {Value = libro.ISBN});
                    command.Parameters.Add(new SqlParameter("@Autorlibro", System.Data.SqlDbType.NVarChar) {Value = libro.AutorLibro});
                    command.Parameters.Add(new SqlParameter("@TituloLibro", System.Data.SqlDbType.NVarChar) {Value = libro.TituloLibro});
                    command.Parameters.Add(new SqlParameter("@EditorialLibro", System.Data.SqlDbType.NVarChar) {Value = libro.EditorialLibro});
                    command.Parameters.Add(new SqlParameter("@GeneroLibro", System.Data.SqlDbType.NVarChar) {Value = libro.GeneroLibro});

                    connection.Open();
                    command.ExecuteNonQuery();

                }

            }

        }

        public void actualizarLibro(Libro libro) {

            using (var connection = new SqlConnection(_stringConnect)) {

                string query = "Update tbLibro set ISBN = @Isbn, autorLibro = @Autorlibro, tituloLibro = @TituloLibro, editorialLibro = @EditorialLibro, generoLibro = GeneroLibro where ISBN = @Isbn;";

                using (var command = new SqlCommand(query, connection)) {

                    command.Parameters.Add(new SqlParameter("@Isbn", System.Data.SqlDbType.NVarChar) { Value = libro.ISBN });
                    command.Parameters.Add(new SqlParameter("@Autorlibro", System.Data.SqlDbType.NVarChar) { Value = libro.AutorLibro });
                    command.Parameters.Add(new SqlParameter("@TituloLibro", System.Data.SqlDbType.NVarChar) { Value = libro.TituloLibro });
                    command.Parameters.Add(new SqlParameter("@EditorialLibro", System.Data.SqlDbType.NVarChar) { Value = libro.EditorialLibro });
                    command.Parameters.Add(new SqlParameter("@GeneroLibro", System.Data.SqlDbType.NVarChar) { Value = libro.GeneroLibro });

                    connection.Open();
                    command.ExecuteNonQuery();

                }

            }

        }

        public void eliminarLibro(Libro libro)
        {

            using (var connection = new SqlConnection(_stringConnect))
            {

                string query = "delete from tbLibro where ISBN = @Isbn";

                using (var command = new SqlCommand(query, connection))
                {

                    command.Parameters.Add(new SqlParameter("@Isbn", System.Data.SqlDbType.NVarChar) { Value = libro.ISBN });
                   
                    connection.Open();
                    command.ExecuteNonQuery();

                }

            }

        }




    }
}
