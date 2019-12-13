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
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string email;
        public bool isWinner;
        private int registrationNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
        }

        public Contestant(string firstName, string lastName, string email, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationNumber = registrationNumber;
            isWinner = false;
        }
    }
}
