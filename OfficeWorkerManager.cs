using OfficeApp;
using System;
using System.Collections.Generic;

namespace OfficeApp
{
    public class OffiseWorkerManager
    {
        public void ExecuteGetPosition(List<OfficeWorker> officeWorkers)
        {
            for (int i = 0; i < officeWorkers.Count; i++)
            {
                officeWorkers[i].GetPosition();

            }

        }
    }
}

