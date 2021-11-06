using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    float walkingSpeedLowerBound = 5f;
    SpriteRenderer sr;
    Animator ani;
    private float currentSpeed;
    private Vector2 currentDirection;
    private Vector2 savedDirection;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }

    //The two functions below should be used in the player movement script
    public void UpdateWalkingSpeed(float newSpeed)  //Used to update the speed the player is going at (If they are going fast enough they will play a walking animation instead of an idle)
    {                                               //The lower limit for how fast they need to be going is controlled by the walkingSpeedLowerBound variable
        currentSpeed = newSpeed;
    }

    public void UpdateDirection(Vector2 newDirection)   //Used to control what direction the player is facing
    {                                                   //It should be based off of the current input there is already a check below to take in to account 
        currentDirection = newDirection;                //the user not pressing any input keys
    }

    private void Update()
    {
        sr.flipX = false;
        if(currentDirection != Vector2.zero)
        {
            savedDirection = currentDirection;
        }

        if(savedDirection.y == 1)
        {
            //Going Up
            if(currentSpeed > walkingSpeedLowerBound)
            {
                ani.Play("WalkUp");
            }
            else
            {
                ani.Play("UpIdle");
            }
        }
        else if(savedDirection.y == -1)
        {
            //Going Down
            if(currentSpeed > walkingSpeedLowerBound)
            {
                ani.Play("WalkDown");
            }
            else
            {
                ani.Play("DownIdle");
            }
        }
        else
        {
            sr.flipX = savedDirection.x == -1;
            //Horizontal
            if(currentSpeed > walkingSpeedLowerBound)
            {
                ani.Play("HorizontalWalk");
            }
            else
            {
                ani.Play("HorizontalIdle");
            }
        }
    }
}
