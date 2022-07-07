using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Script para Game controller

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instance;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject nextLevel;
    
   
   
    // Start is called before the first frame update
    void Start()
    {
        instance = this;        
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvName)
    {
        SceneManager.LoadScene(lvName);
    }

    public void ShowNextLevel()
    {
        nextLevel.SetActive(true);
    }

    public void NextLevel(string lvName)
    {
         SceneManager.LoadScene(lvName);
    }

}
