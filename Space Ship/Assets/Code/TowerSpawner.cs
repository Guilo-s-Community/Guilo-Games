using UnityEngine;

public class TowerSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject towerPrefab;
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
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            SetTimeSpawn();
        }
    }

    private void SetTimeSpawn(){

        timeToSpawn = Random.Range(minSpawnTime,maxSpawnTime);

    }
}
