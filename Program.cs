using System;

namespace divis_o
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numerador...");
            String numerador = Console.ReadLine();
            Decimal numerador1 = Convert.ToDecimal(numerador);

            Console.WriteLine("digite o denominador...");
            String denominador = Console.ReadLine();
            Decimal denominador1 = Convert.ToDecimal(denominador);

            Decimal resultado = numerador1 / denominador1;
            Console.WriteLine("o resultado da divisão é ...." + resultado);


        }
    }
}
