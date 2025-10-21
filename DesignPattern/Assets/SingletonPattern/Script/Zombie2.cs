using UnityEngine;

public class Zombie2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.state) return;
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 2) - 1, transform.position.z);
    }

    public void PositionPingPong()
    {
        
    }
}
