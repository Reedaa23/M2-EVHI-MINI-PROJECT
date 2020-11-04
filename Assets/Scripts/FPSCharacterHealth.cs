using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCharacterHealth : MonoBehaviour
{
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1);
    }
    
    void Update()
    {
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.01f);
    }
}
