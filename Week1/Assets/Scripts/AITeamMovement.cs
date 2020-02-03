using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AITeamMovement 
{
    
    public float speed = 1.0f; 
    
    public void MoveTowardsBall()
    {
       //find the ball's current location 
       Debug.Log(Services._ball);
       var ballLocation = Services._ball.GetComponent<Transform>().position; 
       float step = speed * Time.deltaTime;

       for (int i = 0; i < Services._player1Team.Length; i++)
       {
           var TeamX = Services._player1Team[i].GetComponent<Transform>().position.x; // changed here for readability 
           var TeamY = Services._player1Team[i].GetComponent<Transform>().position.y; // how can I do this without using getComponent at all??? 
           
           var currentposition = new Vector2(TeamX, TeamY);
           
           Services._player1Team[i].GetComponent<Transform>().position =
               Vector2.MoveTowards(currentposition, ballLocation, step); 
       }

    }
}
