using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        StartCoroutine(spawnWave());
    }
    public void SpawnObject()
    {
        //Instantiate(spawnee, transform.position, transform.rotation);
        GameObject a = Instantiate(spawnee, transform.position, transform.rotation) as GameObject;
        a.transform.position = new Vector3(0, 0, 0);
    }
    IEnumerator spawnWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(30.0f);
            SpawnObject();
        }
    }
    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}