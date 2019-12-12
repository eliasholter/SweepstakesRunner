using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = UserInterface.ChooseManagerStyle();

            ISweepstakesManager managerChoice = ManagerFactory.SelectManagerStyle(userChoice);

            MarketingFirm firm = new MarketingFirm(managerChoice);

        }
    }
}
