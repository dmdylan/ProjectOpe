using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI playerPointsText = null;   
    [SerializeField] private TextMeshProUGUI playerHighScoreText = null;

    public IntValue playerPoints;

    private void Start()
    {
        SetPlayerPointsText();
        ShowPlayerHighScore();
    }

    private void SetPlayerPointsText()
    {
        playerPointsText.text = playerPoints.Value.ToString();
    }

    private void ShowPlayerHighScore()
    {
        playerHighScoreText.text = PlayerPrefs.GetInt("High Score").ToString();
    }
}
