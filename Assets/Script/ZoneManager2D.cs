using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class ZoneManager2D : MonoBehaviour
{
    [SerializeField]
    private Text uiZoneTest;

    private string currentZones;

    void Start()
    {
        Debug.Log("Le script ZoneManager2D a démarré.");
    }

    public void ZoneEntered(string zoneName)
    {
        currentZones = zoneName;
        uiZoneTest.text = currentZones;
    }
}
