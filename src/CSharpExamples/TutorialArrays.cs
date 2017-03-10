using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class TutorialArrays
    {
        public int[] integerArray()
        {
            int[] integerList = { 1, 2, 3 };
            int x = integerList[0] + 1;
            int y = integerList[1] + 1;
            integerList[1] = y;
            // the following line throws IndexOutOfRangeException
            //integerList[3] = x;
            return integerList;
        }

        public void splitter()
        {
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(',');
            string dashedString = String.Join("-",colors);
            Console.WriteLine(dashedString);
        }

        public void lists()
        {
            // lists are arrays without a fixed size
            List<int> someInts = new List<int>();
            someInts.Add(2);

            List<int> moreInts = new List<int>() { 2, 3, 4 };

            string[] colors = "red,blue,yellow,green".Split(',');
            List<string> colorList = new List<string>(colors);

            colorList.Remove("red");
            colorList.Insert(0, "orange");
            colorList.RemoveAll(c => c.Contains("l"));
            Console.WriteLine(String.Join(", ", colorList));
            // count method works on every IEnumerable
            // length is specific for lists
            int numColors = colorList.Count;
            Console.WriteLine($"colorList has {numColors} elements");

            colorList.ForEach(c => Console.WriteLine(c));
        }

        public void todo()
        {
            List<string> todoList = new List<string>();
            bool userWantsToExit = false;
            while (!userWantsToExit)
            {
                Console.WriteLine(
                    $"{{{String.Join(",",todoList)}}}"
                    );
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input = Console.ReadLine();
                if (input == "--")
                {
                    todoList.Clear();
                }
                else if (input == "q")
                {
                    userWantsToExit = true;
                }
                else if (input.StartsWith("-"))
                {
                    string itemName = input.Substring(1);
                    todoList.Remove(itemName);
                }
                else if (input.StartsWith("+"))
                {
                    string itemName = input.Substring(1);
                    todoList.Add(itemName);
                }
                else
                {
                    Console.WriteLine("Invlaid Command");
                }
            }
        }
        public void listIteration()
        {
            // this only provides access to 
            // one element of the list
            var myList = new List<string>() { "one", "two", "three" };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            for (int i=0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }

        public void sumList()
        {
            List<int> intList = new List<int>() { 2, 4, 6, 5 };
            Console.WriteLine($"Numbers: {String.Join(" ",intList)}");
            int sum = 0;
            for (int i=0;i<intList.Count;i++)
            {
                sum = sum + intList[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
