using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermanager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isEnd;
    public GameObject gameOverScreen;
    public GameObject EndScreen;
    public AudioSource music;
    private void Awake()
    {
        //flagi
        isGameOver = false;
        isEnd = false;
    }
    private void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
            music.Stop();
        }    
        if(isEnd)
        {
            EndScreen.SetActive(true);
            music.Stop();
        }
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
