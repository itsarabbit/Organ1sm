using System;
using System.Security.Policy;
using System.Timers;
using UnityEngine;
using System.Collections;

public static class GlobalVars
{
    public static float WorldRadius
    {
        get { return Level + 20; }
    }
    private static float time = 0;
    public static int Level = 1;
}
