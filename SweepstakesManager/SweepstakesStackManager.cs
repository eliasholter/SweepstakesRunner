using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            try
            {
                return stack.Pop();
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
