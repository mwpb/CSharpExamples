using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorials
{
    class DateTutorial
    {
        public void runDateTutorial()
        {
            // The System.DateTime provides static access
            // to the system clock.
            var currentTime = DateTime.Now;
            // if no time (only a date) is specified
            // then it will be set to midnight
            // which is the absolute START of the day
            var today = DateTime.Today; // midnight
            var someDate = new DateTime(2016, 7, 1); //midnight
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0);
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");

            // extracting information from a DateTime object
            var t = new DateTime(2016, 7, 1, 11, 20, 9);
            int year = t.Year;
            int month = t.Month;
            int day = t.Day;
            int hour = t.Hour;
            int minute = t.Minute;
            int second = t.Second;

            // the difference between two dates 
            // is a TimeSpan
            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year.");

            DateTime birthday = new DateTime(1988, 10, 22);
            TimeSpan daysOldSpan = DateTime.Today - birthday;
            int daysOld = daysOldSpan.Days;
            Console.WriteLine($"You are {daysOld} days old.");

        }
    }
}
