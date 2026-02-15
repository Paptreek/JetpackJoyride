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
    public GameObject diamondsM;
    public GameObject diamondsSquare;
    public GameObject diamondsLine;
    public GameObject spawnManager;

    private float _score;
    private float _highScore;
    private float _timer = 1.0f;
    private float _speedIncrease = 0.1f;

    private bool _hasSpawnRateIncreased;

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
}
