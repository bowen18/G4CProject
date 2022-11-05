using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && transform.rotation.y > -0.45)
        {
            transform.Rotate(0, -20 * Time.deltaTime,0);
        }
        else if (Input.GetKey("a") && transform.rotation.y < 0.36)
        {
            transform.Rotate(0, 20 * Time.deltaTime,0);
           
        }
        
    }
}
