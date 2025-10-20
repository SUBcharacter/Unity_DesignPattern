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
        
    }

    public void RotatingCharacter()
    {
        transform.Rotate(new Vector3(0,360,0)*Time.deltaTime);
    }
       
}
