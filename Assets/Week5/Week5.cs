using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week5 : MonoBehaviour
{
    /*
     * Create a function that returns the position of an object with a given starting position,
     * velocity, and acceleration after a number of frames.
     *
     * Remember - acceleration is how much velocity changes each frame,
     * and velocity is how much position changes each frame.
     *
     * For example:
     *     - PositionAfterFrames(V2(2, 3), V2(1, 0), V2(0, 0), 4) => returns (6, 3);
     *     - PositionAfterFrames(V2(0, 0), V2(0, 0), V2(0, 1), 8) => returns (0, 36);
    */

    private Vector2 PositionAfterFrames(Vector2 startingPosition, Vector2 velocity, Vector2 acceleration, int numberOfFrames)
    {
        for (var i = 0; i < numberOfFrames; i++)
        {
            velocity += acceleration;
            startingPosition += velocity;
        }   
        
        return startingPosition;
    }

    /*
     * Make the ball accelerate towards the mouse position - I've included code that gets the mouse position.
     * 
    */

    public GameObject ball;
    public float ballAccelerationMagnitude;
    private Vector2 _ballVelocity;
    
    private void MoveBall()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Make the ball object accelerate towards the mouse.

        var acceleration = ballAccelerationMagnitude * Time.deltaTime * (mousePosition - (Vector2) ball.transform.position).normalized;

        _ballVelocity += acceleration;

        ball.transform.position = (Vector2) ball.transform.position + _ballVelocity;
    }


    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI positionAfterFramesText;

    private void Update()
    {
        positionAfterFramesText.text = "Position After Frames Assignment\n<align=left>\n";
        positionAfterFramesText.text +=
            Success(PositionAfterFrames(new Vector2(0, -1), new Vector2(0, 0), new Vector2(0, 0), 10) ==
                    new Vector2(0, -1)) + " correct for zero acceleration and velocity.\n";
        positionAfterFramesText.text +=
            Success(PositionAfterFrames(new Vector2(2, 3), new Vector2(1, 0), new Vector2(0, 0), 4) ==
                    new Vector2(6, 3)) + " correct for no acceleration.\n";
        positionAfterFramesText.text +=
            Success(PositionAfterFrames(new Vector2(0, 0), new Vector2(0, 0), new Vector2(0, 1), 8) ==
                    new Vector2(0, 36)) + " correct for acceleration = (0, 1).\n";

        MoveBall();
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}