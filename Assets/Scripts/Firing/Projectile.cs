using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /// The class definition for a projectile
 [RequireComponent(typeof(Rigidbody))]
 public class Projectile : MonoBehaviour
 {
     public float m_Speed = 10f;   // this is the projectile's speed
     public float m_Lifespan = 1f; // this is the projectile's lifespan (in seconds)
     private Rigidbody m_Rigidbody;

     void Awake()
     {
         m_Rigidbody = GetComponent<Rigidbody>();
     }

     void Start()
     {
         m_Rigidbody.AddRelativeForce(0, m_Speed, 0);
         //m_Rigidbody.AddForce(m_Rigidbody.transform.forward * m_Speed);
         Destroy(gameObject, m_Lifespan);
     }

    void OnCollisionExit(Collision col)
    {
        //Back to original color
        if (col.gameObject.name == "Enemy")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
 }
