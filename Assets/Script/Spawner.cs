using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] item;
    public int nextspawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawningItem", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawningItem()
    {
        int random = Random.Range(0, 4);
        Vector3 SpawnPos = new Vector3(Random.Range(-2, 2), 0, 0);

        nextspawn -= 1;

        if(nextspawn <= 0)
        {
            Instantiate(item[random], SpawnPos, Quaternion.identity);
            nextspawn = 1;
        }
    }
}
