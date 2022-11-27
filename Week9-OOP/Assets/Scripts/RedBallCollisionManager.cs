using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject redBall;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        if(OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Red collided with yellow");
            //the red ball teleports in the air to the center
            redBall.transform.position = new Vector3(0, 5, 0);

        }
    }
}

