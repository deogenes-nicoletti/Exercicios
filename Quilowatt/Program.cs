using System;

namespace Quilowatt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Console.Write("Por favor informe o valor do salario minimo: ");
            input = Console.ReadLine();
            var minSalary = Convert.ToDecimal(input);

            Console.Write("Por favor informe a quantia de quilowatt consumidas: ");
            input = Console.ReadLine();
            var consumedKiloWatt = Convert.ToDecimal(input);
            var kilowattValue = minSalary / 5M;

            Console.WriteLine($"Valor de cada quilowatt {kilowattValue}");

            var residenceCost = kilowattValue * consumedKiloWatt;
            Console.WriteLine($"Valor a ser pago pela residencia R${residenceCost}");

            const decimal discountAmount = 0.85M;
            var residenceCostWithDiscount = residenceCost * discountAmount;
            Console.WriteLine($"Valor a ser pago pela residencia com 15% de desconto R${residenceCostWithDiscount}");
        }
    }
}
