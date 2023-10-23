/*
 * Crea una funci�n que reciba dos par�metros para crear una cuenta atr�s.
 * - El primero, representa el n�mero en el que comienza la cuenta.
 * - El segundo, los segundos que tienen que transcurrir entre cada cuenta.
 * - S�lo se aceptan n�meros enteros positivos.
 * - El programa finaliza al llegar a cero.
 * - Debes imprimir cada n�mero de la cuenta atr�s.
 */

using System;
using System.Threading;

namespace reto27
{
    public class Reto27
    {
        static void Main(string[] args)
        {
            Cuenta_atras(10, 1);

            Cuenta_atras(5, 3);

            Console.ReadKey();
        }

        private static void Cuenta_atras(int numero, int segundos)
        {
            if (numero > 0)
            {
                if (segundos > 0)
                {
                    for (int i = numero; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(segundos * 1000);
                    }
                }
                else
                {
                    Console.WriteLine("Los segundos entre cada n�mero de la cuenta atr�s deben de ser n�meros enteros positivos");
                }
            }
            else
            {
                Console.WriteLine("El inicio de la cuentra atr�s debe de ser un n�mero entero positivo");
            }
        }
    }
}