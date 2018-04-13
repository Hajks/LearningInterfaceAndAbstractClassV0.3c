using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._3c
{
    interface IWorker
    {
        string job{get; }
        int ShiftsLeft { get; }
        void DoThisJob(string job, int shifts);
        void WorkOneShift();
    }
}
