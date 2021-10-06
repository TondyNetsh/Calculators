using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("======= SIMPLE CALCULATOR FOR TWO NUMBERS =========");
                Console.WriteLine("===================================================");

                Console.Write("Please enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose Arithmetic Operators +,-,*,/");
                char sign = Convert.ToChar(Console.ReadLine());

                if (sign == '+')
                {
                    Console.WriteLine("Sum of " + num1 + " and " + num2 + " = " + Program.Addition(num1,num2));
                }
                else if (sign == '-')
                {
                    Console.WriteLine("Difference of " + num1 + " and " + num2 + " : " + Program.Substraction(num1, num2));
                }
                else if (sign == '*')
                {
                    Console.WriteLine("Product of " + num1 + " and " + num2 + " : " + Program.Multiplication(num1, num2));
                }
                else if (sign == '/')
                {
                    Console.WriteLine("Quotient of " + num1 + " and " + num2 + " : " + Program.Division(num1, num2));
                }
                else
                {
                    Console.WriteLine("Invalid operator selected.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int Addition(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;

            return sum;
        }
        static int Substraction(int num1, int num2)
        {
            int sum = 0;
            sum = num1 - num2;

            return sum;
        }
        static int Multiplication(int num1, int num2)
        {
            int product = 0;
            product = num1 * num2;

            return product;
        }
        static int Division(int num1, int num2)
        {
            int quotient = 0;
            if(num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                quotient = num1 / num2;
            }
            return quotient;
        }
    }
}
