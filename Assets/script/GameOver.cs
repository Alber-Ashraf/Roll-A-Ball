using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager gameManager;

    public void quit()
    {
        Debug.Log("Bye");
        Application.Quit();
    }

    public void restart()
    {
        gameManager.gameRestart();
    }
}
