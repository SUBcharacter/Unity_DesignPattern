using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] float time;
    [SerializeField] int minute;
    [SerializeField] int second;
    [SerializeField] int milliseconds;

    [SerializeField] bool state;

    private void OnEnable()
    {
        EventManager.Subscribe(Event.START, Continue);
        EventManager.Subscribe(Event.PAUSE, Pause);
    }

    private void Update()
    {
        if (!state)
            return;
        time -= Time.deltaTime;

        if (time <= 0)
        {
            EventManager.Publish(Event.EXIT);
            timeText.text = string.Format("{0 : 00} : {1 : 00} : {2 : 00}",0, 0, 0);
            return;
        }

        minute = (int)time / 60;
        second = (int)time % 60;
        milliseconds = (int)(time * 1000) % 1000;

        timeText.text = string.Format("{0 : 00} : {1 : 00} : {2 : 00}", minute, second, milliseconds);

    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Event.START, Continue);
        EventManager.Unsubscribe(Event.PAUSE, Pause);
    }

    void Continue()
    {
        state = true;
    }

    void Pause()
    {
        state = false;
    }

}
