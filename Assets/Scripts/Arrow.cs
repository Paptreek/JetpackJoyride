using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
