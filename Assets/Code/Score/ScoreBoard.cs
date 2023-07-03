using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro textMeshPro;
    public BoxCollider2D boxCollider2D;

    private void Start()
    {
        UpdateTextMesh();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseScore();
    }

    private void UpdateTextMesh()
    {
        textMeshPro.text = score.ToString();
    }

    [NaughtyAttributes.Button]
    public void IncreaseScore()
    {
        score += 1;
        UpdateTextMesh();
    }
}