using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
    public float scrollX = 0.0f;
    public float scrollY = 0.0f;
   
    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset =
           new Vector2(Time.time * scrollX, Time.time * scrollY);
    }
}
