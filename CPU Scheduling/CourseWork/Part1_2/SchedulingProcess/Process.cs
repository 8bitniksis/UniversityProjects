using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProcess
{
    public class Process : ICloneable
    {
        public int PID { get; set; }
        public float ArriveTime { get; set; }
        public float CPUTime { get; set; }
        public float CriticalTime { get; set; }
        public int Priority { get; set; }

        public object Clone()
        {
            var process = (Process)MemberwiseClone();
            return process;
        }
    }

    public class Processes : List<Process>, ICloneable
    {
        public float AverageWaitingTime { get; set; }
        public float AverageTurnAroundTime { get; set; }

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
