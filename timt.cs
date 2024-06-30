using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class timt : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerText1;
    private float startTime;
    public static bool StopTime = true;
    string minutes;
    string seconds;
    float t;

    void Start()
    {
        if (StopTime == true) { startTime = Time.time; }

    }

    void Update()
    {
        if (StopTime == true)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
            timerText1.text = timerText.text;
        }





    }
}
