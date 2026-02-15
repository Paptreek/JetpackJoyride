using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ravens;
    public GameObject diamondsM;
    public GameObject diamondsSquare;
    public GameObject diamondsLine;

    private float _timer;

    void Start()
    {
        _timer = 5.0f;

        SpawnRavens();
    }

    void Update()
    {
        float spawnChoice = Random.Range(1, 4);

        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            if (spawnChoice == 3)
            {
                SpawnDiamonds();
                _timer = Random.Range(3.0f, 5.0f);
            }
            else
            {
                SpawnRavens();
                _timer = Random.Range(3.0f, 5.0f);
            }
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
