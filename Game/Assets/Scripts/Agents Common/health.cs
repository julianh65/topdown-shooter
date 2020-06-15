using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float healthAmount;

    void takeDamage(float damageAmount)
    {
        healthAmount -= damageAmount;
    }

    void heal(float healAmount)
    {
        healAmount += healAmount;
    }

    void onDeath()
    {
        //call any death functions here
    }


    void Update()
    {
        if(healthAmount == 0)
        {
            onDeath();
        }
    }
}
