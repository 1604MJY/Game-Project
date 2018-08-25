using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour {

    void Start()
    {

    }
    public Vector2 speed = new Vector2(25, 25);
    private Vector2 movement;
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

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
        
    }
  
}
