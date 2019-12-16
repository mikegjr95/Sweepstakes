using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        public void InsertSweepstakes(Sweepstakes sweepstakes)


        {
            Stack sweepstakesStack = new Stack();

            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
            sweepstakesStack.Push("");
        }
        public Sweepstakes GetSweepstakes()
        {

        }

    }
} 
