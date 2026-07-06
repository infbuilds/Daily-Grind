using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Topic: Conditions (if statements) | Konu: Koşullar (if ifadeleri)


namespace csharp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Golden Fork Restaurant & Bar--------------");
            Console.WriteLine("1-Main Dishes");
            Console.WriteLine("2-Drinks");
            Console.WriteLine("3-Soups");
            Console.WriteLine("4-Desserts");
            Console.WriteLine("--------------Golden Fork Restaurant & Bar--------------");
            Console.WriteLine("Please select a category:");
            string select;
            select = Console.ReadLine(); // kullanıcıdan seçim alır | reads selection from user

            if (select == "1") // eğer 1 seçildiyse | if 1 is selected
            {
                Console.WriteLine("--------------Main Dishes--------------");
                Console.WriteLine("1-Adana Wrap");
                Console.WriteLine("2-Stuffed Intestine");
                Console.WriteLine("3-Clay Pot Kebab");
                Console.WriteLine("4-Fried Chicken");
                Console.WriteLine("5-Bechamel Pasta");
            }

            if (select == "2") // eğer 2 seçildiyse | if 2 is selected
            {
                Console.WriteLine("--------------Drinks--------------");
                Console.WriteLine("1-Ayran");
                Console.WriteLine("2-Cola");
                Console.WriteLine("3-Beer");
                Console.WriteLine("4-Whiskey");
                Console.WriteLine("5-Sex on The Beach");
            }

            if (select == "3") // eğer 3 seçildiyse | if 3 is selected
            {
                Console.WriteLine("--------------Soups--------------");
                Console.WriteLine("1-Red Lentil Soup");
                Console.WriteLine("2-Tomato Soup");
                Console.WriteLine("3-Ezogelin Soup");
            }

            if (select == "4") // eğer 4 seçildiyse | if 4 is selected
            {
                Console.WriteLine("--------------Desserts--------------");
                Console.WriteLine("1-Baklava");
                Console.WriteLine("2-Rice Pudding");
                Console.WriteLine("3-Kadayif");
            }

            Console.Read(); // konsolu açık tutar | keeps console open
        }
    }
}
