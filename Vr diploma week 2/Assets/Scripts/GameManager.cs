using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    //Manage timer and Score;
    public int score = 0;
    public Text scoretext;
    public float time = 0;
    public Text timetext;

    public void Scored()
    {
        score++;
        scoretext.text = "score : " + score;

    }
    void Update()
    {
        timer();
    }

    private void timer()
    {
        int timeinint = Convert.ToInt32(time);
        time += 1 * Time.deltaTime;
        timetext.text = "time : " + timeinint;
    }
}
