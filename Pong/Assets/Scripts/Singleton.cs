using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{
    public static Singleton _instance;
    public float Volume_height;
    private Slider slider;

    void Awake()
    {

        if (_instance == null)
        {

            _instance = this;
            DontDestroyOnLoad(this.gameObject);

            //Rest of your Awake code

        }
        else
        {
            Destroy(this);
        }
    }

    public void SetVolumeSlider()
    {
        slider = FindObjectOfType<Slider>();
        slider.value = Volume_height;
    }

    public void SetVolumeHeight()
    {
        slider = FindObjectOfType<Slider>();
        if (slider != null)
        {
            Volume_height = slider.value;
            
        }
    }
    //Rest of your class code

}
