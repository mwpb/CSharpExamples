using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Decisions
    {
        public void Guess(int userGuess)
        {
            var correctAnswer = new Random().Next(4);
            if (userGuess == correctAnswer)
            {
                Console.WriteLine("Correct");
            }
            else if (userGuess < correctAnswer)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Too high");
            }
        }
        public void Switcher()
        {
            switch (1)
            {
                case 0:
                    Console.WriteLine("Invalid guess.");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You guessed low.");
                    break;
                case 4:
                    Console.WriteLine("You guessed correct.");
                    break;
                default:
                    Console.WriteLine("You guessed high.");
                    break;
            }
        }
    }
}
