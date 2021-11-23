using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "adming";
            string password = "pass1234";

            string userName, userPassword;

            Console.WriteLine("Enter ur username: ");
            userName = Console.ReadLine();

            Console.WriteLine("Enter ur password: ");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops. Something went wrong.");
            }

        }
    }
}
