/*
 * Realiza una conexi�n desde el lenguaje que hayas seleccionado a la siguiente base de datos MySQL:
 * - Host: mysql-5707.dinaserver.com
 * - Port: 3306
 * - User: mouredev_read
 * - Password: mouredev_pass
 * - Database: moure_test
 * 
 * Una vez realices la conexi�n, lanza la siguiente consulta e imprime el resultado:
 * - SELECT * FROM `challenges`
 *
 * Se pueden usar librer�as para realizar la l�gica de conexi�n a la base de datos.
 */

using System;
using MySql.Data.MySqlClient;

namespace Reto23
{
    public class Reto23
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=mysql-5707.dinaserver.com;Database=moure_test;Port=3306;User ID=mouredev_read;Password=mouredev_pass";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexi�n
                    connection.Open();

                    // Realizar operaciones en la base de datos aqu�

                    // Ejemplo: Obtener datos de una tabla
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM challenges", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int num_columnas = reader.FieldCount;

                            while (reader.Read())
                            {
                                for (int i = 0; i < num_columnas; i++)
                                {
                                    Console.Write($"{reader[i].ToString()} | ");
                                }                
                                
                                Console.WriteLine();
                            }
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.ReadKey();
        }
    }
}