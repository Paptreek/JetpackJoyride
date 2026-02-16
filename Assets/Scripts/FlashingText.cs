using TMPro;
using UnityEngine;

public class FlashingText : MonoBehaviour
{
    public GameObject startText;

    private float _turnOffTimer = 0.5f;
    private float _turnOnTimer = 0.5f;
    private bool _textIsActive = true;

    private void Update()
    {
        // if active, set active ~> start a timer ~> set inactive
        // if inactive, set inactive ~> start a timer ~> set active

        if (_textIsActive)
        {
            startText.gameObject.SetActive(true);
            _turnOffTimer -= Time.deltaTime;

            if (_turnOffTimer <= 0)
            {
                _textIsActive = false;
                _turnOffTimer = 0.5f;
            }
        }

        if (!_textIsActive)
        {
            startText.gameObject.SetActive(false);
            _turnOnTimer -= Time.deltaTime;

            if (_turnOnTimer <= 0)
            {
                _textIsActive = true;
                _turnOnTimer = 0.5f;
            }
        }
    }
}
