/*
 * Crea un juego interactivo por terminal en el que tendr�s que adivinar 
 * el resultado de diferentes
 * operaciones matem�ticas aleatorias (suma, resta, multiplicaci�n 
 * o divisi�n de dos n�meros enteros).
 * - Tendr�s 3 segundos para responder correctamente.
 * - El juego finaliza si no se logra responder en ese tiempo.
 * - Al finalizar el juego debes mostrar cu�ntos c�lculos has acertado.
 * - Cada 5 aciertos debes aumentar en uno el posible n�mero de cifras 
 *   de la operaci�n (cada vez en un operando):
 *   - Preguntas 1 a 5: X (entre 0 y 9) operaci�n Y (entre 0 y 9)
 *   - Preguntas 6 a 10: XX (entre 0 y 99) operaci�n Y (entre 0 y 9)
 *   - Preguntas 11 a 15: XX operaci�n YY
 *   - Preguntas 16 a 20: XXX (entre 0 y 999) operaci�n YY
 *   ...
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace reto44
{
    public class Reto44
    {
        static void Main(string[] args)
        {
            int num_respuestas = 0, respuesta, resultado = 0;
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            Task<int> readInputTask;

            do
            {                
                readInputTask = Task.Run(() => Lanza_operacion(num_respuestas, out resultado), cancellationToken);
                respuesta = Task.WaitAny(new Task[] { readInputTask }, TimeSpan.FromSeconds(2));

                if (Task.WaitAny(new Task[] { readInputTask }, TimeSpan.FromSeconds(3)) != -1)
                {
                    if (readInputTask.Result == resultado)
                    {
                        num_respuestas++;
                    }
                    else
                    {
                        Console.WriteLine($"El resultado {readInputTask.Result} no es correcto, el valor esperado era {resultado}");
                        respuesta = -2;
                    }
                }
                else
                {
                    respuesta = -1;
                    break;
                }

            } while (respuesta != -1 && respuesta != -2);

            cancellationTokenSource.Cancel();

            if (respuesta == -1)
            {                
                Console.WriteLine();
                Console.WriteLine($"Has tardado m�s de 3 segundos en responder, lo siento, has perdido pero has respondido bien a {num_respuestas} respuestas");
            }
         
            Console.ReadKey();
        }

        public static int Lanza_operacion(int num_respuestas, out int resultado)
        {
            Random random = new Random();
            int operacion, respuesta;
            string num1 = "", num2 = "", operador = "";           

            for (int i = 0; i < Math.Floor(num_respuestas / 5.0) + 1; i++)
                num1 += random.Next(0, 10).ToString();

            for (int i = 0; i < Math.Floor(num_respuestas / 5.0) + 1; i++)
                num2 += random.Next(0, 10).ToString();

            operacion = random.Next(0, 4);

            switch (operacion)
            {
                case 0:
                    operador = "+";
                    resultado = Int32.Parse(num1) + Int32.Parse(num2);
                    break;
                case 1: 
                    operador = "-";
                    resultado = Int32.Parse(num1) - Int32.Parse(num2);
                    break; 
                case 2: 
                    operador = "x";
                    resultado = Int32.Parse(num1) * Int32.Parse(num2);
                    break; 
                case 3: 
                    operador = "/";
                    resultado = Int32.Parse(num1) / Int32.Parse(num2);
                    break;
                default:
                    resultado = 0;
                    break;
            }

            Console.Write($"Resuelve: {num1} {operador} {num2} = ");

            if (Int32.TryParse(Console.ReadLine(), out respuesta))
                return respuesta;
            else
                return 0;
        }
    }
}