using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public bool gameStarted = false;

    void StartGame()
    {
        gameStarted = true;
        // Additional game start logic here
    }

    void EndGame()
    {
        gameStarted = false;
        // Additional game end logic here
    }
}
