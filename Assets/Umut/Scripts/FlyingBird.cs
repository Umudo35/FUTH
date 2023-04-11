using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBird : MonoBehaviour
{

    public float moveSpeed = 3f;
    Transform leftWayPoint2, rightWayPoint2;
    Vector3 localScale;
    bool movingRight = true;
    Rigidbody2D rb;
    void Start()
    {

        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        leftWayPoint2 = GameObject.Find("LeftWayPoint2").GetComponent<Transform>();
        rightWayPoint2 = GameObject.Find("RightWayPoint2").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > rightWayPoint2.position.x)
            movingRight = false;

        if (transform.position.x < leftWayPoint2.position.x)
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
        localScale.x = 0.2f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }

    void moveLeft()
    {
        movingRight = false;
        localScale.x = -0.2f;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }


}
