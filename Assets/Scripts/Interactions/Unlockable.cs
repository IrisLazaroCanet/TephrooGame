using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(BoxCollider2D))]
public class Unlockable : Interactable
{
    public bool isOpened = false;
    public Sprite lockedSprite;
    public Sprite unlockedSprite;
    public AudioClip unlockSound;
    public BoxCollider2D boxC;
    private SpriteRenderer sprite;
    public GameData.GameItem unlockerItem;      //De moment no es fa servir. S'utilitzarà quan programem l'inventari (per substituir els if else if de CheckIfPlayerHasUnlocker() )
    public bool unlockerItemIsTaken;

    private SpriteRenderer spriteR;
    private AudioSource audioS;

    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        audioS = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();

        if (isOpened) {
            Unlock();
        }
    }

    public override void Interact()
    {

        if (isOpened == false && CheckIfPlayerHasUnlocker() == true) 
        {
            Unlock();
            audioS.PlayOneShot(unlockSound);
        }
    }

    public bool CheckIfPlayerHasUnlocker()
    {
        //Mirar a l'inventari si tenim l'unlockerItem
        //Seria així:  if (isOpened == false && inventory.CheckIfPlayerHasItem(unlockerItem))
        if (this.tag == "Door")
            unlockerItemIsTaken = GameObject.Find("Key").GetComponent<Takeable>().isTaken;
        else if (this.tag == "Trapdoor")
            unlockerItemIsTaken = GameObject.Find("key_2").GetComponent<Takeable>().isTaken;
        else if (this.tag == "Untagged")      //Untagged Unlockables poden obrir-se sense un unlockerItem
            unlockerItemIsTaken = true;

        return unlockerItemIsTaken;
    }

    private void Unlock() {
        isOpened = true;
        spriteR.sprite = unlockedSprite;
        boxC.enabled = false;
        sprite.sortingLayerName = "Default";
    }
}
