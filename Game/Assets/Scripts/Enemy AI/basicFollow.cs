using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFollow : MonoBehaviour
{

    public float speed;

    public GameObject targetGameObject;

    private Transform target;

    public Rigidbody2D rb;

    private Vector2 movement;

    private void Start()
    {
        target = targetGameObject.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()
    {
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }



    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2) transform.position + (direction * speed * Time.fixedDeltaTime));
    }
}