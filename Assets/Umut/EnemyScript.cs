using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyScript: MonoBehaviour
{
    Rigidbody2D rb;
    public float horizontal;
    public float speed;
    public float jumpspeed;
    bool jump = true;
    bool turnright = true;
    Vector3 scale;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jump == true)
        {

            rb.AddForce(new Vector2(0, jumpspeed));
            jump = false;
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime * speed, rb.velocity.y, 0);
        if (horizontal > 0 && turnright == false)
        {
            turn();
        }

        if (horizontal < 0 && turnright == true)
        {
            turn();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            jump = true;
        }
;
    }
    void turn()
    {
        turnright = !turnright;
        scale = gameObject.transform.localScale;
        scale.x = scale.x * -1;
        gameObject.transform.localScale = scale;
    }
}


