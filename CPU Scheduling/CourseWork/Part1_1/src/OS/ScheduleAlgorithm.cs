using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OS
{
    internal class ScheduleAlgorithm
    {
        //inputs
        public int[] mArivalsTime;
        public int[] mBurstsTime;
        public int[] mPrioritys;
        public int[] mCritialsTime;
        
        public int mQuantum;
        public int mNumbProcess;
        public TextBox mTexBox;


        //outputs
        public int[] waitingTime;
        public int[] turnaroundTime;
        public int[] start;
        public int[] end;
        public int[] proc;

        public float avg_waiting;
        public float avg_turnaround;
        public float freeTimes;
        public float freeTimesPercent;
        public int lastValid;

        public ScheduleAlgorithm(int[] arrivalsTime, int[] burstsTime, int[] priorytis, int[] critialsTime, int quant, int num)
        {
            mNumbProcess = num;
            mArivalsTime = arrivalsTime;
            mBurstsTime = burstsTime;
            mPrioritys = priorytis;
            mQuantum = quant;
            mCritialsTime = critialsTime;

            waitingTime = new int[2000];
            turnaroundTime = new int[2000];
            start = new int[2000];
            end = new int[2000];
            proc = new int[2000];
            for (int i = 0; i < 2000; i++)
            {
                waitingTime[i] = 0; turnaroundTime[i] = 0; start[i] = 0; end[i] = 0; proc[i] = -1;
            }
        }

        public void ClearData()
        {
            mArivalsTime = new int[0]; mBurstsTime = new int[0]; mPrioritys = new int[0]; mCritialsTime = new int[0];
            for (int i = 0; i < 2000; i++)
            {
                waitingTime[i] = 0; turnaroundTime[i] = 0; start[i] = 0; end[i] = 0; proc[i] = -1;
            }
        }

        public void ScheduleFirstComeFirstServed()
        {
            List<Process> p = new List<Process>(mNumbProcess);

            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i]));
            }

            Process.SortArrivalsTime(p);

            int cnt = 0, idx = 0;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (p[i].mArrival <= cnt)
                {
                    //Output process scheduling
                    start[idx] = cnt;
                    end[idx] = cnt + p[i].mBurstTime;
                    proc[idx] = p[i].mIndex;
                    waitingTime[i] = start[idx] - p[i].mArrival;
                    turnaroundTime[i] = end[idx] - p[i].mArrival;
                    cnt += p[i].mBurstTime;
                    if (cnt > mCritialsTime[i])
                    {
                        Console.WriteLine("Время выполнения: " + turnaroundTime[i]);
                        Console.WriteLine("Предельный срок: " + mCritialsTime[i]);
                        Console.WriteLine("Процесс Id: " + i + " вышел за свои рамки предельного срока");
                        mTexBox.Text += "Время выполнения: " + turnaroundTime[i] + Environment.NewLine;
                        mTexBox.Text += "Предельный срок: " + mCritialsTime[i] + Environment.NewLine;
                        mTexBox.Text += "Процесс Id: " + i + " вышел за свои рамки предельного срока" + Environment.NewLine;
                    }
                    idx++;
                }
                else
                {
                    //Output free time data
                    start[idx] = cnt;
                    end[idx] = p[i].mArrival;
                    //Free time output
                    proc[idx] = -1;
                    freeTimes += end[idx] - start[idx];
                    Console.WriteLine("FCFS idle: " + freeTimes);
                    cnt = p[i].mArrival;
                    idx++;
                    start[idx] = cnt;
                    end[idx] = cnt + p[i].mBurstTime;
                    proc[idx] = p[i].mIndex;
                    waitingTime[i] = start[idx] - p[i].mArrival;
                    turnaroundTime[i] = end[idx] - p[i].mArrival;
                    
                    cnt += p[i].mBurstTime;
                    idx++;
                }
            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx;
        }
        public void ScheduleRoundRobin()
        {
            List<Process> p = new List<Process>(mNumbProcess);
            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i], mPrioritys[i], mCritialsTime[i]));
            }
            Process.SortArrivalsTime(p);

            int cnt = 0, idx = 0;
            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(mNumbProcess);
                if (p.First().mArrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = p.First().mArrival;
                    //Free time output
                    proc[idx] = -1;
                    freeTimes += end[idx] - start[idx];
                    Console.WriteLine("RR idle: " + freeTimes);
                    idx++;
                    cnt = p.First().mArrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].mArrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;

                }
                while (ready.Count != 0)
                {
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (mQuantum < readyProcess.mBurstTime)
                    {
                        start[idx] = cnt;
                        end[idx] = cnt + mQuantum;
                        freeTimesPercent = (freeTimes / end[idx]) * 100;
                        proc[idx] = readyProcess.mIndex;
                        cnt += mQuantum;
                        readyProcess.mBurstTime -= mQuantum;
                        ready.Add(readyProcess);
                        idx++;
                    }
                    else
                    {
                        start[idx] = cnt;
                        end[idx] = cnt + readyProcess.mBurstTime;
                        freeTimesPercent = (freeTimes / end[idx]) * 100;
                        proc[idx] = readyProcess.mIndex;
                        cnt += readyProcess.mBurstTime;
                        if (cnt > mCritialsTime[idx])
                        {
                            Console.WriteLine("Время выполнения: " + turnaroundTime[idx]);
                            Console.WriteLine("Предельный срок: " + mCritialsTime[idx]);
                            Console.WriteLine("Процесс Id: " + idx + " вышел за свои рамки предельного срока");
                            mTexBox.Text += "Время выполнения: " + turnaroundTime[idx] + Environment.NewLine;
                            mTexBox.Text += "Предельный срок: " + mCritialsTime[idx] + Environment.NewLine;
                            mTexBox.Text += "Процесс Id: " + idx + " вышел за свои рамки предельного срока" + Environment.NewLine;
                        }
                        idx++;
                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].mArrival <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;
                    }

                }
            }
            for (int j = 0; j < mNumbProcess; j++)
            {
                bool k = false; int wait = 0;
                for (int i = 0; i <= idx; i++)
                {
                    if (proc[i] == j)
                    {
                        if (!k)
                        {
                            waitingTime[j] = start[i] - mArivalsTime[j]; k = true;
                            wait = end[i];

                        }
                        else if (k)
                        {
                            waitingTime[j] += start[i] - wait;
                            wait = end[i];
                        }
                        turnaroundTime[j] = wait - mArivalsTime[j];
                    }
                }
            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx;

        }
        public void SchedulePriorityNonPremptive()
        {
            List<Process> p = new List<Process>(mNumbProcess);

            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i], mPrioritys[i], mCritialsTime[i]));
            }
            Process.SortArrivalsTime(p);
            int cnt = 0;
            int idx = 0;

            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(mNumbProcess);
                if (p.First().mArrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = p.First().mArrival;
                    //Free time output
                    proc[idx] = -1;
                    freeTimes += end[idx] - start[idx];
                    Console.WriteLine("PriorityNP idle: " + freeTimes);
                    idx++;
                    cnt = p.First().mArrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].mArrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
                while (ready.Count != 0)
                {
                    Process.SortPrioritys(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    start[idx] = cnt;
                    end[idx] = cnt + readyProcess.mBurstTime;
                    freeTimesPercent = (freeTimes / end[idx]) * 100;
                    proc[idx] = readyProcess.mIndex;
                    waitingTime[idx] = start[idx] - readyProcess.mArrival;
                    turnaroundTime[idx] = end[idx] - readyProcess.mArrival;
                    idx++;
                    cnt += readyProcess.mBurstTime;
                    for (int i = 0, j = 0; i < p.Count; i++)
                    {
                        if (p[j].mArrival <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                            if (turnaroundTime[j] > mCritialsTime[j])
                            {
                                Console.WriteLine("Время выполнения: " + turnaroundTime[j]);
                                Console.WriteLine("Предельный срок: " + mCritialsTime[j]);
                                Console.WriteLine("Процесс Id: " + j + " вышел за свои рамки предельного срока");
                                mTexBox.Text += "Время выполнения: " + turnaroundTime[j] + Environment.NewLine;
                                mTexBox.Text += "Предельный срок: " + mCritialsTime[j] + Environment.NewLine;
                                mTexBox.Text += "Процесс Id: " + j + " вышел за свои рамки предельного срока" + Environment.NewLine;
                            }
                        }
                        else j++;
                    }
                }

            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx;
        }

        public void SchedulePriorityPremprive()
        {
            List<Process> p = new List<Process>(mNumbProcess);

            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i], mPrioritys[i], mCritialsTime[i]));
            }
            Process.SortArrivalsTime(p);
            int cnt = 0;
            int idx = 0;
            int cur = -2;
            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(mNumbProcess);
                if (p.First().mArrival > cnt)
                {
                    idx++;
                    start[idx] = cnt;
                    end[idx] = p.First().mArrival;
                    freeTimes += end[idx] - start[idx];
                    proc[idx] = -1;
                    idx++;
                    cnt = p.First().mArrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].mArrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
                while (ready.Count != 0)
                {
                    Process.SortPrioritys(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (cur != readyProcess.mIndex)
                    {
                        idx++;
                        start[idx] = cnt;
                        proc[idx] = readyProcess.mIndex;

                        readyProcess.mBurstTime--;
                        cur = readyProcess.mIndex;
                        cnt++;
                        end[idx] = cnt;

                        if (readyProcess.mBurstTime > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        
                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].mArrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                            }
                            else j++;
                        }
                    }
                    else
                    {
                        readyProcess.mBurstTime--;
                        cur = readyProcess.mIndex;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.mBurstTime > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        
                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].mArrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                                
                            }
                            else j++;
                        }
                    }
                    
                }
            }
            for (int j = 0; j < mNumbProcess; j++)
            {
                bool k = false; int wait = 0;
                for (int i = 0; i <= idx; i++)
                {
                    if (proc[i] == j)
                    {
                        if (!k)
                        {
                            waitingTime[j] = start[i] - mArivalsTime[j]; k = true;
                            wait = end[i];

                        }
                        else if (k)
                        {
                            waitingTime[j] += start[i] - wait;
                            wait = end[i];
                        }
                        turnaroundTime[j] = wait - mArivalsTime[j];
                        if (turnaroundTime[j] > mCritialsTime[j])
                        {
                            Console.WriteLine("Время выполнения: " + turnaroundTime[j]);
                            Console.WriteLine("Предельный срок: " + mCritialsTime[j]);
                            Console.WriteLine("Процесс Id: " + j + " вышел за свои рамки предельного срока");

                            mTexBox.Text += "Процесс Id: " + j + " вышел за свои рамки предельного срока" + Environment.NewLine;
                            mTexBox.Text += "Его текущее критическое время: " + turnaroundTime[j] + Environment.NewLine;
                        }
                        freeTimesPercent = (freeTimes / end[i]) * 100;
                    }
                }
            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];             
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx + 1;

        }
        public void ScheduleShortestJobFirstNonPremptive()
        {
            List<Process> p = new List<Process>(mNumbProcess);

            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i], mPrioritys[i], mCritialsTime[i]));
            }
            Process.SortArrivalsTime(p);
            int cnt = 0;
            int idx = 0;

            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(mNumbProcess);
                if (p.First().mArrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = p.First().mArrival;
                    //Free time output
                    proc[idx] = -1;
                    freeTimes += end[idx] - start[idx];
                    Console.WriteLine("SJF_NP idle: " + freeTimes);
                    idx++;
                    cnt = p.First().mArrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].mArrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
                while (ready.Count != 0)
                {
                    Process.SortBurstsTimes(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    start[idx] = cnt;
                    end[idx] = cnt + readyProcess.mBurstTime;
                    freeTimesPercent = (freeTimes / end[idx]) * 100;
                    proc[idx] = readyProcess.mIndex;
                    waitingTime[idx] = start[idx] - readyProcess.mArrival;
                    turnaroundTime[idx] = end[idx] - readyProcess.mArrival;
                    idx++;
                    cnt += readyProcess.mBurstTime;
                    for (int i = 0, j = 0; i < p.Count; i++)
                    {
                        if (p[j].mArrival <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                            if (turnaroundTime[j] > mCritialsTime[j])
                            {
                                Console.WriteLine("Время выполнения: " + turnaroundTime[j]);
                                Console.WriteLine("Предельный срок: " + mCritialsTime[j]);
                                Console.WriteLine("Процесс Id: " + j + " вышел за свои рамки предельного срока");
                                mTexBox.Text += "Время выполнения: " + turnaroundTime[j] + Environment.NewLine;
                                mTexBox.Text += "Предельный срок: " + mCritialsTime[j] + Environment.NewLine;
                                mTexBox.Text += "Процесс Id: " + j + " вышел за свои рамки предельного срока" + Environment.NewLine;
                            }
                        }
                        else j++;
                    }
                }

            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx;

        }
        public void ScheduleShortestJobFirstPremprive()
        {
            List<Process> p = new List<Process>(mNumbProcess);
            for (int i = 0; i < mNumbProcess; i++)
            {
                p.Add(new Process(i, mArivalsTime[i], mBurstsTime[i], mPrioritys[i], mCritialsTime[i]));
            }
            Process.SortArrivalsTime(p);
            int cnt = 0;
            int idx = 0;
            int cur = -2;
            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(mNumbProcess);
                if (p.First().mArrival > cnt)
                {
                    //TODO:Check why SJF work normal with two idx++
                    idx++;
                    start[idx] = cnt;
                    end[idx] = p.First().mArrival;
                    freeTimes += end[idx] - start[idx];
                    Console.WriteLine("SJF_P idle: " + freeTimes);
                    //Free time output
                    proc[idx] = -1;
                    idx++;
                    
                    cnt = p.First().mArrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].mArrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
                while (ready.Count != 0)
                {
                    Process.SortBurstsTimes(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (cur != readyProcess.mIndex)
                    {
                        idx++;
                        start[idx] = cnt;
                        proc[idx] = readyProcess.mIndex;

                        readyProcess.mBurstTime--;
                        cur = readyProcess.mIndex;
                        cnt++;
                        end[idx] = cnt;

                        if (readyProcess.mBurstTime > 0)
                        {
                            ready.Add(readyProcess);
                        }

                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].mArrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                            }
                            else j++;
                        }
                    }
                    else
                    {
                        // Reduce remaining time by one
                        readyProcess.mBurstTime--;
                        cur = readyProcess.mIndex;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.mBurstTime > 0)
                        {
                            ready.Add(readyProcess);
                        }

                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].mArrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                            }
                            else j++;
                        }
                    }
                }
            }

            for (int j = 0; j < mNumbProcess; j++)
            {
                bool k = false; int wait = 0;
                for (int i = 0; i <= idx; i++)
                {
                    if (proc[i] == j)
                    {
                        if (!k)
                        {
                            waitingTime[j] = start[i] - mArivalsTime[j]; k = true;
                            wait = end[i];

                        }
                        else if (k)
                        {
                            waitingTime[j] += start[i] - wait;
                            wait = end[i];
                        }
                        turnaroundTime[j] = wait - mArivalsTime[j];
                        if (turnaroundTime[j] > mCritialsTime[j])
                        {
                            Console.WriteLine("Время выполнения: " + turnaroundTime[j]);
                            Console.WriteLine("Предельный срок: " + mCritialsTime[j]);
                            Console.WriteLine("Процесс Id: " + j + " вышел за свои рамки предельного срока");
                            mTexBox.Text += "Время выполнения: " + turnaroundTime[j] + Environment.NewLine;
                            mTexBox.Text += "Предельный срок: " + mCritialsTime[j] + Environment.NewLine;
                            mTexBox.Text += "Процесс Id: " + j + " вышел за свои рамки предельного срока" + Environment.NewLine;
                        }
                        freeTimesPercent = (freeTimes / end[i]) * 100;
                    }
                }
            }
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= mNumbProcess;
            for (int i = 0; i < mNumbProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= mNumbProcess;
            lastValid = idx + 1;
        }
    }
}
