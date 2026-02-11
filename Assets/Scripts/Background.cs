using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    void Update()
    {
        transform.Translate(new Vector3(-scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
