using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2BackzoneScore : MonoBehaviour
{
    public ScoreBoard scoreboard;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("P2BackZone");
        scoreboard.p1Score = scoreboard.p1Score + 1;
        scoreboard.UpdateScore();
    }
}
