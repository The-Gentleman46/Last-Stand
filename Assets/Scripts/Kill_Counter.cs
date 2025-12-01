using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill_Counter : MonoBehaviour
{
    
    public static int scoreValue = 0;
    Text score;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Zombies Killed: " + scoreValue;
    }
}
