// https://www.microsoft.com/net/tutorials/csharp/getting-started
using System;
using Extensions;

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
            var classTutorial = new Tutorials.TutorialClasses();
            var accessTutorial = new Tutorials.TutorialAccess();
            var course1 = accessTutorial.createCourse();
            course1.printStudents();
            Console.ReadLine();
        }
    }
}