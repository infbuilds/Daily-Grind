using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Topic: Switch Statement | Konu: Switch İfadesi


namespace csharp02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            Console.Write("Enter 1st number: ");
            number1 = int.Parse(Console.ReadLine()); 

            Console.Write("Enter 2nd number: ");
            number2 = int.Parse(Console.ReadLine());

            char symbol;
            Console.Write("Enter operator (+, -, *, /): ");
            symbol = char.Parse(Console.ReadLine()); 

            switch (symbol) // sembole göre işlem seçer | selects operation based on symbol
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sum: " + result); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Difference: " + result); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Product: " + result); break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Quotient: " + result); break;
                default: 
                    Console.WriteLine("Invalid operator. Please use +, -, *, /"); break;
            }

            Console.Read();
        }
    }
}
