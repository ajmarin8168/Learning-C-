/* Allan Marin
* This program is following the Variables video by Bob Taylor https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners
* 
* Notes:
* an array is a "tackel box" with "storage areas"
* Also in general an array is a collection or data 
*/
using System;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

// The index is a place holder for specific variables in the array [] and can be called , like below

//Below outputs the number assigned to the index number in the array
            Console.WriteLine(numbers[1]);

// Below outputs the length of the array in a whole number                
            Console.WriteLine(numbers.Length);
            Console.ReadLine();

// Below creates a new array without by making the compialer figure out the amount of values based on inputting values in the {}
            int[] numbers2 = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers2[3]);
            Console.ReadLine();

// Below shows how to create an array for strings
            string[] names = new string[] { "Allan", "Porter", "Zeb", "Guarn", "Luke", "Christain", "Ryan", "Bryan" };

// Below is a for loop outputting all of the names in the array            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                
            }
            Console.ReadLine();

//Below shows another way to display the names using the foreach tool
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
// Below shows a string quote by Bill Gates
            String quote = "Time is the one Commodity you can't buy" +
                " - Bill Gates";
// char means single character
// Below shows a string of characters being seperated into individual characters and put into an array
            char[] charArray = quote.ToCharArray();
// Below takes the array and revereses so the cwords are read backwards
            Array.Reverse(charArray);

            foreach (char letter in charArray)
            {
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}
