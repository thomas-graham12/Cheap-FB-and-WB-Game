using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    Rigidbody2D rb;

    private float dirX;
    private float dirY;
    private float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "PlayerOne")
        {
            dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            dirY = Input.GetAxisRaw("Vertical") * moveSpeed;
        }    

        if (name == "PlayerTwo" && Input.anyKey)
        {
            if (Input.GetKey(KeyCode.I))
            {
                dirY = moveSpeed;
            }
            if (Input.GetKey(KeyCode.K))
            {
                dirY = -moveSpeed;
            }
            if (Input.GetKey(KeyCode.J))
            {
                dirX = -moveSpeed;
            }
            if (Input.GetKey(KeyCode.L))
            {
                dirX = moveSpeed;
            }
        }
        else if (name == "PlayerTwo" && !Input.anyKey)
        {
            dirX = 0f;
            dirY = 0f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Exit"))
        {
            Destroy(gameObject);
        }
    }

}
