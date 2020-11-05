using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject doorHinge1;
    public GameObject doorHinge2;
    public GameObject door1;
    public GameObject door2;
    public GameObject healthToken;
    public GameObject invicibilityToken;

    private int collided = 0;

    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    void OnCollisionEnter(Collision col)
    {   
        List<string> firstFourLevels = new List<string>();
        firstFourLevels.Add("Scene 1");
        firstFourLevels.Add("Scene 2");
        firstFourLevels.Add("Scene 3");
        firstFourLevels.Add("Scene 4");
        if(firstFourLevels.Contains(SceneManager.GetActiveScene().name))
        {
            if (col.gameObject.name == "Floor 2")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(SceneManager.GetActiveScene().name == "Scene 5")
        {
            if (col.gameObject.name == "Door 1" | col.gameObject.name == "Door 2")
            {
                collided = 1;
            }

            if (col.gameObject.name == "Floor 2")
            {
                GetComponent<PlayerInteraction>().enabled = false;
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        if(SceneManager.GetActiveScene().name == "Scene 5")
        {
            if (col.gameObject.name == "Door 1" | col.gameObject.name == "Door 2")
            {
                collided = 2;
            }
        }
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Scene 3" | SceneManager.GetActiveScene().name == "Scene 5" )
        {
            healthToken.transform.Rotate(1,0,0);
            invicibilityToken.transform.Rotate(1,0,0);
        }

        if(SceneManager.GetActiveScene().name == "Scene 5")
        {
            if (collided == 1 & doorHinge1.transform.rotation.eulerAngles.y <= 28)
            {
                doorHinge1.transform.Rotate(0,1.5f,0);
                door1.GetComponent<Renderer>().material.color = Color.green;
                doorHinge2.transform.Rotate(0,-1.5f,0);
                door2.GetComponent<Renderer>().material.color = Color.green;
            }
            if (collided == 2 & doorHinge1.transform.rotation.eulerAngles.y >= 28)
            {
                doorHinge1.transform.Rotate(0,-24,0);
                door1.GetComponent<Renderer>().material.color = Color.blue;
                doorHinge2.transform.Rotate(0,24,0);
                door2.GetComponent<Renderer>().material.color = Color.blue;
            }
            if(doorHinge1.transform.rotation.eulerAngles.y <= 4)
            {
                collided = 0;
                door1.GetComponent<Renderer>().material.color = Color.blue;
                door2.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
        
    }
}