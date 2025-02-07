using System;
namespace MindfulnessApp
{
    class Program
    {
    static void Main(string[] args)
    {
        while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();

                if (choice == "4")
                    break;

                MindfulnessActivity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    _ => null
                };

                activity?.StartActivity();
            }
        }
    }
}