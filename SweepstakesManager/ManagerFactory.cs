using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    static class ManagerFactory
    {
        public static ISweepstakesManager SelectManagerStyle(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new SweepstakesQueueManager();
                case "2":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid managment style"));
            }
        }
    }
}
