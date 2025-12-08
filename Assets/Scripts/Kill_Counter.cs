using TMPro;
using UnityEngine;
public class Kill_Counter : MonoBehaviour
{
    private int scoreValue = 0;
    public TextMeshProUGUI score;
    public void AddScore()
    {
        scoreValue++;
        score.SetText("Zombies Killed : " + scoreValue.ToString());
    }
}