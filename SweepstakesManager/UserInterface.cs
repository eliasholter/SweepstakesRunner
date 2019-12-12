using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    public static class UserInterface
    {
        public static string ChooseManagerStyle()
        {
            bool validSelection = false;
            string selection = "";

            while (validSelection == false)
            {
                Console.WriteLine("Would you like to use a Queue or a Stack to manage your Sweepstakes? Please enter 1 for Queue or 2 for Stack: ");
                selection = Console.ReadLine();

                if(selection == "1")
                {
                    validSelection = true;
                }
                else if(selection == "2")
                {
                    validSelection = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection, please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }              
            }

            return selection;
        }

        public static string GetCustomerFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            return Console.ReadLine();
        }

        public static string GetCustomerLastName()
        {
            Console.WriteLine("Please enter your last name:");
            return Console.ReadLine();
        }

        public static string GetCustomerEmail()
        {
            Console.WriteLine("Please enter your email:");
            return Console.ReadLine();
        }

        public static string GetCustomer()
        {
            Console.WriteLine("Please enter your email:");
            return Console.ReadLine();
        }

        public static string PrintContestantInfo(string firstName, string lastName, string email, int registrationNumber)
        {
            Console.WriteLine("First Name:          " + firstName);
            Console.WriteLine("Last Name:           " + lastName);
            Console.WriteLine("Email:               " + email);
            Console.WriteLine("Registration Number: " + registrationNumber);
            return Console.ReadLine();
        }
    }
}
