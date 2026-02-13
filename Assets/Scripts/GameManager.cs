using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private float _score;

    void Update()
    {
        _score = GetComponent<Score>().GetScore();
        scoreText.text = $"Current Score: {_score:0}";

        // for every 50 points, increase speed of arrows

        // for every 100 points, increase spawn rate of birds
    }
}
