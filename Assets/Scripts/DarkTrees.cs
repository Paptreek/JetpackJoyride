using UnityEngine;

public class DarkTrees : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    void Update()
    {
        transform.Translate(new Vector3(-scrollSpeed, 0, 0) * Time.deltaTime);

        if (transform.position.x <= -17.9f)
        {
            transform.position = new Vector3(17.85f, -0.2f, 0);
        }
    }
}
