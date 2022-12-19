using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public ContactFilter2D movementFilter;
    
    private Vector2 movement;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    private Rigidbody2D rb;
    // !!!! Needs collisionOffset !!!!

        // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // input
    public void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called on a looping timer.
    public void FixedUpdate()
    {
        // rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        bool success = MovePlayer(movement);

        if (!success)
        {
            success = MovePlayer(new Vector2(movement.x, 0));

            if (!success)
            {
                success = MovePlayer(new Vector2(0, movement.y));
            }
        }
    }

    // Checks if player is able to move.
    public bool MovePlayer(Vector2 direction)
    {
        int count = rb.Cast(direction, movementFilter, castCollisions, moveSpeed * Time.fixedDeltaTime);

        if (count == 0)
        {
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            rb.MovePosition(rb.position + moveVector);
            return true;
        }
        else
        {
            foreach (RaycastHit2D hit in castCollisions)
            {
                print(hit.ToString());
            }
            return false;
        }
    }
}
