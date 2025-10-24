using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected List<GameObject> bullets;

    [SerializeField] protected Transform mussle;

    public abstract void Shot();

    
}
