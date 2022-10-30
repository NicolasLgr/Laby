using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] Positions;

    public GameObject door;

    public Transform location;

    public bool isSpawn = false;

    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(door, location);
        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        if (!isSpawn && interval < 0.1)
        {
            location = Positions[Random.Range(0, Positions.Length)];
            Instantiate(door, location);
            isSpawn = true;
        }
    }
}
