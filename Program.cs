using OfficeApp;
using System;
using System.Collections.Generic;

namespace OfficeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OffiseWorkerManager offiseWorkerManager = new OffiseWorkerManager();
            List<OfficeWorker> officeWorkers = new List<OfficeWorker>();
            OfficeWorker cordinator = new Cordinator("Alina", "Petrosyan", 25);
            cordinator.AddBonus();
            officeWorkers.Add(cordinator);

            officeWorkers.Add(new Director("Mamikon", "Vardanyan", 35));
            officeWorkers.Add(new Assistant("Karen", "Arustamyan", 27));
            officeWorkers.Add(new SecurityWorker("Gor", "Gevorgyan", 54));
            offiseWorkerManager.ExecuteGetPosition(officeWorkers);

            Console.ReadKey();

        }
    }
}

