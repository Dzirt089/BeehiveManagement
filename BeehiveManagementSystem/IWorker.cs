using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    internal interface IWorker
    {
        string Job { get; }
        void WorkTheNextShift();
        
    }
}
