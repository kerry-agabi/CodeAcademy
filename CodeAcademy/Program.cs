// See https://aka.ms/new-console-template for more information
using System;

namespace FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {





            bool b = true;
            string con = b.ToString();
            Console.WriteLine("This is the conversion "+ b);

            string sentence = "Kerry Agabi";
            char[] charArr = sentence.ToCharArray();
            foreach (char ch in charArr)
            {
                Console.WriteLine(ch);
            }

            long count = 76665464455;
            string Verify = count.ToString();
            Console.WriteLine(Verify);
            //double Number;
            //// Ask user for fave number
            //Console.Write("Enter your favorite number!: ");
            // Number =double.Parse(Console.ReadLine());
            //int NewNumber = (int)Number;
            //Console.Write(NewNumber);
            //// Turn that answer into an int

            //bool isRaining = false;
            //// This sets umbrellaOrNot to "Umbrella" if isRaining is true,
            //// and "No Umbrella" if isRaining is false.
            //string umbrellaOrNot = isRaining ? "Umbrella" : "The Latter";

            //// "Umbrella"
            //Console.WriteLine(umbrellaOrNot);


        }
    }
}


