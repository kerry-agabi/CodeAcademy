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

            if (password.Length > 8) 
            {

                Console.WriteLine("");
            }

            else 
            {
                Console.WriteLine("Password should be a bit more Lengthy");
            }

            if ( containsUpper)
            {

                Console.WriteLine("");
            }

            else
            {

                Console.WriteLine("Password Needs to contain an UpperCase");
            }

            if (containsLower)
            {

                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Password needs to contain a lower case");
            }

            if(containsSymbol)
            {
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Password needs to contain Symbols");
            }

            if ( containsDigit)
            {
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Password needs to contain Numbers");
            }

            if (password.Length < 8 && !containsUpper && !containsSymbol && !containsLower && !containsDigit)
            {

                Console.WriteLine("Password is Hella weak");
            }

            else
            {
                Console.WriteLine("Password is Hella Strong");
            }
            











        }
    }
}
