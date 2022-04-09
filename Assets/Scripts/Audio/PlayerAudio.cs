using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip walking;
    public AudioClip takeKey;

    void Awake()
    {
        //aSource.gameObject.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (!aSource.isPlaying)
                aSource.PlayOneShot(walking);

        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
            aSource.Stop();
    }
}
