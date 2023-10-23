/*
 * Crea una funci�n que reciba una expresi�n matem�tica (String)
 * y compruebe si es correcta. Retornar� true o false.
 * - Para que una expresi�n matem�tica sea correcta debe poseer
 *   un n�mero, una operaci�n y otro n�mero separados por espacios.
 *   Tantos n�meros y operaciones como queramos.
 * - N�meros positivos, negativos, enteros o decimales.
 * - Operaciones soportadas: + - * / % 
 *
 * Ejemplos:
 * "5 + 6 / 7 - 4" -> true
 * "5 a 6" -> false
 */

using System;
using System.Text.RegularExpressions;

namespace reto28
{
    public class Reto28
    {
        static void Main(string[] args)
        {
            string expresion1 = "5 + 6 / 7 - 4", expresion2 = "5 a 6", expresion3 = "2 + 2", expresion4 = "";

            Console.WriteLine($"{expresion1} -> {Es_expresion_matematica_correcta(expresion1)}");
            Console.WriteLine($"{expresion2} -> {Es_expresion_matematica_correcta(expresion2)}");
            Console.WriteLine($"{expresion3} -> {Es_expresion_matematica_correcta(expresion3)}");
            Console.WriteLine($"{expresion4} -> {Es_expresion_matematica_correcta(expresion4)}");

            Console.ReadKey();
        }

        private static bool Es_expresion_matematica_correcta(string expresion)
        {
            string pattern = @"(?:\d+\s*[+\-*/%]\s*)+\d+|(?:\d+\s*[+\-*/%]\s*\d+)";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(expresion);
        }
    }
}