using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class LogicTutorial
    {
        public string Greeting()
        {
            // it is often eaier to appropriately define 
            // the booleans first and then take care of
            // the branching
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            bool isMorning = hour < 12;
            bool isAfternoon = hour >= 12 && hour < 17;
            bool isEvening = hour >= 17 && hour < 22;
            bool isNight = hour >= 22 && hour < 24;
            if (isMorning) { return "Good Morning"; }
            if (isAfternoon) { return "Good Afternoon"; }
            if (isEvening) { return "Good Evening"; }
            if (isNight) { return "Good Night"; }
            return "Escaped";
        }

        public void Guesser()
        {
            int numberToGuess = new Random().Next(1, 101);
            int currentGuess = 0;
            while (true)
            {
                Console.WriteLine("Guess between 1 and 100.");
                currentGuess = int.Parse(Console.ReadLine());
                if (currentGuess < numberToGuess)
                {
                    Console.WriteLine("Too low.");
                }
                if (currentGuess > numberToGuess)
                {
                    Console.WriteLine("Too high");
                }
                if (currentGuess == numberToGuess) { break; }
            }
            Console.WriteLine("Correct");
        }

        public void printFactors()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors: ");
            if(number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.WriteLine(candidateFactor);
                        number = number / candidateFactor;
                    }
                    candidateFactor = candidateFactor + 1;
                }
                
            }
        }

        public void printInterval()
        {
            // first arg names and initialises dummy variable
            // second argument specifies the break condition
            // third tells how to update the dummy
            // i++ is short for i = i+1
            int startNumber = 5;
            int endNumber = 10;
            for (int i=startNumber; i< endNumber; i++)
            {
                Console.WriteLine(i);
            }
            // i+=2 is short for i = i+2
            for (int i=0; i< 10; i+=2)
            {
                Console.WriteLine(i);
            }
            //similarly i-- and i-=2
        }

        public void multiplicationTable()
        {
            Console.WriteLine("    1 2 3 4 5 6 7 8 9");
            for (int i =1; i< 10; i++)
            {
                Console.Write($" {i} ");
                for (int j =1; j<10;j++)
                {
                    string product = (i * j).ToString();
                    Console.Write(product.PadLeft(3));
                }
                Console.WriteLine();
            }
        }
        public void countToTwentyFour()
        {
            for (var inc = 1; inc <=4; inc++)
            {
                Console.Write("0");
                for (var i = inc; i <= 24; i+=inc)
                {
                    Console.Write($", {i}");
                }
                Console.WriteLine();
            }
        }
    }
}
