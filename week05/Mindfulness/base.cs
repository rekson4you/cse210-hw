using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int duration;
        protected string name;
        protected string description;

        public void StartActivity()
        {
            Console.WriteLine($"Starting {name}");
            Console.WriteLine(description);
            Console.Write("Enter the duration of the activity in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3); // Show spinner for 3 seconds before starting
            PerformActivity();
            EndActivity();
        }

        protected abstract void PerformActivity();

        protected void EndActivity()
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
            ShowSpinner(3); // Show spinner for 3 seconds before finishing
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\r{i}...");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
