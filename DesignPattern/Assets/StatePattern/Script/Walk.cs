using UnityEngine;

public class Walk : State
{
    public override void Enter(Character character)
    {
        character.animator.Play("Walk");
    }

    public override void Update(Character character)
    {
        
    }

    public override void Exit(Character character)
    {
        
    }
}
