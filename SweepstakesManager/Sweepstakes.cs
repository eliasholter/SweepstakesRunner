﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    public class Sweepstakes
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

        public string PickWinner()
        {
            List<int> keyList = new List<int>(dataSet.Keys);
            Random random = new Random();

            int winningKey = keyList[random.Next(keyList.Count)];

            string winningContestant = dataSet[winningKey].FirstName + " " + dataSet[winningKey].FirstName;

            return winningContestant;
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant.FirstName, contestant.LastName, contestant.Email, contestant.RegistrationNumber);
            return;
        }
    }
}
