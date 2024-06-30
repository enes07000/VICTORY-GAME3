using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sayac : MonoBehaviour
{
    Text text2;
    public static int altin1;

    void Start()
    {
        text2 = GetComponent<Text>();
    }


    // Update is called once per frame
    public void Update()
    {
        text2.text = ":" + altin1;

    }
}
