using System;

namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Void methods / Değer döndürmeyen metotlar
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            void PrintStudentCard(string name, string surname)
            {
                Console.WriteLine("Student: " + name + " " + surname);
            }

            void PrintSum(int num1, int num2, int num3)
            {
                Console.WriteLine("Total: " + (num1 + num2 + num3));
            }


            // Return methods / Değer döndüren metotlar
            string GetGreeting()
            {
                return "Hello!";
            }

            string GetStudentCard()
            {
                return "John Doe";
            }
            Console.WriteLine(GetStudentCard());

            string GetCountryInfo(string country, string capital, string flagColor)
            {
                return $"Country: {country} - Capital: {capital} - Flag: {flagColor}";
            }
            // Console.WriteLine(GetCountryInfo("Turkey", "Ankara", "Red-White"));

            int AddNumbers(int number1, int number2)
            {
                return number1 + number2;
            }

            // Practical example / Koşullu mantık örneği
            string CalculateExamResult(string student, int exam1, int exam2, int exam3)
            {
                int average = (exam1 + exam2 + exam3) / 3;
                return average >= 50 ? $"{student} passed." : $"{student} failed.";
            }
            // Console.WriteLine(CalculateExamResult("Jolly", 50, 40, 35));

            Console.Read();
        }
    }
}
