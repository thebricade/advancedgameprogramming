using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyAI : AiStateMachine
{
    public enum AIState
    {
        None = 0, 
        Wander = 1, 
        Pursue = 2, 
        Attack = 3 
    }

    [Header("From EnemyAI")] 
    public float speed = 4.0f;
    public float pursueRange;
    public float attackRange;
    public bool printDebugInfo = false;

    public AIState currentState;

    private Transform targetPostition;
    private Vector3 movement;
    private float gravity = 15f;

    protected override void AiInitialization()
    {
        controller = GetComponent<CharacterController>();

        currentState = AIState.Wander;
        targetPostition = transform.transform;
        PrintDebugInfo("Starting out in " + currentState);
        
        base.AiInitialization();
    }

    protected override void AiTick()
    {
        switch (currentState)
        {
            case AIState.Attack:
                AttackStateUpdate();
                break;
            case AIState.Pursue:
                PursueStateUpdate();
                break;
            case AIState.Wander:
                WanderStatusUpdate();
                break;
            default:
                Debug.LogError("a state we haven't set has been encountered'");
                break;
        }
        
        base.AiTick();
    }

    private void PursueStateUpdate()
    {
        //transition from pursue to attack
        if (Vector3.Distance(transform.position, targetPostition.position) < attackRange)
        {
            PrintDebugInfo("transition: Purssue -> attack");
            currentState = AIState.Attack; 
        }
        
        //transition from pursue to wander
        else if (Vector3.Distance(transform.position, targetPostition.position) > pursueRange)
        {
            PrintDebugInfo("transition: pursue -> wander");
            currentState = AIState.Wander;
        }

        movement = targetPostition.position - transform.position;
        movement = movement.normalized * speed;

        movement.y -= gravity * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);
    }

    private void AttackStateUpdate()
    {
        PrintDebugInfo("attack");

        movement.y -= gravity * Time.deltaTime; 
        PrintDebugInfo("transition: attack -> pursue");
        currentState = AIState.Pursue;
    }

    private void WanderStatusUpdate()
    {
        //find a waypoint
        Vector3 waypointPosition = wayPointList[currentWayPoint].transform.position;

        if (Vector3.Distance(transform.position, targetPostition.position) < pursueRange)
        {
            PrintDebugInfo("transition: wander -> pursue");
            currentState = AIState.Pursue;
        }

        movement = waypointPosition - transform.position;
        movement = movement.normalized * speed;
        movement.y -= gravity * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            NextWaypoint();   // how to do a patrol 
        }
    }

    private void NextWaypoint()
    {
        currentWayPoint = (currentWayPoint++) % wayPointList.Length;
        PrintDebugInfo("moving to waypoint "+ currentWayPoint);
        
    }

    public void PrintDebugInfo(string message) // you can turn this on and off in the inspector
    {
        if (printDebugInfo)
        {
            Debug.Log(message);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
