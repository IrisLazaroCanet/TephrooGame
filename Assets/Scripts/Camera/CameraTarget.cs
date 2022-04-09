using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        Camera.main.GetComponent<CameraMovement>().cameraTarget = transform.position;
    }
}
