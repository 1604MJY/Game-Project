using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour {

    void Start()
    {

    }

    // 1 - The speed of the ship
    public Vector2 speed = new Vector2(25, 25);
    // 2 - Store the movement 
    private Vector2 movement;
    void Update()
    {
        // 3 - Retrieve axis information 
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 4 - Movement per direction
        movement = new Vector2(
        speed.x * inputX,
        speed.y * inputY);

    }
    void FixedUpdate()
    {

        GetComponent<Rigidbody2D>().velocity = movement;

        Animator an = GetComponent<Animator>();
        if (an)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                an.SetInteger("direction", 3);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                an.SetInteger("direction", 1);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                an.SetInteger("direction", 2);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                an.SetInteger("direction", 0);
            }
        }
        // 5 - Move the game object 
    }
    // Use this for initialization
  
}
