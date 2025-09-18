using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using GestorDeBibliotecaUniversitaria.Data;

namespace GestorDeBibliotecaUniversitaria.Servicios
{
    internal class PrestamoService
    {

        private readonly PrestamosRepositorio _prestamoRepository;

        public PrestamoService(PrestamosRepositorio repositorio)
        {
            _prestamoRepository = repositorio;
        }

        // Listar todos los préstamos
        public List<Prestamo> ListarPrestamos()
        {
            return _prestamoRepository.ObtenerPrestamos();
        }

        // Crear un préstamo
        public void CrearPrestamo(Prestamo prestamo)
        {
            _prestamoRepository.InsertarPrestamo(prestamo);
        }

        // Actualizar un préstamo
        public void ActualizarPrestamo(Prestamo prestamo)
        {
            if ((string.IsNullOrEmpty(prestamo.CarnetPersona)))
                throw new Exception("Seleccione un prestamo para actualizar");

            if (string.IsNullOrEmpty(prestamo.CarnetPersona) || string.IsNullOrEmpty(prestamo.ISBNLibro))
                throw new Exception("No dejar espacios en blanco");

            _prestamoRepository.ActualizarPrestamo(prestamo);
        }

        // Eliminar un préstamo
        public void EliminarPrestamo(Prestamo prestamo)
        {
            if ((string.IsNullOrEmpty(prestamo.CarnetPersona)))
                throw new Exception("Seleccione un préstamo válido para eliminar");

            _prestamoRepository.EliminarPrestamo(prestamo);
        }
    }
}

