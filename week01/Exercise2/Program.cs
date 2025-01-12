using System;

class Program
{
    static void Main(string[] args)
    {  
        //Ask the user for their grade
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            //Print the user grade
        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed. ");
        }
        else
        {
            Console.WriteLine("Keep trying! Better luck next time. ");
        }
    }
}
