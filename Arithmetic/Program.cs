using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
	            double firstNumber = 14, secondNumber = 4, result;
				int num1 = 26, num2 = 4, rem;

			
				result = firstNumber + secondNumber;
				Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

				
				result = firstNumber - secondNumber;
				Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

				
				result = firstNumber * secondNumber;
				Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

				
				result = firstNumber / secondNumber;
				Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

				
				rem = num1 % num2;
				Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
			}
		}
	}
				

