using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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

        public static Contestant NewContestant()
        {
            string firstName = GetCustomerFirstName();
            string lastName = GetCustomerLastName();
            string email = GetCustomerEmail();
            int refNum = GetCustomerRefNumber();

            Contestant newContestant = new Contestant(firstName, lastName, email, refNum);

            return newContestant;
        }

        public static string GetCustomerFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            return Console.ReadLine();
        }

        public static string GetCustomerLastName()
        {
            Console.Clear();
            Console.WriteLine("Please enter your last name:");
            return Console.ReadLine();
        }

        public static string GetCustomerEmail()
        {
            Console.Clear();
            Console.WriteLine("Please enter your email:");
            return Console.ReadLine();
        }

        public static int GetCustomerRefNumber()
        {
            Console.Clear();
            bool userInputIsAnInteger = false;
            int registrationNumber = -1;

            while (!userInputIsAnInteger || registrationNumber < 0)
            {
                Console.WriteLine("Please enter your registration number: ");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out registrationNumber);
            }

            return registrationNumber;
        }

        public static void PrintContestantInfo(string firstName, string lastName, string email, int registrationNumber)
        {
            Console.WriteLine("First Name:          " + firstName);
            Console.WriteLine("Last Name:           " + lastName);
            Console.WriteLine("Email:               " + email);
            Console.WriteLine("Registration Number: " + registrationNumber);
            Console.ReadLine();
            return;
        }

        public static void PrintContestantResults(Contestant contestant, string winner)
        {
            if (contestant.isWinner == true)
            {
                Console.WriteLine("Congratulations " + winner + " you won the sweepstakes!");

                // Use MailKit API to send email to the winner
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sweepstakes 'R' Us", "elias_footballer2@yahoo.com"));
                message.To.Add(new MailboxAddress(winner, contestant.Email));
                message.Subject = "Winner Winner Chicken Dinner!";
                message.Body = new TextPart("plain") { Text = @"Greetings " + winner + " and congratulations on winning the sweepstakes!" };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("smtp.mail.yahoo.com", 465, false);

                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            else
            {
                Console.WriteLine("Congratulations to " + winner + " on winning the sweepstakes!");
                Console.WriteLine("Sorry " + contestant.FirstName + " " + contestant.LastName + " you did not win this sweepstakes. Better luck next time!");
            }

            Console.ReadLine();
            return;
        }
    }
}
