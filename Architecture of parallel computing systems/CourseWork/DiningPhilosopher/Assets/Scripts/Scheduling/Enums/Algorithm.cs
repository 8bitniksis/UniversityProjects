namespace Scheduling
{
    [System.Serializable]
    public enum Algorithm
    {
        FCFS = 0,
        SJF_PREEMPTIVE,
        SJF_NONPREEMPTIVE,
        PRIORITY_PREEMPTIVE,
        PRIORITY_NONPREEMPTIVE,
        ROUND_ROBIN
    }
}
