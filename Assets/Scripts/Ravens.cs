using UnityEngine;

public class Ravens : MonoBehaviour
{
    private float _moveSpeed = 1.5f;

    private void Awake()
    {
        float spawnHeight = Random.Range(-2.0f, 3.0f);

        transform.position = new Vector3(10.0f, spawnHeight, 0);
    }

    void Update()
    {
        float spawnHeight = Random.Range(-2.0f, 3.0f);

        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -11.8f)
        {
            transform.position = new Vector3(10.0f, spawnHeight, 0);
        }
    }
}
