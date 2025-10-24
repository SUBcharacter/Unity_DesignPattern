using System;
using UnityEngine;

public class SAIGA : Weapon
{
    public int index = 0;

    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject instance = Instantiate(bullet, transform);
            bullets.Add(instance);
            bullets[i].SetActive(false);
        }
    }
    public override void Shot()
    {
        Debug.Log("SAIGA Shot");
        bullets[index].GetComponent<Bullet>().Init(mussle);
        index = (index + 1) % bullets.Count;
    }
}
