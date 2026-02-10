using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    public GameObject arrow;

    private float _timeBetweenSpawns = 5;
    private bool _canSpawn;

    void Awake()
    {
        Instantiate(arrow);
    }

    void Update()
    {
        SpawnArrows();
    }

    void SpawnArrows()
    {
        _timeBetweenSpawns -= Time.deltaTime;
        Debug.Log(_timeBetweenSpawns.ToString("0.0"));

        if (_timeBetweenSpawns <= 0)
        {
            _canSpawn = true;
        }

        if (_canSpawn)
        {
            _canSpawn = false;
            
            arrow.transform.position = new Vector3(10, GetSpawnHeight(), 0);
            Instantiate(arrow);

            _timeBetweenSpawns = Random.Range(3.5f, 5.0f);
        }
    }

    private float GetSpawnHeight()
    {
        return Random.Range(-3.5f, 3.5f);
    }
}
