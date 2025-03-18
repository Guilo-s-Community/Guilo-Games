using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject ciaPrefab;
    [SerializeField]
    private float minSpawnTime;
    [SerializeField]
    private float maxSpawnTime;

    private float timeToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake(){
        SetTimeSpawn();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -=Time.deltaTime;

        if(timeToSpawn <= 0 )
        {
            Instantiate(ciaPrefab, transform.position, Quaternion.identity);
            SetTimeSpawn();
        }
    }

    private void SetTimeSpawn(){

    timeToSpawn = Random.Range(minSpawnTime,maxSpawnTime);

    }
}
