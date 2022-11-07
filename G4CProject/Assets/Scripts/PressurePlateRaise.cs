using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateRaise : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    
    public float distanceToMove;
    public float speed;

    private Vector3 StartingPoint;

    public bool doormove = false;
    public bool doorClosed = true;
    
    [SerializeField]
    private Vector3 SlideDirection = Vector3.back;
    [SerializeField]
    private float SlideAmount = 3f;


    
    void Start()
    {
        StartingPoint = door.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("raised");
        door.transform.Translate(0, 2, 0);
    }
}
