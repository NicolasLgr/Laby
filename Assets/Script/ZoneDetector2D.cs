using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDetector2D : MonoBehaviour
{
    private ZoneManager2D zoneManager;

    void Start()
    {
        zoneManager = GetComponentInParent<ZoneManager2D>();
        if (zoneManager == null)
        {
            Debug.LogError("ZoneManager2D non trouvé sur le parent.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            zoneManager.ZoneEntered(gameObject.name);
        }
    }

}
