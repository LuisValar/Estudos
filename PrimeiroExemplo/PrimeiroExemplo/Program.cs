using System;
using System.Globalization;

namespace PrimeiroExemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 10.12345678;

            Console.WriteLine("Ola Mundo!"); // quebra de linha

            Console.Write("Bom dia!"); // sem quebra de linha

            Console.WriteLine(x.ToString("F2")); // limita a 2 casas decimais F e depois a qtd de casas dec.

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // utiliza separado ponto como separador

            Console.WriteLine("Resultado é = " + x); // concatenação de valores

            // ------------- Processamento de dados -----------

            int g, y;

            g = 5;

            y = 2  * g;

            Console.WriteLine("Valor de  g = " + g + "Valor de Y = " + y);

            /* -------- Casting -------
                É a conversão explicita de um tipo de dado pora outro

                exemplo abaixo
                */
            // sem casting

            int a, b;
            double resultado, resultado2;

            a = 5;
            b = 2;

            resultado = a / b;

            Console.WriteLine("Sem Casting" + resultado);

            // Com casting

            resultado2 = (double) a / b;

            Console.WriteLine("Com Casting" + resultado2);
        }
    }
}