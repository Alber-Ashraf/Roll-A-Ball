using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    //public FollowPlayer follow;

    public float autoForce = 1200f;
    public float forwardForce = 500f;
    public float sideForce = 500f;
    public float losingPoint = -6;
    public float jump = 200f;


    void Start()
    {
        Debug.Log("Hello Player");
    }


    void FixedUpdate()
    {
        // Old Player Movement****************************************************************
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            //follow.offset = new Vector3(0, 3, -5);
        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            //follow.offset = new Vector3(0, 3, 5);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //follow.offset = new Vector3(-5, 3, 0);
        }

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //follow.offset = new Vector3(5, 3, 0);
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("Hello Player");

        //        rb.AddForce(0, jump * Time.deltaTime, 0, ForceMode.VelocityChange);
        //    //if (rb.position.y == 1)
        //    //{
        //    //    //rb.AddForce(0, jump, 0);
        //    //}
        //}
        //*************************************************************************************

        if (rb.position.y < losingPoint)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Biger Scale")
        {
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }

        else if (collisionInfo.collider.tag == "Smaller Scale")
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        else if (collisionInfo.collider.tag == "Wall Disappear")
        {
            transform.position = new Vector3(17,3.7f,7.3f);
        }
        
        else if (collisionInfo.collider.tag == "Left Force")
        {
            rb.AddForce(autoForce, 0, 0);
        }

        else if (collisionInfo.collider.tag == "Right Force")
        {
            rb.AddForce(-autoForce, 0, 0);
        }

        else if (collisionInfo.collider.tag == "Forward Force")
        {
            rb.AddForce(0, 0, autoForce);
        }

        else if (collisionInfo.collider.tag == "Backward Force")
        {
            rb.AddForce(0, 0, -autoForce);
        }

        else if (collisionInfo.collider.tag == "Jump")
        {
            rb.AddForce(0, jump, 0);
        }

        else if (collisionInfo.collider.tag == "Player Biger Mass")
        {
            rb.mass = 100f;
        }

        else if (collisionInfo.collider.tag == "Player Smaller Mass")
        {
            rb.mass = 1f;
        }

        else if (collisionInfo.collider.tag == "Smaller Ball Maze")
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }

        else if (collisionInfo.collider.tag == "TB Out Maze")
        {
            transform.position = new Vector3(58, 1, 0);
            //follow.offset = new Vector3(0, 3, -5);
        }

        else if (collisionInfo.collider.tag == "TB Into Maze")
        {
            transform.position = new Vector3(-2, 1, 70);
            transform.localScale = new Vector3(1, 1, 1);
            //follow.offset = new Vector3(0, 20, 0);
        }
    }


}
