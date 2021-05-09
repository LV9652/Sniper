using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemyMake;
    public double spawn_interval;
    public Vector3 spawn_position;
    double nasru;

    // Start is called before the first frame update
    void Start()
    {
        nasru = spawn_interval;
    }

    // Update is called once per frame
    void Update()
    {
        nasru -= Time.deltaTime;
        if (nasru <= 0)
        {
            nasru = spawn_interval;
            GameObject go = GameObject.Instantiate(enemyMake);
            // go.transform.position = transform.position;
            go.transform.position = spawn_position;
        }
    }
}
