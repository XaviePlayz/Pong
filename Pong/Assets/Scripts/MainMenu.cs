using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Back()
    {
        Singleton._instance.SetVolumeHeight();
        GameManager.Unload();
        SceneManager.LoadScene(0);
    }
    public void SettingsMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectGamemode()
    {
        SceneManager.LoadScene(2);
    }
    public void Play_1Player()
    {
        SceneManager.LoadScene(4);
    }
    public void Play_1Player_EASY()
    {
        SceneManager.LoadScene(5);

    }
    public void Play_1Player_NORMAL()
    {
        SceneManager.LoadScene(6);

    }

    public void Play_1Player_HARD()
    {
        SceneManager.LoadScene(7);
    }
    public void Play_1Player_INSANE()
    {
        SceneManager.LoadScene(8);
    }

    public void Play_1Player_SPECIAL()
    {
        SceneManager.LoadScene(9);
    }

    public void Play_2Player()
    {
        SceneManager.LoadScene(3);
    }



}
