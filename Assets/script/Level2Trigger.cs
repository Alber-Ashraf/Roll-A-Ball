using UnityEngine;

public class Level2Trigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        bool complete = false;

        if (complete == false)
        {
            gameManager.Level2Qustion();
            complete = true;
        }

    }
}
