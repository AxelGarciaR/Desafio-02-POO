using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeBibliotecaUniversitaria.Clases
{
    // Esta clase "Estudiante" esta heredada de "Persona"
    public class Estudiante : Persona
    {
        // Atributos para los estudiantes
        private bool moraActiva;
        private decimal valorMora;
        private DateTime nuevaFechamora;


        public bool MoraActiva
        {
            get { return moraActiva; }
            set { moraActiva = value; }
        }

        public decimal ValorMora
        {
            get { return valorMora; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor de la mora no puede ser negativo.");
                }
                valorMora = value;
            }
        }

        public DateTime FechaMora
        {
            get { return nuevaFechamora; }
            set { nuevaFechamora = value; }
        }

        public Estudiante(string ID, string NOMBRE, string CORREO, bool Moraactiva, decimal Valormora, DateTime Fechamora) : base(ID, NOMBRE, CORREO, "Estudiante")
        {
            // el constructor de persona ya se encarga de validar los campos base definidos en Persona.cs
            // Asi que, aqui se validan los atributos hechos especificamente para "Estudiante":
            MoraActiva = Moraactiva;
            ValorMora = Valormora;
            FechaMora = Fechamora;
        }

        // constructor vacio
        public Estudiante() { }

        public override string MostrarInfo()
        {
            string infobase = base.MostrarInfo();
            return $"{infobase}, Mora Activa: {(MoraActiva ? "Si" : "No")}, Valor de Mora: {ValorMora}";
        }
    }
}
