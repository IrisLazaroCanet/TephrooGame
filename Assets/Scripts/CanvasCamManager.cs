using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCamManager : MonoBehaviour
{
    Camera activeCam;
    public Canvas canvas;
    // Update is called once per frame
    void Update()
    {
        //activeCam = GameObject.Find("CameraManager").GetComponent<CameraMovement>().activeCameraObj;
        canvas.worldCamera = activeCam;
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        
    }
}
