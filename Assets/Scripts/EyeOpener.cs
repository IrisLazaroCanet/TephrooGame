using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOpener : MonoBehaviour
{
    public bool interacting;

    [SerializeField] Animator animator;

    void Update()
    {
        if (interacting)
        {
            animator.SetBool("open", interacting);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            interacting = true;
        }

        if (collision.CompareTag("Door"))
        {
            interacting = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        interacting = false;
    }
}
