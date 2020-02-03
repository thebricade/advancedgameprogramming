using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        InitializeServices();
    }

    public void InitializeServices()
    {
        Services._game = this;
        Services._ball = GameObject.Find("Ball");
        Services._player1Team = GameObject.FindGameObjectsWithTag("player1");
        
        Services._AiTeam1 = new AITeamMovement(); 


        //everything for player2
        //Services._player2Team = GameObject.FindGameObjectsWithTag("player2");

    }
    
    
}
