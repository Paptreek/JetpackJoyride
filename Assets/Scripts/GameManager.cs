using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    public GameObject player;
    public GameObject arrows;
    public GameObject ravens;
    public GameObject ground1;
    public GameObject ground2;
    public GameObject darkTrees1;
    public GameObject darkTrees2;
    public GameObject lightTrees1;
    public GameObject lightTrees2;

    private float _score;
    private float _highScore;
    private float _timer = 1.0f;
    private float _speedIncrease = 0.5f;

    void Update()
    {
        _score = GetComponent<Score>().GetScore();
        scoreText.text = $"Current Score: {_score:0}";
        // get high score stuff from other projects

        IncreaseDifficulty();
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
        }
    }
}
