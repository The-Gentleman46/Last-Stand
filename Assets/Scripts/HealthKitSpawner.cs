using System;
using UnityEngine;

public class HealthKitSpawner : MonoBehaviour
{

    float timeElapsed;
    public GameObject MedPack;

    public void RandomHealthSpawn()
    {
        int spawnPointX = (int)UnityEngine.Random.Range(transform.position.x - 40, transform.position.x + 40);
        int spawnPointY = (int)UnityEngine.Random.Range(transform.position.y - 40, transform.position.y + 40);
        Vector2 HealthSpawnPos = new Vector2(spawnPointX, spawnPointY);
        Instantiate(MedPack, HealthSpawnPos, Quaternion.identity);
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        while ((int)timeElapsed % 5 == 0)
        {
            RandomHealthSpawn();
        }
    }
}


