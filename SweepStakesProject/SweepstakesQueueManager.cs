using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public void InsertSweepstakes(Sweepstakes sweepstakes)

        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(007);
            myQueue.Enqueue(700);
            myQueue.Enqueue(070);
            myQueue.Enqueue(770);

        }


        public Sweepstakes GetSweepstakes()
        {
        Queue myQueue = new Queue();
            myQueue.dequeue(007);
         
        }


    }
}
