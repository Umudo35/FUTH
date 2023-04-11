using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   
    public float moveSpeed = 3f;
    Transform leftWayPoint, rightWayPoint;
    Vector3 localScale;
    bool movingRight = true;
    Rigidbody2D rb;
    void Start()
    {
        
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (transform.position.x > rightWayPoint.position.x)
            movingRight = false;

        if (transform.position.x < leftWayPoint.position.x)
            movingRight = true;

        if (movingRight)
        {
            moveRight();
        }
        else
        {
            moveLeft();
        }


    }
    void moveRight()
    {
        movingRight = true;
        localScale.x = 1f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }

    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }


}
