using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class ProcessControl : MonoBehaviour
{
    [Header("Input Main Data GUI")]
    public float Ca = 70.0f;
    public float Cb = 175.0f;
    public float Ta = 140.0f;
    public float Tb = 350.0f;
    public float P = 70.0f;

    public InputField CaInput;
    public InputField CbInput;
    public InputField TaInput;
    public InputField TbInput;
    public InputField PInput;

    public Scheduling.Algorithm algSelector = Scheduling.Algorithm.ROUND_ROBIN;
    public Dropdown algo;

    [Header("Input Process Data GUI")]
    public int ACountProcess = 4;
    public InputField CountProcessAInput;
    public Dropdown aPriority;
    public Scheduling.ProcessPriority priorityAProcess = Scheduling.ProcessPriority.AboveNormal;
    public int BCountProcess = 3;
    public InputField CountProcessBInput;
    public Dropdown bPriority;
    public Scheduling.ProcessPriority priorityBProcess = Scheduling.ProcessPriority.Normal;

    [Header("Filled Process Data")]
    public List<Scheduling.Process> processData;

    [Header("")]
    public SchedulingAlgorithms alg;

    public Text avgWaitText;
    public Text avgTurnText;
    public Text freeTimeText;
    public Text freeTimesPercentText;

    private int CountProcesss;
    private float quant = 0.0f;

    public void SetData()
    {
        if (float.TryParse(CaInput.text, out Ca))
        {
            Debug.Log("Sucsess input: " + CaInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + CaInput.text);
        }

        if (float.TryParse(CbInput.text, out Cb))
        {
            Debug.Log("Sucsess input: " + CbInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + CbInput.text);
        }

        if (float.TryParse(TaInput.text, out Ta))
        {
            Debug.Log("Sucsess input: " + TaInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + TaInput.text);
        }

        if (float.TryParse(TbInput.text, out Tb))
        {
            Debug.Log("Sucsess input: " + TbInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + TbInput.text);
        }

        if (float.TryParse(PInput.text, out P))
        {
            Debug.Log("Sucsess input: " + PInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + PInput.text);
        }

        if (int.TryParse(CountProcessAInput.text, out ACountProcess))
        {
            Debug.Log("Sucsess input: " + CountProcessAInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + CountProcessAInput.text);
        }

        if (int.TryParse(CountProcessBInput.text, out BCountProcess))
        {
            Debug.Log("Sucsess input: " + CountProcessBInput.text);
        }
        else
        {
            Debug.Log("No Sucsess input: " + CountProcessBInput.text);
        }


        switch (aPriority.value)
        {
            case 0:
                priorityAProcess = Scheduling.ProcessPriority.Highest;
                break;
            case 1:
                priorityAProcess = Scheduling.ProcessPriority.AboveNormal;
                break;
            case 2:
                priorityAProcess = Scheduling.ProcessPriority.Normal;
                break;
            case 3:
                priorityAProcess = Scheduling.ProcessPriority.BelowNormal;
                break;
            case 4:
                priorityAProcess = Scheduling.ProcessPriority.Lowest;
                break;
        }

        switch (bPriority.value)
        {
            case 0:
                priorityBProcess = Scheduling.ProcessPriority.Highest;
                break;
            case 1:
                priorityBProcess = Scheduling.ProcessPriority.AboveNormal;
                break;
            case 2:
                priorityBProcess = Scheduling.ProcessPriority.Normal;
                break;
            case 3:
                priorityBProcess = Scheduling.ProcessPriority.BelowNormal;
                break;
            case 4:
                priorityBProcess = Scheduling.ProcessPriority.Lowest;
                break;
        }

        switch (algo.value)
        {
            case 0:
                algSelector = Scheduling.Algorithm.FCFS;
                break;
            case 1:
                algSelector = Scheduling.Algorithm.SJF_PREEMPTIVE;
                break;
            case 2:
                algSelector = Scheduling.Algorithm.SJF_NONPREEMPTIVE;
                break;
            case 3:
                algSelector = Scheduling.Algorithm.PRIORITY_PREEMPTIVE;
                break;
            case 4:
                algSelector = Scheduling.Algorithm.PRIORITY_NONPREEMPTIVE;
                break;
            case 5:
                algSelector = Scheduling.Algorithm.ROUND_ROBIN;
                break;
        }

        CountProcesss = ACountProcess + BCountProcess;
        if (algSelector == Scheduling.Algorithm.ROUND_ROBIN)
            quant = P / 2.0f; // quant for Round Robin alg

        var count = 0.0f;
        var count2 = 0.0f;
        for (int i = 0; i < CountProcesss; i++)
        {
            //Fill by A process
            if (i <= ACountProcess)
            {
                Scheduling.Process data = new Scheduling.Process();
                data.PID = i;
                data.ArriveTime = count;
                count += Ta;
                data.CPUTime = Ca;
                data.CriticalTime = count;
                data.Priority = (int)priorityAProcess;
                processData.Insert(i, data);
            }
            //Fill by B process
            else if (i > ACountProcess)
            {
                Scheduling.Process data = new Scheduling.Process();
                data.PID = i;
                data.ArriveTime = count2;
                count2 += Tb;
                data.CPUTime = Cb;
                data.CriticalTime = count2;
                data.Priority = (int)priorityBProcess;
                processData.Insert(i, data);
            }
        }

        switch (algSelector)
        {
            case Scheduling.Algorithm.FCFS:
                alg.Initialize();
                alg.ScheduleFirstComeFirstServed(processData);
                break;
            case Scheduling.Algorithm.SJF_PREEMPTIVE:
                alg.Initialize();
                alg.ScheduleShortestJobFirstPremprive(processData);
                break;
            case Scheduling.Algorithm.SJF_NONPREEMPTIVE:
                alg.Initialize();
                alg.ScheduleShortestJobFirstNonPremptive(processData);
                break;
            case Scheduling.Algorithm.PRIORITY_PREEMPTIVE:
                alg.Initialize();
                alg.SchedulePriorityPremprive(processData);
                break;
            case Scheduling.Algorithm.PRIORITY_NONPREEMPTIVE:
                alg.Initialize();
                alg.ScheduleShortestJobFirstNonPremptive(processData);
                break;
            case Scheduling.Algorithm.ROUND_ROBIN:
                alg.Initialize();
                alg.ScheduleRoundRobin(processData, quant);
                break;
        }
        avgWaitText.text = alg.avg_waiting.ToString();
        avgTurnText.text = alg.avg_turnaround.ToString();
        freeTimeText.text = alg.freeTimes.ToString();
        freeTimesPercentText.text = alg.freeTimesPercent.ToString();
    }

    public void ClearData()
    {
        Ca = 0.0f;
        Cb = 0.0f;
        Ta = 0.0f;
        Tb = 0.0f;
        P = 0.0f;
        algSelector = Scheduling.Algorithm.FCFS;
        ACountProcess = 0;
        BCountProcess = 0;
        priorityAProcess = Scheduling.ProcessPriority.Highest;
        priorityBProcess = Scheduling.ProcessPriority.Highest;
        processData.Clear();
        avgWaitText.text = 0.0f.ToString();
        alg.avg_waiting = 0.0f;
        alg.avg_turnaround = 0.0f;
        alg.freeTimes = 0.0f;
        alg.freeTimesPercent= 0.0f;
        alg.lastValid = 0;
        alg.debugIdlesTime = null;
        alg.debugIdlesTime2 = null;
        avgTurnText.text = 0.0f.ToString();
        freeTimeText.text = 0.0f.ToString();
        freeTimesPercentText.text = 0.0f.ToString();
    }
}
