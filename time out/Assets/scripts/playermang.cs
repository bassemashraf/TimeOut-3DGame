﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class playermang : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameOver;
    public static bool gamestarted;
    public GameObject gameoverpanel;
    public GameObject startingtext;
    public static float Timeseconds;
    public Text time;
    public Text Gamescore;
    public Text Highscore;
    public float scoree = 0;
    float x = 1 / 100;

    MyDataa m = new MyDataa();
    void Start()
    {

        GameOver = false;
        Time.timeScale = 1;
        gamestarted = false;
        Timeseconds = 30f;

        //   Highscore.text = "anaanas";
        //m.save(5);
        //  PlayerPrefs.SetInt("HS", 2);

        Highscore.text = "" + m.load();
        //Highscore.text= (PlayerPrefs.GetInt("HS")).ToString();

    }

    // Update is called once per frame
    void Update()
    {

        Gamescore.text = "" + (int)scoree;
        //   Gamescore.text = "BASD";


        if (GameOver || time.text == "" + 0)
        {
            Time.timeScale = 0;


            gameoverpanel.SetActive(true);
        }
        if (GameOver)
        {
            //  if (scoree > PlayerPrefs.GetInt("HS"))
            //  {
            //      PlayerPrefs.SetInt("HS", scoree);
            //   }
            //  Highscore.text = PlayerPrefs.GetInt("HS").ToString();
            //  if (scoree > mydata.load());
            //  {
            //    mydata.save(scoree);
            //   }

            if ((int)scoree > m.load())
            {
                m.save((int)scoree);
            }
            //Gamescore.text =scoree.ToString();


            // Highscore.text = (PlayerPrefs.GetInt("HS")).ToString();
            //Highscore.text = (mydata.load()).tostring;
            Highscore.text = "" + m.load();



        }
        if (gamestarted && Timeseconds > 0)
        {
            Timeseconds -= Time.deltaTime * 2;

        }
        if (!gamestarted)
        {
            scoree = 0;
        }
        if (gamestarted && !GameOver)
        {

            // scoree = scoree + 1;
            scoree = scoree + Time.deltaTime * 10;
        }
        time.text = "" + (int)Timeseconds;
        if (swipemanager.tap)
        {

            gamestarted = true;
            Destroy(startingtext);
        }

    }


}
