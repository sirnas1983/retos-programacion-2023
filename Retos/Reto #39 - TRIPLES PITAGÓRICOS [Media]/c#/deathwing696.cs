/*
 * Crea una funci�n que encuentre todos los triples pitag�ricos
 * (ternas) menores o iguales a un n�mero dado.
 * - Debes buscar informaci�n sobre qu� es un triple pitag�rico.
 * - La funci�n �nicamente recibe el n�mero m�ximo que puede
 *   aparecer en el triple.
 * - Ejemplo: Los triples menores o iguales a 10 est�n
 *   formados por (3, 4, 5) y (6, 8, 10).
 */

using System;
using System.Collections.Generic;

namespace deathwing696
{
    public class Deathwing696
    {
        private static bool Es_triple(int a, int b, int c)
        {
            return (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2));                
        }

        private static void Calcula_triple_pitagorico(int maximo, List<List<int>> triples)
        {            
            for (int a = 1; a <= maximo; a++)
            {
                for (int b = a + 1; b <= maximo; b++)
                {
                    int c = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    if (c <= maximo && Es_triple(a, b, c))
                    {
                        List<int> combinacion = new List<int>() {a, b, c};

                        triples.Add(combinacion);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int maximo;

            Console.Write("Introduce el n�mero m�ximo del triple pitag�rico:");

            if (Int32.TryParse(Console.ReadLine(), out maximo))
            {
                List<List<int>> triples;

                triples = new List<List<int>>();
                Calcula_triple_pitagorico(maximo, triples);

                Console.WriteLine($"Los triples menores o iguales a {maximo} est�n formados por:");

                foreach (var combinacion in triples)
                    Console.WriteLine($"({String.Join(", ", combinacion)})");
            }
            else
            {
                Console.WriteLine("Lo que has introducido por teclado no es un n�mero...Fin del programa");
            }

            Console.ReadKey();
        }
    }
}