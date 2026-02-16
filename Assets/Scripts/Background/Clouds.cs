using UnityEngine;

public class Clouds : MonoBehaviour
{
    private float _scrollSpeed;

    private void Start()
    {
        _scrollSpeed = 0.5f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -18.5f)
        {
            transform.position = new Vector3(25.0f, 0, 0);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _scrollSpeed += increment;
    }
}
