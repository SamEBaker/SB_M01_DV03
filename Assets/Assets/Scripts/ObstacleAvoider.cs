using UnityEngine;

public class ObstacleAvoider : Kinematic
{
    ObstacleAvoid myMoveType;
    Face mySeekRotateType;
    //idk why he doesnt move?

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new ObstacleAvoid();
        myMoveType.character = this;
        myMoveType.target = myTarget;

        mySeekRotateType = new Face();
        mySeekRotateType.character = this;
        mySeekRotateType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = myMoveType.getSteering();
        base.Update();
    }
}
