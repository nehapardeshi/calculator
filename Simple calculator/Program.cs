using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Calculator App");
			var calcAction = "";
			var calc = new Calculator();

			do
			{
				Console.Write("Enter number 1: ");
				decimal.TryParse(Console.ReadLine(),out decimal firstNumber);
				Console.Write("Enter operator (+,-,*,/,%)");
				var op = Console.ReadLine();
				Console.Write("Enter number 2: ");
				decimal.TryParse(Console.ReadLine(), out decimal secondNumber);

				decimal result = 0;

				switch (op)
				{
					case"+":
					result = calc.Sum(firstNumber,secondNumber);
						break;
					case "-":
						result = calc.Difference(firstNumber, secondNumber);
						break;
					case "*":
						result = calc.Multiply(firstNumber, secondNumber);
						break;
					case "/":
						result = calc.Divide(firstNumber, secondNumber);
						break;
					case "%":
						result = calc.Mod(firstNumber, secondNumber);
						break;

					default:
						Console.WriteLine("Not valid operation");
						break;
				}
				Console.WriteLine($"{firstNumber} {op} {secondNumber} = {result}");
				Console.WriteLine("");

				Console.WriteLine("Enter 0 to exit. Enter any other key to continue...");
				calcAction = Console.ReadLine();
			} while (calcAction != "0");
		}
	}
}
