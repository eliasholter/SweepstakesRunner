using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            try
            {
                return queue.Dequeue();
            }
            catch(InvalidOperationException)
            {
                return null;
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
