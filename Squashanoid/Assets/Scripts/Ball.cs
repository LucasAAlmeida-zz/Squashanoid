using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Racket racket;
    [SerializeField] float xLaunchVelocity = 2f;
    [SerializeField] float yLaunchVelocity = 15f;
    bool hasStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) {
            LockRacketToBall();
            LaunchBallOnMouseClick();
        }
    }

    private void LaunchBallOnMouseClick()
    {
        if(Input.GetMouseButton(0)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xLaunchVelocity, yLaunchVelocity);
            hasStarted = true;
        }
    }

    private void LockRacketToBall()
    {
        Vector3 racketPosition = racket.transform.position;
        float yOffset = 0.5f;
        transform.position = new Vector2(racketPosition.x, racketPosition.y + yOffset);
    }
}
