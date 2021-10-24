using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            while (n != 0)
            {
                Console.WriteLine("For exit insert 0");
                Console.Write("n = ");
                bool output = int.TryParse(Console.ReadLine(), out n);
                if (output)
                {
                    if (n < 1)
                        Console.WriteLine("Please insert a number > 1");
                    else
                    {
                        MultiplicationTable table = new PrimeNumbersMultiplicationTable();
                        table.GenerateNumbers(n);
                        Console.WriteLine(table.ToString());
                    }
                }
                else
                    Console.WriteLine("Your input is not a number");
            }
        }
    }
}
