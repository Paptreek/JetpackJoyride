using UnityEngine;

public class Diamonds : MonoBehaviour
{
    private float _moveSpeed;

    private void Awake()
    {
        _moveSpeed = 3.0f;
    }

    void Update()
    {
        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -9.5f)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _moveSpeed += increment;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
