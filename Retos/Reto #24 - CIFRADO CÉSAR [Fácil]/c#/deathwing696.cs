/*
 * Crea un programa que realize el cifrado C�sar de un texto y lo imprima.
 * Tambi�n debe ser capaz de descifrarlo cuando as� se lo indiquemos.
 *
 * Te recomiendo que busques informaci�n para conocer en profundidad c�mo
 * realizar el cifrado. Esto tambi�n forma parte del reto.
 */

using System;

namespace reto24
{
    public class Reto24
    {
        static void Main(string[] args)
        {
            int desplazamiento = 3;
            string texto = "Con diez ca�ones por banda,\r\nviento en popa a toda vela,\r\nno corta el mar, sino vuela\r\nun velero bergantin; ";
            string texto_cifrado = "Frq glhc fd�rqhv sru edqgd, \r\nylhqwr hq srsd d wrgd yhod, \r\nqr fruwd ho pdu, vlqr yxhod \r\nxq yhohur ehujdqwlq;";

            Console.WriteLine($"Texto:\r\n{texto}");
            Console.WriteLine($"Texto cifrado:\r\n{Cifra_texto(desplazamiento, texto)}");
            Console.WriteLine($"Texto descifrado:\r\n{Descifra_texto(desplazamiento, texto_cifrado)}");

            Console.ReadKey();
        }

        private static string Cifra_texto(int desplazamiento, string texto)
        {
            string texto_cifrado  = "";

            foreach (var caracter in texto)
            {
                if (caracter == '�')
                {
                    texto_cifrado += caracter;
                }
                else if (char.IsLetter(caracter))
                {
                    int codigoAscii;

                    if (char.IsUpper(caracter))
                        codigoAscii = ((int)caracter - (int)'A' + desplazamiento + 26) % 26 + (int)'A';
                    else
                        codigoAscii = ((int)caracter - (int)'a' + desplazamiento + 26) % 26 + (int)'a';

                    char letra_codificada = (char)codigoAscii;

                    texto_cifrado += letra_codificada;
                }
                else
                {
                    texto_cifrado += caracter;
                }
            }

            return texto_cifrado;
        }

        private static string Descifra_texto(int desplazamiento, string texto)
        {
            return Cifra_texto(-desplazamiento, texto);
        }
    }
}