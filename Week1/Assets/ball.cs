using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("GoalPlayer1"))
        {
            Debug.Log("you have hit the goal ");
        }

        if (col.gameObject.CompareTag("GoalPlayer2"))
        {
            Debug.Log("you hit player 2 goal");
        }
    }
    
}
