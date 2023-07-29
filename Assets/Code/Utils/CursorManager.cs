using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public bool showCursor = true;
    public GameObject pauseMenu;
    public GameObject endGameMenu;

    private void Start()
    {
        if (showCursor) ShowCursor(true);
        else ShowCursor(false);
    }

    private void Update()
    {
        bool inMenu = IsInMenu();
        ShowCursor(inMenu);
    }

    private void ShowCursor(bool visible)
    {
        Cursor.visible = visible;
        Cursor.lockState = visible ? CursorLockMode.None : CursorLockMode.Locked;
    }

    private bool IsInMenu()
    {
        if (pauseMenu.activeSelf || endGameMenu.activeSelf) return true;

        else return false;
    }
}
