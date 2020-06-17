using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float healthAmount;

    public void takeDamage(float damageAmount)
    {
        healthAmount -= damageAmount;
        Debug.Log("Taken " + damageAmount + "damage");
        Debug.Log(healthAmount);
    }

    public static void heal(float healAmount)
    {
        healAmount += healAmount;
    }

    public void onDeath()
    {
        Debug.Log("Dying");
        Destroy(gameObject);

    }


    public void Update()
    {
        if(healthAmount < 0)
        {
            onDeath();
        }
    }
}
