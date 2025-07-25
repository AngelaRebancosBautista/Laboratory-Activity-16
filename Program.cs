using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string operatorInput = Console.ReadLine();

            float result = 0;
            bool validOperation = true;

            switch (operatorInput)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    validOperation = false;
                    break;
            }
            if (validOperation)
            {
                Console.WriteLine($"The result of {num1} {operatorInput} {num2} is: {result}");
            }
        }
    }
}
            

