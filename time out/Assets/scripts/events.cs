using UnityEngine.SceneManagement;
using UnityEngine;

public class events : MonoBehaviour
{
    // will add All onlick methods

    public void ReplayGame() 
    {
        SceneManager.LoadScene("level");
        Time.timeScale = 1;
    }
    public void QuitGame() 
    {
        Application.Quit();
    }

}
