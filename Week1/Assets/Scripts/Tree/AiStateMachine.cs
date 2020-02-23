using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiStateMachine : MonoBehaviour
{
    //headers create sections in inspector 
    //also it yells at you until you put the variable
    [Header("From AIStateMachine")] 
    public GameObject targetPlayer;

    public GameObject[] wayPointList;

    protected int currentWayPoint;
    protected Vector3 nextWayPointPosition;

    protected CharacterController controller; // if this is the same we can make a reference in serviced
    // Start is called before the first frame update
    void Start()
    {
        currentWayPoint = 0;
        AiInitialization();
    }

    protected virtual void AiInitialization()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        AiTick();
    }

    protected virtual void AiTick()
    {
        
    }
}
