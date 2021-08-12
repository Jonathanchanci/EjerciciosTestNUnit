using NUnit.Framework;
using System;
using System.Collections;

namespace Test
{
    /*
     Ejercicio prueba de excepciones
    Dado el siguiente código:

    Func<int, int, int> dividir = (int dividendo, int divisor) => dividendo / divisor;

    int[] items = new[] {1, 2};

    ArrayList arr = null;

    Verificar:

    Que la funcion dividir lanza una DivideByZeroException cuando el divisor es 0
    Que acceder al tercer elementos del array items lanza IndexOutOfRangeException
    Que invocar el método Clear (o cualquier otro método) sobre la referencia arr lanza NullReferenceException
     */
    [TestFixture]
    public class ExcepcionesTest
    {
        public Func<int, int, int> dividir = (int dividendo,int divisor) => dividendo / divisor;

        [Test]
        public void DivideByZeroException()
        {
            //Arrange
            int dividendo = 1;
            int divisor = 0;

            //Act y Assert
            Assert.Throws<DivideByZeroException>( () => dividir(dividendo, divisor));
        }

        [Test]
        public void IndexOutOfRangeException()
        {
            //Arrange
            int[] items = new[] { 1, 2 };

            //Act y Assert
            Assert.Throws<IndexOutOfRangeException>(() => items[2].ToString());
        }

        [Test]
        public void NullReferenceException()
        {
            ArrayList arr = null;
            Assert.Throws<NullReferenceException>(() => arr.Clear());
        }
    }
}
