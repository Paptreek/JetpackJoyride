using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private float _score;

    void Start()
    {
    }

    void Update()
    {
        _score = GetComponent<Score>().GetScore();
        scoreText.text = $"Current Score: {_score:0}";
    }
}
