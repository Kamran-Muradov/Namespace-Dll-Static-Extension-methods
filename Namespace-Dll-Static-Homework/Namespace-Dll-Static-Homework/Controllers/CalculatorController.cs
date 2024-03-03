
using Namespace_Dll_Static_Homework.Services;

namespace Namespace_Dll_Static_Homework.Controllers
{
    internal class CalculatorController
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        public void Calculation()
        {
            Console.WriteLine("Enter first number:");
        Num1: string num1Str = Console.ReadLine();

            double num1;

            if (!double.TryParse(num1Str, out num1))
            {
                Console.WriteLine("Number format is wrong. Please enter again:");
                goto Num1;
            }
            else
            {
                Console.WriteLine("Enter second number:");
            Num2: string num2Str = Console.ReadLine();

                double num2;

                if (!double.TryParse(num2Str, out num2))
                {
                    Console.WriteLine("Number format is wrong. Please enter again:");
                    goto Num2;
                }
                else
                {
                    Console.WriteLine("Enter operation (+, -, * or /):");
                Operation: string operation = Console.ReadLine().Trim();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Console.WriteLine("Operation is wrong. Please enter again:");
                        goto Operation;
                    }
                    else
                    {
                        double result = _calculatorService.Calculation(num1, num2, operation);

                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
