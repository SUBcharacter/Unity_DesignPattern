using UnityEngine;

public class Publisher : MonoBehaviour
{
    private void Start()
    {
        EventManager.Publish(Event.START);
    }

    public void Pause()
    {
        EventManager.Publish(Event.PAUSE);
    }

    public void start()
    {
        EventManager.Publish(Event.START);
    }
}
