using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 15.0f;
    public float jumpSpeed = 10f;

    private CharacterController controller;  
    // https://docs.unity3d.com/ScriptReference/CharacterController.html 

    private Vector3 movement = Vector3.zero;  //makes new Vector3(0f,0f,0f) SHORTCUT
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
