using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1BackzoneScore : MonoBehaviour
{
    public ScoreBoard scoreboard;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("P1BackZone");
        scoreboard.p2Score = scoreboard.p2Score + 1;
        scoreboard.UpdateScore();
    }
}
