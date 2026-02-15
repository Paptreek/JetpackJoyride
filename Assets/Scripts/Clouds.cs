using UnityEngine;

public class Clouds : MonoBehaviour
{
    private float _scrollSpeed;

    private void Start()
    {
        _scrollSpeed = 0.25f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector3(28.0f, 0.14917f, 0);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _scrollSpeed += increment;
    }
}
