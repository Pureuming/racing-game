using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TMP_Text scoreText;
    private int initScore = 100;
    private int currentScore;

    private void Start()
    {
        currentScore = initScore;
    }

    private void Update()
    {
        DisplayScore();
    }

    public void DisplayScore()
    {
        float t = 0;
        t += Time.deltaTime;
        currentScore -= (int)t;
        scoreText.text = $"Gas : {currentScore}";
        Debug.Log(currentScore);
    }

    public void LeftMove()
    {
        if (transform.position.x <= -1)
        {
            return;
        }
        
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }

    public void RightMove()
    {
        if (transform.position.x >= 1)
        {
            return;
        }
        
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }
}
