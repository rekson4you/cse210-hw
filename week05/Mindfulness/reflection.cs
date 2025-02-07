using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private static readonly List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
        {
            name = "Reflection Activity";
            description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        protected override void PerformActivity()
        {
            Random rnd = new Random();
            string prompt = prompts[rnd.Next(prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(3); // Show spinner for 3 seconds before starting questions

            for (int i = duration; i > 0; i -= 5)
            {
                string question = questions[rnd.Next(questions.Count)];
                Console.WriteLine(question);
                ShowSpinner(5);
            }
        }
    }
}
