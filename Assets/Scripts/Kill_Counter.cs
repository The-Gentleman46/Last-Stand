using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kill_Counter : MonoBehaviour
{
    public static int scoreValue = 0;
    public TextMeshProUGUI score;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Zombies Killed: " + scoreValue.ToString();
    }

    public static void AddScore(int points)
    {
        scoreValue += points;
    }
}
