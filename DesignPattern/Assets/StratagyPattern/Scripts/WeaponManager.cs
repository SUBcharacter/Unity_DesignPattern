using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Weapon[] weapon;

    int index = 0;

    private void Start()
    {
        weapon = GetComponentsInChildren<Weapon>();
        for(int i =0; i < weapon.Length; i++)
        {
            weapon[i].gameObject.SetActive(false);
        }
        weapon[index].gameObject.SetActive(true);
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon[index].Shot();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
    }

    void Swap()
    {
        weapon[index].gameObject.SetActive(false);
        index = (index + 1) % weapon.Length;
        weapon[index].gameObject.SetActive(true);
    }
}
