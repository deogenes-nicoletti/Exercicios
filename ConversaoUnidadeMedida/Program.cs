using System;

namespace ConversaoUnidadeMedida
{
    class Program
    {
        const decimal FOOT_IN_INCH = 12;
        const decimal YARD_IN_FOOT = 3;
        const decimal MILE_IN_YARD = 1760;

        static void Main(string[] args)
        {
            Console.Write("Por favor informe um valor em pés: ");
            string sInput = Console.ReadLine();
            decimal dInput = Convert.ToDecimal(sInput);

            var inch = dInput * FOOT_IN_INCH;
            Console.WriteLine($"Em polegadas: {inch}");

            var yard = dInput / YARD_IN_FOOT;
            Console.WriteLine($"Em jardas: {yard}");

            var mile = yard / MILE_IN_YARD;
            Console.WriteLine($"Em milhas: {mile}");
        }
    }
}
