using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna;

public class PlayerJoin : MonoBehaviour
{
    private Multiplayer multiPlayer;
    private PlayerController playerController;
    
    private void Start()
    {
        
        multiPlayer = FindObjectOfType<Multiplayer>();
        multiPlayer.JoinFirstAvailable();
        
        
        
        GameManager.Instance.AddConnectedUser(multiPlayer.Me);
    }

    public void GameStart()
    {
        
    }
}
