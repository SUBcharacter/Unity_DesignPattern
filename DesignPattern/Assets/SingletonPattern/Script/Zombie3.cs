using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Zombie3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.state) return;
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }

    public void RotatingCharacter()
    {
        
    }
       
}
