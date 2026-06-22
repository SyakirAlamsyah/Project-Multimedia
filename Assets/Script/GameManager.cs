using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    public static GameManager instance;
    
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
