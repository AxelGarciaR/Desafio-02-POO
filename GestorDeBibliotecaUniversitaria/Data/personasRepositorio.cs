using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using Microsoft.Data.SqlClient;

namespace GestorDeBibliotecaUniversitaria.Data
{
    internal class PersonasRepositorio
    {
        private readonly string _stringConnect;

        public PersonasRepositorio(string stringConnect)
        {
            _stringConnect = stringConnect;
        }

        // metodo para listar a todas las personas de la base de datos:
        public List<Persona> ObtenerPersonas()
        {
            var personas = new List<Persona>();
            string query = "SELECT carnetPersona, nombrePersona, correoPersona, tipoPersona FROM tbPersona";

            using (var connection = new SqlConnection(_stringConnect))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Persona persona = new Persona();
                                persona.id = reader["carnetPersona"].ToString();
                                persona.nombre = reader["nombrePersona"].ToString();
                                persona.correo = reader["correoPersona"].ToString();
                                persona.tipoPersona = reader["tipoPersona"].ToString();
                                personas.Add(persona);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al obtener los datos de las personas de la base de datos.", ex);
                    }
                }
            }


            return personas;
        }

        // Metodo para insertar personas nuevas a la base de datos:
        public void InsertarPersona(Persona persona)
        {
            string query = "INSERT INTO tbPersona (carnetPersona, nombrePersona, correoPersona, tipoPersona) VALUES (@Carnet, @Nombre, @Correo, @TipoPersona);";

            using (var connection = new SqlConnection(_stringConnect))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Carnet", persona.id);
                        command.Parameters.AddWithValue("@Nombre", persona.nombre);
                        command.Parameters.AddWithValue("@Correo", persona.correo);
                        command.Parameters.AddWithValue("@TipoPersona", persona.tipoPersona);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al insertar una nueva persona a la base de datos.", ex);
                    }
                }
            }
        }

        // metodo para actualizar personas ya existentes en la base de datos:
        public void ActualizarPersona(Persona persona)
        {
            string query = "UPDATE tbPersona SET nombrePersona = @Nombre, correoPersona = @Correo, tipoPersona = @TipoPersona WHERE carnetPersona = @Carnet;";

            using (var connection = new SqlConnection(_stringConnect))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Carnet", persona.id);
                        command.Parameters.AddWithValue("@Nombre", persona.nombre);
                        command.Parameters.AddWithValue("@Correo", persona.correo);
                        command.Parameters.AddWithValue("@TipoPersona", persona.tipoPersona);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al actualizar los datos de la persona en la base de datos.", ex);
                    }
                }
            }
        }

        // metodo para eliminar personas de la base de datos:
        public void EliminarPersona(string carnet)
        {
            string query = "DELETE FROM tbPersona WHERE carnetPersona = @Carnet;";
            using (var connection = new SqlConnection(_stringConnect))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Carnet", carnet);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al eliminar la persona de la base de datos.", ex);
                    }
                }
            }

        }


    }

}