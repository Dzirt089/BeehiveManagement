using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    internal class NectarDefender : NectarCollector, IDefend
    {
        Bee worker = new NectarCollector();
        
        
        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
