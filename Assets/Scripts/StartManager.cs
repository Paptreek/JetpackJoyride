using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private float _score;
    private float _highScore;

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

        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Game");
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
}
