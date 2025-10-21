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
}
