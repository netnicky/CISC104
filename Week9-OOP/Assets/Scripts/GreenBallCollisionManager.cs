using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject greenBall;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        if(OtherBall.GetComponent<RedBallCollisionManager>() != null)
        {
            Debug.Log("Green collided with Red");

            //the green ball grows
            greenBall.transform.localScale = new Vector3(1, 1, 1);
        }

    }
}

