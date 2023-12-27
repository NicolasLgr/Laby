using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLost : MonoBehaviour
{
    [SerializeField]
    private Text timer;

    [SerializeField]
    private string lose;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.text == "0:00")
        {
            SceneManager.LoadScene(lose);
        }
        return;
    }
}
