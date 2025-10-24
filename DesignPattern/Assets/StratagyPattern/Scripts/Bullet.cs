using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float time;

    private void Update()
    {
        time += Time.deltaTime;
        if(time >=5f)
        {
            gameObject.SetActive(false);
            time = 0;
        }
        transform.position += new Vector3(0,0,0.5f);
    }

    public void Init(Transform mussle)
    {
        transform.position = mussle.position;
        gameObject.SetActive(true);
        
    }


}
