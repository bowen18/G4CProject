using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgitateTexture : MonoBehaviour
{
    public Vector3 rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FlipSign", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotatespeed * Time.deltaTime);
    }

    void FlipSign()
    {
        rotatespeed.x = -rotatespeed.x;
        rotatespeed.y = -rotatespeed.y;
        rotatespeed.z = -rotatespeed.z;
    }
}
