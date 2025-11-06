using System;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    float timeElapsed;
    int maxZombies = 1;
    int zombies = 1;
    public GameObject Zombie;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        maxZombies = (int)timeElapsed;
        while (zombies < maxZombies)
        {
            Instantiate(Zombie, transform.position, transform.rotation);
            zombies++;
        }
    }
}


