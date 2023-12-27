using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private string retry;

    [SerializeField]
    private string menu;
    
    public void RetryBtn()
    {
        //Recommencer
        SceneManager.LoadScene(retry);
    }

    public void MainMenu()
    {
        //Retour au menu
        SceneManager.LoadScene(menu);
    }
}
