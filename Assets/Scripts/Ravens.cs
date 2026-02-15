using UnityEngine;

public class Ravens : MonoBehaviour
{
    private float _moveSpeed;

    private void Awake()
    {
        _moveSpeed = 3.0f;

        ////float spawnDistance = Random.Range(10.3f, 25.0f);
        //float spawnHeight = Random.Range(-2.0f, 3.0f);

        //transform.position = new Vector3(11, spawnHeight, 0);
    }

    void Update()
    {
        //float spawnDistance = Random.Range(10.3f, 25.0f);
        //float spawnHeight = Random.Range(-2.0f, 3.0f);

        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -11.8f)
        {
            //transform.position = new Vector3(spawnDistance, spawnHeight, 0);
            Destroy(gameObject);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        _moveSpeed += increment;
    }
}
