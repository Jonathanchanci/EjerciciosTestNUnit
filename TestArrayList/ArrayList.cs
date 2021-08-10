using NUnit.Framework;
using System.Collections;

namespace Test
{
    public class Tests
    {
        /*
         Ejercicio Prueba de ArrayList
        Escribe al menos una prueba para verificar cada uno de los siguientes comportamientos de la clase ArrayList.

        CuandoSeCreaCountEsCero
        CuandoSeAgregaUnItemCountEsUno
        ContainsEsTrueCuandoContieneElItem
        ContainsEsFalseNoContieneElItem 
         */
        public ArrayList array;
        const string texto = "hola";
        const string textoNo = "como";
        [SetUp]
        public void Setup()
        {
            //Arrange
            array = new ArrayList();
            array.Add(texto);
        }

        [Test]
        public void CuandoSeCreaCountEsCero()
        {
            //Arrange
            array = new ArrayList();

            //Act
            int contadorArray = array.Count;

            //Assert
            Assert.AreEqual(0, contadorArray);
        }

        [Test]
        public void CuandoSeAgregaUnItemCountEsUno()
        {
            //Act
            int contadorArray1 = array.Count;

            //Assert
            Assert.AreEqual(1, contadorArray1);
        }

        [Test]
        public void ContainsEsTrueCuandoContieneElItem()
        {
            //Act
            bool loContiene = array.Contains(texto);

            //Arrange
            Assert.IsTrue(loContiene);
        }

        [Test]
        public void ContainsEsFalseNoContieneElItem()
        {
            //Act
            bool loContiene = array.Contains(textoNo);

            //Arrange
            Assert.IsFalse(loContiene);
        }
    }
}