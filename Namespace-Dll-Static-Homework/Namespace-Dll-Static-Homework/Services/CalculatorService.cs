
namespace Namespace_Dll_Static_Homework.Services
{
    internal class CalculatorService
    {
        public double Calculation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "*":
                    return num1 * num2;

                case "/":
                    return num1 / num2;

                default:
                    return -1;
            }
        }
    }
}
