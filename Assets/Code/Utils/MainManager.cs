using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Difficulty selectedDifficulty;
    public GameMode selectedGameMode;
    public bool CRTEffect = true;
    public bool MuteGame;

    public enum Difficulty {Easy, Normal, Hard};
    public enum GameMode {AI, PVP};

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SelectedDifficulty(int index)
    {
        selectedDifficulty = (Difficulty)index;
    }

    public void SelectedGameMode(int index)
    {
        selectedGameMode = (GameMode)index;
    }
}
