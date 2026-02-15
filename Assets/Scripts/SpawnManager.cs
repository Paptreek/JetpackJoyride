using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ravens;
    public GameObject diamondsM;
    public GameObject diamondsSquare;
    public GameObject diamondsLine;

    private float _timer;
    private float _shortestSpawn = 2.0f;
    private float _longestSpawn = 6.0f;

    void Start()
    {
        _timer = 5.0f;

        SpawnRavens();
    }

    void Update()
    {

        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            float spawnChoice = Random.Range(1, 6);
            Debug.Log(spawnChoice);
            
            if (spawnChoice == 5)
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
        //float x = Random.Range(10.3f, 25.0f);
        float x = 12.5f;
        float y = Random.Range(-2.0f, 3.0f);

        ravens.transform.position = new Vector3(x, y, 0);

        Instantiate(ravens);
    }

    private void SpawnDiamonds()
    {
        //float x = Random.Range(10.3f, 25.0f);
        float x = 12.0f;
        float y = Random.Range(-2.0f, 2.0f);

        diamondsM.transform.position = new Vector3(x, y, 0);

        Instantiate(diamondsM);
    }
}
