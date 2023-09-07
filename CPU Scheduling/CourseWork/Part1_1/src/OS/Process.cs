using System.Collections.Generic;

namespace OS
{
    class Process
    {
        public int mArrival;
        public int mIndex;
        public int mBurstTime;
        public int mPriority;
        public int mCriticalTime;

        public Process()
        {

        }
        public Process(int index, int arrivalTime, int burstTime)
        {
            mIndex = index;
            mArrival = arrivalTime;
            mBurstTime = burstTime;
        }

        public Process(int index, int arrivalTime, int burstTime, int priority)
        {
            mIndex = index;
            mArrival = arrivalTime;
            mBurstTime = burstTime;
            mPriority = priority;
        }

        public Process(int index, int arrivalTime, int burstTime, int priority, int criticalTime)
        {
            mIndex = index;
            mArrival = arrivalTime;
            mBurstTime = burstTime;
            mPriority = priority;
            mCriticalTime = criticalTime;
        }

        public static void SortArrivalsTime(List<Process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].mArrival < l[j].mArrival)
                    {
                        Process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }

        public static void SortPrioritys(List<Process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].mPriority < l[j].mPriority)
                    {
                        Process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
        public static void SortBurstsTimes(List<Process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].mBurstTime < l[j].mBurstTime)
                    {
                        Process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }

        }

        public static void SortCriticalsTimes(List<Process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].mCriticalTime < l[j].mCriticalTime)
                    {
                        Process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }

        }
    }
}
