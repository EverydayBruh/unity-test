using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class russiaSpawner : MonoBehaviour
{
    public GameObject russia;
    public float spawn_time = 2;
    private float timer = 0;
    public float highOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawn_time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_time) { timer += Time.deltaTime; }
        else
        {
            SpawnRussia();
            timer = 0;
        }
    }

    void SpawnRussia()
    {
        Vector3 pos = transform.position + Vector3.up * Random.Range(-1*highOffset, highOffset);
        Instantiate(russia, pos, transform.rotation);
    }
}
