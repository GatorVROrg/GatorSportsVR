using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class Frame : MonoBehaviour
{
    int state = 0;
    int[] scores = new int[2];
    int totalScore = 0;
    public TextMeshProUGUI firstHalf;
    public TextMeshProUGUI secondHalf;
    public TextMeshProUGUI total;

    public void SetScore(int score)
    {
        if (state < 2)
        {
            scores[state] = score;
            totalScore += score;
            if (score == 10)
            {
                state = 2;
            }
            else
            {
                state++;
            }
            SetText();
        }
    }

    public int GetScore()
    {
        return totalScore;
    }

    public int GetState()
    {
        return state;
    }
    public int GetTotal()
    {
        return totalScore;
    }

    public void SetText()
    {
        firstHalf.text = "" + scores[0];
        secondHalf.text = "" + scores[1];
        total.text = "" + totalScore;
    }
}
