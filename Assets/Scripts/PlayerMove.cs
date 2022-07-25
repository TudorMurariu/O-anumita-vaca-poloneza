using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   public LayerMask platformLayer;
    public float F = 1200f;
    public float foreceUpwards = 9000f;
    public Rigidbody2D RB;
    public BoxCollider2D boxCollider;
    private bool canDoublejump; 

    void Start()
    {
       
    }

    void Update()
    {
        if(isGrounded())
        {
            canDoublejump = true;
        }

        Vector2 force = new Vector2(F * Time.deltaTime, 0);
        Vector2 forceUP = new Vector2(0, foreceUpwards * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            RB.AddForce(force);
        }
        if (Input.GetKey("a"))
        {
             RB.AddForce(-force);
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded())
            {
                RB.AddForce(forceUP);
            }
            else
            {
                if (canDoublejump)
                {
                    RB.AddForce(forceUP);
                    canDoublejump = false;
                    //Debug.Log("It doublejummped!!!!");
                }
            }
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D RD = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 0.1F, platformLayer);
        RaycastHit2D RD1 = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.up, 0.1F, platformLayer);
        return (RD.collider != null) || (RD1.collider != null);
    }
}
