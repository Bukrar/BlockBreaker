using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Paddle paddle;
    [SerializeField]
    float xPush = 2F;
    [SerializeField]
    float yPush = 15F;

    bool isStarted = false;
    Vector2 paddleToBallVector;

    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    void Update()
    {
        if(!isStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
