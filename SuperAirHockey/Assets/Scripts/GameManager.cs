using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : CommunicationBridge
{
    [SerializeField] private int scoreToWin;
    private int[] score = new int[2];

    
    //Replace with the player controller class
    private List<User> connectedUsers;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType(typeof(GameManager)) as GameManager;

            return instance;
        }
        set
        {
            instance = value;
        }
    }
    private static GameManager instance;

    private void Start()
    {
        Multiplayer.GetUser();
        foreach (int point in score)
        {
            score[point] = 0;
        }
    }

    public void AddConnectedUser(User user)
    {
        connectedUsers.Add(user);
        if (connectedUsers.Count > 1)
            StartGame();
    }

    private void StartGame()
    {
        foreach (User user in connectedUsers)
        {
            //Run enable function
        }

        EnablePuck();
    }

    private void EnablePuck()
    {
        //Start puck physics
    }

    public void ScoreUp(int scoringUser)
    {
        foreach (int point in score)
        {
            if (score[point] == scoringUser)
            {
                score[point]++;
            }
            
            if (score[point] == scoreToWin)
                EndGame(scoringUser);
        }
    }

    private void EndGame(int winningPlayer)
    {
        
    }
}
