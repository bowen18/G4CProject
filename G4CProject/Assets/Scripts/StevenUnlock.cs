using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StevenUnlock : MonoBehaviour
{
    public CharacterSwap Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<CharacterSwap>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Steven")
        {
            if (this.enabled == true)
            {
                if(other != null)
                {
                    Debug.Log("Triggered");
                    if(Gamemanager.possibleCharacters.Count <= 1)
                    {
                        Debug.Log("Unlocked");
                        Gamemanager.possibleCharacters.Add(GameObject.Find("Zoe").GetComponent<Transform>());
                    }
                }
            }
        }
        
    }
}
