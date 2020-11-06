using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider slider;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.yellow;
            slider.value -= 0.21f;
        }
        if (slider.value <= 0)
            {
                this.gameObject.SetActive(false);
                //Destroy(this.gameObject);
            }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Projectile(Clone)")
        {
            this.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
