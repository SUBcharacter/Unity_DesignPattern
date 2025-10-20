using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Zombie1 z1;
    [SerializeField] Zombie2 z2;
    [SerializeField] Zombie3 z3;

    bool state = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(state)
        {
            z1.SizePingPong();
            z2.PositionPingPong();
            z3.RotatingCharacter();
        }
        
    }

    public void Pause()
    {
        state = !state;
    }
}
