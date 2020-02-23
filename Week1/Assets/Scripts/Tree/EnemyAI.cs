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
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
