using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void OnStartClicked()
    {
        GameManager.Instance.LoadScene("Game");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}