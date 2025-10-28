using UnityEngine;

public class Idle : State
{
    public override void Enter(Character character)
    {
        character.animator.Play("Idle");
    }

    public override void Update(Character character)
    {
        
    }

    public override void Exit(Character character)
    {
        
    }
}
