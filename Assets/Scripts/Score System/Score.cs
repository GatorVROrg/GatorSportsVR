using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Player[] players = new Player[5];
    public int index = 0;

    public int testingScore;
    public bool test;

    public void SetScore(int score)
    {
        if (index < 5)
        {
            if (players[index].frames[players[index].index].GetState() < 2)
            {
                players[index].SetScore(score);

            } 
            else
            {
                index++;
                players[index].SetScore(score);
            }
        }
        else
        {
            index = 0;
            players[index].SetScore(score);
        }
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
