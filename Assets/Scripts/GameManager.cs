using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    public GameObject gameOver;

    public GameObject player;
    public GameObject spawnManager;

    public GameObject arrows;
    public GameObject ravens;

    public GameObject diamondsM;
    public GameObject diamondsSquare;
    public GameObject diamondsLine;
    
    public GameObject ground1;
    public GameObject ground2;

    private float _score;
    private float _highScore;

    private float _timer = 1.0f;
    private float _speedIncrease = 0.1f;

    private bool _hasSpawnRateIncreased;
    private bool _hasSoundPlayed;

    void Awake()
    {
        ravens.GetComponent<Ravens>().moveSpeed = 3.0f;
        diamondsM.GetComponent<DiamondMovement>().moveSpeed = 3.0f;
        diamondsSquare.GetComponent<DiamondMovement>().moveSpeed = 3.0f;
        diamondsLine.GetComponent<DiamondMovement>().moveSpeed = 3.0f;
    }

    void Update()
    {
        _score = GetComponent<Score>().GetScore();
        scoreText.text = $"Current Score: {_score:0000}";

        _highScore = GetHighScore("HighScore");
        highScoreText.text = $"High Score: {_highScore:0000}";

        if (_score > GetHighScore("HighScore"))
        {
            SetHighScore("HighScore", Convert.ToInt32(_score));
        }

        IncreaseDifficulty();

        if (player == null)
        {
            AllowRestart();
        }
    }

    private void IncreaseDifficulty()
    {
        _timer -= Time.deltaTime;

        if (_score > 1 && Convert.ToInt32(_score) % 50 == 0 && _timer <= 0)
        {
            _timer = 1.0f;

            // increase enemy speeds
            arrows.GetComponent<Arrow>().IncreaseSpeed(_speedIncrease);
            ravens.GetComponent<Ravens>().IncreaseSpeed(_speedIncrease);

            // increase ground scroll speed
            ground1.GetComponent<Ground>().IncreaseSpeed(_speedIncrease);
            ground2.GetComponent<Ground>().IncreaseSpeed(_speedIncrease);

            // diamond move speed
            diamondsM.GetComponent<DiamondMovement>().IncreaseSpeed(_speedIncrease);
            diamondsSquare.GetComponent<DiamondMovement>().IncreaseSpeed(_speedIncrease);
            diamondsLine.GetComponent<DiamondMovement>().IncreaseSpeed(_speedIncrease);
        }

        if (_score > 250 && !_hasSpawnRateIncreased)
        {
            spawnManager.GetComponent<SpawnManager>().IncreaseSpawnRate();
            _hasSpawnRateIncreased = true;
        }
    }

    private void SetHighScore(string keyName, int value)
    {
        PlayerPrefs.SetInt(keyName, value);
    }

    private int GetHighScore(string keyName)
    {
        return PlayerPrefs.GetInt(keyName);
    }

    private void AllowRestart()
    {
        gameOver.gameObject.SetActive(true);

        if (!_hasSoundPlayed)
        {
            gameOver.gameObject.GetComponent<AudioSource>().Play();
            _hasSoundPlayed = true;
        }

        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
