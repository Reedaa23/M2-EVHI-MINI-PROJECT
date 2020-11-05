using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private bool toRight = true;
    private int moveSpeed = 4;
    private int minDist = 4;
    public Transform player;
    public Light roomLight;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Scene 2")
        {
            if (toRight)
            {
                this.transform.Translate(-Time.deltaTime, 0, 0, Space.World);
                if (this.transform.position.x <= -7.91)
                {
                    toRight = false;
                }
            }
            else
            {
                this.transform.Translate(Time.deltaTime, 0, 0, Space.World);
                if (this.transform.position.x >= -2.26)
                {
                    toRight = true;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            transform.LookAt(player);
            if(Vector3.Distance(transform.position,player.position) > minDist)
            {
                transform.position += transform.forward*moveSpeed*Time.deltaTime;
            }
            if(Vector3.Distance(transform.position,player.position) == minDist)
            {
                //The enemy hits the player
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            if(roomLight.intensity >= 5.89f)
            {
                transform.LookAt(player);
                if(Vector3.Distance(transform.position,player.position) > minDist)
                {
                    transform.position += transform.forward*moveSpeed*Time.deltaTime;
                }
                if(Vector3.Distance(transform.position,player.position) == minDist)
                {
                    //The enemy hits the player
                }
            }
        }
        
    }
}
