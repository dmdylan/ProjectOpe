using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIUpdates : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsText = null;
    [SerializeField] private TextMeshProUGUI gameTimeText = null;

    public FloatValue gameTimer;
    public IntValue playerPoints;

    // Update is called once per frame
    void Update()
    {
        UpdateGameTimeText();
        UpdatePointsText();
    }

    private void UpdateGameTimeText()
    {
        gameTimeText.text = FormatSeconds(gameTimer.Value);
    }

    private void UpdatePointsText()
    {
        string playerPointsString;
        int playerScore = playerPoints.Value;
        playerPointsString = string.Format("Points: {0:D3}", playerScore);
        pointsText.text = playerPointsString;
    }

    private string FormatSeconds(float elapsed)
    {
        int d = (int)(elapsed * 100.0f);
        int minutes = d / (60 * 100);
        int seconds = (d % (60 * 100)) / 100;
        int hundredths = d % 100;
        return string.Format("Time: {0:00}.{1:00}", seconds, hundredths);
    }
}
