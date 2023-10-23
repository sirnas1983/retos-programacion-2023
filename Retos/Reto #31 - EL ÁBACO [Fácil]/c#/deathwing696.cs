/*
 * Crea una funci�n que sea capaz de leer el n�mero representado por el �baco.
 * - El �baco se representa por un array con 7 elementos.
 * - Cada elemento tendr� 9 "O" (aunque habitualmente tiene 10 para realizar operaciones)
 *   para las cuentas y una secuencia de "---" para el alambre.
 * - El primer elemento del array representa los millones, y el �ltimo las unidades.
 * - El n�mero en cada elemento se representa por las cuentas que est�n a la izquierda del alambre.
 *
 * Ejemplo de array y resultado:
 * ["O---OOOOOOOO",
 *  "OOO---OOOOOO",
 *  "---OOOOOOOOO",
 *  "OO---OOOOOOO",
 *  "OOOOOOO---OO",
 *  "OOOOOOOOO---",
 *  "---OOOOOOOOO"]
 *  
 *  Resultado: 1.302.790
 */

using System;
using System.Collections.Generic;

namespace reto31
{
    public class Reto31
    {
        static void Main(string[] args)
        {
            List<string> abaco = new List<string>() {"O---OOOOOOOO", "OOO---OOOOOO", "---OOOOOOOOO", "OO---OOOOOOO", "OOOOOOO---OO", "OOOOOOOOO---", "---OOOOOOOOO" };
            string cadena_numero = "";
            int numero;

            foreach (string fila in abaco)
            {
                var valor = fila.Split('-');
                var num_ceros = Dame_num_ceros(valor[0]).ToString();
                cadena_numero += num_ceros;
            }

            numero = Int32.Parse(cadena_numero);

            Console.WriteLine($"Resultado: {numero.ToString("N0")}");

            Console.ReadKey();
        }

        private static int Dame_num_ceros(string cadena)
        {
            int num_ceros = 0;

            foreach (char caracter in cadena)
            {
                if (caracter == 'O')
                    num_ceros++;
            }

            return num_ceros;
        }
    }
}