using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; //Speed of movement
    public float maxSpeed; //Our max speed
    public float jumpForce; //The amount of jump
    public Vector3 distanceDown;

    [HideInInspector] public bool isWalking;
    [HideInInspector] public bool grounded;

  

    Animator animator; //Our player's animator

    Rigidbody2D rb; //Our rigidbody 2D

    //Map movement to a selected key
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode jump = KeyCode.Z;

    //Flipping the image with this enumerator
    public enum DIRECTION
    {
        LEFT = -1,
        RIGHT = 1
    }
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set up bool for animator
        animator.SetBool("isWalking", isWalking);

        grounded = Physics2D.Linecast(transform.position, distanceDown, 1 << LayerMask.NameToLayer("Ground"));
        Debug.DrawLine(transform.position, transform.position + distanceDown, Color.red);

        Debug.Log("Is Grounded?: " + grounded);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(right))
            MoveRight();
        if (Input.GetKey(left))
            MoveLeft();
        if (Input.GetKeyDown(jump) && grounded == true)
            Jump();
        else isWalking = false;
    }

    //Moving to the right
    public void MoveRight()
    {
        isWalking = true;

        Flip(DIRECTION.RIGHT);

        if (rb.velocity.magnitude < maxSpeed) {
            rb.velocity += new Vector2(speed, 0);
        }
    }

    //Moving to the left
    public void MoveLeft()
    {
        isWalking = true;

        Flip(DIRECTION.LEFT);

        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.velocity += new Vector2(-speed, 0);
        }
    }

    //Jumping
    public void Jump()
    {
        rb.velocity += new Vector2(0, jumpForce);
    }

    //Flip the image over the y axis
    public void Flip(DIRECTION direction)
    {
        Vector3 xscale;
        switch (direction)
        {
            case DIRECTION.RIGHT:
                xscale = gameObject.transform.localScale;
                xscale.x = (float)DIRECTION.RIGHT;
                gameObject.transform.localScale = xscale;
                break;

            case DIRECTION.LEFT:
                xscale = gameObject.transform.localScale;
                xscale.x = (float)DIRECTION.LEFT;
                gameObject.transform.localScale = xscale;
                break;
        }
    }
}
