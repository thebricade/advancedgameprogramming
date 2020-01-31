using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerInput : MonoBehaviour
{
    public KeyCode playerUp, playerDown, playerRight, playerLeft;

    private Rigidbody2D rb2d; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        movePlayer();
    }

    public void movePlayer()
    {
        if (Input.GetKey(playerUp)) { rb2d.AddForce(Vector2.up);}
        if(Input.GetKey(playerDown)){ rb2d.AddForce(Vector2.down);}
        if(Input.GetKey(playerLeft)){ rb2d.AddForce(Vector2.left);}
        if(Input.GetKey(playerRight)){rb2d.AddForce(Vector2.right);}
        
    }
}
