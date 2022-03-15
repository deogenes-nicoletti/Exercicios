using System;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal total = decimal.Zero, divider = decimal.Zero;

            for (byte i = 0; i < 4; ++i)
            {
                string input = String.Empty;

                Console.Write("Por favor informe uma nota: ");
                input = Console.ReadLine();
                decimal note = Convert.ToDecimal(input);

                Console.Write("Por favor informe um peso: ");
                input = Console.ReadLine();
                decimal weight = Convert.ToDecimal(input);

                total += note * weight;
                divider += weight;

                Console.WriteLine("Obrigado!");
            }

            Decimal result = total / divider;

            Console.WriteLine($"Média ponderada: {result}");
        }
    }
}
