using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFollow : MonoBehaviour
{

    public float speed;

    public Transform target;


    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }
}