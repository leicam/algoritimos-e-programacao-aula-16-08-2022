using System;

namespace Aula.Tipos.Inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1;
            int numero2 = 2;

            numero2 = numero1;
            numero1 = 10;

            Console.WriteLine("Numero 1: " + numero1);
            Console.WriteLine("Numero 2: " + numero2);
            Console.WriteLine("Soma: " + (numero1 + numero2));
            Console.WriteLine("Subtração: " + (numero1 - numero2));
            Console.WriteLine("Multiplicação: " + (numero1 * numero2));
            Console.WriteLine("Divisão: " + (numero1 / numero2));
            Console.WriteLine("Divisão: " + (numero1 % numero2));
        }
    }
}
