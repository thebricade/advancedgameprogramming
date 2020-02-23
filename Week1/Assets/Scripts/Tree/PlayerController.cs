using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 15.0f;
    public float jumpStrength = 10f;

    private CharacterController controller;  
    // https://docs.unity3d.com/ScriptReference/CharacterController.html 

    private Vector3 movement = Vector3.zero;  //makes new Vector3(0f,0f,0f) SHORTCUT
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            movement = transform.TransformDirection(movement);
            movement *= speed;

            if (Input.GetButton("Jump"))
            {
                movement.y = jumpStrength; 
            }
        }
        else
        {
            movement.y -= gravity * Time.deltaTime; 
        }

        controller.Move(movement * Time.deltaTime);
    }
    
}
