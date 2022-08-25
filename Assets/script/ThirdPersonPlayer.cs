//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ThirdPersonPlayer : MonoBehaviour
//{
//    //public CharacterController controller;
//    public Transform cam;

//    public float turnSmoothTime = 0.1f;
//    float turnSmoothVelocity;
//    //public float speed = 6f;


//    void Update()
//    {
//        float horizontal = Input.GetAxisRaw("Horizontal");
//        float vertical = Input.GetAxisRaw("Vertical");
//        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

//        if (direction.magnitude >= 0.1f)
//        {
//            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
//            float angel = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref turnSmoothVelocity, turnSmoothTime);
//            transform.rotation = Quaternion.Euler(0f, angel, 0f);

//            //Vector3 moveDir = Quaternion.Euler(0f, targetAngel, 0f) * Vector3.forward;
//            //controller.Move(moveDir.normalized * speed * Time.deltaTime);
//        }
//    }
//}
