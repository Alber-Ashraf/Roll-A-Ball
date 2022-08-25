using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2Qustion : MonoBehaviour
{
    public GameManager gameManager;

    public void Level2Continuo()
    {
        gameManager.level2Continuo();
    }

    public void Level2Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
