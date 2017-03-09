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
            var logicTutorial = new Tutorials.LogicTutorial();
            logicTutorial.countToTwentyFour();
            Console.ReadLine();
        }
    }
}