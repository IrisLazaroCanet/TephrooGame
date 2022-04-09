using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Interactable focusedObject;

    private void Update()
    {
        if (Input.GetButtonDown("Interact")) 
        {
            if(focusedObject != null)
                focusedObject.Interact();
        }
    }
}
