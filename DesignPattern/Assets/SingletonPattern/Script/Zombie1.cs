using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Zombie1 : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.state) return;
        transform.localScale = new Vector3(Mathf.PingPong(Time.time, 1), Mathf.PingPong(Time.time, 1), Mathf.PingPong(Time.time, 1));
    }

    public void SizePingPong()
    {
        
    }
}
