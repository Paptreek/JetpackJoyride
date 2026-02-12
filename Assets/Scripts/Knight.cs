using UnityEngine;

public class Knight : MonoBehaviour
{
    private float _moveSpeed = 6.0f;

    void Update()
    {
        transform.Translate(new Vector3(-_moveSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -11.8f)
        {
            transform.position = new Vector3(50.0f, -2.902f, 0);
        }
    }
}
