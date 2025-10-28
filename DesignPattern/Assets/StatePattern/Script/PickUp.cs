using UnityEngine;

public class PickUp : State
{
    [SerializeField] float timer = 0;
    [SerializeField] float ExitTimer;

    public override void Enter(Character character)
    {
        timer = 0f;
        character.animator.Play("Pick Up");
    }

    public override void Update(Character character)
    {
        timer += Time.deltaTime;
    }

    public bool CanExit() => timer >= ExitTimer;

    public override void Exit(Character character)
    {
        
    }
}
