using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float sidespeed;
    public playermovement movement;
   
    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidespeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindAnyObjectByType<manage>().EndGame();
        }

    }

    void OnCollisionEnter(Collision collisioninfo)
    { 
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<manage>().EndGame();
        }
          
    }




}
