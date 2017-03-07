// https://www.microsoft.com/net/tutorials/csharp/getting-started
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = "Matthew";
            var surname = "Burke";
            Console.WriteLine($"Hello {name} {surname}.");

            //the above is better than concatenation
            string message1 = "Hello"+name+" "+surname;
            //also it is better than a replace
            string message2 = "Hello **NAME** **SURNAME".Replace("**NAME**",name).Replace("**SURNAME**",surname);
            
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
            string shortVersion = input.Trim().Substring(0,3);

            // The System.DateTime provides static access
            // to the system clock.
            var currentTime = DateTime.Now;
            // if no time (only a date) is specified
            // then it will be set to midnight
            // which is the absolute START of the day
            var today = DateTime.Today; // midnight
            var someDate = new DateTime(2016,7,1); //midnight
            var someMoment = new DateTime(2016,7,1,8,0,0);
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");

            // extracting information from a DateTime object
            var t = new DateTime(2016,7,1,11,20,9);
            int year = t.Year;
            int month = t.Month;
            int day = t.Day;
            int hour = t.Hour;
            int minute = t.Minute;
            int second = t.Second;

            // the difference between two dates 
            // is a TimeSpan
            DateTime nextYear = new DateTime(DateTime.Today.Year+1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year.");

            DateTime birthday = new DateTime(1988,10,22);
            TimeSpan daysOldSpan = DateTime.Today - birthday;
            int daysOld = daysOldSpan.Days;
            Console.WriteLine($"You are {daysOld} days old.");
        }
    }
}