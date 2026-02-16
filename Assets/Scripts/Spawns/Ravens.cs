using UnityEngine;

public class Ravens : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -11.8f)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        moveSpeed += increment;
    }
}
