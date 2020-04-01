using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermang : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameOver;
    public static bool gamestarted;
    public GameObject gameoverpanel;
    public GameObject startingtext;
    public static float Timeseconds;
    public Text time;
    void Start()
    {
        GameOver = false;
        Time.timeScale = 1;
        gamestarted = false;
        Timeseconds = 30f;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver|| time.text == "" + 0)
        {
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
        }
        if (gamestarted&&Timeseconds>0)
        {
                Timeseconds -= Time.deltaTime * 2;
        }
        time.text = "" + (int)Timeseconds; 
        if (swipemanager.tap)
        {
            
            gamestarted = true;
            Destroy(startingtext);
        }
        //asdasdasssa
    }
  
   
}
