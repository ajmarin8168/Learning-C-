/* Allan Marin
* This program is following the Variables video by Bob Taylor https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners
*/
using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /* int is used for numbers without decimals
             * must declare variable before it can be used
             * when changing a variable name use CTRL . to change all of the variable locations to the same name

            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

// string is used for using more than one letter, character, or number at once or for sentences
// us \n as enter button for spacing sentences
Console.WriteLine("What is your Name?");
            Console.WriteLine("Please type your first name:");
            string firstName;
            firstName = Console.ReadLine();

            string lastName;
            Console.WriteLine("Please type your last name: ");
            lastName = Console.ReadLine();

            /*can also be written as
            
            Console.WriteLine("What is your last name");
            String lastName = Console.ReadLine();

            */
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!\n" );
            Console.ReadLine();

        }
    }
}
