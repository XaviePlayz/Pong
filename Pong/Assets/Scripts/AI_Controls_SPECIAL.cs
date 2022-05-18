﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Controls_SPECIAL : MonoBehaviour
{
    private float speed = 10f;

    Transform ball;

    Rigidbody2D ballRig2D;

    public float topBound = 4F;
    public float bottomBound = -4F;

    // Use this for initialization
    void Start()
    {
        //Continuously Invokes Move every x seconds (values may differ)
        InvokeRepeating("Move", .02F, .02F);
    }

    // Movement for the paddle
    void Move()
    {

        //finding the ball
        if (ball == null)
        {
            ball = GameObject.FindGameObjectWithTag("Ball").transform;
        }

        //setting the ball's rigidbody to a variable
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the ball
        if (ballRig2D.velocity.x < 0)
        {

            //checking y direction of ball
            if (ball.position.y < this.transform.position.y - .3F)
            {
                //move ball down if lower than paddle
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            else if (ball.position.y > this.transform.position.y + .3F)
            {
                //move ball up if higher than paddle
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

        }

        //set bounds of AI
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }
        else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }
}