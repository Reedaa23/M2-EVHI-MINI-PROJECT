using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider slider;

    void OnCollisionEnter(Collision col)
    {   
        //When the player hits the enemy
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.yellow;
            slider.value -= 0.21f;
        }
        //When the enemy dies
        if (slider.value <= 0)
            {
                this.gameObject.SetActive(false);
                //Destroy(this.gameObject);
                if(SceneManager.GetActiveScene().name == "Scene 5")
                {
                    SceneManager.LoadScene("Victory");
                }
            }
    }

    void OnCollisionExit(Collision col)
    {
        //Back to original color
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
