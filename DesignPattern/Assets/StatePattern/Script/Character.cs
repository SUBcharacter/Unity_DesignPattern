using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] bool isWalk = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        AnimationControler();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickUp();
        }
    }

    void Move()
    {
        isWalk = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        
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
}
