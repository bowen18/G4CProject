using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

  
    public CharacterSwap Gamemanager;
    
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<CharacterSwap>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag == "Player")
        {
            if (this.enabled == true)
            {
                if(other != null)
                {
                Debug.Log(other.GetComponent<Transform>());
                Gamemanager.possibleCharacters.Add(GameObject.Find("Player3").GetComponent<Transform>());
                }
            }
            
        }
        
    }
}
