using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUi;
    public GameObject qustion;
    public GameObject GameOver;
    public Text xText;

    //The Game Diffculty **********************************
    static public int DeathCount = 100;
    public void Easy()
    {
        DeathCount = 200;
    }
    public void Normal()
    {
        DeathCount = 100;
    }
    public void Hard()
    {
        DeathCount = 50;
    }
    //*****************************************************

    [System.Obsolete]
    private void Update()
    {
        if(DeathCount == 0)
        {
            GameOver.SetActive(true);
        }
        
        if (Application.loadedLevel == 0) 
            return;

        xText.text = DeathCount.ToString("0");
    }

    //Restart the level ************************************
    public float restartDelay = 2f;
    bool gameHasEnded = false;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            DeathCount--;
        }
    }
    //********************************************************

    //GameOver Resart ****************************************
    public string sceneToLoad = "Menu";
    public void gameRestart()
    {
        SceneManager.LoadScene(sceneToLoad);
        DeathCount = 100;
    }
    //*********************************************************

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }

    public void Level2Qustion()
    {
        qustion.SetActive(true);
        transform.position = new Vector3(0, -4, 68);
        Time.timeScale = 0f;
    }

    public void level2Continuo()
    {
        qustion.SetActive(false);
        Time.timeScale = 1f;
    }

    
}
