using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationTrigger : MonoBehaviour
{
    // This GameObject waits for the Target GameObject to trigger the collider.
    // when Target does, this gameObject activates another gameObject and then
    // deactivates it when the Target leaves.


    [SerializeField] GameObject target;
    [SerializeField] GameObject activateObject;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (target.tag == other.tag)
        {
            activateObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (target.tag == other.tag)
        {
            activateObject.SetActive(false);
        }
    }
}
