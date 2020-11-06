using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /// The class definition for a projectile's trigger
 public class ProjectileTrigger : MonoBehaviour
 {
     public GameObject m_Projectile;    // this is a reference to your projectile prefab
     public Transform m_SpawnTransform; // this is a reference to the transform where the prefab will spawn
 
     private void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             //Instantiate clones of the projectiles from the gun barrel end
            if (m_Projectile != null)
            {
                Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
            }
         }
     }
 }
