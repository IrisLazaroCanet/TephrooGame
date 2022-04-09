using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
public class Takeable : Interactable
{
    public GameData.GameItem gameItem;
    public bool isTaken = false;
    public AudioClip takeSound;

    private SpriteRenderer spriteR;
    private AudioSource audioS;

    public override void Interact()
    {
        if (isTaken == false) 
        {
            isTaken = true;
            spriteR.enabled = false;
            audioS.PlayOneShot(takeSound);
            Debug.Log(gameItem +  " item taken.");
        }
    }


    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        audioS = GetComponent<AudioSource>();

        if (isTaken)
        {
            spriteR.enabled = false;
        }
        else {
            spriteR.enabled = true;
        }
    }
}
