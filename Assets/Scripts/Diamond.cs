using UnityEngine;

public class Diamond : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= -9.5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
