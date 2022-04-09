using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Camera speed value
    public float cameraSpeed = 0.2f;
    //Speficies the position where the camera will move
    public Vector3 cameraTarget;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cameraTarget.z = transform.position.z;

        if (Vector3.Distance(transform.position, cameraTarget) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, cameraTarget, cameraSpeed * Time.deltaTime);
        }
    }
}
