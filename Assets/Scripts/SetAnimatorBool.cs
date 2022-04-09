using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorBool : MonoBehaviour
{
    [SerializeField] Animator animator;
    bool value;

    [ContextMenu("SetAnimatorOn")]

    /*
    public void SetAnimatorOn()
    {
        SetAnimator(true);
    }

    [ContextMenu("SetAnimatorOff")]
    public void SetAnimatorOff()
    {
        SetAnimator(false);
    }

   
    public void SetAnimator(bool value)
    {
        value = GameObject.Find("TrapDoor").GetComponent<Unlockable>().isOpened;
        animator.SetBool("slided", value);
    }
    */

    private void Update()
    {
        value = GameObject.Find("TrapDoor").GetComponent<Unlockable>().isOpened;

        if (value == true)
            animator.SetBool("slided", value);
    }

}

