using UnityEngine;

public class Arrow : MonoBehaviour
{
    private float _moveSpeed = 10.0f;

    void Update()
    {
        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
