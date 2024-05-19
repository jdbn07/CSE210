using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

class Program : Activity
{
    static void Main(string[] args)
    {
        Console.Clear();
        var choice = "";

        int count = 0;
        int breathingCounter = 0;
        int reflectingCounter = 0;
        int listingCounter = 0;

        do
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Until now, you used this program {count} times.");
            Console.WriteLine(" "); //
            Console.WriteLine($"You focused on your brething -- {breathingCounter} -- times.");
            Console.WriteLine($"You focused on reflecting -- {reflectingCounter} -- times.");
            Console.WriteLine($"You focused on listing your experiences -- {listingCounter} -- times.");
            
            
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.Run();
                breathingCounter++;
                count++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new();
                reflectingActivity.Run();
                reflectingCounter++;
                count++;
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity =  new();
                listingActivity.Run();
                listingCounter++;
                count++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thanks for priorize youe health! Stay safe!");
            }
            else
            {
                Console.Write("--- Invalid character, please select a number from the menu. Try again ---");
                Console.WriteLine(" ");
            }
        } while (choice != "4");
    }
}