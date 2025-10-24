using UnityEngine;

public class AA12 : Weapon
{

    public int index = 0;

    private void Awake()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject instance = Instantiate(bullet, transform);
            bullets.Add(instance);
            bullets[i].SetActive(false);
        }
    }

    public override void Shot()
    {
        Debug.Log("AA12 Shot");

        bullets[index].GetComponent<Bullet>().Init(mussle);
        index = (index + 1) % bullets.Count;
    }
}
