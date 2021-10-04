using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject RestartUI;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            RestartUI.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameHasEnded = false;
        RestartUI.SetActive(false);
    }
}
