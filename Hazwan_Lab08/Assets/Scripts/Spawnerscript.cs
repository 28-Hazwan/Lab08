using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    float PositionY;
    public float interval;
    public float interval2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", interval2, interval);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }
}
