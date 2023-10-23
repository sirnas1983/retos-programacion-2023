/*
 *	�El nuevo "The Legend of Zelda: Tears of the Kingdom" ya est� disponible! 
 *
 * Crea un programa que dibuje una Trifuerza de "Zelda"
 * formada por asteriscos.
 * - Debes indicarle el n�mero de filas de los tri�ngulos con un entero positivo (n).
 * - Cada tri�ngulo calcular� su fila mayor utilizando la f�rmula 2n-1.
 *
 * Ejemplo: Trifuerza 2
 * 
 *    *
 *   ***
 *  *   *
 * *** ***
 *
 */

using System;

namespace deathwing696
{
    public class Deathwing696
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el n�mero de pisos que tendr�n los tri�ngulos de la trifuerza:");

            int pisos;

            if (Int32.TryParse(Console.ReadLine(), out pisos))
            {
                DibujarTrifuerza(pisos);
            }
            else
            {
                Console.WriteLine("Lo introducido no es un n�mero...fin del programa");
            }

            Console.ReadKey();
        }

        private static void DibujarTrifuerza(int pisos)
        {
            Dibuja_triangulo_arriba(pisos);
            Dibuja_triangulos_abajo(pisos);
            
        }        

        private static void Dibuja_triangulo_arriba(int pisos)
        {
            for (int i = 0; i < pisos; i++)
            {
                for (int j = 0; j < (2 * pisos - 1) - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < (2 * i) + 1; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }

        private static void Dibuja_triangulos_abajo(int pisos)
        {
            for (int i = 0; i < pisos; i++)
            {
                for (int j = 0; j < pisos - 1 - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < (2 * i) + 1; j++)
                {
                    Console.Write('*');
                }

                for (int j = 0; j < 2 * pisos - 1 - 2 * i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < (2 * i) + 1; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}