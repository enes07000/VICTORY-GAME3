using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SES : MonoBehaviour
{
    public Slider volumeSlider;
    private static SES instance = null;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        if (PlayerPrefs.HasKey("volume"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            volumeSlider.value = AudioListener.volume;
        }


        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {

        AudioListener.volume = volume;

        PlayerPrefs.SetFloat("volume", volume);
    }
}
