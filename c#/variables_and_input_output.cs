using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region passenger info
            string passenger_name, passenger_surname;
            Console.Write("passenger name: ");
            passenger_name = Console.ReadLine();
            Console.Write("passenger surname: ");
            passenger_surname = Console.ReadLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("name: " + "  " + passenger_name + " " + "surname: " + passenger_surname);
            #endregion

            #region shopping cart
            int shoes, laptop, tv, phone, headset;
            shoes = 1800;
            laptop = 70000;
            tv = 11899;
            phone = 25000;
            headset = 3500;

            int shoesQ, laptopQ, tvQ, phoneQ, headsetQ;
            Console.Write("how many shoes do you want: ");
            shoesQ = int.Parse(Console.ReadLine());
            Console.Write("how many laptops do you want: ");
            laptopQ = int.Parse(Console.ReadLine());
            Console.Write("how many tvs do you want: ");
            tvQ = int.Parse(Console.ReadLine());
            Console.Write("how many phones do you want: ");
            phoneQ = int.Parse(Console.ReadLine());
            Console.Write("how many headsets do you want: ");
            headsetQ = int.Parse(Console.ReadLine());

            int total = shoes * shoesQ + laptop * laptopQ + tv * tvQ + phone * phoneQ + headset * headsetQ;
            Console.WriteLine();
            Console.WriteLine("total price: " + total);
            #endregion

            #region exam average
            double exam1, exam2, exam3, exam4, result;
            Console.Write("enter exam 1 score: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("enter exam 2 score: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("enter exam 3 score: ");
            exam3 = double.Parse(Console.ReadLine());
            Console.Write("enter exam 4 score: ");
            exam4 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3 + exam4) / 4;
            Console.WriteLine();
            Console.WriteLine("average score: " + result);
            #endregion

            #region temperature converter
            double celsius;
            Console.Write("enter temperature in celsius: ");
            celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("fahrenheit: " + fahrenheit);
            Console.WriteLine("kelvin: " + kelvin);
            #endregion

            #region rectangle calculator
            double width, height;
            Console.Write("enter rectangle width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("enter rectangle height: ");
            height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine("area: " + area);
            Console.WriteLine("perimeter: " + perimeter);
            #endregion

            #region tip calculator
            double bill, tipPercent;
            Console.Write("enter bill amount: ");
            bill = double.Parse(Console.ReadLine());
            Console.Write("enter tip percentage: ");
            tipPercent = double.Parse(Console.ReadLine());
            double tip = bill * tipPercent / 100;
            double totalBill = bill + tip;
            Console.WriteLine("tip amount: " + tip);
            Console.WriteLine("total with tip: " + totalBill);
            #endregion

            #region speed distance time
            double speed, time;
            Console.Write("enter speed (km/h): ");
            speed = double.Parse(Console.ReadLine());
            Console.Write("enter time (hours): ");
            time = double.Parse(Console.ReadLine());
            double distance = speed * time;
            Console.WriteLine("distance traveled: " + distance + " km");
            #endregion

            Console.Read();
        }
    }
}
