using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject original;
    [SerializeField] List<GameObject> cloneList;
    [SerializeField] Transform createPosition;
    

    [SerializeField] float spawnTimer = 0;
    [SerializeField] int spawnTime;

    private void Awake()
    {
        spawnTime = Random.Range(0, 6);
        cloneList = new List<GameObject>();
        
    }

    private void Start()
    {
        StartCoroutine(Create());
    }

    private void Update()
    {
        
    }

    IEnumerator Create()
    {
        while(true)
        {
            yield return CoroutineManager.Wait(spawnTime);
            GameObject clone = Instantiate(original, transform);
            cloneList.Add(clone);
            spawnTime = Random.Range(1, 6);
        }
    }
}
