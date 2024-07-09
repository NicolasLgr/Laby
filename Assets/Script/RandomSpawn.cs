using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] Positions;

    public GameObject door;

    public Transform location;

    public bool isSpawn = false;

    [SerializeField]
    private GameObject uiDoorSpawn;

    [SerializeField]
    private int howManySecondVisibleText;

    public float timeBeforeSpawning;
    // Start is called before the first frame update
    void Start()
    {
        howManySecondVisibleText = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(door, location);
        if (timeBeforeSpawning > 0)
        {
            timeBeforeSpawning -= Time.deltaTime;
        }
        if (!isSpawn && timeBeforeSpawning < 0.1)
        {
            location = Positions[Random.Range(0, Positions.Length)];
            Instantiate(door, location);
            isSpawn = true;
            StartCoroutine(ActivateTextForSeconds(howManySecondVisibleText));
        }
    }

    public IEnumerator ActivateTextForSeconds(float seconds)
    {
        uiDoorSpawn.SetActive(true);
        yield return new WaitForSeconds(seconds);
        uiDoorSpawn.SetActive(false);
    }
}
