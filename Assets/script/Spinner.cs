using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 2f;
    public float lonelyspeed = 1.2f;
    //public float Groundspeed = 5f;

    public Rigidbody rb;
    public Rigidbody rb1;
    public Rigidbody rb2;
    public Rigidbody rb3;
    public Rigidbody rb4;
    public Rigidbody rb5;
    public Rigidbody rb6;
    //public Rigidbody rb7;

    void Update()
    {
        rb.transform.Rotate(new Vector3(0, lonelyspeed, 0));
        //rb7.transform.Rotate(new Vector3(0, Groundspeed, 0));
        rb1.transform.Rotate(new Vector3(0, speed, 0));
        rb2.transform.Rotate(new Vector3(0, -speed, 0));
        rb3.transform.Rotate(new Vector3(0, speed, 0));
        rb4.transform.Rotate(new Vector3(0, -speed, 0));
        rb5.transform.Rotate(new Vector3(0, speed, 0));
        rb6.transform.Rotate(new Vector3(0, -speed, 0));
    }
}
