using System;
using UnityEngine;

public class HealthKitSpawner : MonoBehaviour
{

    float timeElapsed;
    public GameObject MedPack;
    public GameObject Player;


    public void RandomSpawn()
    {
        int spawnPointX = (int)UnityEngine.Random.Range(transform.position.x - 40, transform.position.x + 40);
        int spawnPointY = (int)UnityEngine.Random.Range(transform.position.y - 40, transform.position.y + 40);
        Vector2 zombSpawnPos = new Vector2(spawnPointX, spawnPointY);
        Instantiate(MedPack, zombSpawnPos, Quaternion.identity);
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        while ((int)timeElapsed % 5 == 0)
        {
            RandomSpawn();
        }
    }
}


