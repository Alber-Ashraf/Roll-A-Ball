using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        bool complete = false;

        if (complete == false)
        {
            gameManager.CompleteLevel();
            complete = true;
        }

    }
}

