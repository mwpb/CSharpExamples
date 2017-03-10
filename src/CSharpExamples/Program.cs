﻿// https://www.microsoft.com/net/tutorials/csharp/getting-started
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
            var arrayTutorial = new Tutorials.TutorialArrays();
            var methodTutorial = new Tutorials.TutorialMethods();
            Console.WriteLine(methodTutorial.calcArea(5,4));
            Console.ReadLine();
        }
    }
}