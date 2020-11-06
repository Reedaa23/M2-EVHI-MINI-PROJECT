using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //Fix a bug that appears when a menu is opened from another scene
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    //Play again
    public void yes()
    {
        SceneManager.LoadScene(0);
    }
    //Quit the game
    public void no()
    {
       //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
