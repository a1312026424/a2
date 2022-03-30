using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed;
    //public int Time;
    public float jumpspeed = 10;

    public float g = 10;

    public CharacterController playercontroller;
    
    Vector3 move;
    void Update()
    {
        float x = 0, z = 0;

        if(playercontroller.isGrounded){
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move = (transform.right * x + transform.forward * z) * speed;

        if(Input.GetAxis("Jump") == 1){

            move.y = jumpspeed;
        }
    
    }

        move.y = move.y - g * Time.deltaTime;

        playercontroller.Move(move * Time.deltaTime);
    }
}
