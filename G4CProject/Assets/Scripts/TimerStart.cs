using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{
    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag=="Player")
        {
            coll.gameObject.GetComponent<Timer>().TimerBegin(); 
        }
    }
}
