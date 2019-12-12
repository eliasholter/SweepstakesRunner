using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Contestant> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Contestant>();
        }

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
