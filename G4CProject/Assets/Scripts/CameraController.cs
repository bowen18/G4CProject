using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float zoom;
    //public float speed;
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }
    
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        if (movement>0 && transform.rotation.y > -0.45)
        {
            transform.Rotate(0, -20 * Time.deltaTime,0);
        }
        else if (movement<0 && transform.rotation.y < 0.36)
        {
            transform.Rotate(0, 20 * Time.deltaTime,0);
        }
        
    }
    
}
