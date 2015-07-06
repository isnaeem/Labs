using MyAwesomeApp.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeApp
{
    class Program   // Difference between a class an object - Class is a template - Object is the specific thing
    {
        static void Main(string[] args)
        {
/*            
            if (File.Exists(@"HelloWorld.txt"))
            {
                Console.WriteLine("It Exists!"); // C# for strings it is ALWAYS DOUBLE QUOTES
            }

            String name = "Nick";
            Int32 number = 12;
            Boolean isTodayMonday = true;

            string name2 = "Nick";
            int number2 = 13;
            bool isTodayFriday = false;

            DateTime today = DateTime.Now;
            string todayIsFriday = isTodayFriday.ToString();
*/          
 
/*          
            Console.WriteLine("Enter the first number:");
            int firstNum = 0;
            bool firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);

            Console.WriteLine("Enter the second number");
            int secondNum = 0;
            bool secondNumIsNumber = int.TryParse(Console.ReadLine(), out secondNum);

             
            // Display Result
            if (firstNumIsNumber && secondNumIsNumber)
            {
                int result = firstNum + secondNum;
                Console.WriteLine("The result is " + result.ToString());
            }
            else 
            {
                Console.WriteLine("You did not enter valid numbers!");
            }
 */
 /*
            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;

            string dinner = "";
            switch (dayOfWeek) 
            { 
                case DayOfWeek.Monday:
                    dinner = "Steak";
                    break;
                case DayOfWeek.Tuesday:
                    dinner = "Chicken";
                    break;
                case DayOfWeek.Wednesday:
                    dinner = "Fish";
                    break;
                case DayOfWeek.Thursday:
                    dinner = "Roast";
                    break;
                case DayOfWeek.Friday:
                    dinner = "Biryani";
                    break;
                default:
                    dinner = "Pasta";
                    break;
            }
            Console.WriteLine("Dinner today is " + dinner);
 */
            Console.WriteLine("Enter a Date");
            DateTime randomDate;
            bool isDate = DateTime.TryParse(Console.ReadLine(), out randomDate);
            var message = !isDate ? "You did not enter the date correctly!" : randomDate.ToString("D");
            Console.WriteLine(message);
            //if (!isDate)
            //{
            //    Console.WriteLine("You did not enter the date correctly");
            //}
            //else 
            //{
            //    Console.WriteLine(randomDate.ToString("D"));
            //}
            Console.ReadLine();
        }
    }
}