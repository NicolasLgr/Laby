using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeahvior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z = -90;
            transform.eulerAngles = newRotation;

            
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z = 90;
            transform.eulerAngles = newRotation;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z = 0;
            transform.eulerAngles = newRotation;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z = 180;
            transform.eulerAngles = newRotation;
        }
    }
}
