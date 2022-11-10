using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] GameObject target;
   
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(target.transform.position, Vector3.up);
    }
}
