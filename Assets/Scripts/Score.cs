using UnityEngine;

public class Score : MonoBehaviour
{
    private float _score;
    private float _timeElapsed;

    private void Update()
    {
        CalculateScore();
    }

    private void CalculateScore()
    {
        _timeElapsed += Time.deltaTime;
        _score = _timeElapsed * 5;

        //Debug.Log($"Score: {_score.ToString("0")}, Time: {_timeElapsed}");
    }

    public float GetScore()
    {
        return _score;
    }
}
