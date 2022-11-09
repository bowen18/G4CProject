using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyPressurePlate : MonoBehaviour
{
    [SerializeField] Transform MovedObject;

    [SerializeField] Transform[] MovePoints;
    private int nextPoint = 0;
    
    public float moveForce = 1f;

    private Vector3 EndPoint;
    private Vector3 speed = Vector3.zero;


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
        MovedObject.position = Vector3.SmoothDamp(MovedObject.position, EndPoint, ref speed, moveForce); 
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggerer");
        if(other.tag == "Zoe")
        {
            // makes "EndPoint" the desired point to move to
            // "MovePoints[]" is a collection of GameObjects positions
            EndPoint = MovePoints[nextPoint].position;

            // get the next MovePoint in the array
            nextPoint += 1;

            //if the last EndPoint has been reached, start from the beginning 
            if (nextPoint > MovePoints.Length - 1) nextPoint = 0;
        }
        
    }
}
