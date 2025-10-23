using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField]Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventManager.Subscribe(Event.START, EnableField);
        EventManager.Subscribe(Event.PAUSE, UnableField);
        EventManager.Subscribe(Event.EXIT,DestroyField);
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Event.START, EnableField);
        EventManager.Unsubscribe(Event.PAUSE, UnableField);
        EventManager.Unsubscribe(Event.EXIT, DestroyField);
    }

    void EnableField()
    {
        animator.enabled = true;
    }

    void UnableField()
    {
        animator.enabled = false;
    }

    void DestroyField()
    {
        Destroy(gameObject);
    }

}
