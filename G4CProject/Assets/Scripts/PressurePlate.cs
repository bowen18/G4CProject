using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    GameObject door;


    void OnTriggerEnter(Collider other)
    {
        door.transform.position += new Vector3(0, 0, -3);
        Debug.Log("Triggered");
    }
}
