using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyDataa
{
    public MyDataa()
    {
    }
    public void save(int s)
    {
        PlayerPrefs.SetInt("HS", s);
    }
    public int load()
    {
        int x;
        x = PlayerPrefs.GetInt("HS");
        return x;
    }

}
