using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject playButton;
    private int score;

    public void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {
        score = 0; 
        scoreText.text = score.ToString();
        
        playButton.SetActive(false);
        gameOver.SetActive(false);
        
        Time.timeScale = 1f;
        player.enabled = true;
    }

     public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

     public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

