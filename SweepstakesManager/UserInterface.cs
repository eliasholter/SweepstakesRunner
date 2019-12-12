using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    public static class UserInterface
    {
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
