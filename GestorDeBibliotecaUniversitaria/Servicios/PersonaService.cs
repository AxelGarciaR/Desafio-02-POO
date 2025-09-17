using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using GestorDeBibliotecaUniversitaria.Data;

namespace GestorDeBibliotecaUniversitaria.Servicios
{
    internal class PersonaService
    {
        private readonly PersonasRepositorio _personasRepositorio;

        public PersonaService(PersonasRepositorio personasRepositorio)
        {
            _personasRepositorio = personasRepositorio;
        }

        // metodo para crear una persona:
        public void CrearPersona(Persona persona) 
        {
            _personasRepositorio.InsertarPersona(persona);
        }

        // metodo para listar a todas las personas de la base de datos:
        public List<Persona> ListarPersonas() 
        {
            return _personasRepositorio.ObtenerPersonas();
        }

        // metodo para actualizar:
        public void ActualizarPersona(Persona persona) 
        {
            _personasRepositorio.ActualizarPersona(persona);
        }

        // metodo para eliminar una persona de la base de datos:
        public void EliminarPersona(string carnet) 
        {
            _personasRepositorio.EliminarPersona(carnet);
        }


    }
}
