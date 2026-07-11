using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Topic: Arrays | Konu: Diziler


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string array - print all elements | tüm elemanları yazdır
            string[] colors = { "red", "blue", "green", "yellow", "black" };
            for (int i = 0; i < colors.Length; i++) // Length = eleman sayısı | number of elements
            {
                Console.WriteLine(colors[i]);
            }
            #endregion

            #region city array - access by index | index ile erişim
            string[] cities = { "Ankara", "Mersin", "Istanbul", "Izmir", "Bursa" };
            Console.WriteLine(cities[2]); // index 2 = 3. eleman | index 2 = 3rd element
            #endregion

            #region user input into array | kullanıcıdan dizi doldurma
            string[] userCities = new string[3]; // 3 elemanlı boş dizi | empty array with 3 slots
            for (int i = 0; i < userCities.Length; i++)
            {
                Console.Write($"Enter city {i + 1}: ");
                userCities[i] = Console.ReadLine();
            }
            for (int i = 0; i < userCities.Length; i++)
            {
                Console.WriteLine(userCities[i]);
            }
            #endregion

            #region sum of array | dizi toplamı
            int[] numbers = { 21, 43, 456, 7, 68 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; 
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + sum / numbers.Length); 
            #endregion

            #region even numbers | çift sayılar
            int[] numbrs = { 1, 2, 3, 4, 53, 44, 65, 7856, 978 };
            Console.Write("Even numbers: ");
            for (int i = 0; i < numbrs.Length; i++)
            {
                if (numbrs[i] % 2 == 0) // % 2 == 0 ise çift | if % 2 == 0 it's even
                {
                    Console.Write(" " + numbrs[i] + " ");
                }
            }
            Console.WriteLine();
            #endregion

            #region find max and min | en büyük ve en küçük
            int[] my = { 43, 456, 657, 2, 4536, 8, 67, 5, 78 };
            int maxNumber = my[0];
            int minNumber = my[0];
            for (int i = 0; i < my.Length; i++)
            {
                if (my[i] > maxNumber) maxNumber = my[i];
                if (my[i] < minNumber) minNumber = my[i]; 
            }
            Console.WriteLine("Max: " + maxNumber); // 4536
            Console.WriteLine("Min: " + minNumber); // 2
            #endregion

            #region divisible by 3 | 3'e bölünenler
            int[] nums = { 2, 435, 567, 54, 6, 546, 35, 2345, 78 };
            Console.Write("Divisible by 3: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0) // kalan 0 ise tam bölünür | if remainder is 0 it divides evenly
                {
                    Console.Write(nums[i] + " ");
                }                }

            }
            Console.WriteLine();
            #endregion

            Console.Read();
        }
    }
}
