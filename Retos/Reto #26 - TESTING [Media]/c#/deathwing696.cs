/*
 * Crea tres test sobre el reto 12: "Viernes 13".
 * - Puedes copiar una soluci�n ya creada por otro usuario en
 *   el lenguaje que est�s utilizando.
 * - Debes emplear un mecanismo de ejecuci�n de test que posea
 *   el lenguaje de programaci�n que hayas seleccionado.
 * - Los tres test deben de funcionar y comprobar
 *   diferentes situaciones (a tu elecci�n).
 */

using System;
using NUnit.Framework;
using reto_26;

namespace reto26
{
    [TestFixture]
    public class Reto26
    {
        [Test]
        public void Test_existe_viernes_13() 
        {
            var viernes13 = new Viernes13();

            bool tiene_viernes_13 = viernes13.Tiene_viernes_13(2023, 1);

            Assert.IsTrue(tiene_viernes_13);
        }

        [Test]
        public void Test_no_existe_viernes_13()
        {
            var viernes13 = new Viernes13();

            bool tiene_viernes_13 = viernes13.Tiene_viernes_13(2023, 9);

            Assert.IsFalse(tiene_viernes_13);
        }

        [Test]
        public void Test_viernes_13_anyo_bisiesto()
        {
            var viernes13 = new Viernes13();

            bool tiene_viernes_13 = viernes13.Tiene_viernes_13(2024, 9);

            Assert.IsTrue(tiene_viernes_13);
        }
    }
}