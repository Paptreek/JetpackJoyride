using UnityEngine;

public class DiamondMovement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -12.0f)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseSpeed(float increment)
    {
        moveSpeed += increment;
    }
}
