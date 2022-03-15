using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Console.Write("Por favor informe seu salário atual: ");
            input = Console.ReadLine();
            decimal salary = Convert.ToDecimal(input);

            const decimal readjustment = 1.25M;
            decimal newSalary = salary * readjustment;

            Console.WriteLine($"Novo salário: {newSalary}");
        }
    }
}
