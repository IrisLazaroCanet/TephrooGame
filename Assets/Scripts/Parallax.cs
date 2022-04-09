using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float backgroundX;
    public float backgroundY;
     float left;
     float right;
    float up;
    public float initialX;
    public float initialY;
    public float movementIndex = 10;
    public float transitionTime = 0.2f;
    Vector3 startPos;
    Vector3 endPos;
    void Start()
    {
        right = initialX + movementIndex;
        left = initialX - movementIndex;
        up = initialY - movementIndex;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            backgroundX = left;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            backgroundX = right;
        }
        else
        {
            backgroundX = initialX;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            backgroundY = up;
        }
        else
        {
            backgroundY = initialY;
        }
        Vector3 startPos = new Vector3(initialX, initialY, 0);
        Vector3 endPos = new Vector3(backgroundX, backgroundY, 0);

        transform.position = Vector3.Lerp(startPos, endPos, transitionTime);
    }

}
