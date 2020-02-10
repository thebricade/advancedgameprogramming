using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreController : MonoBehaviour
{
    private string player1Score, player2Score; 
    
    // Start is called before the first frame update
    void Start()
    {
        Services._EventSystem.Register<GoalScored>(OnGoalScored);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGoalScored(AGPEvent e)
    {
        var goalScoredEvent = (GoalScored)e;
        //not sure how to get score here? do i just make a new variable
        Debug.Log("goal Score!");
        
    }

    private void OnDestroy()
    {
        Services._EventSystem.Unregister<GoalScored>(OnGoalScored);
    }
}
