using System;

namespace DepartamentoPessoal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Console.Write("Por favor informe as horas trabalhadas: ");
            input = Console.ReadLine();
            Decimal hoursWorked = Convert.ToDecimal(input);

            Console.Write("Por favor informe o valor do salario minimo: ");
            input = Console.ReadLine();
            Decimal minSalary = Convert.ToDecimal(input);

            Decimal hoursWorkedValue = minSalary * 0.5M;
            Decimal grossSalary = hoursWorked * hoursWorkedValue;
            Decimal tax = grossSalary * 0.03M;
            
            Decimal salaryToReceivable = grossSalary - tax;
            Console.WriteLine($"Salario a receber R${salaryToReceivable}");
        }
    }
}
