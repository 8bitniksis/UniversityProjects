using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scheduling
{
    [System.Serializable]
    public enum ProcessPriority
    {
        Highest,//0
        AboveNormal,//1
        Normal,//2
        BelowNormal,//3
        Lowest,//4
    }
}
