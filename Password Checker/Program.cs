using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a Password");
            string password = Console.ReadLine();

            bool containsUpper = password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsDigit = password.Any(char.IsDigit);
            bool containsSymbol = password.Any(char.IsSymbol);
            int Score = 0;

            if (password.Length > 8) 
            {

                Score++;
            }

            else 
            {
                Console.WriteLine("Password should be a bit more Lengthy");
            }

            if ( containsUpper)
            {

                Score++;
            }

            else
            {

                Console.WriteLine("Password Needs to contain an UpperCase");
            }

            if (containsLower)
            {

                Score++;
            }

            else
            {
                Console.WriteLine("Password needs to contain a lower case");
            }

            if(containsSymbol)
            {
                Score++;

            }
            else
            {
                Console.WriteLine("Password needs to contain Symbols");
            }

            if ( containsDigit)
            {
                Score++;
            }

            else
            {
                Console.WriteLine("Password needs to contain Numbers");
            }

            if ( containsUpper && password.Length > 8 && containsSymbol && containsLower && containsDigit)
            {

                Console.WriteLine("Password is Strong");
                Score++;
                Score++;

                
            }

            else
            {
                Console.WriteLine("Password is weak");
            }

            Console.WriteLine(Score);


            switch (Score)
            {

                case 1:
                    Console.WriteLine("Password is weak");
                    break;

                    case 2:
                    Console.WriteLine("Password is mediocre ");
                    break;

                case 3:
                    Console.WriteLine("Password is weak ");
                    break;

                case 4:
                    Console.WriteLine("Password is medium");
                    break;

                case 5:
                    Console.WriteLine("Password is getting stronger");
                    break;
                case 6:
                    Console.WriteLine("Password is getting stronger");
                    break;
                case 7:
                    Console.WriteLine("Password is Strong");

                    break;

                default:
                    Console.WriteLine("Somethings wrong");
                    break;







            }








        }
    }
}
