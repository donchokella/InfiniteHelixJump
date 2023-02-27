using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject gameOverPanel;

    public AudioClip gameOverSound;

    //Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //Singleton

    private void Start()
    {
        gameOver = false;
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        AudioSource.PlayClipAtPoint(gameOverSound, transform.position);
    }
}
