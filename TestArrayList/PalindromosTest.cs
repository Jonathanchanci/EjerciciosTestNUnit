using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /*
     Ejercicio: Pruebas palindromo
        Un palíndromo es una palabra o frase que se igual al derecho o al revés. Utilizando la funcionalidad de 
        "TestCase" de NUnit y la clase la clase Palindromo escribe tests para verificar que las siguientes palabras/frases son palindromos.
        ana
        amar da drama
        anana
        luz azul
        oso baboso
        yo soy
     */
    [TestFixture]
    public class PalindromosTest
    {
        [Test]
        [TestCase("ana")]
        [TestCase("amar da drama")]
        [TestCase("anana")]
        [TestCase("luz azul")]
        [TestCase("oso baboso")]
        [TestCase("yo soy")]
        [TestCase("fallaf")]
        public void ValidarFrasesPalindromas(string frase)
        {
            //Act
            frase = frase.Replace(" ", "");
            char[] reversar = frase.ToCharArray();
            Array.Reverse(reversar);
            string fraseReversa = new(reversar);

            Assert.AreEqual(frase, fraseReversa);
        }
    }
}
