using NUnit.Framework;
using System;
using Codificador_de_palabras;
namespace Tests
{
    
    
    public class Tests
    {

        public static String cadena1;
        public static String cadena2;
        public static String cadena3;
        public static String cadena4;
        public static String cadena5;

        [SetUp]
        public void Setup()
        {
            cadena1 = "hi"; 
            cadena2 = "yes";
            cadena3 = "foo bar";
            cadena4 = "hello world";
            cadena5 = "hello1223world#";
        }

        [Test]
        public void Test1()
        {
            String esperado = "44 444";
            String resultado = Codificar.Codificador(cadena1);

            Assert.AreEqual(esperado, resultado);
        }

       [Test]
        public void Test2()
        {
            String esperado = "999337777";

            String resultado = Codificar.Codificador(cadena2);

            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void Test3()
        {
            String esperado = "333666 666022 2777";
            String resultado = Codificar.Codificador(cadena3);

            Assert.AreEqual( esperado, resultado);
        }

        [Test]
        public void Test4()
        {
            String esperado = "4433555 555666096667775553";
            String resultado = Codificar.Codificador(cadena4);

            Assert.AreEqual(esperado,resultado);
        }

        [Test]
        public void Test5()
        {
            String esperado = "Error de caracteres, solo se pueden ingresar letras minusculas y espacios";
            String resultado = Codificar.Codificador(cadena5);

            Assert.AreEqual(esperado, resultado);
        }
       

    }
}