using UnityEngine;

public class LightTrees : MonoBehaviour
{
    private float _scrollSpeed;

    private void Start()
    {
        _scrollSpeed = 1.50f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -17.9f)
        {
            transform.position = new Vector3(17.85f, 0.14917f, 0);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _scrollSpeed += increment;
    }
}
