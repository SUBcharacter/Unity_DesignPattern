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
    }

    private void OnDisable()
    {
        EventManager.Subscribe(Event.START, EnableField);
        EventManager.Subscribe(Event.PAUSE, UnableField);
    }

    void EnableField()
    {
        animator.enabled = true;
    }

    void UnableField()
    {
        animator.enabled = false;
    }

}
