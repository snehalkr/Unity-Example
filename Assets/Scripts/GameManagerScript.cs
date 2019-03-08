using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    private bool gameEnded = true;

    public float restartDelay = 1f;

    public GameObject LevelCompleteUI;

    public void LevelComplete()
    {
        Debug.Log("Level Complete!");
        LevelCompleteUI.SetActive(true);
    }

	public void EndGame()
    {
        if(gameEnded)
        {
            Debug.Log("Game Over!");
            gameEnded = false;
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
