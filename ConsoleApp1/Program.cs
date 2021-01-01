using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for ( i = 0; i <=6; i++)
            {
                for ( j = 1; j <=7-i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            Console.ReadLine();
        }
    }
}
