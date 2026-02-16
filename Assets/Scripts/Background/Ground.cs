using UnityEngine;

public class Ground : MonoBehaviour
{
    private float _scrollSpeed;

    private void Awake()
    {
        _scrollSpeed = 3.0f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -9.69)
        {
            transform.position = new Vector3(27.09f, -4.76f, 0);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _scrollSpeed += increment;
    }
}
