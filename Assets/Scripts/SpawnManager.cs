using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ravens;
    public GameObject diamondsM;
    public GameObject diamondsSquare;
    public GameObject diamondsLine;

    private float _timer;
    private float _shortestSpawn = 2.0f;
    private float _longestSpawn = 5.5f;

    void Start()
    {
        _timer = 5.0f;

        SpawnDiamonds();
    }

    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            float spawnChoice = Random.Range(1, 4);
            Debug.Log(spawnChoice);

            if (spawnChoice == 3)
            {
                SpawnDiamonds();
            }
            else
            {
                SpawnRavens();
            }

            _timer = Random.Range(_shortestSpawn, _longestSpawn);
        }
    }

    private void SpawnRavens()
    {
        float x = 10.0f;
        float y = Random.Range(-1.75f, 3.25f);

        ravens.transform.position = new Vector3(x, y, 0);

        Instantiate(ravens);
    }

    private void SpawnDiamonds()
    {
        float spawnChoice = Random.Range(1, 4);

        float x = 10.0f;
        float y = Random.Range(-3.25f, 1.35f);

        diamondsM.transform.position = new Vector3(x, y, 0);
        diamondsSquare.transform.position = new Vector3(x, y, 0);
        diamondsLine.transform.position = new Vector3(x, y, 0);

        if (spawnChoice == 1)
        {
            Instantiate(diamondsM);
        }
        else if (spawnChoice == 2)
        {
            Instantiate(diamondsSquare);
        }
        else
        {
            Instantiate(diamondsLine);
        }
    }

    public void IncreaseSpawnRate()
    {
        _longestSpawn -= 2.5f;
    }
}
