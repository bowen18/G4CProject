using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponent<Camera>().fieldOfView);
        //zoomIn
        if (Input.GetAxis ("Mouse ScrollWheel") > 0 && GetComponent<Camera>().fieldOfView > 20)
        {
            GetComponent<Camera>().fieldOfView--;
        }
        //zoomOut
        else if (Input.GetAxis ("Mouse ScrollWheel") < 0 && GetComponent<Camera>().fieldOfView < 85)
        {
            GetComponent<Camera>().fieldOfView++;
        }
    }
}
