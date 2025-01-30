using UnityEngine;

public class ObstacleAvoid : Seek
{
    public float avoidDist = 30f;
    public float lookAhead = 10f;


    protected override Vector3 getTargetPosition()
    {
        RaycastHit ray;
        //ray = character.linearVelocity;
        //ray.Normalize();
        //ray *= lookAhead;

       // collision = getCollision(character.transform.position, ray)

        if (Physics.Raycast(character.transform.position, character.linearVelocity, out ray, lookAhead)) {
            return ray.point - (ray.normal * avoidDist); 
            //target = collision.position + collision.normal * avoidDist;
        }
        else
        {
           return Vector3.positiveInfinity;
           // return Vector3.zero;
        }

        
    }

}
