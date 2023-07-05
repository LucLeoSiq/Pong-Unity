using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreTextMesh;
    public GameObject gameEndTextMesh;
    public BoxCollider2D boxCollider2D;

    private void Start()
    {
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseScore();
    }

    private void UpdateScore()
    {
        scoreTextMesh.text = score.ToString();
        if (score >= 10)
        {
            EndGame();
        }
    }

    [NaughtyAttributes.Button]
    public void IncreaseScore()
    {
        score += 1;
        UpdateScore();
    }

    public void EndGame()
    {
        Time.timeScale = 0f;
        gameEndTextMesh.SetActive(true);
    }
}