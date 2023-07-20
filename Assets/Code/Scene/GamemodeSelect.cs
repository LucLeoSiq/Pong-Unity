using UnityEngine;

public class GamemodeSelect : MonoBehaviour
{
    public GameObject aiPaddle;
    public GameObject p2Paddle;

    private void Start()
    {
        CheckGamemode();
    }

    private void CheckGamemode()
    {
        if (MainManager.Instance.selectedGameMode == MainManager.GameMode.AI)
        {
            aiPaddle.SetActive(true);
        }


        else if (MainManager.Instance.selectedGameMode == MainManager.GameMode.PVP)
        {
            p2Paddle.SetActive(true);
        }

        else
        {
            p2Paddle.SetActive(true);
        }
    }
}
