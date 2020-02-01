using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AITeamMovement : MonoBehaviour
{
    private Rigidbody2D rdbd;
    public GameObject ball;
    private Vector2 ballLocation , teamPosition;
    public float speed = 1.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        rdbd = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsBall();
    }

    public void MoveTowardsBall()
    {
        //Move a step closer to the target
        float step = speed * Time.deltaTime; 
        ballLocation = new Vector2(ball.GetComponent<Transform>().position.x, ball.GetComponent<Transform>().position.y);
        teamPosition = new Vector2(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y);
        gameObject.GetComponent<Transform>().position = Vector2.MoveTowards(teamPosition, ballLocation, step); 
    }
}
