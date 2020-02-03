using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerInput : MonoBehaviour
{
    public KeyCode playerUp, playerDown, playerRight, playerLeft, cheerKey;
    public string team; 

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
        CheerTeam(team); //expensive warning
    }

    public void movePlayer()
    {
        if (Input.GetKey(playerUp)) { rb2d.AddForce(Vector2.up);}
        if(Input.GetKey(playerDown)){ rb2d.AddForce(Vector2.down);}
        if(Input.GetKey(playerLeft)){ rb2d.AddForce(Vector2.left);}
        if(Input.GetKey(playerRight)){rb2d.AddForce(Vector2.right);}
        
    }

    public void CheerTeam(string team)
    {
        //when you cheer for your team they move a little towards the ball 
        if (Input.GetKey(cheerKey))
        {
            Debug.Log("cheer key has been pressed");
            if (team == "Team1")
            {
                Services._AiTeam1.MoveTowardsBall();
                Debug.Log("Team 1 is cheered towards the ball");
            } else if (team == "Team2")
            {
                Services._AiTeam2.MoveTowardsBall();
            }
            else
            {
                Debug.LogError("In correct team submission");
            }
            
        }
    }
}
