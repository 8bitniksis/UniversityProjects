using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SchedulingAlgorithms : MonoBehaviour
{
    //outputs
    public Text logerOverCriticalTime;
    public float[] waitingTime;
    public float[] turnaroundTime;
    public float[] finalTime;
    public float[] start;
    public float[] end;
    public string[] debugIdlesTime;
    public string[] debugIdlesTime2;
    public int[] proc;

    public float avg_waiting;
    public float avg_turnaround;
    public float freeTimes;
    public float freeTimesPercent;
    public int lastValid;

    public void Initialize()
    {
        waitingTime = new float[2000];
        turnaroundTime = new float[2000];
        start = new float[2000];
        finalTime = new float[2000];
        end = new float[2000];
        debugIdlesTime = new string[2000];
        debugIdlesTime2 = new string[2000];
        proc = new int[2000];
        avg_waiting = 0.0f;
        freeTimes = 0.0f;
        freeTimesPercent = 0.0f;
        avg_turnaround = 0.0f;
        lastValid = 0;

        for (int i = 0; i < 2000; i++)
        {
            waitingTime[i] = 0; turnaroundTime[i] = 0; start[i] = 0; end[i] = 0; proc[i] = -1; finalTime[i] = 0; debugIdlesTime[i] = ""; debugIdlesTime2[i] = "";
        }
    }

    private void Awake()
    {
        Initialize();
    }

    private void SortArrivalsTime(List<Scheduling.Process> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            for (int j = 0; j < l.Count; j++)
            {
                if (l[i].ArriveTime < l[j].ArriveTime)
                {
                    Scheduling.Process temp = l[i];
                    l[i] = l[j];
                    l[j] = temp;
                }
            }
        }
    }

    private void SortPrioritys(List<Scheduling.Process> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            for (int j = 0; j < l.Count; j++)
            {
                if (l[i].Priority < l[j].Priority)
                {
                    Scheduling.Process temp = l[i];
                    l[i] = l[j];
                    l[j] = temp;
                }
            }
        }
    }
    private void SortBurstsTimes(List<Scheduling.Process> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            for (int j = 0; j < l.Count; j++)
            {
                if (l[i].CPUTime < l[j].CPUTime)
                {
                    Scheduling.Process temp = l[i];
                    l[i] = l[j];
                    l[j] = temp;
                }
            }
        }

    }

    private void SortCriticalsTimes(List<Scheduling.Process> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            for (int j = 0; j < l.Count; j++)
            {
                if (l[i].CriticalTime < l[j].CriticalTime)
                {
                    Scheduling.Process temp = l[i];
                    l[i] = l[j];
                    l[j] = temp;
                }
            }
        }

    }

    public void ScheduleFirstComeFirstServed(List<Scheduling.Process> processData)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);

        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }

        SortArrivalsTime(p);

        float cnt = 0; int idx = 0;
        for (int i = 0; i < processData.Count; i++)
        {
            if (p[i].ArriveTime <= cnt)
            {
                start[idx] = cnt;
                end[idx] = cnt + p[i].CPUTime;
                proc[idx] = p[i].PID;
                waitingTime[i] = start[idx] - p[i].ArriveTime;
                turnaroundTime[i] = end[idx] - p[i].ArriveTime;
                cnt += p[i].CPUTime;
                finalTime[i] = cnt;
                if (cnt > processData[i].CriticalTime)
                {
                    Debug.Log("Процесс: " + p[i].PID + " Его финальное время" + cnt);
                    debugIdlesTime[i] = "Процесс: " + p[i].PID + " Его финальное время" + cnt;
                }
                idx++;
            }
            else
            {
                start[idx] = cnt;
                end[idx] = p[i].ArriveTime;
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                cnt = p[i].ArriveTime;
                idx++;
                start[idx] = cnt;
                end[idx] = cnt + p[i].CPUTime;
                proc[idx] = p[i].PID;
                waitingTime[i] = start[idx] - p[i].ArriveTime;
                turnaroundTime[i] = end[idx] - p[i].ArriveTime;
                cnt += p[i].CPUTime;
                idx++;
            }
            freeTimesPercent = (freeTimes / finalTime[i]) * 100;
        }

        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx;
    }

    public void ScheduleRoundRobin(List<Scheduling.Process> processData, float mQuantum)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);

        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }

        SortArrivalsTime(p);

        float cnt = 0; int idx = 0;
        while (p.Count != 0)
        {
            List<Scheduling.Process> ready = new List<Scheduling.Process>(processData.Count);
            if (p.First().ArriveTime > cnt)
            {
                start[idx] = cnt;
                end[idx] = p.First().ArriveTime;
                //Free time output
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                idx++;
                cnt = p.First().ArriveTime;
            }
            for (int i = 0, j = 0; j < p.Count; i++)
            {
                if (p[j].ArriveTime <= cnt)
                {
                    ready.Add(p[j]);
                    p.RemoveAt(j);
                }
                else j++;

            }
            while (ready.Count != 0)
            {
                Scheduling.Process readyProcess = ready[0];
                ready.RemoveAt(0);
                if (mQuantum < readyProcess.CPUTime)
                {
                    start[idx] = cnt;
                    end[idx] = cnt + mQuantum;
                    proc[idx] = readyProcess.PID;
                    cnt += mQuantum;
                    finalTime[idx] = cnt;
                    readyProcess.CPUTime -= mQuantum;
                    ready.Add(readyProcess);
                    idx++;
                }
                else
                {
                    start[idx] = cnt;
                    end[idx] = cnt + readyProcess.CPUTime;
                    proc[idx] = readyProcess.PID;
                    cnt += readyProcess.CPUTime;
                    finalTime[idx] = cnt;

                    idx++;
                }
                for (int i = 0; i < processData.Count; i++)
                {
                    if (cnt > readyProcess.CriticalTime)
                    {
                        Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                        debugIdlesTime[i] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    }
                }

                if (cnt > readyProcess.CriticalTime)
                {
                    Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                    debugIdlesTime[idx] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    logerOverCriticalTime.text = debugIdlesTime[idx];
                }
                freeTimesPercent = (freeTimes / cnt) * 100;


                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].ArriveTime <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
            }
        }


        for (int j = 0; j < processData.Count; j++)
        {
            bool k = false; float wait = 0;
            for (int i = 0; i <= idx; i++)
            {
                if (proc[i] == j)
                {
                    if (!k)
                    {
                        waitingTime[j] = start[i] - processData[j].ArriveTime; k = true;
                        wait = end[i];

                    }
                    else if (k)
                    {
                        waitingTime[j] += start[i] - wait;
                        wait = end[i];
                    }
                    turnaroundTime[j] = wait - processData[j].ArriveTime;
                }
            }
        }
        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx;

    }

    public void SchedulePriorityNonPremptive(List<Scheduling.Process> processData)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);

        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }

        SortArrivalsTime(p);

        float cnt = 0; int idx = 0;

        while (p.Count != 0)
        {
            List<Scheduling.Process> ready = new List<Scheduling.Process>(processData.Count);
            if (p.First().ArriveTime > cnt)
            {
                start[idx] = cnt;
                end[idx] = p.First().ArriveTime;
                //Free time output
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                idx++;
                cnt = p.First().ArriveTime;
            }
            for (int i = 0, j = 0; j < p.Count; i++)
            {
                if (p[j].ArriveTime <= cnt)
                {
                    ready.Add(p[j]);
                    p.RemoveAt(j);
                }
                else j++;
            }
            while (ready.Count != 0)
            {
                SortPrioritys(ready);
                Scheduling.Process readyProcess = ready[0];
                ready.RemoveAt(0);
                start[idx] = cnt;
                end[idx] = cnt + readyProcess.CPUTime;

                proc[idx] = readyProcess.PID;
                waitingTime[idx] = start[idx] - readyProcess.ArriveTime;
                turnaroundTime[idx] = end[idx] - readyProcess.ArriveTime;
                idx++;
                cnt += readyProcess.CPUTime;
                finalTime[idx] = cnt;
                if (cnt > readyProcess.CriticalTime)
                {
                    Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                    debugIdlesTime[idx] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    logerOverCriticalTime.text = debugIdlesTime[idx];
                }

                freeTimesPercent = (freeTimes / cnt) * 100;


                for (int i = 0, j = 0; i < p.Count; i++)
                {
                    if (p[j].ArriveTime <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
            }

        }
        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx;
    }

    public void SchedulePriorityPremprive(List<Scheduling.Process> processData)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);
        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }
        SortArrivalsTime(p);

        float cnt = 0;
        int idx = -1;
        if (p[0].ArriveTime > cnt)
        {
            idx = 0;
        }
        while (p.Count != 0)
        {
            List<Scheduling.Process> ready = new List<Scheduling.Process>(processData.Count);
            if (p.First().ArriveTime > cnt)
            {
                idx++;
                start[idx] = cnt;
                end[idx] = p.First().ArriveTime;
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                idx++;
                cnt = p.First().ArriveTime;
            }
            for (int i = 0, j = 0; j < p.Count; i++)
            {
                if (p[j].ArriveTime <= cnt)
                {
                    ready.Add(p[j]);
                    p.RemoveAt(j);
                }
                else j++;
            }
            int cur = -2;
            while (ready.Count != 0)
            {
                SortPrioritys(ready);
                Scheduling.Process readyProcess = ready[0];
                ready.RemoveAt(0);
                if (cur != readyProcess.PID)
                {
                    idx++;
                    start[idx] = cnt;
                    proc[idx] = readyProcess.PID;

                    readyProcess.CPUTime--;
                    cur = readyProcess.PID;
                    cnt++;
                    end[idx] = cnt;
                    finalTime[idx] = cnt;

                    if (readyProcess.CPUTime > 0)
                    {
                        ready.Add(readyProcess);
                    }
                    else
                    {
                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].ArriveTime <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;
                    }
                }
                else
                {
                    readyProcess.CPUTime--;
                    cur = readyProcess.PID;
                    cnt++;
                    end[idx] = cnt;
                    finalTime[idx] = cnt;

                    if (readyProcess.CPUTime > 0)
                    {
                        ready.Add(readyProcess);
                    }
                    else
                    {

                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].ArriveTime <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;
                    }
                }
                if (cnt > readyProcess.CriticalTime)
                {
                    Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                    debugIdlesTime[idx] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    logerOverCriticalTime.text = debugIdlesTime[idx];
                }
                freeTimesPercent = (freeTimes / finalTime[idx]) * 100;
            }
        }
        for (int j = 0; j < processData.Count; j++)
        {
            bool k = false; float wait = 0;
            for (int i = 0; i <= idx; i++)
            {
                if (proc[i] == j)
                {
                    if (!k)
                    {
                        waitingTime[j] = start[i] - processData[j].ArriveTime; k = true;
                        wait = end[i];
                    }
                    else if (k)
                    {
                        waitingTime[j] += start[i] - wait;
                        wait = end[i];
                    }
                    turnaroundTime[j] = wait - processData[j].ArriveTime;
                }
            }
        }
        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx + 1;
    }

    public void ScheduleShortestJobFirstNonPremptive(List<Scheduling.Process> processData)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);

        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }

        SortArrivalsTime(p);

        float cnt = 0; int idx = 0;

        while (p.Count != 0)
        {
            List<Scheduling.Process> ready = new List<Scheduling.Process>(processData.Count);
            if (p.First().ArriveTime > cnt)
            {
                start[idx] = cnt;
                end[idx] = p.First().ArriveTime;
                //Free time output
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                idx++;
                cnt = p.First().ArriveTime;
            }
            for (int i = 0, j = 0; j < p.Count; i++)
            {
                if (p[j].ArriveTime <= cnt)
                {
                    ready.Add(p[j]);
                    p.RemoveAt(j);
                }
                else j++;
            }
            while (ready.Count != 0)
            {
                SortBurstsTimes(ready);
                Scheduling.Process readyProcess = ready[0];
                ready.RemoveAt(0);
                start[idx] = cnt;
                end[idx] = cnt + readyProcess.CPUTime;
                proc[idx] = readyProcess.PID;
                waitingTime[idx] = start[idx] - readyProcess.ArriveTime;
                turnaroundTime[idx] = end[idx] - readyProcess.ArriveTime;
                idx++;
                cnt += readyProcess.CPUTime;
                finalTime[idx] = cnt;
                if (cnt > readyProcess.CriticalTime)
                {
                    Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                    debugIdlesTime[idx] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    logerOverCriticalTime.text = debugIdlesTime[idx];
                }
                freeTimesPercent = (freeTimes / cnt) * 100;

                for (int i = 0, j = 0; i < p.Count; i++)
                {
                    if (p[j].ArriveTime <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
            }

        }
        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx;
    }

    public void ScheduleShortestJobFirstPremprive(List<Scheduling.Process> processData)
    {
        List<Scheduling.Process> p = new List<Scheduling.Process>(processData.Count);

        for (int i = 0; i < processData.Count; i++)
        {
            p.Insert(i, processData[i]);
        }

        SortArrivalsTime(p);
        float cnt = 0;
        int idx = -1;
        if (p[0].ArriveTime > cnt)
        {
            idx = 0;
        }
        while (p.Count != 0)
        {
            List<Scheduling.Process> ready = new List<Scheduling.Process>(processData.Count);
            if (p.First().ArriveTime > cnt)
            {
                start[idx] = cnt;
                end[idx] = p.First().ArriveTime;
                proc[idx] = -1;
                freeTimes += end[idx] - start[idx];
                idx++;
                cnt = p.First().ArriveTime;
            }
            for (int i = 0, j = 0; j < p.Count; i++)
            {
                if (p[j].ArriveTime <= cnt)
                {
                    ready.Add(p[j]);
                    p.RemoveAt(j);
                }
                else j++;
            }
            int cur = -2;
            while (ready.Count != 0)
            {
                SortBurstsTimes(ready);
                Scheduling.Process readyProcess = ready[0];
                ready.RemoveAt(0);
                if (cur != readyProcess.PID)
                {
                    idx++;
                    start[idx] = cnt;
                    proc[idx] = readyProcess.PID;

                    readyProcess.CPUTime--;
                    cur = readyProcess.PID;
                    cnt++;
                    end[idx] = cnt;
                    finalTime[idx] = cnt;

                    if (readyProcess.CPUTime > 0)
                    {
                        ready.Add(readyProcess);
                    }
                    else
                    {
                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].ArriveTime <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;
                    }
                }
                else
                {
                    readyProcess.CPUTime--;
                    cur = readyProcess.PID;
                    cnt++;
                    end[idx] = cnt;
                    finalTime[idx] = cnt;

                    if (readyProcess.CPUTime > 0)
                    {
                        ready.Add(readyProcess);
                    }
                    else
                    {
                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].ArriveTime <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;
                    }
                }
                if (cnt > readyProcess.CriticalTime)
                {
                    Debug.Log("Процесс: " + readyProcess.PID + " Его финальное время" + cnt);
                    debugIdlesTime[idx] = "Процесс: " + readyProcess.PID + " Его финальное время" + cnt;
                    logerOverCriticalTime.text = debugIdlesTime[idx];
                }
                freeTimesPercent = (freeTimes / cnt) * 100;
            }
        }
        for (int j = 0; j < processData.Count; j++)
        {
            bool k = false; float wait = 0;
            for (int i = 0; i <= idx; i++)
            {
                if (proc[i] == j)
                {
                    if (!k)
                    {
                        waitingTime[j] = start[i] - processData[j].ArriveTime; k = true;
                        wait = end[i];

                    }
                    else if (k)
                    {
                        waitingTime[j] += start[i] - wait;
                        wait = end[i];
                    }
                    turnaroundTime[j] = wait - processData[j].ArriveTime;
                }
            }
        }
        for (int i = 0; i < processData.Count; i++)
        {
            if (waitingTime[i] == 0) continue;
            else
            {
                avg_waiting += waitingTime[i];
            }
        }
        avg_waiting /= processData.Count;
        for (int i = 0; i < processData.Count; i++)
        {
            if (turnaroundTime[i] == 0) continue;
            else
            {
                avg_turnaround += turnaroundTime[i];
            }
        }
        avg_turnaround /= processData.Count;
        lastValid = idx + 1;
    }
}
