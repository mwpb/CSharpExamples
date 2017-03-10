using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class TutorialMethods
    {
        // a static method is called from the class
        // not an instance.
        // this means that it shouldn't depend 
        // on the other properties of the class.
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public string FirstName;
        public string Surname;
        // FullName depends on other properties 
        // so shouldn't be static.
        public string FullName()
        {
            return $"{FirstName} {Surname}";
        }
        // optional args and defaults
        public string CreateGreeting(string name = "undefined")
        {
            return $"Hi {name}";
        }
        // alternatively using method overloads
        public string Greeting2()
        {
            return "Hi there";
        }
        public string Greeting2(string name)
        {
            return $"Hi {name}";
        }

        // lambda expressions
        public Func<int, int> addOne = (x => x+1);
        public Func<int, int, int> calcArea = ((x, y) => x * y);
        //halfway through extension methods

    }
}
