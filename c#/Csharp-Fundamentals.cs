using System;

namespace CsharpLearningJourney
{
    // A simple console application to practice basics:
    // User info display, variables, arithmetic operations, and console output.
    internal class OrderCalculation
    {
        static void Main(string[] args)
        {
            // --- Part 1: Displaying User Information ---
            // Storing user details in variables
            string firstName = "Berat";
            string lastName = "Kurt";
            string studentId = "123456789";
            string city = "Istanbul";
            string country = "Turkey";

            // Output user details to the console
            Console.WriteLine("*** User Information ***");
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Location: " + city + " / " + country);
            Console.WriteLine(); // Add an empty line for readability


            // --- Part 2: Menu and Product Prices ---
            // Unit prices for menu items
            int hamburgerPrice = 300;
            int friesPrice = 150;
            int cokePrice = 100;
            int waterPrice = 50;

            // Displaying the menu with prices
            Console.WriteLine("--- Our Menu ---");
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Fries: " + friesPrice + " TL");
            Console.WriteLine("Coke: " + cokePrice + " TL");
            Console.WriteLine("Water: " + waterPrice + " TL");
            Console.WriteLine(); // Add an empty line for readability


            // --- Part 3: Placing an Order ---
            // Defining order quantities
            int hamburgerCount = 3;
            int friesCount = 3;
            int cokeCount = 3;
            int waterCount = 0;

            // Calculating totals for each item
            int totalHamburgerCost = hamburgerCount * hamburgerPrice;
            int totalFriesCost = friesCount * friesPrice;
            int totalCokeCost = cokeCount * cokePrice;
            int totalWaterCost = waterCount * waterPrice;

            // Calculating the grand total for the order
            int grandTotal = totalHamburgerCost + totalFriesCost + totalCokeCost + totalWaterCost;

            // Displaying the order summary and bill
            Console.WriteLine("--- Order Summary ---");
            Console.WriteLine("Hamburger (" + hamburgerCount + "x): " + totalHamburgerCost + " TL");
            Console.WriteLine("Fries (" + friesCount + "x): " + totalFriesCost + " TL");
            Console.WriteLine("Coke (" + cokeCount + "x): " + totalCokeCost + " TL");
            Console.WriteLine("Water (" + waterCount + "x): " + totalWaterCost + " TL");
            Console.WriteLine("---------------------");
            Console.WriteLine("Grand Total: " + grandTotal + " TL");

            // Pause the application before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
