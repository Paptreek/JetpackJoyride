using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;

    private float _moveSpeed;

    private void Awake()
    {
        _moveSpeed = 10.0f;
        float spawnDistance = Random.Range(10.65f, 25.0f);
        float spawnHeight = player.gameObject.transform.position.y;

        transform.position = new Vector3(spawnDistance, spawnHeight, 0);
    }

    void Update()
    {
        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);
        
        if (player != null)
        {
            float spawnDistance = Random.Range(10.65f, 25.0f);
            float spawnHeight = player.gameObject.transform.position.y;

            if (transform.position.x <= -11.8f)
            {
                transform.position = new Vector3(spawnDistance, spawnHeight, 0);
            }
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _moveSpeed += increment;
    }
}
