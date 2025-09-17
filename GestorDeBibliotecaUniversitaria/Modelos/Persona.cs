using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeBibliotecaUniversitaria.Clases
{
    public class Persona
    {
        // estos atributos se mantienen privados para el encapsulamiento
        private string iD;
        private string Nombre;
        private string Correo;
        private string TipoPersona;

        public string id
        {

            get { return iD; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    iD = value;
                }
                else
                {

                    throw new ArgumentException("El campo iD no puede estar vacio");

                }
            }
        }

        public string nombre
        {

            get { return Nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Nombre = value;
                }
                else
                {

                    throw new ArgumentException("El campo Nombre no puede estar vacio");

                }
            }
        }

        public string correo
        {

            get { return Correo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Correo = value;
                }
                else
                {

                    throw new ArgumentException("El campo Correo no puede estar vacio");

                }

            }
        }

        public string tipoPersona
        {

            get { return TipoPersona; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    TipoPersona = value;
                }
                else
                {

                    throw new ArgumentException("El campo Tipo de Persona no puede estar vacio");

                }

            }
        }

        // Constructor
        public Persona(string ID, string NOMBRE, string CORREO, string TIPOdePERSONA)
        {
            id = ID;
            nombre = NOMBRE;
            correo = CORREO;
            tipoPersona = TIPOdePERSONA;
        }

        // constructor vacio 
        public Persona() { }

        // metodo para el polimorfismo
        public virtual string MostrarInfo()
        {
            return $"ID: {id}, Nombre: {nombre}, Correo: {correo}, Tipo de Persona: {tipoPersona}";
        }

    }
}
