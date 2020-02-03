﻿using System.Collections;
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
           var TeamLocation = Services._player1Team[i].GetComponent<Transform>().position; 
           
           Services._player1Team[i].GetComponent<Transform>().position =
               Vector2.MoveTowards(TeamLocation, ballLocation, step); 
       }

    }
}
