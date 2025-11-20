using System;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    float timeElapsed;
    int maxZombies = 1;
    int zombies = 1;
    public GameObject Zombie;
    public GameObject Player;
    

    public void RandomSpawn()
    {
        int spawnPointX = (int)UnityEngine.Random.Range(transform.position.x - 10, transform.position.x + 10);
        int spawnPointY = (int)UnityEngine.Random.Range(transform.position.y - 10, transform.position.y + 10);
        Vector2 zombSpawnPos = new Vector2(spawnPointX, spawnPointY);
        Instantiate(Zombie, zombSpawnPos, Quaternion.identity);
        zombies++;
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        maxZombies = (int)timeElapsed;
        while (zombies < maxZombies)
        {
            RandomSpawn();
        }
    }
}


