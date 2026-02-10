using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    public GameObject arrow;
    public GameObject player;

    private float _timeBetweenSpawns = 5;
    private bool _canSpawn;

    void Awake()
    {
        arrow.transform.position = new Vector3(10, -3.5f, 0);
        arrow.transform.rotation = new Quaternion(0, 0, 0, 0);
        Instantiate(arrow);
    }

    void Update()
    {
        SpawnArrows();
    }

    void SpawnArrows()
    {
        _timeBetweenSpawns -= Time.deltaTime;
        //Debug.Log(_timeBetweenSpawns.ToString("0.0"));

        if (_timeBetweenSpawns <= 0)
        {
            _canSpawn = true;
        }

        if (_canSpawn)
        {
            _canSpawn = false;

            //arrow.transform.rotation = Quaternion.Euler(0, 0, -25);
            arrow.transform.position = new Vector3(10, GetPlayerHeight(), 0);
            Instantiate(arrow);

            _timeBetweenSpawns = Random.Range(3.5f, 5.0f);
        }
    }

    private float GetPlayerHeight()
    {
        return player.gameObject.transform.position.y;
    }
}
