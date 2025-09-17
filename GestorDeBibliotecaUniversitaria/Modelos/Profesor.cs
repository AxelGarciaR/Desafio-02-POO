using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeBibliotecaUniversitaria.Clases
{
    // La clase "Profesor" esta heredada de "Persona"
    public class Profesor : Persona
    {
        // aqui agregaremos un constructor para profesor utilisando la base de Persona.cs
        public Profesor(string ID, string NOMBRE, string CORREO) : base(ID, NOMBRE, CORREO, "Profesor") { }

        // Constructor Vacio
        public Profesor() { }

        // Aqui utilizamos polimorfismo para poder sobreescribir el metodo mostrarInfo
        public override string MostrarInfo()
        {
            return base.MostrarInfo();
        }
    }
}
