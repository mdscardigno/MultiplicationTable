using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Please enter the number to use to create the table: ");
            int table = int.Parse(Console.ReadLine());

            for (int multiplicador = 0; multiplicador < 10; multiplicador++)
            {
                if (multiplicador == 5)
                {
                    // break; //it exists the loop when equal to 5
                    continue; // when multiplicador is equal to 5, the line will not be executed
                }
                Console.WriteLine(table + " X " + multiplicador + " = " + table * multiplicador);
            }
            Console.ReadKey();
        }
    }
}
