using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "adming";
            string password = "pass1234";
            int attempts = 3;

            string userName, userPassword;

            while (attempts != 0)
            {
                Console.WriteLine("Enter ur username: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter ur password: ");
                userPassword = Console.ReadLine();

                if (login != userName || password != userPassword)
                {
                    Console.WriteLine("Oops. Something went wrong.");
                    attempts --;
                    Console.WriteLine($"{3 - attempts} attempts left");
                    if (attempts == 0)
                    {
                        Console.WriteLine("You don't have any attempts more");
                    }
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }

        }
    }
}
