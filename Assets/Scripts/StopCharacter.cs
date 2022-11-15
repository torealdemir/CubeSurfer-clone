using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCharacter : MonoBehaviour
{

    

    // Update is called once per frame
    void Update()
    {
        DeactivateCharacter();
    }

    public void DeactivateCharacter()
    {
        if(PlayerMovement.instance.cubes.Count == 0)
        {
            this.GetComponent<PlayerMovement>().enabled = false;
        }

    }
}
