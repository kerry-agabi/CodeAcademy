using Figgle;
using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            CONDITIONALS: if, if...else, else if
            SWITCH STATEMENT: switch (condition)
            TERNARY OPERATOR: (condition) ? true : false

            Good luck! */

            Console.WriteLine("guess a random number between 1-10 ");
            string Number = Console.ReadLine();

            switch (Number)
            {

                case "1":
                    Console.WriteLine("Too low");
                    break;

                case "2":
                    Console.WriteLine("Too low");
                    break;
                case "3":
                    Console.WriteLine("Too low");
                    break;
                case "4":
                    Console.WriteLine("Too low");
                    break;
                case "5":
                    Console.WriteLine("Correct!");
                    break;
                case "6":
                    Console.WriteLine("Too High");
                    break;
                case "7":
                    Console.WriteLine("Too High");
                    break;
                case "8":
                    Console.WriteLine("Too High");
                    break;
                case "9":
                    Console.WriteLine("Too High");
                    break;
                case "10":
                    Console.WriteLine("Too High");
                    break;
                default:
                    Console.WriteLine("Chosen Number isn't between 1-10\n");
                    break;
            }

            Console.WriteLine("Enter Your Favourite Type of Cuisine");
            string Cuisine = Console.ReadLine();

            if (Cuisine == "Chinese")
            {
                Console.WriteLine("You are a Persian Cat");
            }

            else if (Cuisine == "Caribbean")
            {
                Console.WriteLine("You are a Maine Coon Cat");

            }

            else if (Cuisine == "British")
            {
                Console.WriteLine("You are a British Shorthair Cat");
            }

            else
            {

                Console.WriteLine("Invalid option, Run the program again and pick between the following: \n 1. Chinese \n 2. Carribean \n 3. British ");
            }

            DateTime birthday = new DateTime(1943, 06, 01);
            Console.WriteLine("Enter Your Birthday");
            string Birthday = Console.ReadLine();
            var UserDate = DateTime.Parse(Birthday);    

            if (birthday == UserDate)
            {
                Console.WriteLine(
                FiggleFonts.Standard.Render("Hello, World!"));

            }

             else if(birthday != UserDate)
            {
                Console.WriteLine((birthday-UserDate).TotalDays);
               
            }

            else
            {

                Console.WriteLine("Oops, Somethings wrong with your date format...run the program again and try using the VS studio date format (int year, int month, int day) ");
            }


    }
    }
}
