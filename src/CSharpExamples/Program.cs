// https://www.microsoft.com/net/tutorials/csharp/getting-started
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stringTutorial = new Tutorials.StringTutorial();
            var dateTutorial = new Tutorials.DateTutorial();
            var decisionTutorial = new Tutorials.Decisions();
            var userGuess = Console.ReadLine();
            decisionTutorial.Guess(int.Parse(userGuess));
            Console.ReadLine();
        }
    }
}