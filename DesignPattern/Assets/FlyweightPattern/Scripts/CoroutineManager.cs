using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager
{
    static Dictionary<float,WaitForSeconds>dict = new();
    
    public static WaitForSeconds Wait(float time)
    {
        if (dict.TryGetValue(time, out WaitForSeconds wait))
        {
            return wait;
        }
        wait = new WaitForSeconds(time);
        dict[time] = wait;

        return wait;
    }

}
