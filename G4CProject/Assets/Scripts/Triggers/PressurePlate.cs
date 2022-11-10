using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] Transform MovedObject;
    [SerializeField] Transform[] MovePoints;
    public float moveForce = 1f;

    private int nextPoint = 0;
    private Vector3 EndPoint;
    private Vector3 speed = Vector3.zero;
    private bool triggered = false;

    //-----------------------------------------------------------------------
    // objects using smoothDamp don't always reach thier destination exactly
    // so I made a cut off distance to stop Update from moving the object
    // at that distance from the endPoint
    public float distanceCutOff = 0;
    //-----------------------------------------------------------------------


    private void Start()
    {
        // sets the beginning EndPoint to the position of the object to be moved 
        // so the object doesnt move to the first EndPoint in the MovePoints[] array
        // on the start of the scene
        EndPoint = MovedObject.position;
    }
    private void Update()
    {
        // moves "MovedObject" to desited location at "EndPoint"
        if (triggered)
        {
            MovedObject.position = Vector3.SmoothDamp(MovedObject.position, EndPoint, ref speed, moveForce);
        }

        // stop moveObject movement once it reached its destination
        if (Vector3.Distance(MovedObject.position, EndPoint) <= distanceCutOff) triggered = false;


    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggerer");

        // let Update start the move
        triggered = true;

        // makes "EndPoint" the desired point to move to
        // "MovePoints[]" is a collection of GameObjects positions
        EndPoint = MovePoints[nextPoint].position;

        // get the next MovePoint in the array
        nextPoint += 1;

        //if the last EndPoint has been reached, start from the beginning 
        if (nextPoint > MovePoints.Length - 1) nextPoint = 0;
    }
}
