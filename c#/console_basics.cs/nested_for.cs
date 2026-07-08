using System;

// Topic: For Loops (Nested) | Konu: For Döngüleri (İç İçe)

//
// Output | Çıktı:
// *
// **
// ***
// ****
// *****
// ****
// ***
// **
// *

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            
            for (int i = 4; i >= 1; i--) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
