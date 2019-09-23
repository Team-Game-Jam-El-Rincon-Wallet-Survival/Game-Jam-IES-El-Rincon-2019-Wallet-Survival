using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float InputHorizontal;
    private float InputVertical;
    public float speed;
    public float speedMax;
    private bool activeDeceleration;
    public float Deceleration;
    private Vector2 mov;
    private Rigidbody2D rb2d;


    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	
	void Update () {

        mov = new Vector2(
            0,
            0
            );

        bool pressKeyUp = Input.GetKey(KeyCode.UpArrow);
        bool pressKeyDown = Input.GetKey(KeyCode.DownArrow);
        bool pressKeyRigth = Input.GetKey(KeyCode.RightArrow);
        bool pressKeyLeft = Input.GetKey(KeyCode.LeftArrow);

        if (pressKeyUp)
        {
            mov += new Vector2(0,1);
        }

        if (pressKeyDown)
        {
            mov += new Vector2(0, -1);
        }

        if (pressKeyRigth)
        {
            mov += new Vector2(1, 0);
        }

        if (pressKeyLeft)
        {
            mov += new Vector2(-1, 0);
        }

        if (pressKeyUp | pressKeyDown | pressKeyRigth | pressKeyLeft)
        {
            activeDeceleration = false;
        } else
        {
            activeDeceleration = true;
        }


    }

    void FixedUpdate()
    {
        rb2d.AddForce(mov * speed);
        float velocityX = Mathf.Clamp(rb2d.velocity.x, -speedMax, speedMax);
        float velocityY = Mathf.Clamp(rb2d.velocity.y, -speedMax, speedMax);
        rb2d.velocity = new Vector2(velocityX, velocityY);


        if (activeDeceleration)
        {
            if (velocityX > 0)
            {
                rb2d.AddForce(new Vector2(-1,0) * Deceleration);
            } else if (velocityX < 0)
            {
                rb2d.AddForce(new Vector2(1, 0) * Deceleration);
            }

            if (velocityY > 0)
            {
                rb2d.AddForce(new Vector2(0, -1) * Deceleration);
            }
            else if (velocityY < 0)
            {
                rb2d.AddForce(new Vector2(0, 1) * Deceleration);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hola");
    }
}
