using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{

    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;
    // Start is called before the first frame update
    void Start()
    {
        if(character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (whichCharacter == 0){
                whichCharacter = possibleCharacters.Count -1;
            }
            else
            {
                whichCharacter -= 1;
            }
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (whichCharacter == possibleCharacters.Count -1){
                whichCharacter = 0;
            }
            else
            {
                whichCharacter += 1;
            }
            Swap();
        }
    }
    void Swap()
    {
        // turns current players controlLight off
        character.GetComponent<PlayerController>().turnControlLightOn(false);

        // swicth character
        character = possibleCharacters[whichCharacter];
        character.GetComponent<PlayerController>().enabled = true;

        // turns new players controlLight on
        character.GetComponent<PlayerController>().turnControlLightOn(true);
        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if(possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<PlayerController>().enabled = false;
            }
        }
    }
}
