using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dataSet;
        string name;

        public Sweepstakes(string name)
        {
            dataSet = new Dictionary<int, Contestant>();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            dataSet.Add(contestant.RegistrationNumber, contestant);
            return;
        }

        public Contestant PickWinner(int winningKey)
        {
            return dataSet[winningKey];
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant.FirstName, contestant.LastName, contestant.Email, contestant.RegistrationNumber);
            return;
        }
    }
}
