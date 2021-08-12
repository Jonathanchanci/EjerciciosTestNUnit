using NUnit.Framework;
using System.Collections;

namespace Test
{
    /*
     Ejercicio prueba de stack
    Un stack (pila) es un estructura de datos que funciona según la regla "ultimo entrado primero salido". 
    Escribe 3 test para verificar este comportamiento teniendo presente que el método para agregar 
    ítems es push y el método para retirar items es pop.
     */
    [TestFixture]
    public class StackTest
    {
        Stack _stack = new Stack();
        [SetUp]
        public void SetUp()
        {
            _stack.Push(1);
            _stack.Push(2);
        }

        [Test]
        [Category("PruebaCategoria")]
        public void UltimoEntraPrimeroSale()
        {
            //Act
            var valor2 = _stack.Pop();

            //Assert
            Assert.AreEqual(2, valor2);
        } 

        [Test]
        public void Entra3Sale3()
        {
            //Arrange
            _stack.Push(3);

            //Act
            var valor3 = _stack.Pop();

            //Assert
            Assert.AreEqual(3, valor3);
        }

        [Test]
        public void Borro1Sale1()
        {
            //Arrange
            _stack.Pop();

            //Act
            var valor1 = _stack.Pop();

            //Assert
            Assert.AreEqual(1, valor1);
        }
    }
}
