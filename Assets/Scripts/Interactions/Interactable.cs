using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Interactable : MonoBehaviour
{
    public string itemName;
    public Dialogue dialogue;
    public abstract void Interact();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("Player enters " + itemName + " trigger");
            collision.GetComponent<PlayerInteraction>().focusedObject = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Call UI to close icon (eye)
            Debug.Log("Player exits " + itemName + " trigger");
            collision.GetComponent<PlayerInteraction>().focusedObject = null;
        }
    }
}
