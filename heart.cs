using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    Text hurt;
    public static int hort = 1;

    void Start()
    {
        hurt = GetComponent<Text>();
    }


    // Update is called once per frame
    public void Update()
    {
        hurt.text = ":" + hort;

    }
}
