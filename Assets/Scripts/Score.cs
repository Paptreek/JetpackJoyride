using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject player;

    private float _score;
    private float _timeElapsed;

    private void Update()
    {
        CalculateScore();
    }

    private void CalculateScore()
    {
        int diamondsCollected = player.GetComponent<PlayerController>().GetDiamondCount();

        if (player != null)
        {
            _timeElapsed += Time.deltaTime;
            _score = (_timeElapsed * 5) + (diamondsCollected * 5);
        }
    }

    public float GetScore()
    {
        return _score;
    }
}
