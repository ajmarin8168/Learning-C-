/* Allan Marin
* This program is following the Variables video by Bob Taylor https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners
*/
using System;

namespace For_Itterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // i=0 is declairing i as the starting value
            // i < 10 shows i must be less than 10 for the for statement to work
            // i++ increases the value of i by 1 each time the for statement is looped through
            for (int i = 0; i < 10; i++)
            {
                // below goes from 0-9
                //Console.WriteLine(i);

                // below writes found 7 when i == 7
                //if (i == 7)
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
