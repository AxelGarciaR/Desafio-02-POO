using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using GestorDeBibliotecaUniversitaria.Data;

namespace GestorDeBibliotecaUniversitaria.Servicios
{
    internal class LibroService
    {

        private readonly LibrosRepositorio _libroRepository;

        public LibroService(LibrosRepositorio libro) {

            _libroRepository = libro;

        }

        public List<Libro> ListarLibros()
        {

            return _libroRepository.obtenerLibros();

        }

        public void CrearUsuario(Libro libro)
        {

            if (string.IsNullOrEmpty(libro.ISBN) || string.IsNullOrEmpty(libro.AutorLibro)
                || string.IsNullOrEmpty(libro.TituloLibro) || string.IsNullOrEmpty(libro.EditorialLibro)
                || string.IsNullOrEmpty(libro.GeneroLibro)){

                throw new Exception("Error al crear usuario");

            }
            else {

                _libroRepository.insertarUsuario(libro);
            }

        }

       
        public void ActualizarUsuario(Libro libro)
        {
            if (libro.ISBN.Length > 0)
                throw new ArgumentException("Debe de seleecionar un libro para actualizar");

            if (string.IsNullOrEmpty(libro.ISBN) || string.IsNullOrEmpty(libro.AutorLibro)
                || string.IsNullOrEmpty(libro.TituloLibro) || string.IsNullOrEmpty(libro.EditorialLibro)
                || string.IsNullOrEmpty(libro.GeneroLibro))
            {
                throw new Exception("No dejar espacios en blanco");
            }
            else
            {
                _libroRepository.insertarUsuario(libro);
            }

            _libroRepository.actualizarLibro(libro);
        }


        public void EliminarUsuario(Libro libro)
        {

            if (string.IsNullOrEmpty(libro.ISBN))
            {

                throw new Exception("Seleccione un libro para eliminar");

            }
            else
            {

                _libroRepository.eliminarLibro(libro);
            }

        }

    }
}
