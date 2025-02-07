using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
        {
            name = "Breathing Activity";
            description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void PerformActivity()
        {
            for (int i = duration; i > 0; i -= 5)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(2);
                Console.WriteLine("Breathe out...");
                ShowCountdown(3);
            }
        }

        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\r{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
