
using UnityEngine;
using UnityEngine.SceneManagement;
// Player controller and behavior 
//
public class playercontrol : MonoBehaviour
{
    // 1 - The speed of the ship
    public Vector2 speed = new Vector2(50, 50);
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
        // 5 - Move the game object 
        GetComponent<Rigidbody2D>().velocity = movement;
    }


    void OnCollisionEnter(Collision collision)
    {

    }
    void OnTriggerEnter(Collider collider)
    {
    }
    public void OnCollisionEnter2D(Collision2D other)
    {


        if (other.gameObject.tag == "car")
        {

            SceneManager.LoadScene(0);



        }
    }
    
}


