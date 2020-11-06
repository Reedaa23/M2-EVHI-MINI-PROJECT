using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    private bool quitGame;

    IEnumerator SetFalse()
    {
        yield return new WaitForSeconds(3); //Wait 3 seconds before quitting game in case of a victory
        quitGame = true;
    }
    
    void Update()
    {
        StartCoroutine(SetFalse());
        if(quitGame)
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

    }
}
