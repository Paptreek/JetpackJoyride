using UnityEngine;

public class DarkTrees : MonoBehaviour
{
    public float _scrollSpeed;

    private void Awake()
    {
        _scrollSpeed = 2.0f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -17.9f)
        {
            transform.position = new Vector3(17.85f, -0.2f, 0);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _scrollSpeed += increment;
    }
}
