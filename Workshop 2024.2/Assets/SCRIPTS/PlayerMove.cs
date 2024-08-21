using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
     private Rigidbody2D rb;
     public float inputX;
     public bool inputJump;
     public float speed;
     public float forceJump;
     public bool inGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputJump = Input.GetKeyDown(KeyCode.Space);

        if(inputJump == true && inGround == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, forceJump);
        }
    }

    
    
    private void FixedUpdate()
    {
    rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }
}