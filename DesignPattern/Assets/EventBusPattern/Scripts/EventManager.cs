using System;
using System.Collections.Generic;
using UnityEngine;

public enum Event
{
    START, PAUSE, EXIT
}

public static class EventManager
{
    private static Dictionary<Event, Action> bus = new();

    public static void Subscribe(Event condition, Action action)
    {
        if(!bus.ContainsKey(condition))
            bus[condition] = action;

        bus[condition] += action;
    }

    public static void Unsubscribe(Event condition, Action action)
    {
        if (!bus.ContainsKey(condition))
            return;

        bus[condition] -= action;
    }

    public static void Publish(Event condition)
    {
        if (!bus.ContainsKey(condition))
            return;
        Debug.Log("이벤트 보내기");
        bus[condition]?.Invoke();
    }
}
