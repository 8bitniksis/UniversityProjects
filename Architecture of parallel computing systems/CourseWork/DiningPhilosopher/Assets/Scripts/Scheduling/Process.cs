using System;
using System.Collections;
using System.Collections.Generic;

namespace Scheduling
{
    [System.Serializable]
    public class Process : ICloneable
    {
        public int PID;
        public float ArriveTime;
        public float CPUTime;
        public float CriticalTime;
        public int Priority;

        public object Clone()
        {
            var process = (Process)MemberwiseClone();
            return process;
        }
    }

    [System.Serializable]
    public class Processes : List<Process>, ICloneable
    {
        public float AverageWaitingTime;
        public float AverageTurnAroundTime;

        public object Clone()
        {
            Processes processes = new Processes();
            foreach (var process in this)
            {
                processes.Add((Process)process.Clone());
            }
            return processes;
        }
    }
}
