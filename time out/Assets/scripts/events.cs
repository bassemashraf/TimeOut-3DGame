using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using System;
public class events : MonoBehaviour
{
    // will add All onlick methods
    public GameObject gameoverpanel;

    public void ReplayGame()
    {
        SceneManager.LoadScene("level");
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void revive()
    {
        PlayerPrefs.SetString("R","true");
    }

}
