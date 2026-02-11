using System.Drawing;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject background;
    public GameObject ground;

    void Awake()
    {
        background.transform.position = Vector3.zero;
        Instantiate(background);

        ground.transform.position = new Vector3(8.65f, -4.76f, 0);
        Instantiate(ground);
    }

    void Update()
    {
        // if right side is less than right edge of screen, spawn a new one

        SpawnBackground();
    }

    private void SpawnBackground()
    {
        float centerOfBackground = background.transform.position.x;

        Debug.Log(centerOfBackground);
    }
}
