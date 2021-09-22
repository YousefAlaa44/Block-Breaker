using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    Vector3 BallToPaddleVector;
    private bool hasstarted = false;
    public Rigidbody2D rb;
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        BallToPaddleVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasstarted)
        {
            
            this.transform.position = paddle.transform.position + BallToPaddleVector;

            //Launce the Ball
            if (Input.GetMouseButtonDown(0))
            {               
                hasstarted = true;
                this.rb.velocity = new Vector2(2f, 10f);
            }
        }
        
        
    }
    void OnCollisionEnter2D()
    {
        Vector2 tweak = new Vector2(Random.Range(0f, .2f), Random.Range(0f, .2f));
        if (hasstarted)
        {
            rb.velocity += tweak;
        }
    }
}
