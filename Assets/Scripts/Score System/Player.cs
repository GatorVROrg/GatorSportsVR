using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int totalScore = 0;
    public Frame[] frames = new Frame[10];
    public string name = "";
    public int index = 0;
    public TextMeshProUGUI totalText;
    public TextMeshProUGUI playerName;

    public int testingScore;
    public bool test;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    // set score
    public void SetScore(int score)
    {
        if (index < 10)
        {
            if (frames[index].GetState() < 2)
            {
                frames[index].SetScore(score);
            }
            else
            {
                index++;
                frames[index].SetScore(score);
            }
            SetTotal();
        }
    }
    
    //set total
    public void SetTotal()
    {
        totalScore = 0;
        for (int i = 0; i < 10; i++)
        {
            totalScore += frames[i].GetTotal();
        }
        totalText.text = "" + totalScore;
    }

    // start function
    void SetName()
    {
        playerName.text = name;
    }

    public void Update()
    {
        if (test)
        {
            SetScore(testingScore);
            test = false;
        }
    }
}
