using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTakeDamage : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

        health healthRef = collision.gameObject.GetComponent<health>();
        healthRef.takeDamage(3f);
        Destroy(gameObject);

    }

}
