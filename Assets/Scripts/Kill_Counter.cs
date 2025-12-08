using TMPro;
using UnityEngine;
public class Kill_Counter : MonoBehaviour
{
    public HealthKitSpawner spawner;
    private int scoreValue = 0;
    public TextMeshProUGUI score;
    public void Update()
    {
        score.SetText("Zombies Killed : " + scoreValue.ToString());
    }
    public void AddScore()
    {
        scoreValue++;
        if (scoreValue > 0 && scoreValue%10 == 0)
        {
            spawner.RandomHealthSpawn();
        }
    }
}