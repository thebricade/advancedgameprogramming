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
        if(Input.GetKey(playerUp)) {Debug.Log("player moved up");}
        if(Input.GetKey(playerDown)){}
        if(Input.GetKey(playerLeft)){}
        if(Input.GetKey(playerRight)){}
        
    }
}
