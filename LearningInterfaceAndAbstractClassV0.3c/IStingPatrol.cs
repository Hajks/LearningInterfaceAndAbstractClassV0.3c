using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._3c
{
    interface IStingPatrol : IWorker // So now if we decide to implement IStingPatrol, we have to include in our class all elements from this interface and IWorker interface 
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Length);
    }
}
