using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestorDeBibliotecaUniversitaria.Clases
{
    internal class Prestamo
    {
        private int idPrestamo;
        private DateTime fechaPrestamo;
        private DateTime finFechaPrestamo;
        private bool moraActivaPrestamo;
        private decimal valorMoraPrestamo;
        private string carnetPersona;
        private string isbnLibro;

        public int IdPrestamo
        {
            get { return idPrestamo; }
            set
            {
                if (value > 0)
                    idPrestamo = value;
                else
                    throw new ArgumentException("ID de préstamo inválido");
            }
        }

        public DateTime FechaPrestamo
        {
            get { return fechaPrestamo; }
            set
            {
                if (value <= DateTime.Now)
                    fechaPrestamo = value;
                else
                    throw new ArgumentException("La fecha de préstamo no puede ser futura");
            }
        }

        public DateTime FinFechaPrestamo
        {
            get { return finFechaPrestamo; }
            set
            {
                if (value >= FechaPrestamo)
                    finFechaPrestamo = value;
                else
                    throw new ArgumentException("La fecha de fin no puede ser anterior a la de inicio");
            }
        }

        public bool MoraActivaPrestamo
        {
            get { return moraActivaPrestamo; }
            set { moraActivaPrestamo = value; }
        }

        public decimal ValorMoraPrestamo
        {
            get { return valorMoraPrestamo; }
            set
            {
                if (value >= 0)
                    valorMoraPrestamo = value;
                else
                    throw new ArgumentException("El valor de la mora no puede ser negativo");
            }
        }

        public string CarnetPersona
        {
            get { return carnetPersona; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    carnetPersona = value;
                else
                    throw new ArgumentException("El carnet de la persona no puede estar vacío");
            }
        }

        public string ISBNLibro
        {
            get { return isbnLibro; }
            set
            {
                string patron = @"^\d{3}-\d{1}-\d{2}-\d{6}-\d{1}$";
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, patron))
                    isbnLibro = value;
                else
                    throw new ArgumentException("ISBN inválido. Debe cumplir el formato 000-0-00-000000-0");
            }
        }

    
        public Prestamo() { }
        public Prestamo(int id, DateTime fecha, DateTime finFecha, bool moraActiva, decimal valorMora, string carnet, string isbn)
        {
            IdPrestamo = id;
            FechaPrestamo = fecha;
            FinFechaPrestamo = finFecha;
            MoraActivaPrestamo = moraActiva;
            ValorMoraPrestamo = valorMora;
            CarnetPersona = carnet;
            ISBNLibro = isbn;
        }

       
    }
}



