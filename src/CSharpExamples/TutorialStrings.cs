using System;

namespace Tutorials
{
    public class StringTutorial
    {
        public void runStringTutorial ()
        {
            var name = "Matthew";
            var surname = "Burke";
            Console.WriteLine($"Hello {name} {surname}.");

            //the above is better than concatenation
            string message1 = "Hello" + name + " " + surname;
            //also it is better than a replace
            string message2 = "Hello **NAME** **SURNAME".Replace("**NAME**", name).Replace("**SURNAME**", surname);

            // string is reference type
            // therefore are null when they are declared
            string string1; //string1 is null
            string1 = "Hello";
            string empty1 = ""; //empty1 is not null
            string empty2 = String.Empty;

            // illustration of the difference between
            // empty and null
            string emptyString = String.Empty;
            string nullString = null;
            Console.WriteLine(emptyString);
            Console.WriteLine(nullString);
            Console.WriteLine($"emptyString length = {emptyString.Length}");
            // the following line will cause an exception
            //Console.WriteLine($"nullString length = {nullString.Length}");

            string input = " Matthew ";
            string clean1 = input.TrimStart();
            string clean2 = input.TrimEnd();
            string clean3 = input.Trim();
            // substring takes a starting position
            // and a NUMBER OF CHARACTERS to return
            string shortVersion = input.Trim().Substring(0, 3);
    }
    }
}
