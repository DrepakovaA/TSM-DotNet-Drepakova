using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: \n1: + \n2: - \n3: * \n4: /");
            int oper = int.Parse(Console.ReadLine());
            if(oper == 1)
            {
                Console.WriteLine($"Answer: {first + second}");
            } else if (oper == 2)
            {
                Console.WriteLine($"Answer: {first - second}");
            } else if (oper == 3)
            {
                Console.WriteLine($"Answer: {first * second}");
            } else if (oper == 4)
            {
                Console.WriteLine($"Answer: {first / second}");
            } else
            {
                Console.WriteLine("Incorrect operator");
            }
        }
    }
}
