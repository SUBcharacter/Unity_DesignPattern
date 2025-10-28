using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] State currentState;

    [SerializeField] bool isWalk = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        currentState = new Idle();
        currentState.Enter(this);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            isWalk = !isWalk;
        }
        bool pickUp = Input.GetKeyDown(KeyCode.Space);


      
        if (isWalk && !(currentState is Walk))
        {
            if (pickUp && !(currentState is PickUp))
            {
                ChangeState(new PickUp());
            }
            else
            {
                ChangeState(new Walk());
            }
        }
        else
        {
            if (pickUp && !(currentState is PickUp))
            {
                ChangeState(new PickUp());
            }
            else
            {
                ChangeState(new Idle());
            }
        }
        currentState.Update(this);

    }

    void Move()
    {
        
        
    }

    void AnimationControler()
    {
        animator.SetBool("Walk", isWalk);
    }

    void PickUp()
    {
        AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animatorStateInfo.IsName("pickup"))
            return;
        animator.SetTrigger("PickUp");
    }

    public void ChangeState(State state)
    {
        currentState?.Exit(this);
        currentState = state;
        currentState.Enter(this);
    }
}
