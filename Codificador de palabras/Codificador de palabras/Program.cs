using System;

namespace Codificador_de_palabras
{
    class Program
    {
         
        static void Main(string[] args)
        {
            String cadena = null, numeros = null;

            Console.WriteLine("Ingrese:");
            Console.WriteLine();

            cadena = Console.ReadLine();

            numeros = Codificar.Codificador(cadena);

            Console.WriteLine(numeros);


        }


       
    }



}


