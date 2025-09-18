using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeBibliotecaUniversitaria.Clases;
using Microsoft.Data.SqlClient;

namespace GestorDeBibliotecaUniversitaria.Data
{
    internal class PrestamosRepositorio
    {
        private readonly string _stringConnect;

        public PrestamosRepositorio(string stringConnect)
        {
            _stringConnect = stringConnect;
        }

        // Obtener  préstamos
        public List<Prestamo> ObtenerPrestamos()
        {
            var prestamos = new List<Prestamo>();

            using (var connection = new SqlConnection(_stringConnect))
            {
                string query = "SELECT idPrestamo, fechaPrestamo, finFechaPrestamo, moraActivaPrestamo, valorMoraPrestamo, carnetPersona, ISBN FROM tbPrestamoLibro";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prestamo p = new Prestamo
                            {
                                IdPrestamo = Convert.ToInt32(reader["idPrestamo"]),
                                FechaPrestamo = Convert.ToDateTime(reader["fechaPrestamo"]),
                                FinFechaPrestamo = Convert.ToDateTime(reader["finFechaPrestamo"]),
                                MoraActivaPrestamo = Convert.ToBoolean(reader["moraActivaPrestamo"]),
                                ValorMoraPrestamo = Convert.ToDecimal(reader["valorMoraPrestamo"]),
                                CarnetPersona = reader["carnetPersona"].ToString(),
                                ISBNLibro = reader["ISBN"].ToString()
                            };

                            prestamos.Add(p);
                        }
                    }
                }
            }

            return prestamos;
        }

        // Insertar
        public void InsertarPrestamo(Prestamo p)
        {
            using (var connection = new SqlConnection(_stringConnect))
            {
                string query = "INSERT INTO tbPrestamoLibro (fechaPrestamo, finFechaPrestamo, moraActivaPrestamo, valorMoraPrestamo, carnetPersona, ISBN) " +
                               "VALUES (@fecha, @finFecha, @moraActiva, @valorMora, @carnet, @isbn)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@fecha", System.Data.SqlDbType.Date) { Value = p.FechaPrestamo });
                    command.Parameters.Add(new SqlParameter("@finFecha", System.Data.SqlDbType.Date) { Value = p.FinFechaPrestamo });
                    command.Parameters.Add(new SqlParameter("@moraActiva", System.Data.SqlDbType.Bit) { Value = p.MoraActivaPrestamo });
                    command.Parameters.Add(new SqlParameter("@valorMora", System.Data.SqlDbType.Decimal) { Value = p.ValorMoraPrestamo });
                    command.Parameters.Add(new SqlParameter("@carnet", System.Data.SqlDbType.NVarChar) { Value = p.CarnetPersona });
                    command.Parameters.Add(new SqlParameter("@isbn", System.Data.SqlDbType.NVarChar) { Value = p.ISBNLibro });

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Actualizar 
        public void ActualizarPrestamo(Prestamo p)
        {
            using (var connection = new SqlConnection(_stringConnect))
            {
                string query = "UPDATE tbPrestamoLibro SET fechaPrestamo=@fecha, finFechaPrestamo=@finFecha, moraActivaPrestamo=@moraActiva, valorMoraPrestamo=@valorMora, carnetPersona=@carnet, ISBN=@isbn " +
                               "WHERE idPrestamo=@id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = p.IdPrestamo });
                    command.Parameters.Add(new SqlParameter("@fecha", System.Data.SqlDbType.Date) { Value = p.FechaPrestamo });
                    command.Parameters.Add(new SqlParameter("@finFecha", System.Data.SqlDbType.Date) { Value = p.FinFechaPrestamo });
                    command.Parameters.Add(new SqlParameter("@moraActiva", System.Data.SqlDbType.Bit) { Value = p.MoraActivaPrestamo });
                    command.Parameters.Add(new SqlParameter("@valorMora", System.Data.SqlDbType.Decimal) { Value = p.ValorMoraPrestamo });
                    command.Parameters.Add(new SqlParameter("@carnet", System.Data.SqlDbType.NVarChar) { Value = p.CarnetPersona });
                    command.Parameters.Add(new SqlParameter("@isbn", System.Data.SqlDbType.NVarChar) { Value = p.ISBNLibro });

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Eliminar
        public void EliminarPrestamo(Prestamo p)
        {
            using (var connection = new SqlConnection(_stringConnect))
            {
                string query = "DELETE FROM tbPrestamoLibro WHERE idPrestamo=@id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = p.IdPrestamo });

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

