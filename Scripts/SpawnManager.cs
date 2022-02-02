using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyprefeb;
    public float spawnrange = 9;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnenemy()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyprefeb, spawnposition(), enemyprefeb.transform.rotation);
        }
    }
    private Vector3 spawnposition()
    {
        float spawnX = Random.Range(-spawnrange, spawnrange);
        Vector3 spawnPos = new Vector3(spawnX, 1, 0);
        return spawnPos;
    }
}
