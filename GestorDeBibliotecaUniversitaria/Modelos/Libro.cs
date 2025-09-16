using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestorDeBibliotecaUniversitaria.Clases
{
    internal class Libro
    {

        private string isbn;
        private string autorlibro;
        private string titulolibro;
        private string editoriallibro;
        private string generolibro;

        public string ISBN {

            get { return isbn; }

            //Validar el formato 000-0-00-000000-0
            set {

                string patron = @"^\d{3}-\d{1}-\d{2}-\d{6}-\d{1}$";

                if (Regex.IsMatch(value, patron))
                {

                    isbn = value;

                }
                else {

                    throw new ArgumentException("El valor no cumple el formato de ISBN 000-0-00-000000-0");

                }

            }

        }

        public string AutorLibro{
            
            get { return autorlibro; }

            set {

                if (!string.IsNullOrEmpty(value))
                {
                    autorlibro = value;
                }
                else { 
                    
                    throw new ArgumentException("El campo autor no puede estar vacio");

                }
            
            }

        }

        public string TituloLibro {

            get { return titulolibro; }

            set {

                if (!string.IsNullOrEmpty(value))
                {
                    titulolibro = value;
                }
                else
                {

                    throw new ArgumentException("El campo titulo no puede estar vacio");

                }

            }

        }

        public string EditorialLibro {

            get { return editoriallibro; }

            set {

                if (!string.IsNullOrEmpty(value))
                {
                    editoriallibro = value;
                }
                else
                {

                    throw new ArgumentException("El campo titulo no puede estar vacio");

                }

            }

        }

        public string GeneroLibro {

            get { return generolibro; }

            set {

                if (!string.IsNullOrEmpty(value))
                {
                    generolibro = value;
                }
                else
                {

                    throw new ArgumentException("El campo genero no puede estar vacio");

                }

            }

        }

        public Libro() { }

        public Libro(string ISBNA, string AutorLibroA, string TituloLibro_A, string EditorialLibroA, string GeneroLibroA) {
            ISBN = ISBNA;
            AutorLibro = AutorLibroA;
            TituloLibro = TituloLibro_A;    
            EditorialLibro = EditorialLibroA;
            GeneroLibro = GeneroLibroA;
        }

        public string ObtenerLista() {

            return $"Libro: id {ISBN}, autor {AutorLibro}, titulo: {TituloLibro}, editorial {EditorialLibro}, genero {GeneroLibro}";

        }



    }

}
