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
    public class Sweepstakes
    {
        Dictionary<int, Contestant> dataSet;
        List<int> keyList;
        string name;

        public Sweepstakes(string name)
        {
            dataSet = new Dictionary<int, Contestant>();
            keyList = new List<int>(dataSet.Keys);
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            dataSet.Add(contestant.RegistrationNumber, contestant);
            keyList.Add(contestant.RegistrationNumber);
            return;
        }

        public string PickWinner()
        {
            List<int> keyList = new List<int>(dataSet.Keys);
            Random random = new Random();

            int winningKey = keyList[random.Next(keyList.Count)];

            string winningContestant = dataSet[winningKey].FirstName + " " + dataSet[winningKey].FirstName;

            dataSet[winningKey].isWinner = true;

            return winningContestant;
        }

        public void GetSweepstakesResults(string winner)
        {
            foreach (int key in keyList)
            {
                UserInterface.PrintContestantResults(dataSet[key], winner);
            }

            return;
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant.FirstName, contestant.LastName, contestant.Email, contestant.RegistrationNumber);
            return;
        }
    }
}
