using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;

    private float _moveSpeed = 10.0f;

    private void Awake()
    {
        float spawnHeight = player.gameObject.transform.position.y;

        transform.position = new Vector3(15, spawnHeight, 0);
    }

    void Update()
    {
        float spawnHeight = player.gameObject.transform.position.y;

        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -11.8f)
        {
            transform.position = new Vector3(10.0f, spawnHeight, 0);
        }
    }
}
