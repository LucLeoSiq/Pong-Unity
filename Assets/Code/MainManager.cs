using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Difficulty selectedDifficulty;

    public enum Difficulty {Easy, Normal, Hard};

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
}
