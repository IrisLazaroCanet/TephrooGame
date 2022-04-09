using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 18;
    public float jumpForce = 300;
    public float gravity = -0.15f;
    int movementSign = 0;
    public int extraJumps = 0;
    public int maxJumps = 1;
    public bool touchingGround = false;
    public bool touchingLWall = false;
    public bool touchingRWall = false;
    public float rayLength = 0.6f;
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            if (!touchingRWall)
            {
                movementSign = 1;
                animator.SetInteger("Horizontal", movementSign);
            }
            else
            {
                movementSign = 0;
                animator.SetInteger(1, movementSign);
            }
               
            

        }
        //else if (Input.GetKey(KeyCode.A))
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            if (!touchingLWall)
            {
                movementSign = -1;
                animator.SetInteger("Horizontal", movementSign);
            }
            else
            {
                movementSign = 0;
                animator.SetInteger(-1, movementSign);
            }
                
           

        }
        else
        {
            movementSign = 0;
            animator.SetInteger("Horizontal", movementSign);
        }

        if (Input.GetButtonDown("Jump"))
        {
            JumpAttempt();

        }

        
        touchingGround = Physics2D.Raycast(transform.position, Vector2.down, rayLength);
        Debug.DrawLine(transform.position, transform.position+Vector3.down * rayLength);
    }


    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveSpeed * movementSign, rb2d.velocity.y + gravity);
    }

    void JumpAttempt()
    {
        if (extraJumps > 0 || touchingGround)
            Jump();
    }

    void Jump()
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(0, jumpForce));
        
        if (touchingGround)
            extraJumps = maxJumps;
        
        else
        extraJumps--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (movementSign == 1 && touchingLWall == false && touchingGround == false)
        {
            touchingRWall = true;
            touchingLWall = false;
        }
       else  if (movementSign == -1 && touchingRWall == false && touchingGround == false)
        {
            touchingLWall = true;
            touchingRWall = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
            touchingLWall = false;
            touchingRWall = false;
    
    }
}


