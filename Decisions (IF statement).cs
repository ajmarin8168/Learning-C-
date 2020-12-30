/* Allan Marin
* This program is following the Variables video by Bob Taylor https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners
*/
using System;
using System.Net.Http;

namespace Decisions__IF_statement_
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.WriteLine("Bob's Big Giveaway\n");
            Console.Write("Choose a door: 1, 2, or 3\n");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "Sorry you lost.";
            else
            {
                message = "Sorry we didn't quite understand that.\nPlease enter a vailid answer of 1,2, or 3 \nPress ENTER to try again.";
                Console.WriteLine(message);
                Console.ReadLine();
                Main(null);
            }
            Console.WriteLine(message);
            Console.ReadLine();

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}
