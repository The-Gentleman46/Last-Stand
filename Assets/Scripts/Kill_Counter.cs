using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kill_Counter : MonoBehaviour
{
    public int scoreValue = 0;
    public TextMeshProUGUI score;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score.SetText("Zombies Killed : " + scoreValue.ToString());
    }
    public void AddScore()
    {
        scoreValue++;
        score.SetText("Zombies Killed : " + scoreValue.ToString());
    }
}