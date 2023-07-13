using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public int p1Score = 0; 
    public int p2Score = 0;
    public int endScore;

    public TextMeshPro p1ScoreTextMesh;
    public TextMeshPro p2ScoreTextMesh;

    public GameObject gameEndMessage;
    public TextMeshProUGUI gameEndMessageText;

    private void Start()
    {
        p1Score = 0;
        p2Score = 0;
        UpdateScore();
    }

    public void UpdateScore()
    {
        p1ScoreTextMesh.text = p1Score.ToString();
        p2ScoreTextMesh.text = p2Score.ToString();
        CheckEndGame();
    }

    [NaughtyAttributes.Button]
    public void CheckEndGame()
    {
        if (p1Score >= endScore)
        {
            gameEndMessageText.text = "PLAYER 1 Wins";
            Time.timeScale = 0f;
            gameEndMessage.SetActive(true);
        }

        if (p2Score >= endScore)
        {
            gameEndMessageText.text = "PLAYER 2 Wins";
            Time.timeScale = 0f;
            gameEndMessage.SetActive(true);
        }
    }
}