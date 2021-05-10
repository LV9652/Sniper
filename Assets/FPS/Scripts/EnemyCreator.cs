using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemy;
    public float spawn_interval;
    public Vector3 spawn_position;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createEnemy());
    }

    public void CreateObject()
    {
        GameObject go = Instantiate(enemy);
        go.transform.position = spawn_position;
        go.SetActive(true);
    }
    IEnumerator createEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawn_interval);
            CreateObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
