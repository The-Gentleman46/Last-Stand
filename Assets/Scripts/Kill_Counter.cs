using TMPro;
using UnityEngine;
public class Kill_Counter : MonoBehaviour
{
    private int scoreValue = 0;
    public TextMeshProUGUI score;
    public void Update()
    {
        score.SetText("Zombies Killed : " + scoreValue.ToString());
    }
    public void AddScore()
    {
        scoreValue++;
    }
}