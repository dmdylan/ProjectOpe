using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public IntValue playerScore;
    public IntValue playerHighScore;
    public FloatValue gameTimer;
    public FloatValue maxSpawnTime;
    private bool theGameIsNotOver = true;

    private void Update()
    {
        CheckGameState();
        UpdateGameTime();
        IncreaseObjectsSpawned();
    }

    private void Awake()
    {
        maxSpawnTime.Value = 4f;
        playerScore.Value = 0;
        gameTimer.Value = 60f;
    }

    private void CheckGameState()
    {
        switch (theGameIsNotOver)
        {
            case true:
                break;
            case false:
                break;
        }
    }

    private void UpdateGameTime()
    {
        gameTimer.Value -= Time.deltaTime;
    }

    private void IncreaseObjectsSpawned()
    {
        if(gameTimer.Value <= 20)
        {
            maxSpawnTime.Value = 1f;
        }
    }
}
