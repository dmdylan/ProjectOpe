using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        TheGameIsOver();
    }

    private void Awake()
    {
        HideMouse();
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
                GameOverSequence();
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

    private void HideMouse()
    {
        Cursor.visible = false;
    }

    private void SetPlayerHighScore()
    {
        if(PlayerPrefs.GetInt("High Score") < playerScore.Value)
        {
            PlayerPrefs.SetInt("High Score", playerScore.Value);
        }
    }

    private void TheGameIsOver()
    {
        if(gameTimer.Value <= 0)
        {
            theGameIsNotOver = false;
        }
    }

    private void GameOverSequence()
    {
        SetPlayerHighScore();
        SceneManager.LoadScene("GameOver");
    }
}
