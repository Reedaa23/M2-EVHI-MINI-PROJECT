using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //Fix a bug that appears when a menu is opened from another scene
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    //Play from the first scene
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectScene()
    {
        SceneManager.LoadScene(1);

    }

    public void Scene1()
    {
        SceneManager.LoadScene(2);
    }

    public void Scene2()
    {
        SceneManager.LoadScene(3);
    }

    public void Scene3()
    {
        SceneManager.LoadScene(4);
    }

    public void Scene4()
    {
        SceneManager.LoadScene(5);
    }

    public void Scene5()
    {
        SceneManager.LoadScene(6);
    }
    //Back to the main menu
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
